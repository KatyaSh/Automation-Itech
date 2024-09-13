using System.Text.Json;

Class1 person1 = new Class1 { Name = "Anna", Age = 10 };
Class1 person2 = new Class1 { Name = "Sofja", Age = 20 };

Class2 objClass2 = new Class2
{
    City = "Minsk",
    ID = 1,
    IsActive = true,
    CreatedDate = DateTime.Now,
    Class1People = new List<Class1> { person1, person2 }
};

string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "json");

string jsonString = JsonSerializer.Serialize(objClass2, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText(jsonFilePath, jsonString);

Console.WriteLine("Class2 object is serialized to 'class2.json'");

string newJsonString = File.ReadAllText(jsonFilePath);

Class2 deserializedObjClass2 = JsonSerializer.Deserialize<Class2>(newJsonString);

Console.WriteLine("Deserialized Class2 object from 'json' folder:");
Console.WriteLine($"Description: {deserializedObjClass2.City}");
Console.WriteLine($"Identifier: {deserializedObjClass2.ID}");
Console.WriteLine($"IsActive: {deserializedObjClass2.IsActive}");
Console.WriteLine($"CreatedOn: {deserializedObjClass2.CreatedDate}");

foreach (var item in deserializedObjClass2.Class1People)
{
    Console.WriteLine($"Class1 Item: {item.Name}, Value: {item.Age}");
}