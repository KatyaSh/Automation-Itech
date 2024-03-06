
//Task 1
//Create an abstract class that contains at least:
//a variable of any type
//an abstract property
//an abstract method
//a non -abstract method.
//Create several classes that inherit from the abstract class. These classes should contain
//variables/properties/methods different from those that are in the abstract class.
//Create instances of the derived classes and perform any actions with these instances (ex., call a method, assign value to the variable). 
//*Both absract and derived classes and relations between them should make any sense, not just “Class1”, “Class2”
// Creating instances and performing actions
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("___________Task1___Abstract class__________________");
Crows myCrow = new Crows(5, "Gosha", 5);
Parrots myParrot = new Parrots("multicolor", "Kesha", 3);
myCrow.BirdInfo();
myCrow.MakeSound();
myCrow.WhatEating();
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
myParrot.BirdInfo();
myParrot.MakeSound();
myParrot.WhereLiving();


//Create some interfaces. Create a class(es) that implement these interfaces. Create instances of the derived classes
//and perform any actions with these instances (ex., call a method, assign value to the variable). 
//*Created interfaces, classes and relations between them should make any sense, not just “Interface1”, “Class1”

Console.WriteLine("___________Task2________Interfaces_____________");
Penguin myPin = new Penguin("Pin");
myPin.BirdInfo();
myPin.MakeNest();
myPin.Sound();
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Sparrow mySparrow = new Sparrow();
mySparrow.Name = "vorobei";
mySparrow.BirdInfo();
mySparrow.MakeNest();
mySparrow.Sound();
mySparrow.Fly();

//Imagine that there is an application - an electronics store.
//Developer N created 3 classes in the application - Polaroid, MobilePhone and Printer - classes in Task7
//folder in AQA Lab Homework Tasks Repository. Each class has some variables, properties and methods similar to other classes.
//Add these 3 classes into your solution and refactor them implementing abstract class(es)/interface(s) where it’s needed.

Console.WriteLine("___________Task3______Electronics store_______________");
Polaroid polaroid = new Polaroid("Now Generation 2 i-Type Instant Camera", "Polaroid", 129.99);
MobilePhone iphone = new MobilePhone("15 pro", "Apple Inc", 1689.01);
Printer hp = new Printer("LaserJet Pro MFP 4101fdn Printer with Fax", "HP", 379);
polaroid.DeviceInfo();
polaroid.Charge();
polaroid.TurnOn();
polaroid.TurnOff();
polaroid.TakePhoto();
polaroid.Print();
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
iphone.DeviceInfo();
iphone.Charge();
iphone.TurnOn();
iphone.TurnOff();
iphone.TakePhoto();
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
hp.DeviceInfo();
hp.Charge();
hp.TurnOn();
hp.TurnOff();
hp.Print();