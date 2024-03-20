using System;
using System.Collections.Generic;
using System.Reflection;

//Напишите обобщенный класс, который может хранить в массиве объекты любого типа. Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
//A.Создайте три класса: Human(абстрактный – поля имя, фамилия + конструктор)->Woman и Man(наследники с двумя конструкторами –> 1. Без параметров, полям задаются значения по умолчанию, 2. С параметрами имя и фамилия)
//Б.Измените обобщённый массив так, чтобы он мог использовать тип только Woman и Man

Woman woman1 = new Woman();
Woman woman2 = new Woman("Tata", "Ivanec");
Man man1 = new Man("Van", "Dam");
Man man2 = new Man();

ArrayGeneric<Human> humanMassive = new ArrayGeneric<Human>();

humanMassive.Add(woman1);
humanMassive.Add(man1);
humanMassive.Add(woman2);
humanMassive.Add(man2);
Console.WriteLine($"Name {humanMassive[1].FirstName}");

Console.WriteLine($"Array Length = {humanMassive.Count()}");

humanMassive.RemoveAt(2);
Console.WriteLine($"Array Length = {humanMassive.Count()}");

//В классе с методом Main напишите обобщённый метод, который который будет
//генерировать заданное количество элементов, элементы могут быть только типа Man и Woman
//и должны создаваться через вызов конструктора их класса new()

GenerateElemets(5);

void GenerateElemets(int numberOfElements)
{
    ArrayGeneric<Human> humanMassiveGenerate = new ArrayGeneric<Human>();
    for (int i = 0; i < numberOfElements; i++)
    {
        Woman human = new Woman();
        humanMassiveGenerate.Add(human);
    }

    Console.WriteLine($"Generated Array Length = {humanMassiveGenerate.Count()}");
}

//В обобщённом классе создайте метод ToString(), который будет в зависимости от типа
//обобщения выводить имена всех людей, а также сообщение “There’re only women” или “There’re only men”
Woman woman3 = new Woman("Dusya", "Musya");
Woman woman4 = new Woman("Tata", "Ivanec");
Man man3 = new Man("Van", "Dam");
Man man4 = new Man("Reny", "Peny");

ArrayGeneric<Human> humanMassive1 = new ArrayGeneric<Human>();

humanMassive1.Add(woman3);
humanMassive1.Add(woman4);
humanMassive1.ToString();