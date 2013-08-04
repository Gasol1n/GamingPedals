//Code Version 1.1
#include <EEPROM.h>  //Import EEPROM

int l1 = 0;  //Left 1
int l2 = 1;  //Left 2
int r1 = 2;  //Right 1
int r2 = 3;  //Right 2
int led = 11;  //LED Pin on Teensy 2.0
int key[8] = {0, 0, 0, 0, 0, 0, 0, 0};  //Storage for all Keys

boolean newKeys = false;  //Await new Keys
int countNewKeys = 0;  //Counter for Keys
int newKey = 0;  //Storage for the new Key until Finish

int delayL = 100;  //Delay for Left
int delayR = 100;  //Delay for Right
int delayCounterL = 0;  //Delay Counter for Left
int delayCounterR = 0;  //Delay Counter for Right

void setup() {
  pinMode(l1, INPUT_PULLUP);  //Pin declaration
  pinMode(l2, INPUT_PULLUP);
  pinMode(r1, INPUT_PULLUP);
  pinMode(r2, INPUT_PULLUP);
  pinMode(led, OUTPUT);
  Keyboard.set_key1(0);  //Unset all Keyboardkeys
  Keyboard.set_key2(0);
  Keyboard.set_key3(0);
  Keyboard.set_key4(0);
  Keyboard.set_key5(0);
  Keyboard.set_key6(0);
  Keyboard.set_modifier(0);
  Serial.begin(9600);  //Start Serial with 9600 Baud
  load(0);  //Load Keys from EEPROM
}

void input() {  //Serial input Function
  if(Serial.available() > 0) {  //If a byte wait in the Serial buffer
    int tmp = int(Serial.read());
    
    if(tmp == 13) { //If CR is send
      if(!newKeys && (newKey + 48) == 110) {  //If no new Keys awaited and "n" ist the new Key
        newKeys = true;    //Await new Keys
        Serial.println("START");
      } else if(!newKeys && (newKey + 48) == 115) {  //If no new Keys awaitet and "s" ist the new Key
        save();  //Save the Keys in the EEPROM
      } else if(!newKeys && (newKey + 48) == 114) {  //If no new Keys awaitet and "r" ist the new Key
        for(int i = 0; i < 8; i++) {  //Print all Keys
          Serial.print(key[i]);
          Serial.print(",");
        }
      } else if(!newKeys && (newKey + 48) == 108) {  //If no new Keys awaitet and "l" ist the new Key
        load(1);  //Load Keys from EEPROM
      } else if(newKeys) {  //If new Keys are awaitet
        if(countNewKeys <= 6) {  //Save all incomming Keys in the Variable
          key[countNewKeys] = newKey;
          countNewKeys ++;
          Serial.println("ACK");
        } else if(countNewKeys == 7) {
          key[countNewKeys] = newKey;
          countNewKeys = 0;
          newKeys = false;
          Serial.println("FINISH");  //Send "Finish" at the End.
        }
      }
      newKey = 0;  //Reset the new Key
    } else {
      if(newKey > 1000){newKey = 0; Serial.println("NACK");}  //Safety
      newKey = newKey * 10 + (tmp -48);  //Convert the ASCII value to a number and add them
    }
    
  }
}

void save() {  //Save Function
  for(int i = 0; i < 8; i++) {
    EEPROM.write(i, key[i]);
  }
  Serial.println("SAVED");
}

void load(boolean output) {  //Load Function
  for(int i = 0; i < 8; i++) {
    key[i] = EEPROM.read(i);
  }
  if(output){Serial.println("LOADED");}
}

void loop() {
  input(); 
  
  boolean b1 = true;  //Boolean for Left
  boolean b2 = true;  //Boolean for Right
  if(!digitalRead(l1) && digitalRead(l2)) {  //If only the first switch on Left activated
    if(key[2] == 0 && key[3] == 0 || delayCounterL >= delayL) {  //If the second state is not used OR the Delay Counter is reached
      if(key[0] != 0) {  //If the Key not Zero. Meaning is not Disabled.
        Keyboard.set_modifier(modList(key[0]));  //Set the Key
        b1 = false;  //Disable the Boolean
      }
      if(key[1] != 0) {
        Keyboard.set_key1(keyList(key[1]));
        b1 = false;
      }
    } else {
      delayCounterL++;  //Increase the Counter
      b1 = false;  //Disable the Boolean
    }
  } else if(!digitalRead(l1) && !digitalRead(l2)) {  //If all two switches on Left activated
    delayCounterL = 0;
    if(key[2] != 0) {
      Keyboard.set_modifier(modList(key[2]));
      b1 = false;
    }
    if(key[3] != 0) {
      Keyboard.set_key1(keyList(key[3]));
      b1 = false;
    }
  }
  
  if(!digitalRead(r1) && digitalRead(r2)) {  //If only the first switch on Right activated
    if(key[6] == 0 && key[7] == 0 || delayCounterR >= delayR) {  //If the second state is not used OR the Delay Counter is reached
      if(key[4] != 0) {
        Keyboard.set_modifier(modList(key[4]));
        b2 = false;
      }
      if(key[5] != 0) {
        Keyboard.set_key2(keyList(key[5]));
        b2 = false;
      }
    } else {
      delayCounterR++;  //Increase the Counter
      b2 = false;  //Disable the Boolean
    }
  } else if(!digitalRead(r1) && !digitalRead(r2)) {  //If all two switches on Right activated
    delayCounterR = 0;
    if(key[6] != 0) {
      Keyboard.set_modifier(modList(key[6]));
      b2 = false;
    }
    if(key[7] != 0) {
      Keyboard.set_key2(keyList(key[7]));
      b2 = false;
    }
  }
  
  if(b1) {  //Is the Left Boolean not Disabled. Meaning no switch is activated
    delayCounterL = 0;  //Set the Counter back to Zero
    Keyboard.set_modifier(0);  //Reset the Keys
    Keyboard.set_key1(0);
  }
  
  if(b2) {  //Is the Right Boolean not Disabled.
    delayCounterR = 0;  //Set the Counter back to Zero
    Keyboard.set_modifier(0);  //Reset the Keys
    Keyboard.set_key2(0); 
  }
  
  if(b1 && b2) {  //If no switches are activated
    digitalWrite(led, LOW);  //Turn the LED off
  }else {  //else
    digitalWrite(led, HIGH);  //Turn the LED on
  }
  
  Keyboard.send_now();  //Send the Keyboard Keys
}
