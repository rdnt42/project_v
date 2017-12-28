#include <Arduino.h>
#include <OneWire.h>
#include <DallasTemperature.h>
#include <Wire.h>
#include <EEPROM.h>


#define ONE_VAC A0
#define TWO_VAC A1

#define ONE_WIRE_BUS 7

#define ONE_LEVEL A3
#define TWO_LEVEL A4

extern float tempOne;
extern float tempTwo;


extern uint16_t currentLevelOne;
extern uint16_t currentLevelTwo;

extern void init_Temp(void);

extern void getTemp(void);
extern void getLevel(void);
