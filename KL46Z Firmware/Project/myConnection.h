#ifndef __myConnection__
#define __myConnection__

/* Libraries */
#include "MKL46Z4.h"
#include "myLeds.h"
#include "myPIT.h"
#include "myUART0.h"
#include <string.h>


/* Start & Stop Codes */
#define Start_Byte 0x00
#define Stop_Byte  0x01

/* Function Codes */
#define GLed_Set_Frequency  0x02
#define GLed_Info_Frequency 0x03
#define RLed_Set_Frequency  0x04
#define RLed_Info_Frequency 0x05
#define Message_Recieve     0x06
#define Bluetooth_Config    0x07

/* Struct & variable to store leds frequency information */
struct Leds_Frequency_Tag 
{
	union GLed_Tag /* Current green led frequency */
	{
		uint32_t GLed_Frequency32;
		uint8_t  GLed_Frequency8[4];
	} GLed_Frequency;
	union RLed_Tag /* Current red led frequency */
	{
		uint32_t RLed_Frequency32;
		uint8_t  RLed_Frequency8[4];
	} RLed_Frequency;
};
typedef struct Leds_Frequency_Tag Leds_Frequency_Obj;
typedef struct Leds_Frequency_Tag* Leds_Frequency;

/* Status */
typedef enum STATE {
	Idle,
	Started,
	Receiving_GLed_Frequency,
	Receiving_RLed_Frequency,
	Receiving_Message,
	Receiving_Config
} State;

/* Data Structure */
struct DATA_STRUCT_TAG
{
	State Current_State;
	uint8_t frequency_byte_remaining;
	union FREQUENCY
	{
		uint32_t FREQUENCY32;
		uint8_t  FREQUENCY8[4];
		char     FREQUENCYCHAR[4];
	} Frequency_Data;
	struct MESSAGE_TAG
	{
		char text[100];
		uint8_t len;
	} Message;
};
typedef struct DATA_STRUCT_TAG Data_Struct_Obj;
typedef struct DATA_STRUCT_TAG* Data_Struct;

/* Functions */
void INIT(Data_Struct Data, Leds_Frequency LFrequency); /* Initialize all neccessary modules */
void Data_handle(Data_Struct Data, Leds_Frequency LFrequency, uint8_t rdata);
void UART0_Send_Message(char* Message);

#endif /* __myConnection__ */
