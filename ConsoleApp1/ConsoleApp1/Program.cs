//Task1
//The user enters any positive number. Write a program that calculates
//the sum of numbers from 0 to the given number. Write a result of the calculation to the console.

using System;
using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("--------Task 1 --------------------------------------------");

Console.Write("Enter any positive number: ");
var input = Console.ReadLine();
int number;
int sum = 0;
bool parsResultTask1 = int.TryParse(input, out number);
if (parsResultTask1 == true & number >= 0)
{
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    Console.WriteLine($"result of the calculation: {sum}");
}

else
{
    Console.WriteLine("You specified negative number or entered not a number");


}

Console.WriteLine("--------Task 2 --------------------------------------------");

//Task 2
// Using a while loop write the multiplication table for the number 3 to the console.

int j = 0;
int number3 = 3;
int result;
while (j < 10)
{
    result = j * number3;
    Console.WriteLine($"{number3} * {j} = {result}");
    j++;
}



Console.WriteLine("--------Task 3 --------------------------------------------");

//Task 3
//Create an array of numbers [3, 5, 9, 8, 15].
//Find the product of these numbers and write the result to the console

int[] numbers = new int[] { 3, 5, 9, 8, 15 };
int product = 1;
foreach (int i in numbers)
{
    product *= i;
}
Console.WriteLine("the product of these numbers:" + product);




Console.WriteLine("--------Task 4 --------------------------------------------");

//Task 4
//Write a program that calculates how many times 2048 must be divided by 2 to make it less than 10.

int count = 0;
int dividedNumber = 2048;
while (dividedNumber > 10)
{
    dividedNumber = dividedNumber / 2;
    count++;
}
Console.WriteLine($"2048 can be divided {count} times");



Console.WriteLine("--------Task 5 --------------------------------------------");

//Task 5
//Create an array of strings. Write a program that analyzes a created array and,
//if there is a string with the value “Hello”, displays the word “Labas!”
//in console and leaves the loop once it is found.

string[] words = new string[] { "Pts", "Hello", "Kus", "string", "Hello" };
string str1 = "Hello";
foreach (string word in words)
{
    if (string.Equals(word, str1))
    {
        Console.WriteLine("Labas");
        break;
    }
}



Console.WriteLine("--------Task 6--------------------------------------------");

//Task 6
//Create an array of numbers.
//Write a program that calculates the sum of the first and last element of an array
//and writes it to the console.

int[] numbersArr = new int[] { 1, 5, 2, 3, 5, 4, 6 };
int sumOfNumbers = numbersArr[0] + numbersArr[^1];
Console.WriteLine(sumOfNumbers);



Console.WriteLine("--------Task 7--------------------------------------------");

//Task 7
//Create an array of numbers. Find the sum of indexes of minimum and maximum array elements.

int[] numbersArr1 = new int[] { 1, 5, 2, 3, 5, 4, 6 };
int sumOfIndexes;
int minElement = numbersArr1[0];
int maxElement = numbersArr1[0];
int indexMin = 0;
int indexMax = 0;
for (int i = 1; i < numbersArr1.Length; i++)
{
    if (minElement > numbersArr[i])
    {
        minElement = numbersArr[i];
        indexMin = i;
    }

    if (maxElement < numbersArr[i])
    {
        maxElement = numbersArr[i];
        indexMax = i;
    }
}
sumOfIndexes = indexMin + indexMax;
Console.WriteLine(sumOfIndexes);


Console.WriteLine("--------Task 8--------------------------------------------");

//Task 8
//Create an array of numbers and sort its elements in ascending order (without using function Sort).

int[] numbersArr2 = new int[] { 5, 1, 2, 3, 5, 4, 6 };
int temp;
for (int i = 0; i < numbersArr2.Length - 1; i++)
{
    for (int k = i + 1; k < numbersArr2.Length; k++)
    {
        if (numbersArr2[i] > numbersArr2[k])
        {
            temp = numbersArr2[i];
            numbersArr2[i] = numbersArr2[k];
            numbersArr2[k] = temp;
        }
    }
}
Console.WriteLine("ASC Order Output");
foreach (int n in numbersArr2)
{
    Console.WriteLine(n);
}


Console.WriteLine("--------Task 9--------------------------------------------");

//Task 9
//Write to the console a multiplication table for numbers from 1 to 10.

for (int a = 1; a < 11; a++)
{
    int b = 1;
    while (b < 11)
    {
        int result1;
        result1 = a * b;
        Console.WriteLine($"{a} * {b} = {result1}");
        b++;
    }
    Console.WriteLine("-------------------");
}


Console.WriteLine("--------Task 10--------------------------------------------");

//Task 10
//Using a two-dimensional array containing numbers from 1 to 9, write to the console these numbers in the following way:

int[][] nums = new int[2][];
nums[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
nums[1] = new int[3] { 7, 8, 9 };

for (int i = 0; i < nums.Length; i++)
{
    for (int с = 0; с < nums[i].Length; с++)

        if (с == 2)
        {
            Console.Write($"{nums[i][с]} \n");
        }
        else if (с != 2)
        {
            Console.Write($"{nums[i][с]} \t");

        }
    Console.WriteLine();
}

Console.WriteLine("--------Task 11--------------------------------------------");

//Task 11
/*Create an array of numbers: int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Perform the following operations:
1.Add the number 11 to the end of the array
2. Add the number -1 to the beginning of the array
3. Add number 12 to position 4
4. Remove the first element of the array
5. Creating an array from two arrays: the first array is array, the second is int[] array2 = { 100, 200, 300 }. 
The resulting array must contain both array and array2 numbers
*/

int[] oldArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Old array");

foreach (int i in oldArray)
{
    Console.Write($"{i} \t");
}

Console.WriteLine();

int[] newArray = new int[oldArray.Length + 2];

for (int i = 0; i < oldArray.Length; i++)
{
    newArray[i + 1] = oldArray[i];
}

// 1 & 2  tasks
newArray[newArray.Length - 1] = 11;
newArray[0] = -1;

Console.WriteLine("A new array with new elements in the beginning and the end");

foreach (int i in newArray)
{
    Console.Write($"{i} \t");
}

Console.WriteLine();
// 3 task
int[] newArray1 = new int[newArray.Length + 1];
int insertIndex = 3;

for (int i = 0; i < insertIndex; i++)
{
    newArray1[i] = newArray[i];
}

newArray1[insertIndex] = 12;

for (int i = insertIndex + 1; i < newArray1.Length; i++)
{
    newArray1[i] = newArray[i - 1];
}

Console.WriteLine("A new array with new element at 4 position");

foreach (int i in newArray1)
{
    Console.Write($"{i} \t");
}

// 4 task
int[] newArray2 = new int[newArray1.Length - 1];

for (int i = 0; i < newArray2.Length; i++)
{
    newArray2[i] = newArray1[i + 1];
}

Console.WriteLine("\nA new array with removed element");

foreach (int i in newArray2)
{
    Console.Write($"{i} \t");
}

// 5 task -  array from two arrays
int[][] numsNew = new int[2][];
numsNew[0] = oldArray;
numsNew[1] = new int[3] { 100, 200, 300 };

Console.WriteLine("\nA new array from two arrays");

foreach (int[] row in numsNew)
{
    foreach (int el in row)
    {
        Console.Write($"{el} \t");
    }
    Console.WriteLine();
}
