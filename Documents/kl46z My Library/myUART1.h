#ifndef __myUART1__
#define __myUART1__

#include "MKL46Z4.h"
#include "string.h"

/* UART characteristics */
#define Delay_Between_Bytes 2 /* in milliseconds */
#define Max_Buffer_Size 100 /* in bytes */

/* UART Parity  */
typedef enum UART_Parity_Tag {
	None,
	Even,
	Odd
} UART_Parity;

/* Buffer */
struct UART1_Buffer_Tag
{
	char buff[Max_Buffer_Size];
	uint16_t len;
};
typedef struct UART1_Buffer_Tag UART1_Buffer;
static UART1_Buffer buffer;

/* functions */
void UART1_init(uint32_t BaudRate, uint8_t DataBit, UART_Parity ParityBit, uint8_t StopBit); /* initialize */
void UART1_Transmit(uint8_t TransmitData); /* transmit 8 bit */
void UART1_printf(const char *str); /* transmit a string */
void buffer_discard( void ); /* clear buffer */
void buffer_readExist(char* desinationString); /* read string in buffer */
void buffer_read(char* desinationString, uint8_t offset, uint8_t length);
void UART1_IRQHandler( void );

#endif /* __myUART1__ */
