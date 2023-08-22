//Task1
int num = 20;
num += 5;
Console.WriteLine(num);

//Task2

Console.Write("Enter a four-digit number that represents n days:");
int numberOfYears;
int numberOfMonths;
int numberOfDays;
var input = Console.ReadLine();
int days;
bool parsResultTask2 = int.TryParse(input, out days);
if (parsResultTask2 == true & days >=0)
{
    numberOfYears = days / 365;
    numberOfMonths = (days - (numberOfYears * 365)) / 30;
    numberOfDays = (days - (numberOfYears * 365)) % 30;
    Console.WriteLine($"You specified {numberOfYears} years, {numberOfMonths} months and {numberOfDays} days");
}
else 
{
    Console.WriteLine("You specified negative number or entered not a number");
}


//Task3
Console.Write("Enter your number:");
var userNumber = Console.ReadLine();
int parsedNumber;
bool parsResultTask3 = int.TryParse(userNumber, out parsedNumber);
if (parsResultTask3 == true)
{
    int result1 = parsedNumber + parsedNumber * 2;
    Console.WriteLine("Your result is: " + result1);
    }
else
{
    Console.WriteLine("You specified not a number");
}

//Task4

var a = -34;
var b = 4;
var c = "Hello";
var d = 'R';
var e = 23.093433222;
var f = 40000;
var g = true;
var h = 0;
Console.WriteLine("The best type for -34 is: " + a.GetType());
Console.WriteLine("The best type for 4 is: " + b.GetType());
Console.WriteLine("The best type for \"Hello\" is: " + c.GetType());
Console.WriteLine("The best type for \'R\' is: " + d.GetType());
Console.WriteLine("The best type for 23.093433222 is: " + e.GetType());
Console.WriteLine("The best type for 40000 is: " + f.GetType());
Console.WriteLine("The best type for true is: " + g.GetType());
Console.WriteLine("The best type for 0 is: " + h.GetType());

//Task 5
Console.Write("Enter your number:");
var userNumberTsk5 = Console.ReadLine();
int parsedNumberTsk5;
bool result = int.TryParse(userNumberTsk5, out parsedNumberTsk5);
if (result == true &  Math.Abs(parsedNumberTsk5)  %2 == 0)
{
    
    Console.WriteLine("Your number is: Even");
}
else if (result == true & Math.Abs(parsedNumberTsk5) % 2 == 1)
{
    Console.WriteLine("Your number is: Odd");
}
else
{
    Console.WriteLine("You specified not a number");
}