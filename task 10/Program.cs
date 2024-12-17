

using System.Collections.Generic;
Console.WriteLine("_____________________Task 1-1 ______________________________");
//LIST
//Write a method to find the sum of all even numbers in a . 

List<int> enteredNumbers = new List<int>();
for (int i = 0; i < 6; i++)
{
    Console.Write("Enter a number: ");
    var input = Console.ReadLine();
    int number;
    bool parseResult = int.TryParse(input, out number);

    if (parseResult)
    {
        enteredNumbers.Add(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        i--;
    }

}

int sum = EvenNumbersSum.Sum(enteredNumbers);
Console.WriteLine(sum);

Console.WriteLine("_____________________Task 1-2 ______________________________");
//Create a list containing at least 10 integers, call your method, and output the result.

List<int> myNumbers = new List<int>() { 1, 3, 7, 8, 1, 2, 5, 10, 4, 15 };
int sumMyNumbers = EvenNumbersSum.Sum(myNumbers);
Console.WriteLine(sumMyNumbers);

Console.WriteLine("_____________________Task 1-3 ______________________________");
//Create a list of strings that contain words of different lengths. Write a static method to output each word from a
//list of exactly 5 letters.

List<String> words = new List<String>() { "moon", "taxi", "money", "bamby", "task", "casco", "you", "me" };
List<String> wordsSorted = SortingOfWord.wordsSorting(words);
foreach (var word in wordsSorted)
{
    Console.WriteLine(word);
}

Console.WriteLine("_____________________Task 1-4 ______________________________");
//Modify your code to prompt the user to enter the length of a search term. 

Console.Write("Enter a required lenght of word: ");
var input1 = Console.ReadLine();
int number1;
bool parseResult1 = int.TryParse(input1, out number1);
List<String> wordsSortedonLeght = new List<string>();
if (parseResult1)
{
    wordsSortedonLeght = SortingOfWord.wordsSortingCertainLenght(words, number1);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

foreach (var word in wordsSortedonLeght)
{
    Console.WriteLine(word);
}

Console.WriteLine("_____________________Task 2-1 ______________________________");
//LINKED LIST
//Create a LinkedList and two items, insert a second item after each occurrence
//of the first item in the list. So, if the list is [2,4,3,2,8,2,5,1,2] and the elements are 2 and 10,
//the result is [2,10,4,3,2,10,8,2,10,5,1,2,10] *

int[] initialValues = { 2, 4, 3, 2, 8, 2, 5, 1, 2 };
LinkedList<int> initialValuesList = new LinkedList<int>(initialValues);
Console.WriteLine("Elements before insertion:");
foreach (int number in initialValuesList)
{
    Console.WriteLine(number);
}

AddValueToList.AddedValuesToList(initialValuesList);
Console.WriteLine("Elements after insertion:");
foreach (int number in initialValuesList)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____________________Task 2-2 ______________________________");
//Merge two related lists of numbers by including in the final list only those numbers that occur in both lists.
//So, if the lists are [1,3,4,7,12] and [1,5,7,9], the result will be [1,7]. *

int[] initialValues1 = { 1, 3, 4, 7, 12 };
int[] initialValues2 = { 1, 5, 7, 9, 3 };
LinkedList<int> initialValuesList1 = new LinkedList<int>(initialValues1);
LinkedList<int> initialValuesList2 = new LinkedList<int>(initialValues2);
var currentNode1 = initialValuesList1.First;
var currentNode2 = initialValuesList2.First;
LinkedList<int> result = MergeLinkedLists.MergedLists(initialValuesList1, initialValuesList2);
foreach (int number in result)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____________________Task 3-1 ______________________________");
//QUEUE & STACK[ACTUAL]
//Queue - Swap First and Last Implement a function SwapFirstAndLast() in C#. This function should take a Queue<int> as input and,
//using the methods inherent to the Queue<> data structure (Enqueue, Dequeue, Peek etc.),
//it should swap the first and the last elements of the queue. The function should return the modified queue.
//Input test data: Queue<int> myQueue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 })
//Expected Result: Queue<int> { 5, 2, 3, 4, 1}

Queue<int> myQueue = new Queue<int>(new int[] { 5, 3, 6, 2, 7, 8, 9 });
var queue = QueueMethods.SwapFirstAndLastMethod(myQueue);
foreach (var elem in queue) Console.WriteLine(elem);

Console.WriteLine("_____________________Task 3-2 ______________________________");
//Queue - Reverse Queue Write a function ReverseQueue() that takes a Queue<int> as input. 
//	This function, using the methods inherent to the Queue<> data structure, should reverse the content of the queue 
//	and then return this reversed queue.
//		Input test data: Queue<int> myQueue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
//Expected Result: Queue<int> { 5, 4, 3, 2, 1}

Queue<int> myQueue1 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
var queue1 = myQueue.Reverse();
foreach (var elem in queue1) Console.WriteLine(elem);

Console.WriteLine("_____________________Task 3-2 ______________________________");
//Stack - Sort a Stack Your task is to implement SortStack(), a function that accepts Stack<int>. The function is to sort the stack's elements in ascending order. To achieve this, you must use the methods inherent to the Stack<> data structure, like Push() and Pop(). The output should be the modified (sorted) stack.
//		Input test data: Stack<int> myStack = new Stack<int>(new int[] { 3, 2, 5, 1, 4 });
//Expected Result: Queue<int> { 5, 4, 3, 2, 1}

Stack<int> myStack = new Stack<int>(new int[] { 3, 2, 5, 1, 4 });
var stack = StackMethods.AscSorting(myStack);
foreach (var elem in stack) Console.WriteLine(elem);

Console.WriteLine("_____________________Task 3-3 ______________________________");
//Stack - Balanced Parentheses Develop an AreParenthesesBalanced() function that
//accepts a string. This function should inspect whether the parentheses in the string are balanced.
//To fulfill this mission, the function will use methods inherent to the Stack<> data structure.
//The output should be a boolean value denoting whether the parentheses in the input are balanced ('true') or not ('false').
//		Input Test Data: "((a+b))" Expected Result: True
//Input Test Data: "((a+b)" Expected Result: False

string testData1 = "((a+b))))";
string testData2 = ")a+b(";
Console.WriteLine(StackMethods.AreParenthesesBalanced(testData1));
Console.WriteLine(StackMethods.AreParenthesesBalanced(testData2));

Console.WriteLine("_____________________Task 4-1 ______________________________");
//Add a new dictionary whose key is your name and whose value is your age.
//Do this using the Add method.Then add another value to the dictionary using index notation.
//This time, use a different name and a different age. Finally, read the first item you added to the dictionary
//and write it to the console using Console.WriteLine.

Dictionary<string, int> kateDictionary = new Dictionary<string, int>();
kateDictionary.Add("Kate", 5);
kateDictionary["Vita"] = 10;
Console.WriteLine($"Name: Kate, Age: {kateDictionary["Kate"]}");

Console.WriteLine("_____________________Task 4-2 ______________________________");
//Create two lists, each with 10 values. The first list is of type int,
//where the values are not in order. The second list is of type string,
//the values are also not alphabetically specified. Write a method that performs sorting operations on the two lists:
//the int list in ascending and the string list in descending order. Then this method merges the lists into a dictionary.
//Output the resulting word to the console


List<int> intList = new List<int> { 1, 10, 2, 15, 24, 17, 50, 63, 47 };
List<string> stringList = new List<string> { "cat", "dog", "apple", "table", "cup", "grass", "headphones", "monitor", "program" };
var mergedDictionary = DictionaryMethods.SortAndMergeLists(intList, stringList);

// Output the resulting dictionary
foreach (var pair in mergedDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine("_____________________Task 4-3 ______________________________");
//Create a City class where there are fields int population, double area.
//Create a dictionary where Key is the name of the city and Value is the corresponding name of the city and the object of type City.
//Create 5 elements for the dictionary. 
//a.Sort the dictionary by city area and display it on your console
//b.Browse the dictionary by population in reverse order and display it on your console
//c.Count the total population of all cities and output to the console

Dictionary<string, City> cities = new Dictionary<string, City>
        {
            { "New York", new City(8000000, 450) },
            { "Paris", new City(390000, 500) },
            { "Chicago", new City(2700000, 580) },
            { "Minsk", new City(1900000, 250) },
            { "London", new City(3000000, 500) }
        };

List<KeyValuePair<string, City>> cityList = new List<KeyValuePair<string, City>>(cities);
for (int i = 0; i < cityList.Count - 1; i++)
{
    for (int j = i + 1; j < cityList.Count; j++)
    {
        if (cityList[i].Value.Area > cityList[j].Value.Area)
        {
            var temp = cityList[i];
            cityList[i] = cityList[j];
            cityList[j] = temp;
        }
    }
}

Console.WriteLine("Cities sorted by area:");

foreach (var city in cityList)
{
    Console.WriteLine(city.Key + ": " + city.Value.Area + " sq km");
}

Console.WriteLine();
Console.WriteLine("Cities sorted by population desc:");

foreach (var city in cities.OrderByDescending(c => c.Value.Population))
{
    Console.WriteLine($"{city.Key}: Population = {city.Value.Population}");
}

Console.WriteLine();
int totalPopulation = cities.Sum(c => c.Value.Population);
Console.WriteLine($"Total population: {totalPopulation}");
