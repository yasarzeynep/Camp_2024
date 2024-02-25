// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double number5 = 10.4;//64 bit
decimal number6 = 10.4m;
char character = 'a';
bool condition = false;
byte number4 = 255;
short number3 = -32767;
int number1 = 217483647;
long number2 = -9233;
var number7 = 10;
number7 = 'A';

Console.WriteLine("Number1 is {0} ", number1);
Console.WriteLine("Number2 is {0} ", number2);
Console.WriteLine("Number3 is {0} ", number3);
Console.WriteLine("Number4 is {0} ", number4);
Console.WriteLine("Number5 is {0} ", number5); 
Console.WriteLine("Number6 is {0} ", number6); 
Console.WriteLine("Number7 is {0} ", number7); 
Console.WriteLine("Character is:{0} ", (int)character);
Console.WriteLine((int)Days.Monday);
Console.ReadLine();
enum Days
{
    Monday, Tuesday, Wednesday,Thursday, Friday, Saturday, Sunday
}