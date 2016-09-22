#ifndef __myLeds__
#define __myLeds__


#include "MKL46Z.h"

/* Green Led Functions */
void GLed_init( void );
void GLed_off( void );
void GLed_on( void );
void GLed_toggle( void );

/* Red Led Functions */
void RLed_init( void );
void RLed_off( void );
void RLed_on( void );
void RLed_toggle( void );

#endif