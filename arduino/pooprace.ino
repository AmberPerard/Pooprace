 #include "Keyboard.h"

//set all datapins
//player 1
const int buttonPin = 2;
const int buttonPin2 = 5;
const int buttonPin3 = 8;
const int buttonPin4 = 12;
//player 2
const int buttonPin5 = 1;
const int buttonPin6 = 4;
const int buttonPin7 = 7;
const int buttonPin8 = 10;
//start button
const int buttonPinStart= 13;

//set all initial button states
//player1
int buttonState = 0;
int buttonState2 = 0;
int buttonState3 = 0;
int buttonState4 = 0;
//player2
int buttonState5 = 0;
int buttonState6 = 0;
int buttonState7 = 0;
int buttonState8 = 0;
//start button
int buttonStateStart = 0;


//set bools to track if button was pressed (make sure you can't keep pushing button and printing character)
//player1
bool pressed = false;
bool pressed2 = false;
bool pressed3 = false;
bool pressed4 = false;
//player2
bool pressed5 = false;
bool pressed6 = false;
bool pressed7 = false;
bool pressed8 = false;
//start button
bool pressedStart = false;





void setup() {
  //set pinmode for all pins
  //player1
  pinMode(buttonPin, INPUT_PULLUP);
  pinMode(buttonPin2, INPUT_PULLUP);
  pinMode(buttonPin3, INPUT_PULLUP);
  pinMode(buttonPin4, INPUT_PULLUP);
  //player2
  pinMode(buttonPin5, INPUT_PULLUP);
  pinMode(buttonPin6, INPUT_PULLUP);
  pinMode(buttonPin7, INPUT_PULLUP);
  pinMode(buttonPin8, INPUT_PULLUP);
  //start
  pinMode(buttonPinStart, INPUT_PULLUP);

  //put all pins to high to get started
  //player1
  digitalWrite(buttonPin, HIGH);
  digitalWrite(buttonPin2, HIGH);
  digitalWrite(buttonPin3, HIGH);
  digitalWrite(buttonPin4, HIGH);
  //player2
  digitalWrite(buttonPin5, HIGH);
  digitalWrite(buttonPin6, HIGH);
  digitalWrite(buttonPin7, HIGH);
  digitalWrite(buttonPin8, HIGH);
  //start button
  digitalWrite(buttonPinStart, HIGH);

  //start keyboard simulation
  Keyboard.begin();
}

void loop() {
  //button 1 player 1
  //read state of button
  buttonState = digitalRead(buttonPin);
  //if button state is high, and the button isn't pressed yet press right key on keyboard
  if (buttonState == HIGH && pressed == false) {
    Keyboard.press('f');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed = true;
  }
  //if the button is low put pressed back to false because button has been released
  if(buttonState == LOW) {
    pressed = false;
    delay(10);
  }

  //button 2 player 1
  buttonState2 = digitalRead(buttonPin2);
  if (buttonState2 == HIGH && pressed2 == false) {
    Keyboard.press('f');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed2 = true;
  }
  if(buttonState2 == LOW) {
    pressed2 = false;
    delay(10);
  }

  //button 3 player 1
  buttonState3 = digitalRead(buttonPin3);
  if (buttonState3 == HIGH && pressed3 == false) {
    Keyboard.press('f');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed3 = true;
  }
  if(buttonState3 == LOW) {
    pressed3 = false;
    delay(10);
  }

  //button 4 player 1
  buttonState4 = digitalRead(buttonPin4);
  if (buttonState4 == HIGH && pressed4 == false) {
    Keyboard.press('f');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed4 = true;
  }
  if(buttonState4 == LOW) {
    pressed4 = false;
    delay(10);
  }

  //button 1 player 2
  buttonState5 = digitalRead(buttonPin5);
  if (buttonState5 == HIGH && pressed5 == false) {
    Keyboard.press('g');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed5 = true;
  }
  if(buttonState5 == LOW) {
    pressed5 = false;
    delay(10);
  }

  //button 2 player 2
  buttonState6 = digitalRead(buttonPin6);
  if (buttonState6 == HIGH && pressed6 == false) {
    Keyboard.press('g');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed6 = true;
  }
  if(buttonState6 == LOW) {
    pressed6 = false;
    delay(10);
  }

  //button 3 player 2
  buttonState7 = digitalRead(buttonPin7);
  if (buttonState7 == HIGH && pressed7 == false) {
    Keyboard.press('g');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed7 = true;
  }
  if(buttonState7 == LOW) {
    pressed7 = false;
    delay(10);
  }

  //button 4 player 2
      buttonState8 = digitalRead(buttonPin8);
  if (buttonState8 == HIGH && pressed8 == false) {
    Keyboard.press('g');
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressed8 = true;
  }
  if(buttonState8 == LOW) {
    pressed8 = false;
    delay(10);
  }
  
    //start button
  buttonStateStart = digitalRead(buttonPinStart);
  if (buttonStateStart == HIGH && pressedStart == false) {
    Keyboard.press(32); 
    delay(10);
    Keyboard.releaseAll(); // This is important after every Keyboard.press it will continue to be pressed
    pressedStart = true;
  }
  if(buttonStateStart == LOW) {
    pressedStart = false;
    delay(10);
  }
}
