# project_v
 Version 150118
 
# About
This is OOP project for arduino. 

Functions:
* getting data from sensors (temp, vacuum stations, llevel control (photoresistors and laser))
* setting control signals to the modules
* send-recive data to WinForms
  * serial arduino <-> COM <-> WinForm <-> COM devices 
  * serial arduino <-> COM <-> WinForm <-> HID devices 

# Classes and methods
* Valve 
1. Work()      //set state in the loop
2. Update()    //update state from serial or systemState

* Vacuum 
1. Work()      //-||-  
2. Update()    //-||-  
3. GetVac()    //get vac value from vacuum station

* Level 
1. Work()      //-||-  
2. Update()    //-||-  

# Later
* update stage and systemState
* temp setting for thermostat(send to WinForm)
* something else
