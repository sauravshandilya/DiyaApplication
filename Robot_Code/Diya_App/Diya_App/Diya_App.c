/*
 * Diya_App.c
 *
 * Created: 4/3/2013 10:48:06 PM
 *  Author: erts
 */ 


#define F_CPU 14745600
#include<avr/io.h>
#include<avr/interrupt.h>
#include<util/delay.h>

unsigned char data; //to store received data from UDR1

void buzzer_pin_config (void)
{
 DDRC = DDRC | 0x08;		//Setting PORTC 3 as outpt
 PORTC = PORTC & 0xF7;		//Setting PORTC 3 logic low to turnoff buzzer
}

//Function to configure Interrupt switch
void interrupt_switch_config (void)
{
	DDRE = DDRE & 0x7F;  //PORTE 7 pin set as input
	PORTE = PORTE | 0x80; //PORTE7 internal pull-up enabled
}

//Function to configure LDD bargraph display
void LED_bargraph_config (void)
{
	DDRJ = 0xFF;  //PORT J is configured as output
	PORTJ = 0x00; //Output is set to 0
}

void motion_pin_config (void)
{
 DDRA = DDRA | 0x0F;
 PORTA = PORTA & 0xF0;
 DDRL = DDRL | 0x18;   //Setting PL3 and PL4 pins as output for PWM generation
 PORTL = PORTL | 0x18; //PL3 and PL4 pins are for velocity control using PWM.
}

//Function to initialize ports
void port_init()
{
	motion_pin_config();
	buzzer_pin_config();
	interrupt_switch_config();
	LED_bargraph_config();
}

void buzzer_on (void)
{
 unsigned char port_restore = 0;
 port_restore = PINC;
 port_restore = port_restore | 0x08;
 PORTC = port_restore;
}

void buzzer_off (void)
{
 unsigned char port_restore = 0;
 port_restore = PINC;
 port_restore = port_restore & 0xF7;
 PORTC = port_restore;
}

//Function To Initialize UART0
// desired baud rate:9600
// actual baud rate:9600 (error 0.0%)
// char size: 8 bit
// parity: Disabled
void uart0_init(void)
{
 UCSR0B = 0x00; //disable while setting baud rate
 UCSR0A = 0x00;
 UCSR0C = 0x06;
// UBRR0L = 0x47; //11059200 Hz
 UBRR0L = 0x5F; // 14745600 Hzset baud rate lo
 UBRR0H = 0x00; //set baud rate hi
 UCSR0B = 0x58; //enables transmitting
}


//Function To Initialize all The Devices
void init_devices()
{
 cli(); //Clears the global interrupts
 port_init();  //Initializes all the ports
 uart0_init(); //Initailize UART1 for serial communiaction
 sei();   //Enables the global interrupts
}

unsigned int debounce(void)
{
	unsigned int ones=0, zeroes=0;
	unsigned char i;
	/*for(i=0;i<9;i++)
	{
		if(PINE & 0x80)	// read pin == 1
		{ 
			zeroes++;
		} 
		else			// read pin == 0
			{ 
			ones++;
			}
		_delay_ms(75);
	} 
	  return ones>zeroes;*/
	
	while (PINE & 0x80);
	
	}


//Main Function
int main(void)
{	unsigned char value1, flag;
	init_devices();

	 
	while(1)
	{
//		buzzer_on(); //Turn on buzzer
//		_delay_ms(1000);
		flag=0;
/*		if(!(PINE & 0x80) ) //switch is pressed
		{
			_delay_ms(20);
			if(!(PINE & 0x80) )
				{
					flag=1;
					value1 = '0';
					UDR0 = value1;
					buzzer_on(); //Turn on buzzer
					_delay_ms(1000);
					while (1);					
				}
			buzzer_off(); //Turn off buzzer
			_delay_ms(300);
			PORTJ = 0x00; //Turn off bar graph LEDs
		}*/

			if(PINE & 0x80)  //switch is pressed
			{
				/*_delay_ms(20);
				if(!(PINE & 0x80) )
				{
					flag=1;
					value1 = '0';
					UDR0 = value1;
					buzzer_on(); //Turn on buzzer
					_delay_ms(1000);
					while (1);
				}*/
				buzzer_off(); //Turn off buzzer
				//_delay_ms(300);
				PORTJ = 0x00; //Turn off bar graph LEDs
			}

		else
		{
			_delay_ms(100);
			if(!(PINE & 0x80))
			{
			while(!(PINE & 0x80));
			value1 = '0';
			UDR0 = value1;
		//	buzzer_on(); //Turn on buzzer
		//	_delay_ms(500);
		//	buzzer_on(); //Turn on buzzer
		//	_delay_ms(500);
		//	buzzer_on(); //Turn on buzzer
		//	_delay_ms(500);
			}
			
		}
				
	}
}

