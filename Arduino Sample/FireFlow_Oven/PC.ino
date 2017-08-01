bool SCADA_Clear_PID_ID = false;

void SCADA_Listener() {
  if (stringComplete) {
    CheckAT(); //If its not AT -> stringComplete= false

    if (stringComplete) {
      if (AT_equals("CONNECT"))//OK
        SCADA_CONNECT();
      else if (AT_equals("TEMP"))//OK
        SCADA_TEMP();
      else if (AT_equals("PID_OUT"))
        SCADA_PID_OUT();
      else if (AT_startsWith("PID_SET,"))//OK
        SCADA_PID_SET();
      else if (AT_equals("OVEN_START"))
        SCADA_OVEN_START();
      else if (AT_equals("OVEN_STOP"))
        SCADA_OVEN_STOP();
      else if (AT_equals("PID_CLEAR"))//OK
        SCADA_PID_CLEAR();
      else if (AT_equals("PID_NOCLEAR"))//OK
        SCADA_PID_NOCLEAR();
      else if (AT_equals("GET_P"))//OK
        SCADA_GET_P();
      else if (AT_equals("GET_I"))//OK
        SCADA_GET_I();
      else if (AT_equals("GET_D"))//OK
        SCADA_GET_D();
      else if (AT_startsWith("SET_GAINS,"))//OK
        SCADA_SET_GAINS();
    }
    inputPoint = 0;    // clear the string
    stringComplete = false;
  }
}

void ATOK() {
  Serial.println(F("AT OK"));
  Serial.flush();
}

unsigned char AT_equals(const char *cstr )  {
  if (strlen(inputString + 3) != strlen(cstr))
    return 0;
  return strcmp(inputString + 3, cstr) == 0;
}
unsigned char startsWith(const  char  *cstr )  {
  return strncmp(inputString, cstr, strlen(cstr)) == 0;
}
unsigned char AT_startsWith(const  char  *cstr )  {
  return strncmp(inputString + 3, cstr, strlen(cstr)) == 0;
}


String getSeperatedValue(String data, char separator, int index) {
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length() - 1;
  for (int i = 0; i <= maxIndex && found <= index; i++) {
    if (data.charAt(i) == separator || i == maxIndex) {
      found++;
      strIndex[0] = strIndex[1] + 1;
      strIndex[1] = (i == maxIndex) ? i + 1 : i;
    }
  }
  return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void CheckAT() {
  if (!startsWith("AT+")) {
    inputPoint = 0;
    stringComplete = false;
  }
}

void SCADA_CONNECT() {
  ATOK();
}

void SCADA_TEMP() {
  Serial.println((int)Settings.Temperature, DEC);
  Serial.flush();
}

void SCADA_PID_OUT() {
  Serial.println((int)PID_Output, DEC);
  Serial.flush();
}

void SCADA_PID_SET() {
  PID_Setpoint = atoi(inputString + 11);//AT+PID_SET,xxx\0
  Serial.println(PID_Setpoint, DEC); //Echo Setpoint value
  Serial.flush();
}

void SCADA_OVEN_START() {
  Oven_PID_Tunings();
  Oven_Start();
  ATOK();
}

void SCADA_OVEN_STOP() {
  ATOK();
  Oven_Stop();
}
void SCADA_PID_CLEAR() {
  SCADA_Clear_PID_ID = true;
  ATOK();
}

void SCADA_PID_NOCLEAR() {
  SCADA_Clear_PID_ID = false;
  ATOK();
}
void SCADA_GET_P() {
  Serial.println(Settings.PID_P, DEC);
  Serial.flush();
}

void SCADA_GET_I() {
  Serial.println(Settings.PID_I, DEC);
  Serial.flush();
}

void SCADA_GET_D() {
  Serial.println(Settings.PID_D, DEC);
  Serial.flush();
}

void SCADA_SET_GAINS() {
  Settings.PID_P = getSeperatedValue(inputString, ',', 1).toFloat();
  Settings.PID_I = getSeperatedValue(inputString, ',', 2).toFloat();
  Settings.PID_D = getSeperatedValue(inputString, ',', 3).toFloat();
  if (SCADA_Clear_PID_ID)
    myPID.Initialize();
  myPID.SetTunings(Settings.PID_P, Settings.PID_I, Settings.PID_D);
  ATOK();
}
