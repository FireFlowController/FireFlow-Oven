#include <TimerOne.h> //https://github.com/PaulStoffregen/TimerOne
#include <PID_v1.h> //https://github.com/br3ttb/Arduino-PID-Library


#define PWM_PIN 11
//Arduino Uno  9, 10
//Arduino Leonardo  9, 10, 11
//Arduino Mega  11, 12, 13

char inputString[200] = {0}; // an array to hold incoming data
byte inputPoint = 0;
boolean stringComplete = false;  // whether the string is complete

bool Flag_Running = false;

volatile struct Global_Settings {
  float PID_P = 0;
  float PID_I = 0;
  float PID_D = 0;
  double Temperature = 0;
} Settings;

double PID_Setpoint = 0, PID_Input = 0, PID_Output = 0;
PID myPID(&PID_Input, &PID_Output, &PID_Setpoint, 0, 0, 0, DIRECT);

void setup() {
  pinMode(PWM_PIN, OUTPUT);
  Serial.begin(115200);
  myPID.SetOutputLimits(0, 1023); //0-100% on Timer5
  myPID.SetMode(AUTOMATIC);

  Timer1.initialize(1000000); //Set Timer1 Period
  Timer1.attachInterrupt(ISR_Oven_Update_PWM_Duty);  //Set Timer1 Interrupt Service Routine
  Timer1.pwm(PWM_PIN, 0); //Zero PWM output

}

void loop() {
  if (Flag_Running)
    myPID.Compute();
    
  ReadTemp();
  SCADA_Listener();
}

void ReadTemp() {
  Settings.Temperature = 50;
  //Put your sensor reading routines here
}

void serialEvent() {
  while (!stringComplete && Serial.available()) { //Wait old message to respond before replace buffer
    char inChar = (char)Serial.read();
    if (inChar == '\r') {
      stringComplete = true;
      inputString[inputPoint] = '\0';
    } else {
      inputString[inputPoint] = inChar;
      inputPoint++;
    }
  }
}
