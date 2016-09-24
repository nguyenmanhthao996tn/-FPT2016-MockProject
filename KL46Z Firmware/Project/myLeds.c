#include "myLeds.h"

void GLed_init( void )
{
	SIM->SCGC5 |= SIM_SCGC5_PORTD_MASK; /* Enable Clock for PORTD */
	PORTD->PCR[5] |= PORT_PCR_MUX(1);   /* Set PTD5 as GPIO */
	PTD->PDDR |= (1UL << 5);            /* Set PTD5 as Output */
	PTD->PSOR |= (1UL << 5);            /* Turn off green led */
}

void GLed_off( void )
{
    PTD->PSOR |= (1UL << 5);          /* Turn off green led */
}

void GLed_on( void )
{
    PTD->PCOR |= (1UL << 5);          /* Turn on green led */
}

void GLed_toggle( void )
{
    PTD->PTOR |= (1UL << 5);            /* Toggle green led */
}

void RLed_init( void )
{
  SIM->SCGC5 |= SIM_SCGC5_PORTE_MASK; /* Enable Clock for PORTR */
	PORTE->PCR[29] |= PORT_PCR_MUX(1);  /* Set PTE29 as GPIO */
	PTE->PDDR |= (1UL << 29);           /* Set PTD5 as Output */
	PTE->PSOR |= (1UL << 29);           /* Turn off red led */
}

void RLed_off( void )
{
    PTE->PSOR |= (1UL << 29);         /* Turn off red led */
}

void RLed_on( void )
{
    PTE->PCOR |= (1UL << 29);         /* Turn on red led */
}

void RLed_toggle( void )
{
    PTE->PTOR |= (1UL << 29);         /* Toggle red led */
}
