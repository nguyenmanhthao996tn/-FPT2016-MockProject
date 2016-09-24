#include "myConnection.h"

void INIT(Data_Struct Data, Leds_Frequency LFrequency)
{
	/* Data struct */
	Data->Current_State = Idle;
	Data->Frequency_Data.FREQUENCY32 = (uint32_t)0;
	Data->frequency_byte_remaining = 0;
	strcpy(Data->Message.text, "");
	Data->Message.len = 0;
	
	/* Leds Frequency */
	LFrequency->GLed_Frequency.GLed_Frequency32 = LFrequency->RLed_Frequency.RLed_Frequency32 = 11999999u;
	
	/* Leds */
	GLed_init(); /* Green led */
	RLed_init(); /* Red led */
	
	/* PIT */
	PIT_init(11999999, 11999999); /* Default led Frequency are equal to 1s */
	
	/* UART0 */
	UART0_init(9600, 8, UART_ParityBit_None, 1); /* Baudrate: 9600, Databits: 8, Parity: None, Stopbits: 1 */
}

void Data_handle(Data_Struct Data, Leds_Frequency LFrequency, uint8_t rdata)
{
	switch (Data->Current_State)
	{
		case Idle:
			if (rdata == Start_Byte)
			{
				Data->Current_State = Started;
			}
			break;
		case Started:
			switch (rdata)
			{
				case GLed_Set_Frequency:
					Data->Current_State = Receiving_GLed_Frequency;
					Data->frequency_byte_remaining = 4;
					break;
				case GLed_Info_Frequency:
					UART0_printf1((char*)(LFrequency->GLed_Frequency.GLed_Frequency8), 4);
					break;
				case RLed_Set_Frequency:
					Data->Current_State = Receiving_RLed_Frequency;
					Data->frequency_byte_remaining = 4;
					break;
				case RLed_Info_Frequency:
					UART0_printf1((char*)(LFrequency->RLed_Frequency.RLed_Frequency8), 4);
					break;
				case Message_Recieve:
					Data->Current_State = Receiving_Message;
					strcpy(Data->Message.text, "");
					Data->Message.len = 0;
					break;
				case Bluetooth_Config:
					Data->Current_State = Receiving_Config;
					strcpy(Data->Message.text, "");
					Data->Message.len = 0;
					break;
				case Stop_Byte:
				default:
					Data->Current_State = Idle;
				break;
			}
			break;
		case Receiving_GLed_Frequency:
			if (Data->frequency_byte_remaining > 0)
			{
				/* Receiving */
				(Data->frequency_byte_remaining)--;
				Data->Frequency_Data.FREQUENCY8[Data->frequency_byte_remaining] = rdata;
			}
			else
			{
				/* Changing frequency */
				if (rdata == Stop_Byte) /* if receive a stop bye then change the frequency */
				{
					LFrequency->GLed_Frequency.GLed_Frequency32 = Data->Frequency_Data.FREQUENCY32; /* Store frequency in data struct */
					PIT_channel0_change_ldval(Data->Frequency_Data.FREQUENCY32); /* Set new frequency */
					Data->Current_State = Idle; /* Complete receiving frequency, change to idle state */
				}
			}
			break;
		case Receiving_RLed_Frequency:
			if (Data->frequency_byte_remaining > 0)
			{
				/* Receiving */
				(Data->frequency_byte_remaining)--;
				Data->Frequency_Data.FREQUENCY8[Data->frequency_byte_remaining] = rdata;
			}
			else
			{
				/* Changing frequency */
				if (rdata == Stop_Byte) /* if receive a stop bye then change the frequency */
				{
					LFrequency->RLed_Frequency.RLed_Frequency32 = Data->Frequency_Data.FREQUENCY32; /* Store frequency in data struct */
					PIT_channel1_change_ldval(Data->Frequency_Data.FREQUENCY32); /* Set new frequency */
					Data->Current_State = Idle; /* Complete receiving frequency, change to idle state */
				}
			}
			break;
		case Receiving_Message:
			/* Receiving & sending message to HM-10 */
		if (rdata == 0x01) /* stop byte */
		{
			Data->Current_State = Idle;
			/* Send message to HM-10 */
			if (strcmp(Data->Message.text, "abc") == 0)
			{
				UART0_Send_Message("Ok! Message recieved!");
			}
		}
		else
		{
			strcat(Data->Message.text, (char*)&rdata);
			Data->Message.len++;
		}
			break;
		case Receiving_Config:
			/* Receiving & sending config to HM-10 */
			if (rdata == 0x01) /* stop byte */
			{
				Data->Current_State = Idle;
				/* Send config to HM-10 */
				if (strcmp(Data->Message.text, "abc") == 0)
				{
					UART0_Send_Message("Ok! Config recieved!");
				}
			}
			else
			{
				strcat(Data->Message.text, (char*)&rdata);
				Data->Message.len++;
			}
			break;
		default:
			Data->Current_State = Idle; /* error, change to idle state */
			break;
	}
}

void UART0_Send_Message(char* Message)
{
	UART0_Transmit(Start_Byte); /* Send a Start Byte to UART0 */
	UART0_Transmit(Message_Recieve); /* Send Message_Recieve function code to UART0  */
	UART0_printf(Message); /* Send the content of the message */
	UART0_Transmit(Stop_Byte); /* Send a Stop Byte */
}