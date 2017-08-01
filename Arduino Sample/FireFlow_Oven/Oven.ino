void Oven_PID_Tunings() {
  myPID.SetTunings(Settings.PID_P, Settings.PID_I, Settings.PID_D);
  PID_Output = 0;
}

void Oven_Start() {
  PID_Output = 0;
  myPID.Initialize(); //Clear old error from ITerm on PID
  myPID.Compute();
  Timer1.pwm(PWM_PIN, PID_Output);
  Timer1.start();
  Flag_Running = true;
}

void Oven_Stop() {
  Output_CloseAll();
  Flag_Running = false;
  PID_Output = 0;
}

void Output_CloseAll() {
  Timer1.stop(); //Stop PWM Timer
  digitalWrite(PWM_PIN, LOW);
}

void ISR_Oven_Update_PWM_Duty() {
  Timer1.pwm(PWM_PIN, PID_Output);
}
