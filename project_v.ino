////////////////////////Artem L., 5 novemver 2017, radiant42@yandex.ru//////////////
///////////////////////Arduino OOP project, getting data from sensors///////////////
///////////////////////setting control signals to external devices//////////////////
/////////////////////////////////send-recive data to WinForms///////////////////////


///////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!/////
///////////////////DON`T FORGET UPDATE COOMENTS//////////
///////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!/////
///////////////////INCLUDE LIBRARIES///////////////////
#include <timer-api.h>
#include <timer_setup.h>
#include <SPI.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
//#include "U8glib.h"
#include "get.h"

char data[40];         //DATA BUFFER
uint8_t i = 0;         //char data count
//char unitID_in[10];    // ID device
//char command_in[10];   //command, 3 letters
//char data_one[10];     //data
//char data_two[10];
//char data_three [10];


////////////////////TIMER SETUP////////////////////
int _timer = TIMER_DEFAULT;
uint32_t currentTime = 0;


////////////////////STAGE SETUP////////////////////
int systemState = 0;           //start state
enum STATE { //system state
  WELCOME,
  STAGE1,
  STAGE2,
  STAGE3,
  STAGE4,
  STAGE5,
  STAGE6,
  STAGE7,
  STAGE8,
  STAGE9,
  STAGE10,
  LOCKED,
  MENU,
  STOP,
  END,
  ERRORS,
  SYS_IDLE,
  WAIT,

};

void sendPack(String pack) {
  String formPack = "STR,001," + pack + ",";
  formPack += String (formPack.length() + 6) + ",STP";
  Serial.print (formPack);
  _delay_ms(50);
}

class Valve
{

  public: int valveId;         //id valve
    int valvePin12;            //pin 12V relay
    int valvePin24;             //pin 24V relay

  public: bool valveState;     //ON/OFF state
    bool lastValveState;       // if lastValveState!=valveState => state changed from serial or systemState

    bool startFlag;           //first time flag
    bool timeFlag;            //set time flag
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

    bool Work () {                                //cycle work

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
        //Serial.print("001,VLV," + String(valveId) + "," + String(!valveState) + ",SBIT");
        // _delay_ms(50);
        sendPack("VLV," + String(valveId) + "," + String(!valveState));
      }

      digitalWrite(valvePin12, valveState);
      return (valveState);
    }

    void Update (bool state, uint32_t timeSet = 0) { //update state from serial or systemState
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
    int vacPinSet;            //PWM pin to vac
    int vacPinRead;           //analog read from vac station
    bool vacState;            //ON/OFF state
    bool lastVacState;
    int vacSet;               //set vac value
    uint32_t timeWork;        //set work time
    bool timeFlag;            //flag to ON vac with time
  public: int vacValue;

  public:
    Vacuum (int pinSet, int pinRead)
    {
      vacPinSet = pinSet;
      vacPinRead = pinRead;
      vacState = false;
      lastVacState = vacState;
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
          currVac = currVac / 100;*/
        vacValue = map(vacValue, 100, 850, 0, 755);
        millisPrev = millis();
      }
    }

    void Work () {
      if (timeFlag == true && (currentTime >= timeWork)) {
        vacState = false;
        timeFlag = false;
      }

      if (lastVacState != vacState) {
        lastVacState = vacState;
        //Serial.print("001,VAC,1," + String(vacState) + ",SBIT");
        // _delay_ms(50);
        sendPack("VAC,1," + String(vacState));
      }

      if (vacState && ((vacValue - vacSet ) > 0)) {
        analogWrite (vacPinSet, 255);
      }

      else if (vacState && ((vacValue - vacSet  ) < 0) && ((vacValue - vacSet) > -3)) {
        analogWrite (vacPinSet, 150);
      }

      else if (vacState && ((vacValue - vacSet  ) < -3)) {
        analogWrite (vacPinSet, 0);
      }

      else if (!vacState) {
        analogWrite (vacPinSet, 0);
      }
    }

    void Update (bool state, uint32_t valueSet = 750) {
      vacState = state;
      vacSet = valueSet;
      /*if (timeSet != 0) {
        timeWork = timeSet + currentTime;
        timeFlag = true;
        }*/
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
        //Serial.print("001,LVL," + String(levelId) + "," + String(levelState) + ",SBIT");
        sendPack ("LVL," + String(levelId) + "," + String(levelState));
        //  _delay_ms(50);
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

////////////////////CREATE NEW OBJ///////////////////////////////////////////////////
//U8GLIB_ST7920_128X64_1X u8g(35, 33, 31, U8G_PIN_NONE);
LiquidCrystal_I2C lcd(0x27, 16, 4);
Valve vlvOne(A8, A9, 1);
Valve vlvTwo(A10, A11, 2);

Vacuum vacOne (11, A0);

Level lvlOne (22, A4, A5, 1);

void getState (void) {
  getTemp();
  vacOne.GetVac();
}

void resetAll() {
  lvlOne.Update(false);
  vlvOne.Update(0, 0);
  vlvTwo.Update(0, 0);
  vacOne.Update (false);
}

void reciveMessage(void) {
  ////////////////////SERIAL PROTOCOL/////////////////
  //example send    STR,001,ID,COMMAND,DATA_ONE,DATA_TWO,DATA_THREE,STP
  //example answer  STR,002,ID,COMMAND,DATA_ONE,DATA_TWO,DATA_THREE,STP
  //STR,001,VAC,1,750,1,26,STP
  
  if (Serial.available() > 0) {
    while (Serial.available()) {
      data [i] = Serial.read();
      i++;
      _delay_ms(10);
    }

    String message [20];
    int count = 0;
    //Serial.println(String(data).length());
    for (int j = 0; j < String(data).length(); j++) {
      if (data[j] == ',') {
        count++;
        j++;
      }
      message [count] += data[j];
      if (message [count] == "STP")
        break;
    }
    // Serial.println (String(message [count-1] ) + " " + String(String(data).length() - 1));
    // Serial.print(String( message [1]) + " " + String(message [2]) + " " + String(message [count - 1]) + " " + String(message [3]) + " " + String(message [4]) + " " + String(message [5] ));
    String unitID_in = message [1];
    String command_in = message [2];
    int checkSum = message [count - 1].toInt();
    int first = message [3].toInt();
    uint32_t second = message [4].toInt();
    int third = message [5].toInt();

    if ( checkSum == String(data).length() - 1) {
      if (String(command_in) == "BGN") {
        systemState = STAGE1;
      }

      if (String(command_in) == "END") {
        systemState = SYS_IDLE;
      }

      if (String(command_in) == "STG") {
        resetAll ();
        systemState ++;
      }

      else if (String(command_in) == "GET") {
        sendPack("DATA," + String(tempOne) + "," + String(vacOne.vacValue) + "," + String(vlvOne.valveState) + ","
                 + String(vlvTwo.valveState) + "," + String(systemState));
      }

      else if (String(command_in) == "VAC") {
        if (third == 1)
          vacOne.Update(first, second);
      }

      else if (String(command_in) == "AIR") {

      }

      else if (String(command_in) == "VLV") {
        if (third == 1)
          vlvOne.Update(first, second);

        else if (third == 2)
          vlvTwo.Update(first, second);
      }

      else if (String(command_in) == "LVL") {
        lvlOne.Update(first);
      }
    }
    else {
      //try
    }
    memset(&data, 0, sizeof(data));
    Serial.flush();
    i = 0;
  }
}

bool waitTime (uint32_t time) {
  static uint32_t millisPrev;
  int countTime = (int)currentTime - (int)time - (int)millisPrev;
  // Serial.println (String(abs(countTime)));
  //Serial.println (String((int32_t)(time + millisPrev - currentTime)) );
  if ( (int32_t)(time + millisPrev - currentTime) <= 0 ) {
    millisPrev = currentTime;
    return true;
  }
  return false;
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
  switch (systemState) {                                     //1,3,5,7,9,11... stage settings //2,4,6,8,10... stage start


    case WELCOME:                                            //reset all
      //stop all
      //systemState++;
      break;

    case STAGE1:
      vlvOne.Update(1, 0);
      systemState++;
      break;

    case STAGE2:

      if (waitTime(21600)) {//(59400))  {                                  //wait stage
        vlvOne.Update(0, 0);
        systemState++;
      }
      break;

    case STAGE3:

      vlvTwo.Update(1, 0);

      lvlOne.Update(true);
      systemState++;
      break;

    case STAGE4:

      if (lvlOne.Work()) {                                  //work while not TRUE

        lvlOne.Update(false);
        vlvTwo.Update(0, 0);
        systemState++;
      }
      break;

    case STAGE5:
      // if (waitTime(3600))
      systemState++;
      break;

    case STAGE6:
      if (waitTime(600))
        systemState++;
      break;

    case STAGE7:
      //setThermostat (tempThermostat, REACTOR10, true);
      lvlOne.Update(true);
      vlvOne.Update(1, 0);
      vlvTwo.Update(1, 0);
      vacOne.Update (true);
      systemState++;
      break;

    case STAGE8:
      if (waitTime(666))
        systemState++;
      break;

    case STAGE9:
      lvlOne.Update(false);
      vlvOne.Update(0, 0);
      vlvTwo.Update(0, 0);
      vacOne.Update (false);
      systemState++;

      break;

    case STAGE10:
      if (waitTime(1600))
        systemState = SYS_IDLE;
      break;

    case SYS_IDLE:
      resetAll();
      systemState = WELCOME;

      break;
  }
  lvlOne.Work ();
  vlvOne.Work ();
  vlvTwo.Work ();
  vacOne.Work ();
  // Serial.println(analogRead(A0));
}
