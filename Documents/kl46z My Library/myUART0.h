#ifndef __myUART0__
#define __myUART0__


#include "MKL46Z4.h"                    // Device header
#include <string.h>

#define UART_ParityBit_None		0
#define UART_ParityBit_Odd 		1
#define UART_ParityBit_Even 	2

int UART0_init(uint32_t BaudRate, uint8_t DataBit, uint8_t ParityBit, uint8_t StopBit);
void UART0_Transmit(uint8_t TransmitData);
void UART0_printf(const char *str);


#endif