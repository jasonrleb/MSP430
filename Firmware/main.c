#include <msp430.h>
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <math.h>
#include <stdint.h>
#define RXD BIT5
#define TXD BIT6

struct Queue {
    int front, rear, size;
    unsigned capacity;
    char* array;
};

// Create queue of given capacity with initial size 0
struct Queue* CreateQueue(unsigned capacity) {
    struct Queue* theQueue = (struct Queue*) malloc(sizeof(struct Queue));
    theQueue->capacity = capacity;
    theQueue->front = theQueue->size = 0;
    theQueue->rear = capacity - 1; // rear of queue
    theQueue->array = (char*)malloc(theQueue->capacity * sizeof(char));

    return theQueue;
}

int IsFull(struct Queue* theQueue) {
    return (theQueue->size == theQueue->capacity);
}

int IsEmpty(struct Queue* theQueue) {
    return(theQueue->size == 0);
}

void Enqueue(struct Queue* theQueue, char item) {
    if (IsFull(theQueue))
        return;
    theQueue->rear = (theQueue->rear + 1) % theQueue->capacity;
    theQueue->array[theQueue->rear] = item;
    theQueue->size = theQueue->size + 1;
}

char Dequeue(struct Queue* theQueue) {
    if (IsEmpty(theQueue))
        return INT_MIN; // most negative integer
    char item = theQueue->array[theQueue->front];
    theQueue->front = (theQueue->front + 1) % theQueue->capacity;
    theQueue->size = theQueue->size - 1;
    return item;
}

void setClk(void);
void setTimer(void);
void setUART(void);
void setADC(void);
void setPotInput(void);

unsigned int usePot = 1; // 0 for PWM, 1 for potentiometer
unsigned int potVolt = 0; // store potentiometer voltage in here

struct Queue* queue;

int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer
    setClk();
    setTimer();
    setUART();
    setADC();
    setPotInput();

    _EINT(); // enable global interrupts

    while (1) {
        if (usePot) {
            ADC10MCTL0 = ADC10INCH_12; // use P3.0 A12
            ADC10CTL0 |= ADC10ENC + ADC10SC; // enable and start conversion
            __delay_cycles(100); // avoid spamming
            ADC10CTL0 &= ~(ADC10SC);
            while((ADC10IFG & ADC10IFG0) == 0); // wait for flag
            ADC10CTL0 &= ~(ADC10ENC);
            potVolt = ADC10MEM0; // get pot voltage from ADC
            TB0CCR2 = potVolt << 8; // bitshift left since CCR is 16 bit number
        }
    }

    return 0;
}

#pragma vector = USCI_A1_VECTOR
__interrupt void USCI_A1_ISR(void)
{
    unsigned char RxByte = 0;
    RxByte = UCA1RXBUF; // get val from RX buffer
    UCA1TXBUF = RxByte; // "echo back received byte"
    while (!(UCA1IFG & UCTXIFG)); // wait until the previous Tx is finished
}

void setClk() {
    CSCTL0_H = CSKEY >> 8; // enables CS registers, can also do = 0xA5 (pg80 ug [ug = user guide])
    CSCTL1 &= ~DCORSEL; // DCORSEL set to 0 ug72
    CSCTL1 |= DCOFSEL0 + DCOFSEL1; // (pg81 ug) for 8MHz 11b
    CSCTL2 |= SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1; // set all CLK to run off DCO; (ug82)
    CSCTL3 |= DIVS__8; // set SMCLK divider to /8
}

void setTimer() {
    // Output timer B0 on P1.4 and P1.5
    P1DIR |= BIT4 + BIT5;
    P1OUT &= ~(BIT4 + BIT5);
    P1SEL0 |= BIT4 + BIT5;
    P1SEL1 &= ~(BIT4 + BIT5);

    // Set timer B0
    TB0CTL |= TBSSEL1 + MC0; // select SMCLK source, initialize up mode (ug372)
    TB0CCTL1 = OUTMOD_3; // set/reset and interrupt enable (ug375, ug366 diagrams)
    TB0CCTL2 = OUTMOD_3; // set capture/compare register to set/reset (ug375)

    // Set 1000Hz waves (draw up graph to show)
    TB0CCR0 = 1000 - 1; // = (CLK/divider)/target = (8E6/8)/1000; subtract one since it counts more
    TB0CCR1 = 500;
//    TB0CCR2 = 65535;

    // Output timer B1 on P3.4 and P3.5
    P3DIR |= BIT4 + BIT5;
    P3OUT &= ~(BIT4 + BIT5);
    P3SEL0 |= BIT4 + BIT5;
    P3SEL1 &= ~(BIT4 + BIT5);

    // Set timer B1
    TB1CTL |= TBSSEL1 + MC0; // select SMCLK source, initialize up mode (ug372)
    TB1CCTL1 = OUTMOD_3; // set/reset and interrupt enable (ug375, ug366 diagrams)
    TB1CCTL2 = OUTMOD_3; // set capture/compare register to set/reset (ug375)

    // Set 1000Hz waves (draw up graph to show)
    TB1CCR0 = 1000 - 1; // = (CLK/divider)/target = (8E6/8)/1000; subtract one since it counts more
    TB1CCR1 = 500;
//    TB1CCR2 = 65535;
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
