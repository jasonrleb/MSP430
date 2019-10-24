#include <msp430.h>
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <math.h>
#include <stdint.h>

void setupClk(void);
void setTimB(void);
void setupUART(void);

// Define global vars for interrupt
volatile unsigned int rise;
volatile unsigned int fall;
volatile unsigned int freq = 0; // falling - rising
volatile unsigned int mark = 0; // record if rising or falling
volatile int currentFreq;

/**
 * main.c
 */
int main(void)
{
    WDTCTL = WDTPW | WDTHOLD;   // stop watchdog timer

    // Set clock
    setClk();

    // Set timer B
    setTimB();

    // Set UART
    setUART();

    _EINT(); // enable global interrupts

    return 0;
}

void setupClk(void){

    CSCTL0_H = CSKEY >> 8; // enables CS registers, can also do = 0xA5 (pg80 ug [ug = user guide])
//    CSCTL1 &= ~DCORSEL; // DCORSEL set to 0 for low speed ug72
    CSCTL1 |= DCORSEL // DCORSEL set to 1 for high speed
    CSCTL1 |= DCOFSEL0 + DCOFSEL1; //High Speed: 24MHz Low Speed: 8MHz 11b
    CSCTL2 |= SELM0 + SELM1 + SELA0 + SELA1 + SELS0 + SELS1; // set all CLK to run off DCO; (ug82)
    CSCTL3 &= ~DIVS; // set SMCLK divider to /1

}

void setTimB(void){

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

void setupUART(void){

}

