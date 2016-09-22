#include "myUART0.h"

int UART0_init(uint32_t BaudRate, uint8_t DataBit, uint8_t ParityBit, uint8_t StopBit)
{
	uint32_t 	BaudDiff = 0,
						BaudDiff_Min = 0,
						OSR_val = 0,
						OSR_Cval = 0,
						SBR_val = 0,
						SBR_Cval = 0;
	uint8_t i = 0;
	
	SIM->SOPT2 = (SIM->SOPT2 & ~(SIM_SOPT2_UART0SRC_MASK | SIM_SOPT2_PLLFLLSEL_MASK)) |
								SIM_SOPT2_UART0SRC(0x01U);					// UART0 clock = MCGFLLCLK clock or MCGPLLCLK/2
																										// PLLFLLSEL = 0 : MCGFLLCLK clock
	
	// Enable UART module clock (SIM_SCGC4)
	SIM->SCGC4 |= SIM_SCGC4_UART0_MASK;			// Enable clock for UART0 module
	
	// Disable reciver and transmitter (UARTn_C2[RE, TE]) to configure UART0 module
	UART0->C2 &= ~(UART0_C2_RE_MASK | UART0_C2_TE_MASK);
	
	// Configure UART control registers for the desired data format
	switch (DataBit)
	{
		case 8:
			UART0->C4 &= ~UART0_C4_M10_MASK;
			UART0->C1 &= ~UART0_C1_M_MASK;
		break;
		case 9:
			UART0->C4 |= UART0_C4_M10_MASK;
			UART0->C1 &= ~UART0_C1_M_MASK;
		break;
		
		case 10:
			UART0->C1 |= UART0_C1_M_MASK;
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART0_MASK;			// Disable clock for UART0 module
			return 1;																	// Unavailable Data bit
	}
	
	switch (ParityBit)
	{
		case UART_ParityBit_None:
			UART0->C1 &= ~UART0_C1_PE_MASK;	// Disable Parity Bit
		break;
		case UART_ParityBit_Odd:
			UART0->C1 |= UART0_C1_PE_MASK;	// Enable Parity Bit
			UART0->C1 |= UART0_C1_PT_MASK;	// Select Odd Parity Bit
		break;
		case UART_ParityBit_Even:
			UART0->C1 |= UART0_C1_PE_MASK;	// Enable Parity Bit
			UART0->C1 &= ~UART0_C1_PT_MASK;	// Select Even Parity Bit
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART0_MASK;			// Disable clock for UART0 module
			return 1;																	// Unavailable Parity bit
	}
	
	switch (StopBit)
	{
		case 1:
			UART0->BDH &= ~UART0_BDH_SBNS_MASK;	// One stop bit
		break;
		case 2:
			UART0->BDH |= UART0_BDH_SBNS_MASK;	// Two stop bit
		break;
		default:
			SIM->SCGC4 &= ~SIM_SCGC4_UART0_MASK;			// Disable clock for UART0 module
			return 1;																	// Stop bit unavailable
	}
	
	UART0->S2 &= ~UART0_S2_MSBF_MASK;	// LSB First
	UART0->S2 &= ~UART0_S2_RXINV_MASK;	// Recieve isn't reverse
	UART0->C3 &= ~UART0_C3_TXINV_MASK;	// Transmit isn't reverse
	
	// Configure Baud rate (UARTn_BDH & UARTn_BDL) with minimum difference
	OSR_Cval = 4;
	SBR_Cval = (uint32_t)(SystemCoreClock / (OSR_Cval * BaudRate));
	
	if (BaudRate > (SystemCoreClock / (OSR_Cval * SBR_Cval)))
	{
		BaudDiff_Min = BaudRate - (SystemCoreClock / (OSR_Cval * SBR_Cval));
	}
	else
	{
		BaudDiff_Min = (SystemCoreClock / (OSR_Cval * SBR_Cval)) - BaudRate;
	}
	
	for ( i = 5; i < 32; i++)
	{
		OSR_val = i;
		SBR_val = (uint32_t)(SystemCoreClock / (OSR_val * BaudRate));
		
		if (BaudRate > (SystemCoreClock / (OSR_val * SBR_val)))
		{
			BaudDiff = BaudRate - (SystemCoreClock / (OSR_val * SBR_val));
		}
		else
		{
			BaudDiff = (SystemCoreClock / (OSR_val * SBR_val)) - BaudRate;
		}
		
		if (BaudDiff < BaudDiff_Min)
		{
			BaudDiff_Min = BaudDiff;
			OSR_Cval = OSR_val;
			SBR_Cval = SBR_val;
		}
	}
	
	// Set OSR value
	UART0->C4 = (UART0->C4 & ~UART0_C4_OSR_MASK) |
							UART0_C4_OSR(OSR_Cval - 1);
	// Set SBR value
	SBR_val = (SBR_Cval >> 8) & 0x001F; // 5 bits high of SBR
	UART0->BDH = (UART0->BDH & ~UART0_BDH_SBR_MASK) | 
								UART0_BDH_SBR((uint8_t)SBR_val);
	SBR_Cval &= 0x00FF;									// 8 bits low of SBR
	UART0->BDL = (uint8_t)SBR_Cval;
	
	
	
	// Enable clock for port associated with UART pins you want to use (SIM_SCGC5)
	SIM->SCGC5 |= SIM_SCGC5_PORTA_MASK;			// Enable clock for PORTA
	
	// Enable UART pins (PORTx_PCR[n])
	PORTA->PCR[1] = 	(PORTA->PCR[1] & ~PORT_PCR_MUX_MASK) |
										PORT_PCR_MUX(2);			// Set PTA1 as RXD
	PORTA->PCR[2] = 	(PORTA->PCR[2] & ~PORT_PCR_MUX_MASK) |
										PORT_PCR_MUX(2);			// Set PTA2 as TXD
	
	// Enable reciver and transmitter (UARTn_C2[RE, TE])
	UART0->C2 |= 	UART0_C2_RE_MASK | 
								UART0_C2_TE_MASK;
	
	return 0; // UART0 initial successfully
}

void UART0_Transmit(uint8_t TransmitData)
{
	while (!(UART0->S1 & UART0_S1_TDRE_MASK)); 		// Wait until Transit Data Register to empty
	UART0->D = TransmitData;											// Send data
}

void UART0_printf(const char *str)
{
	uint16_t size = strlen(str);
	uint16_t i = 0;
	for (i = 0; i < size; i++)
		UART0_Transmit(str[i]);
}