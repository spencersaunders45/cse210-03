using System;



class Parachute
{
private int _wrongGusses; 

//constructer = a method , you can only have one constructer. Has to have the same name as class. Also, it has no return attribute. fuction = method
public Parachute()
{
 _wrongGusses = 0;
  
}
// calling function
// +=2, increase 2
public void IncrementWrongGuesse()
{
  _wrongGusses++;
}
//getter
public int GetWrongGuesses()
{
  return _wrongGusses;
}



}



