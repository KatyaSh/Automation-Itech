using System;
using System.Reflection.Metadata;
using Employee_lib;
// В главном проекте также создайте класс с полями, методами.
// Одно из полей должно иметь тип класса из подключенной библиотеки.
// Используйте несколько конструкторов – с различным количеством и типом параметров.
// В Main методе создайте несколько объектов класса основного проекта, используя различные конструкторы и инициализаторы.
// Используйте методы объектов для вывода некоторой информации на консоль.
var rabotnik = new Employee("Pasha", "Bubkin", 23, "gruzchik");
var rabotnik1 = new Employee("Venus", "Papus", 45, "director");
var rabotnik2 = new Employee("Mada", "Petrovna", 56, "buhgalter");
var pracauniki = new Employee[] { rabotnik, rabotnik1, rabotnik2 };
var factory = new Factory("Rassvet");
var factory1 = new Factory();
var factory2 = new Factory("Mechta", pracauniki);

factory.AddNewEmployee(rabotnik);
Console.WriteLine("______________");
factory1.NumberOfEmployees();
Console.WriteLine("______________");
factory2.PrintEmployeesInfoCertainPositin("director");
Console.WriteLine("______________");
factory1.PrintEmployeesInfo();

// У фабрики есть  название, есть методы – возвращает количество сотрудников (длина массива);
// добавляет нового сотрудника; выводит список всех сотрудников (имя + фамилия);
// выводит список всех сотрудников, соответствующих определенной должности.
class Factory
{
    private string name;

    public string Name { get; set; }

    private Employee[] employees;

    public Employee[] Employees { get; set; }

    public Factory()
    {
        Name = "Krasnaya zarya";
        Employees = new Employee[] { (new Employee("Bob", "Smith", 35, "Plotnik")), (new Employee("Tom", "Ken", 18, "Stolyar")) };
    }

    public Factory(string name)
    {
        Name = name;
        Employees = new Employee[] { (new Employee("Sam", "Donavan", 35, "Pokraschik")), (new Employee("Vanessa", "Kuper", 23, "OTK")) };
    }

    public Factory(string name, Employee[] employees)
    {
        Name = name;
        Employees = employees;
    }

    public void NumberOfEmployees() => Console.WriteLine(Employees.Length);

    public void AddNewEmployee(Employee personNew)
    {
        var employeesNew = new Employee[Employees.Length + 1];

        for (int i = 0; i < Employees.Length; i++)
        {
            employeesNew[i] = Employees[i];
        }

        employeesNew[Employees.Length] = personNew;

        foreach (Employee employee in employeesNew)
        {
            employee.PrintInfo();
        }

    }

    public void PrintEmployeesInfo()
    {
        foreach (Employee employee in Employees)
        {
            employee.PrintInfo();
        }

    }

    public void PrintEmployeesInfoCertainPositin(string position)
    {
        foreach (var employee in Employees)
        {
            if (position.Equals(employee.Position))
            {
                employee.PrintInfo();
            }

        }

    }

}