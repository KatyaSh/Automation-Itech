// Работник имеет поля: возраст, имя, фамилия, должность
//и методы: возвращает всю информацию по работнику, имитирует некоторое выполнение работы.
namespace Employee_lib
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string age;
        public int Age { get;  set; }

        public virtual void PrintInfo() => Console.WriteLine($"Name: {FirstName}, LastName: {LastName}, Age: {Age}");

    }

    public class Employee : Person {

        private string position;
        public string Position { get; set; }

        public Employee(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Position: {Position}");
        }

    } }