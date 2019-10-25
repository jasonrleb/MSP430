#include <msp430.h>
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <math.h>
#include <stdint.h>

void setClk(void);
void setTimerB(void);
void setUART(void);

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    // Set clock
    setClk();
    // Set timer B
    setTimerB();
    // Set UART
    setUART();

    // Set P3.0 as test output to verify UART
    P3DIR |= BIT0;
    P3OUT &= ~BIT0;

    _EINT(); // enable global interrupts

    return 0;
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA1RXBUF; // get val from RX buffer
    UCA1TXBUF = RxByte; // "echo back received byte"
    while (!(UCA1IFG & UCTXIFG)); // wait until the previous Tx is finished

    if (RxByte == 'j')
        P3OUT ^= BIT0;

    if (RxByte == 'k')
        P3OUT ^= BIT0;
}

void setClk(void){
    CSCTL0_H = CSKEY >> 8; // enables CS registers, can also do = 0xA5 (pg80 ug [ug = user guide])
//    CSCTL1 &= ~DCORSEL; // DCORSEL set to 0 for low speed ug72
    CSCTL1 |= DCORSEL // DCORSEL set to 1 for high speed
    CSCTL1 |= DCOFSEL0 + DCOFSEL1; //High Speed: 24MHz Low Speed: 8MHz 11b
    CSCTL2 |= SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1; // set all CLK to run off DCO; (ug82)
    CSCTL3 &= ~DIVS; // set SMCLK divider to /1
}

void setTimerB(void){
    P1DIR |= BIT4 + BIT5;
    P1OUT &= ~(BIT4 + BIT5);
    P1SEL0 |= BIT4 + BIT5;
    P1SEL1 &= ~(BIT4 + BIT5);

    // Set timer B
    TB0CTL |= TBSSEL1 + MC0; // select SMCLK source, initialize up mode (ug372)
    TB0CCTL1 = OUTMOD_3; // set/reset and interrupt enable (ug375, ug366 diagrams)
    TB0CCTL2 = OUTMOD_3; // set capture/compare register to set/reset (ug375)

    // Set 1000Hz waves (draw up graph to show)
    TB0CCR0 = 2000 - 1; // = (CLK/divider)/target
    TB0CCR1 = 1000; // 50% duty cycle
    TB0CCR2 = 1000; // 25% duty cycle

}

void setUART(void){
    P2SEL0 &= ~(RXD + TXD); // set to 00 ds74
    P2SEL1 |= RXD + TXD; // set to 11 ds74
    UCA1CTLW0 = UCSSEL0; // 01b for ACLK (pg495 ug)
    UCA1MCTLW = UCOS16 + UCBRF0 + 0x4900; // 9600 baud from 8MHz ug490; UCOS16 = oversampling enabled, UCBRF0 = modulation stage
//    UCA1MCTLW = UCOS16 + UCBRF3 + UCBRF1 + 0xF700; // 57600 baud; UCBRFx = decimal 10 = 1010 hex = high low high low
    UCA1BRW = 52; // ug490 and ug497, bit clock prescaler ***Why is this 52 for both 9600 and 57600 baud?
    UCA1IE |= UCRXIE; // enable UART RX interrupt
}

