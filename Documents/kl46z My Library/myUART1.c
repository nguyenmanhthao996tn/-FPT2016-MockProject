#include "myUART1.h"

void UART1_init(uint32_t BaudRate, uint8_t DataBit, UART_Parity ParityBit, uint8_t StopBit) /* initialize */
{
	uint8_t tmp = 0;
	uint16_t sbr = 0;
	
	/* Enable clock for UART1 module */
	SIM->SCGC4 |= SIM_SCGC4_UART1_MASK;
	
	/* Disable TX & RX */
	UART1->C2 &= ~(UART_C2_TE_MASK | UART_C2_RE_MASK);
	
	/* Config DataBit */
	switch (DataBit)
	{
		case 8:
			UART1->C1 &= ~UART_C1_M_MASK;
		break;
		case 9:
			UART1->C1 &= ~UART_C1_M_MASK;
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART1_MASK;			// Disable clock for UART1 module
			return;																	  // Unavailable Data bit
	}
	
	/* Config Parity */
	switch (ParityBit)
	{
		case None:
			UART1->C1 &= ~UART_C1_PE_MASK;	// Disable Parity Bit
		break;
		case Odd:
			UART1->C1 |= UART_C1_PE_MASK;	// Enable Parity Bit
			UART1->C1 |= UART_C1_PT_MASK;	// Select Odd Parity Bit
		break;
		case Even:
			UART1->C1 |= UART_C1_PE_MASK;	// Enable Parity Bit
			UART1->C1 &= ~UART_C1_PT_MASK;	// Select Even Parity Bit
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART1_MASK;			// Disable clock for UART1 module
			return;																	  // Unavailable Parity bit
	}
	
	/* Config StopBit */
	switch (StopBit)
	{
		case 1:
			UART1->BDH &= ~UART_BDH_SBNS_MASK;	// One stop bit
		break;
		case 2:
			UART1->BDH |= UART_BDH_SBNS_MASK;	// Two stop bit
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART1_MASK;			// Disable clock for UART1 module
			return;																	  // Stop bit unavailable
	}
	
	/* Config BaudRate */
	sbr = (uint16_t)((24000000u)/(BaudRate * 16));
	tmp = UART1->BDH & ~UART_BDH_SBR_MASK;
	tmp |= UART_BDH_SBR(sbr >> 8);
	UART1->BDH = tmp;
	UART1->BDL = sbr & 0x00ff;
	
	/* Config UART1 RX & TX Pins */
	SIM->SCGC5 |= SIM_SCGC5_PORTE_MASK; /* Enable clock for PORTE */
	PORTE->PCR[0] = (PORTE->PCR[0] & ~PORT_PCR_MUX_MASK) | PORT_PCR_MUX(0x03); /* Set PTE0 as UART1_TX */
	PORTE->PCR[1] = (PORTE->PCR[1] & ~PORT_PCR_MUX_MASK) | PORT_PCR_MUX(0x03); /* Set PTE1 as UART1_RX */
	
	/* Enable TX & RX */
	UART1->C2 |= UART_C2_TE_MASK | UART_C2_RE_MASK;
	
	/* Enable Receiving Interrupt */
	UART1->C2 |= UART_C2_RIE_MASK;
	NVIC_EnableIRQ(UART1_IRQn);
}

void UART1_Transmit(uint8_t TransmitData) /* transmit 8 bit */
{
	while (!(UART1->S1 & UART_S1_TDRE_MASK)); 		// Wait until Transit Data Register to empty
	UART1->D = TransmitData;											// Send data
}

void UART1_printf(const char *str) /* transmit a string */
{
	uint16_t size = strlen(str);
	uint16_t i = 0;
	for (i = 0; i < size; i++)
		UART1_Transmit(str[i]);
}

void buffer_discard( void ) /* clear buffer */
{
	strcpy(buffer.buff, ""); /* remove contain in buffer */
	buffer.len = 0; /* set buffer len = 0 */
}

void buffer_readExist(char* desinationString) /* read string in buffer */
{
	strcpy(desinationString, buffer.buff); /* copy buffer contain to desinationString */
}

void buffer_read(char* desinationString, uint8_t offset, uint8_t length) /* read a specified location in buffer */
{
	strncpy(desinationString, buffer.buff + offset, (buffer.len < length ? buffer.len : length));
}

uint16_t buffer_getLength() /* get current length of buffer */
{
	return buffer.len; /* return len of buffer */
}

void UART1_IRQHandler( void ) /* ISR */
{
	if (UART1->S1 & UART_S1_RDRF_MASK)
	{
		if (buffer.len < Max_Buffer_Size)
		{
			buffer.buff[buffer.len++] = UART1->D;
		}
	}
}
