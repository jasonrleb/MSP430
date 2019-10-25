#include <msp430.h>
#define RXD BIT5
#define TXD BIT6

void setClk(void);
void setTimer(void);
void setUART(void);
void setADC(void);
void setPotInput();

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    setClk();
    setTimer();
    setUART();
    setADC();
    setPotInput();

    _EINT(); // enable global interrupts

    return 0;
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA1RXBUF; // get val from RX buffer
}

#pragma vector = ADC10_VECTOR
__interrupt void ADC10_ISR(void) {
   ADC10CTL0 &= ~ADC10ENC;
   ADC10MCTL0 = ADC10SREF_1 + ADC10INCH_12;
   temperature = ADC10MEM0 >> 2;
   temperature = temperature - 85;
   ADC10CTL0 |= ADC10ENC | ADC10SC;
}

void setClk() {
    CSCTL0_H = CSKEY >> 8; // enables CS registers, can also do = 0xA5 (pg80 ug [ug = user guide])
    CSCTL1 &= ~DCORSEL; // DCORSEL set to 0 ug72
    CSCTL1 |= DCOFSEL0 + DCOFSEL1; // (pg81 ug) for 8MHz 11b
    CSCTL2 |= SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1; // set all CLK to run off DCO; (ug82)
    CSCTL3 |= DIVS__8; // set SMCLK divider to /8
}

void setTimer() {
    P1DIR |= BIT4 + BIT5;
    P1OUT &= ~(BIT4 + BIT5);
    P1SEL0 |= BIT4 + BIT5;
    P1SEL1 &= ~(BIT4 + BIT5);

    // Set timer B
    TB0CTL |= TBSSEL1 + MC0; // select SMCLK source, initialize up mode (ug372)
    TB0CCTL1 = OUTMOD_3; // set/reset and interrupt enable (ug375, ug366 diagrams)
    TB0CCTL2 = OUTMOD_3; // set capture/compare register to set/reset (ug375)

    // Set 1000Hz waves (draw up graph to show)
    TB0CCR0 = 1000 - 1; // = (CLK/divider)/target = (8E6/8)/1000; subtract one since it counts more
    TB0CCR1 = 500; // 50% duty cycle
    TB0CCR2 = 500; // 25% duty cycle
}

void setUART() {
    P2SEL0 &= ~(RXD + TXD); // set to 00 ds74
    P2SEL1 |= RXD + TXD; // set to 11 ds74
    UCA1CTLW0 = UCSSEL0; // 01b for ACLK (pg495 ug)
    UCA1MCTLW = UCOS16 + UCBRF0 + 0x4900; // 9600 baud from 8MHz ug490; UCOS16 = oversampling enabled, UCBRF0 = modulation stage
//    UCA1MCTLW = UCOS16 + UCBRF3 + UCBRF1 + 0xF700; // 57600 baud; UCBRFx = decimal 10 = 1010 hex = high low high low
    UCA1BRW = 52; // ug490 and ug497, bit clock prescaler ***Why is this 52 for both 9600 and 57600 baud?
    UCA1IE |= UCRXIE; // enable UART RX interrupt
}

void setADC() {
    // Enable ADC_B (ug449)
    ADC10CTL0 &= ~ADC10ENC;                        // ensure ENC is clear
    ADC10CTL0 = ADC10ON + ADC10SHT_3;
    ADC10CTL1 = ADC10SHS_0 + ADC10SHP + ADC10CONSEQ_0 + ADC10SSEL_0;
    ADC10CTL2 = ADC10RES; // 8 or 10 bit ADC out
    ADC10MCTL0 = ADC10SREF_1 + ADC10INCH_12; // ADC10INCH_12 for potentiometer
    ADC10IV = 0x00;    // clear all ADC12 channel int flags
    ADC10IE |= ADC10IE0;  // enable ADC10 interrupts

    ADC10CTL0 |= ADC10ENC | ADC10SC; // start the first sample. If this is not done the ADC10 interrupt will not trigger.

    // Set internal voltage reference
    while(REFCTL0 & REFGENBUSY);
    REFCTL0 |= REFVSEL_3 + REFON; // ug431
}

void setPotInput() {
    // Output Pot on P3.0 ds80
    P3DIR |= BIT0;
    P3SEL1 |= BIT0;
    P3SEL0 |= BIT0;
}
