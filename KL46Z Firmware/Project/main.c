#include "MKL46Z4.h"                    /* Device header */
#include "myConnection.h"

/* Global data pointers */
volatile Data_Struct Data;
volatile Leds_Frequency LFrequency;

int main( void )
{
	Data_Struct_Obj Data_obj; /* Data struct of UART0 connection */
	Leds_Frequency_Obj LFrequency_obj; /* Data struct of Leds frequency */
	
	SystemInit(); /* Init system */
	SystemCoreClockUpdate(); /* Update system clock */
	
	/* Pass data struct addresses to global data pointers */
	Data = &Data_obj; /* Data struct of UART0 connection */
	LFrequency = &LFrequency_obj; /* Data struct of Leds frequency */
	
	INIT(Data, LFrequency); /* Initialize modules */
	
	UART0_Transmit(0x00);
	UART0_Transmit(0x06);
	UART0_printf("TEST");
	UART0_Transmit(0x01);
	
	while (1)
	{
		
	}
}


/* UART0 interrupt service routine */
void UART0_IRQHandler( void )
{
	if (UART0->S1 & UART0_S1_RDRF_MASK) /* if Recieve Data Register Full */
		Data_handle(Data, LFrequency, (uint8_t)(UART0->D));
}
