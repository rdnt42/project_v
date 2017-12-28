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



int _timer = TIMER_DEFAULT;
uint32_t currentTime = 0;
bool qwe = true;

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



    bool flagOne;       //первое вклчюение клапана
    bool flagTwo;       //включение клапана на время
    bool lastValveState;

  public: int valveId;
    uint16_t timeOne;
    uint16_t timeTwo;
    uint32_t currTimeOne;
    uint32_t currTimeTwo;

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

    void Work () {
      digitalWrite(valvePin12, valveState);
      if (flagOne == true && (currentTime >= currTimeOne)) {
        digitalWrite(valvePin24, HIGH);
        flagOne = false;
      }
      if (flagTwo == true && (currentTime >= currTimeTwo)) { //только на выключение через определенное время
        valveState = HIGH;
        flagTwo = false;
      }
      if (lastValveState != valveState) {
        lastValveState = valveState;
        Serial.print("001,VLV," + String(valveId) + "," + String(!valveState) + ",SBIT");
      }
    }

    void Update (bool state, uint32_t timeSet) {
      valveState = !state;
      flagOne = state;
      currTimeOne = timeOne + currentTime;
      digitalWrite(valvePin12, valveState);
      digitalWrite(valvePin24, valveState);
      if (timeSet != 0) {

        currTimeTwo = timeSet + currentTime;
        // Serial.println("ITS OK " + String (timeSet) + " " + String (currTimeTwo)+ " " + String (currentTime));
        flagTwo = true;
      }

    }
};

class Vacuum
{

    int vacPinSet;
    int vacPinRead;
    bool vacState;
    int vacSet;
  public: int vacValue;

  public:
    Vacuum (int pinSet, int pinRead)
    {
      vacPinSet = pinSet;
      vacPinRead = pinRead;
      vacState = false;
      vacSet = 750;

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

    //   void Work () {

    //  }

};

class Level {
    int levelPinLaser;       //пин клапана 12V
    int levelPinReader;       //пин клапана 24V

  public: bool levelState;    //состояние клапана
    bool lastValveState;

    bool flagOne;       //вклчюение уровня на время
    bool lastLevelState;

  public: int levelId;
    uint16_t timeOne;
    uint32_t currTimeOne;

  public:
    Level (int pinLaser, int pinReader, int id)
    {
      levelPinLaser = pinLaser;
      levelPinReader = pinReader;
      levelId = id;
      pinMode (levelPinLaser, OUTPUT);
      levelState = LOW;
      lastLevelState = levelState;
      digitalWrite(levelPinLaser, LOW);
    }

    void Work() {
      digitalWrite (levelPinLaser, levelState);
      if (lastLevelState != levelState) {
        lastLevelState = levelState;
        Serial.print("001,LVL," + String(levelId) + "," + String(levelState) + ",SBIT");
      }
    }

    void Update(bool state) {
      levelState = state;
    }

};

//U8GLIB_ST7920_128X64_1X u8g(35, 33, 31, U8G_PIN_NONE);
LiquidCrystal_I2C lcd(0x27, 20, 4);
Valve vlvOne(A8, A9, 1);
Valve vlvTwo(A10, A11, 2);

Vacuum vacOne (8, A0);

Level lvlOne (22, A4, 1);

void getState (void) {

  getTemp();
  getLevel();
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

    //Serial.println (String(first) + " " + String(second) + " " + String(third));
    // Serial.print(String (unitID_in)+ " " + String (command_in)+ " " +String (data_one) + " " + String(data_two)+" " +String(data_three) );

    if (String(command_in) == "GET") {
      Serial.print("001,DATA," + String(tempOne) + "," + String(vacOne.vacValue) + "," + String(vlvOne.valveState) + "," + String(vlvTwo.valveState) + "," + "SBIT");

    }

    else if (String(command_in) == "VAC") {

    }

    else if (String(command_in) == "AIR") {

    }

    else if (String(command_in) == "VLV") {

      if (second == 1) {

        vlvOne.Update(first, third);

      }

      else if (second == 2)

        vlvTwo.Update(first, third);


      //Serial.println (String(third));
    }

    else if (String(command_in) == "LVL") {
      lvlOne.Update(first);
    }
    /*
      }
      if (String(command_in) == "GET") {
      //data
      //  _delay_ms(100);
      }
      else if (String(command_in) == "STAGE") {
      //Serial.println(String(data_in));
      //      set_command();
      //Serial.println(String(systemState));
      }

      else if (String(command_in) == "TERMON") {
      sscanf(data_in, "%d", &tempThermostat);
      // setThermostat (tempThermostat, REACTOR10, true);
      }

      else if (String(command_in) == "TERMOFF") {
      //   sscanf(data_in, "%d", &tempThermostat);
      //   setThermostat (tempThermostat, REACTOR10, false);

      }

      else if (String(command_in) == "VACON") {
      //flag_vac = 0;
      // sscanf(data_in, "%d", &set_vac_value);
      // set_vac_state = true;
      }

      else if (String(command_in) == "VACOFF") {
      //flag_vac = 0;
      //sscanf(data_in, "%d", &set_vac_value);
      set_vac_state = false;
      }

      else if (String(command_in) == "PUMPONB") {
      //flag_pump_b = 0;
      // sscanf(data_in, "%d", &set_pump_b_time);
      set_pump_b_state = true;

      }

      else if (String(command_in) == "PUMPOFFB") {
      // flag_pump_b = 0;
      // sscanf(data_in, "%d", &set_pump_b_time);
      set_pump_b_state = false;

      }

      else if (String(command_in) == "PUMPONR") {
      // flag_pump_r = 0;
      //sscanf(data_in, "%d", &set_pump_r_time);
      set_pump_r_state = true;

      }

      else if (String(command_in) == "PUMPOFFR") {
      //flag_pump_r = 0;
      // sscanf(data_in, "%d", &set_pump_r_time);
      set_pump_r_state = false;

      }

      else if (String(command_in) == "LASER") {
      if (String(data_in) == "DONE")
      flag_off_wait = 1;

      }
    */
    // memset(first, 0, sizeof(int)*10);

    // memset(&third, 0, sizeof(third));
    Serial.flush();
    i = 0;
  }
}


void timer_handle_interrupts(int timer) {        // обработчик таймера
  currentTime++;
}



void setup() {
  Serial.begin(115200);
  timer_init_ISR_1Hz(TIMER_DEFAULT);
  lcd.init();                      // initialize the lcd
  lcd.init();
  lcd.backlight();


}

void loop() {

  reciveMessage();
  getState();
  vlvOne.Work ();
  vlvTwo.Work ();
  vacOne.GetVac();
  lvlOne.Work();
  lcd.setCursor(3, 0);
  lcd.print(String(vacOne.vacValue));

}