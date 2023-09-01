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

int a = -34;
uint b = 4;
string c = "Hello";
char d = 'R';
double e = 23.093433222;
uint f = 40000;
bool g = true;
int h = 0;


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