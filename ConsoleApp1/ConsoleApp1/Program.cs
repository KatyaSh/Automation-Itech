using MyClassLibrary;
using System.Reflection.Metadata;
using System;

// В главном проекте также создайте класс с полями, методами.
// Одно из полей должно иметь тип класса из подключенной библиотеки.
// Используйте несколько конструкторов – с различным количеством и типом параметров.
// В Main методе создайте несколько объектов класса основного проекта, используя различные конструкторы и инициализаторы.
// Используйте методы объектов для вывода некоторой информации на консоль.

Employee rabotnik  = new Employee("Pasha","Bubkin",23,"gruzchik");
Employee rabotnik1 = new Employee("Venus", "Papus", 45, "director");
Employee rabotnik2 = new Employee("Mada", "Petrovna", 56, "buhgalter");
Employee[] pracauniki = new Employee[] { rabotnik, rabotnik1, rabotnik2 };
Factory factory = new Factory("Rassvet");
Factory factory1 = new Factory();
Factory factory2 = new Factory("Mechta", pracauniki);

Console.WriteLine("______________");

factory.addNewEmployee(rabotnik);

Console.WriteLine("______________");

factory1.numberOfEmployees();

Console.WriteLine("______________");

factory2.printEmployeesInfoCertainPositin("director");

Console.WriteLine("______________");

factory1.printEmployeesInfo();



// У фабрики есть  название, есть методы – возвращает количество сотрудников (длина массива);
// добавляет нового сотрудника; выводит список всех сотрудников (имя + фамилия);
// выводит список всех сотрудников, соответствующих определенной должности.
class Factory
{
    public string name;
    public Employee[] employees;
         public Factory() 
         {
            this.name = "Krasnaya zarya";
            this.employees = new Employee[] { (new Employee("Bob", "Smith", 35, "Plotnik")), (new Employee("Tom", "Ken", 18, "Stolyar")) };
         }
           
        public Factory(string name)
        {
         this.name = name;
         this.employees = new Employee[]{(new Employee("Sam","Donavan",35,"Pokraschik")),(new Employee("Vanessa", "Kuper", 23, "OTK")) };
        }
        public Factory(string name, Employee[] employees)
        {
            this.name = name;
            this.employees = employees;
        }
    public void numberOfEmployees()
    {
        Console.WriteLine(employees.Length);        
    }

    public void addNewEmployee(Employee personNew)
     {
        Employee[] employeesNew = new Employee[employees.Length + 1];
        for (int i = 0; i < employees.Length; i++)
        {
            employeesNew[i] = employees[i];
        }
        employeesNew [employees.Length] = personNew;

        foreach (Employee employee in employeesNew)
        {
            employee.employeeInfoPrint();
        }
    }
    public void printEmployeesInfo()
    {
        foreach (Employee employee in employees)
        {
            employee.employeeInfoPrint();
        }
    }

    public void printEmployeesInfoCertainPositin(string position)
    {
        foreach (Employee employee in employees)
        {
            if (position.Equals(employee.position))
                {
                 employee.employeeInfoPrint();
                }
          
        }

    }
}