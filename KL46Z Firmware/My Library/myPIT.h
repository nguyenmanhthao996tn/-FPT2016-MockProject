#ifndef __myPIT__
#define __myPIT__
#include "MKL46Z4.h"
#include "myLeds.h"

void PIT_init(uint32_t channel0_ldval, uint32_t channel1_ldval); /* Initial PIT with load values */
void PIT_channel0_set_ldval(uint32_t ldval);                     /* Set load value for PIT channel 0 */
void PIT_channel1_set_ldval(uint32_t ldval);                     /* Set load value for PIT channel 1 */
void PIT_IRQHandler( void );                                     /* Interrupt routine service */

#endif
