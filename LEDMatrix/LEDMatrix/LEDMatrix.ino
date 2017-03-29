// anodes
int row[] = {5,6,7};
// cathodes
int col[] = {8,9,10};

// bit patterns for each row
byte pattern1_data[] = {
  0,0,0};


byte pattern2_data[] = {
  0,0,0};

byte pattern3_data[] = {
  0,0,0};

byte pattern4_data[] = {
  0,0,0};

// defines the size of the matrix 
int columns = 3;
int rows = 3;

//millisecond delay between displaying each row
int pause = 1;



void setup()
{
  for (int i=0;i<3;i++)
  {
    pinMode(row[i], OUTPUT);
    pinMode(col[i], OUTPUT);
  } 
  allOff();
}


void loop()
{
  // define pattern
  pattern1_data[0] = B00000101;
  pattern1_data[1] = B00000010;
  pattern1_data[2] = B00000101;

  pattern2_data[0] = B00000000;
  pattern2_data[1] = B00000111;
  pattern2_data[2] = B00000000;

  pattern3_data[0] = B00000101;
  pattern3_data[1] = B00000101;
  pattern3_data[2] = B00000101;

  pattern4_data[0] = B00000010;
  pattern4_data[1] = B00000010;
  pattern4_data[2] = B00000010;
  
  
  int msCounter = 0;

  while (msCounter < 100 ) {
    showPattern(pattern1_data);
    delay(10);
    msCounter++;
  }

  msCounter = 0;
  allOff();

  while (msCounter < 100 ) {
    
    showPattern(pattern2_data);
     delay(10);
    msCounter++;
  }

  msCounter = 0;
  allOff();

  while (msCounter < 100 ) {
    
    showPattern(pattern3_data);
     delay(10);
    msCounter++;
  }

  msCounter = 0;
  allOff();

  while (msCounter < 100 ) {
    
    showPattern(pattern4_data);
     delay(10);
    msCounter++;
  }
  
  
}

void allOff()
{
  for (int i=0;i<3;i++)
  {
    digitalWrite(row[i], LOW);
    digitalWrite(col[i], HIGH);
  }
}


void showPattern(byte data[])
{
  for (int thisrow=0;thisrow<rows;thisrow++)
  {
    //turn everything off
    allOff();
    //turn on current row
    digitalWrite(row[thisrow], HIGH);
    // loop through columns of this row and light
    for (int thiscol=0;thiscol<columns;thiscol++)
    {
      if (bitRead(data[thisrow],columns-thiscol-1)==1)
      {
        digitalWrite(col[thiscol], LOW);
      }
      else
      {
        digitalWrite(col[thiscol], HIGH);
      }
    }
    delay(pause);
  }
}


void showPattern2()
{
  digitalWrite(row[1], HIGH);
  digitalWrite(col[1], LOW);
}


void showPattern3()
{
  for (int thisrow=0;thisrow<rows;thisrow++)
  {
    //turn everything off
    allOff();
    //turn on current row
    digitalWrite(row[thisrow], HIGH);
    // loop through columns of this row and light
    for (int thiscol=0;thiscol<columns;thiscol++)
    {
      if (bitRead(pattern3_data[thisrow],columns-thiscol-1)==1)
      {
        digitalWrite(col[thiscol], LOW);
      }
      else
      {
        digitalWrite(col[thiscol], HIGH);
      }
    }
    delay(pause);
  }
}
