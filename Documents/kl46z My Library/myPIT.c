#include "myPIT.h"

void PIT_init(uint32_t channel0_ldval, uint32_t channel1_ldval) /* Initial PIT with load values */
{
    SIM->SCGC6 |= SIM_SCGC6_PIT_MASK;                                   // Enable Clock for PIT Timer
	PIT->MCR = PIT->MCR & ~PIT_MCR_MDIS_MASK;                           // Turn on PIT Timer
	PIT->CHANNEL[0].LDVAL = channel0_ldval;
	PIT->CHANNEL[0].TCTRL |= PIT_TCTRL_TEN_MASK | PIT_TCTRL_TIE_MASK;   // Start timer, Enable interrupt for Timer0
    
    PIT->CHANNEL[1].LDVAL = channel1_ldval;
	PIT->CHANNEL[1].TCTRL |= PIT_TCTRL_TEN_MASK | PIT_TCTRL_TIE_MASK;   // Start timer, Enable interrupt for Timer0
	
	NVIC->ISER[0] |= (1UL << PIT_IRQn);
}

void PIT_channel0_set_ldval(uint32_t ldval)                     /* Set load value for PIT channel 0 */
{
    PIT->CHANNEL[0].LDVAL = ldval;
}

void PIT_channel1_set_ldval(uint32_t ldval)                     /* Set load value for PIT channel 1 */
{
    PIT->CHANNEL[1].LDVAL = ldval;
}

void PIT_IRQHandler( void )                                     /* Interrupt routine service */
{
    if (PIT->CHANNEL[0].TFLG & PIT_TFLG_TIF_MASK)
		{
			GLed_toggle();
			PIT->CHANNEL[0].TFLG |= PIT_TFLG_TIF_MASK;	// Clear interrupt flag
		}
    if (PIT->CHANNEL[1].TFLG & PIT_TFLG_TIF_MASK)
		{
			RLed_toggle();
			PIT->CHANNEL[1].TFLG |= PIT_TFLG_TIF_MASK;	// Clear interrupt flag
		}
}
