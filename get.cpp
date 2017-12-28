
#include "get.h"


////////////////////GET VAC////////////////////
int16_t currentVacOne;
int16_t currentVacTwo;
int32_t pressSum;
///////////////////GET TEMP///////////////////
float tempOne;
float tempTwo;
float tempThree;
float tempFour;
////////////////////GET LEVEL/////////////////
uint16_t currentLevelOne;
uint16_t currentLevelTwo;

//String* sendMessage = String(currentVacOne) + " " + String(currentVacTwo) + " " + String(tempOne) + " " + String(tempFour);

OneWire oneWire(ONE_WIRE_BUS);

DallasTemperature sensors(&oneWire);
//28EECC5512160281

DeviceAddress addOne = {0x28, 0xEE, 0xCC, 0x55, 0x12, 0x16, 0x02, 0x81 };
//DeviceAddress addOne = {0x28, 0xB4, 0x6B, 0x9B, 0x06, 0x00, 0x00, 0x00 };
DeviceAddress addTwo = {0x28, 0x3A, 0x66, 0x9B, 0x06, 0x00, 0x00, 0x15 };
DeviceAddress addThree = {0x28, 0x8C, 0x2C, 0x9C, 0x06, 0x00, 0x00, 0x72 };
DeviceAddress addFour  =  {0x28, 0xEE, 0xCC, 0x55, 0x12, 0x16, 0x02, 0x81 };



////////////////////GET VAC///////////////////




  //Serial.println( String(currentVacOne));



///////////////////GET TEMP///////////////////
void init_Temp(void) {
  sensors.begin();
}

void getTemp(void) {
  sensors.requestTemperatures();
  tempOne = sensors.getTempC (addOne);
  if (tempOne == -127.00)
  {}
  tempTwo = sensors.getTempC (addTwo);
  if (tempTwo == -127.00)
  {}
  tempThree = sensors.getTempC (addThree);
  if (tempThree == -127.00)
  {}
  tempFour = sensors.getTempC (addFour);
  if (tempFour == -127.00)
  {}
}

void getLevel(void) {
  static unsigned long millisPrevLvl;

  if (millis() - 1000 > millisPrevLvl) {
    int sum;
    for (int i = 0; i < 10; i++) {
      currentLevelOne = analogRead (ONE_LEVEL);  //FIX
      sum += currentLevelOne;
    }
    currentLevelOne = sum / 10;
    //currentLevelOne = analogRead(ONE_LEVEL);
    currentLevelTwo = analogRead(TWO_LEVEL);
    millisPrevLvl = millis();
    
  }
}

