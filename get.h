#include <Arduino.h>
#include <OneWire.h>
#include <DallasTemperature.h>
#include <Wire.h>
#include <EEPROM.h>

#define ONE_WIRE_BUS 7

extern float tempOne;
extern float tempTwo;

extern void init_Temp(void);

extern void getTemp(void);
