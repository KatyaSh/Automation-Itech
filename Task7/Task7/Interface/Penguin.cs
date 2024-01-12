using System;
public class Penguin : IBird, IMakeSound
{
    public string Name { get; set; }

    public Penguin(string name) => Name = name;

    public void MakeNest() => Console.WriteLine("Pinguin does not make nest");

    public void Sound() => Console.WriteLine("honk-honk-honk");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}");

}

