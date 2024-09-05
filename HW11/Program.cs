using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;
using System.Text.RegularExpressions;

int[] numbers = { 0, 1, 2, 5, 6, 7, 8, 9, 100, 515 };

var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

foreach (int num in evenNumbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine("----------------------------------");

//Create a list of numbers: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14.
//Write a program in C# Sharp to find the positive numbers within the range of 1 to 11 from a list of numbers using two
//WHERE conditions in LINQ Query.
//Expected Output: 1 3 6 9 10

List<int> ints = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

var positiveNumber = from num in ints
                     where num > 0
                     where num >= 1 && num < 11
                     select num;

foreach (int num in positiveNumber)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//Write a program in C# Sharp to find the number of an array and the square of each number. 
//Expected Output :
//{ Number = 9, SqrNo = 81 }
//{ Number = 8, SqrNo = 64 }
//{ Number = 6, SqrNo = 36 }
//{ Number = 5, SqrNo = 25 }

int[] numbersSqr = { 11, 2, 5, 6, 7, 8, 9, 100, 515 };

var output = from num in numbersSqr
             select new Square(num);

foreach (var item in output)
{
    Console.WriteLine($"{{ Number = {item.Number}, Sqr = {item.Sqr} }}");
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//Write a program in C# Sharp to display the number and frequency of numbers from the given array.
//Expected Output :
//The number and the Frequency are :
//Number 5 appears 3 times
//Number 9 appears 2 times
//Number 1 appears 1 times

int[] numbersFr = { 11, 2, 5, 3, 6, 11, 5, 7, 8, 9, 100, 515, 3 };

var frequency = from num in numbersFr
                group num by num into g
                select new
                {
                    Number = g.Key,
                    Frequency = g.Count()
                };

Console.WriteLine("The number and the Frequency are:");
foreach (var num in frequency)
{
    Console.WriteLine($"Number {num.Number} appears {num.Frequency} times");
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//Write a program in C# Sharp to find the string which starts and ends with a specific character.
//Test Data :
//The cities are: 'ROME', 'LONDON', 'NAIROBI', 'CALIFORNIA', 'ZURICH', 'NEW DELHI', 'AMSTERDAM', 'ABU DHABI', 'PARIS'
//Input starting character for the string : A
//Input ending character for the string : M
//Expected Output :
//The city starting with A and ending with M is : AMSTERDAM

string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

char startChar = 'A';
char endChar = 'M';

var allStartsWithT = cities.Where(c => c.StartsWith(startChar.ToString()) && c.EndsWith(endChar.ToString()));

foreach (var city in allStartsWithT)
{
    Console.WriteLine(city);
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//Write a program in C# Sharp to display the top n-th records
//Test Data :
//The members of the list are :5, 7, 13, 24, 6, 9, 8, 7
//How many records do you want to display ? : 3
//Expected Output :
//The top 3 records from the list are : 24, 13, 9

int[] numbersNth = { 5, 7, 13, 24, 6, 9, 8, 7 };

Console.Write("How many records do you want to display ? :");
int records = int.Parse(Console.ReadLine());
var orderedNumbers = numbersNth.OrderByDescending(n => n).Take(records);
Console.WriteLine($"The top {records}  records from the list are:");

foreach (var record in orderedNumbers)
{
    Console.Write(record + ", ");
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//Write a program in C# Sharp to display the list of items in the array according to
//the length of the string then by name in ascending order.
//Expected Output :
//Here is the arranged list:
//ROME
//PARIS
//LONDON
//ZURICH
//NAIROBI
//ABU DHABI
//AMSTERDAM
//NEW DELHI
//CALIFORNIA

List<string> places = new List<string> { "ROME", "PARIS", "LONDON", "ZURICH", "NAIROBI", "ABU DHABI", "AMSTERDAM", "NEW DELHI", "CALIFORNIA" };
var sorted = places.OrderBy(n => n.Length).ThenBy(n => n);

Console.WriteLine("Here is the arranged list:");

foreach (var place in sorted)
{
    Console.WriteLine(place);
}

Console.WriteLine();
Console.WriteLine("----------------------------------");
//8.Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.
//Expected Output :
//Biscuit
//Brade
//Butter
//Honey

List<string> elements = new List<string> { "Butter", "Brade", "Honey", "Honey", "Biscuit", "Butter", "Brade" };

var distinctItems = elements.Distinct().OrderBy(item => item);

Console.WriteLine("The elements in ascending order are:");
foreach (var item in distinctItems)
{
    Console.WriteLine(item);
}