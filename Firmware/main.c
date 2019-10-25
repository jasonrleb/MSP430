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

    _EINT(); // enable global interrupts

    return 0;
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

    TB1CTL |= TBSSEL1 // select SMCLK source,
//    TB1CTL |= MC0; // up mode (ug372) (for duty cycle)
    TB1CTL |= MC1; // continuous mode (ug372)
    CNTL = 0x0000; //count value (TB1R) maximum = 16bit

    // Set mode (ug375, ug366 diagrams)
    TB1CCTL1 = OUTMOD_3; // set capture/compare register to set/reset (ug375)
    TB1CCTL2 = OUTMOD_3; // set capture/compare register to set/reset (ug375)

    // Set 500Hz waves (draw up graph to show)
    TB1CCR0 = 2000; // = (CLK/divider)/target = (8E6/8)/500 aka 4x divisions
    TB1CCR1 = 1000; // 50% duty cycle, TB1.1 50%
    TB1CCR2 = 1500; // 25% duty cycle, TB1.2 25%

    // Set P3.4 and P3.5 to be Timer B output and LED output (P1 only has Timer A and no LED); um14, 17
    // BIT4 is TB1.1, BIT5 is TB1.2, should be dimmer
    P3DIR |= BIT4 + BIT5;
    P3OUT &= ~(BIT4 + BIT5);
    P3SEL0 |= BIT4 + BIT5;
    P3SEL1 &= ~(BIT4 + BIT5);

}

void setUART(void){
    // Configure UART on P2.5 and 2.6
    P2SEL0 &= ~(BIT5 + BIT6); // set to 00 ds77
    P2SEL1 |= BIT5 + BIT6; // set to 11 ds77
    UCA1CTLW0 = UCSSEL0; // 01b for ACLK (pg495 ug)
    UCA1MCTLW = UCOS16 + UCBRF0 + 0x4900; // 9600 baud from 8MHz ug490; UCOS16 = oversampling enabled, UCBRF0 = modulation stage
//    UCA0MCTLW = UCOS16 + UCBRF3 + UCBRF1 + 0xF700; // 57600 baud; UCBRFx = decimal 10 = 1010 hex = high low high low
    UCA1BRW = 52; // ug490 and ug497, bit clock prescaler ***Why is this 52 for both 9600 and 57600 baud?
    UCA1IE |= UCRXIE; // enable UART RX interrupt
}

