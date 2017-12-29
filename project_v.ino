////////////////////////Artem L., 5 novemver 2017, radiant42@yandex.ru//////////////
///////////////////////Arduino OOP project, getting data from sensors///////////////
///////////////////////setting control signals to external devices//////////////////
/////////////////////////////////send-recive data to WinForms///////////////////////


//////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!/////
/////DON`T FORGET UPDATE COOMENTS//////////
//////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!/////
#include <timer-api.h>
#include <timer_setup.h>
#include <SPI.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
//#include "U8glib.h"
#include "get.h"


////////////////////TIMER SETUP////////////////////
int _timer = TIMER_DEFAULT;
uint32_t currentTime = 0;

////////////////////STAGE SETUP////////////////////
bool firstIn = true;
int systemState = 0;



////////////////////SERIAL PROTOCOL/////////////////
char data[20];
char unitID_in[10];
char command_in[10];
char data_one[10];
char data_two[10];
char data_three [10];
uint8_t i = 0;

class Valve
{
    int valvePin12;       //пин клапана 12V
    int valvePin24;       //пин клапана 24V

  public: bool valveState;    //состояние клапана
    bool lastValveState;

  public: int valveId;

    bool startFlag;       //первое вклчюение клапана
    bool timeFlag;       //включение клапана на время
    uint32_t timeStart;
    uint32_t timeWork;
    
    uint16_t timeOne;
    
  public:
    Valve(int pin1, int pin2, int id)
    {
      valveId = id;
      valvePin12 = pin1;
      valvePin24 = pin2;
      pinMode (valvePin12, OUTPUT);
      pinMode (valvePin24, OUTPUT);
      valveState = HIGH;
      lastValveState = valveState;
      digitalWrite(valvePin12, HIGH);
      digitalWrite(valvePin24, HIGH);
      timeOne = 2;
    }

    bool Work () {

      if (startFlag == true && (currentTime >= timeStart)) {
        digitalWrite(valvePin24, HIGH);
        startFlag = false;
      }
      if (timeFlag == true && (currentTime >= timeWork)) { //только на выключение через определенное время
        valveState = HIGH;
        timeFlag = false;

      }
      if (lastValveState != valveState) {
        lastValveState = valveState;
        Serial.print("001,VLV," + String(valveId) + "," + String(!valveState) + ",SBIT");
      }

      digitalWrite(valvePin12, valveState);
      return (!valveState);
    }

    void Update (bool state, uint32_t timeSet) {
      valveState = !state;
      startFlag = state;
      timeStart = timeOne + currentTime;
      digitalWrite(valvePin12, valveState);
      digitalWrite(valvePin24, valveState);
      if (timeSet != 0) {
        timeWork = timeSet + currentTime;
        timeFlag = true;
      }
    }
};

class Vacuum
{

    int vacPinSet;
    int vacPinRead;
    bool vacState;
    int vacSet;
    uint32_t timeWork;
    bool timeFlag;
  public: int vacValue;

  public:
    Vacuum (int pinSet, int pinRead)
    {
      vacPinSet = pinSet;
      vacPinRead = pinRead;
      vacState = false;
      vacSet = 750;
      timeFlag = false;

    }

    void GetVac (void) {
      static unsigned long millisPrev;
      if (millis() - 100 > millisPrev) {
        vacValue = analogRead (vacPinRead);
        /* int currVac = 0;
          for (int i = 0; i < 100; i++) {
           currVac += analogRead (vacPinRead);
          }
          currVac = currVac / 100;
          vacValue = map(currVac, 140, 850, 40, 756);*/
        millisPrev = millis();
      }
    }

    void Work () {
      if (timeFlag == true && (currentTime >= timeWork)) {
        vacState = false;
        timeFlag = false;
      }


      if (vacState && ((vacValue - vacSet ) > 0)) { //приводить к типу инт, инач бред выдает, разобраться
        analogWrite (vacPinSet, 255);
      }

      else if (vacState && ((vacValue - vacSet  ) < 0) && ((vacValue - vacSet) > -3)) {
        analogWrite (vacPinSet, 150);
        // Serial.println (pressure - vac_value);
      }

      else if (vacState && ((vacValue - vacSet  ) < -3)) {
        analogWrite (vacPinSet, 0);
      }

      else if (!vacState) {
        analogWrite (vacPinSet, 0);
      }
    }

    void Update (bool state, uint32_t timeSet) {
      vacState = state;
      if (timeSet != 0) {
        timeWork = timeSet + currentTime;
        timeFlag = true;
      }

    }

};

class Level {
    int levelPinLaser;                              //laser pin
    int levelPinReader;                             //photoresistor pin
    int supplayPin;                                 //5v pin
  public: bool levelState;                          //laser work state
  public: bool levelValue;                          //true - photoresistor on light
    bool lastValveState;

    bool flagOne;       //вклчюение уровня на время
    bool lastLevelState;

  public: int levelId;
    uint16_t timeOne;
    uint32_t currTimeOne;

  public:
    Level (int pinLaser, int pinReader, int supplay, int id)
    {
      levelPinLaser = pinLaser;
      levelPinReader = pinReader;
      supplayPin = supplay;
      levelId = id;
      pinMode (levelPinLaser, OUTPUT);
      pinMode (supplayPin, OUTPUT);
      levelState = LOW;
      lastLevelState = levelState;
      digitalWrite(levelPinLaser, LOW);
      digitalWrite(supplayPin, HIGH);
    }

    bool Work() {

      if (lastLevelState != levelState) {
        lastLevelState = levelState;
        Serial.print("001,LVL," + String(levelId) + "," + String(levelState) + ",SBIT");
      }
      digitalWrite (levelPinLaser, levelState);
      if (analogRead(levelPinReader) > 600)
        levelValue = true;
      else
        levelValue = false;
      return levelValue;
    }

    void Update(bool state) {
      levelState = state;
      digitalWrite (levelPinLaser, levelState);
    }

};

//U8GLIB_ST7920_128X64_1X u8g(35, 33, 31, U8G_PIN_NONE);
LiquidCrystal_I2C lcd(0x27, 16, 4);
Valve vlvOne(A8, A9, 1);
Valve vlvTwo(A10, A11, 2);

Vacuum vacOne (8, A0);

Level lvlOne (22, A4, A5, 1);

void getState (void) {
  getTemp();
  vacOne.GetVac();
}

void reciveMessage(void) {
  if (Serial.available() > 0) {
    while (Serial.available()) {
      data [i] = Serial.read();
      i++;
      _delay_ms(10);
    }
    // Serial.println(String(data));
    sscanf(data, "%[^','],%[^','], %[^','],%[^','],%[^','],%d", &unitID_in, &command_in, &data_one, &data_two, &data_three);

    int first, second;
    uint32_t third;                //переводит блоки data в int


    // Serial.println (String(data_one) + " " + String(sizeof(data_two)) + " " + String(sizeof(data_three)));
    //sscanf(data_three, "%d", &third);
    // sscanf(data_one, "%d", &first);
    // sscanf(data_two, "%d", &second);
    first = strtol(data_one, NULL, 0); //замена для atoi, т.к. некорректно работате с 32 битными
    second = strtol(data_two, NULL, 0);
    third = strtol(data_three, NULL, 0);

    if (String(command_in) == "STR") {
      systemState = 1;
    }
    else if (String(command_in) == "GET") {
      Serial.print("001,DATA," + String(tempOne) + "," + String(vacOne.vacValue) + "," + String(vlvOne.valveState) + "," + String(vlvTwo.valveState) + "," + "SBIT");

    }

    else if (String(command_in) == "VAC") {

      if (second == 1)
        vacOne.Update(first, third);
    }

    else if (String(command_in) == "AIR") {

    }

    else if (String(command_in) == "VLV") {

      if (second == 1)
        vlvOne.Update(first, third);

      else if (second == 2)
        vlvTwo.Update(first, third);


      //Serial.println (String(third));
    }

    else if (String(command_in) == "LVL") {
      lvlOne.Update(first);
    }

    // memset(&third, 0, sizeof(third));
    Serial.flush();
    i = 0;
  }
}

void stopFunc() {

}

void startFunc() {

}


void timer_handle_interrupts(int timer) {
  currentTime++;                                    //timer count in sec
}



void setup() {
  Serial.begin(115200);
  timer_init_ISR_1Hz(TIMER_DEFAULT);
  lcd.init();
  lcd.init();
  lcd.backlight();


}

void loop() {
  reciveMessage();
  getState();
  lcd.setCursor(3, 0);
  lcd.clear();
  lcd.print(String(systemState));
  switch (systemState) {                                //1,3,5,7,9,11... stage settings //2,4,6,8,10... stage start

    case 0:                                             //reset all
      // systemState++;
      break;

    case 1:
      //time
      vlvOne.Update (true, 53000);
      systemState++;
      break;

    case 2:
      if (!vlvOne.Work())
        systemState++;
      break;

    case 3:
      //state
      lvlOne.Update(true);
      systemState++;

      break;

    case 4:
      if (lvlOne.Work()) {
        lvlOne.Update(false);
        systemState++;
      }
      break;
  }
  vlvOne.Work ();
  vlvTwo.Work ();
  lvlOne.Work();
}
