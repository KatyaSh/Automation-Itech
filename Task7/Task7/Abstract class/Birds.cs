using System;

public abstract class Birds
{
    
    protected string Name { get; set; }

    protected int FlyDistance { get; set; }
   
    public abstract void MakeSound();
    
    public void BirdInfo()
    {
        Console.WriteLine($"Name: {Name}, Fly distance: {FlyDistance} km");
    }

    protected Birds(string name, int fly)
    {
        Name = name;
        FlyDistance = fly;
    }

}
