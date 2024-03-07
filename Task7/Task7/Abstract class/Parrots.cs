using System;

public class Parrots : Birds
{
    string Color { get; set; }

    public Parrots(string color, string name, int fly) : base(name, fly)
    {
        Color = color;
    }

    public override void MakeSound()
    {
        Console.WriteLine("I'm papuga and repeating all what you are saying");
    }

    public void WhereLiving() => Console.WriteLine("Parrots live on palms");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}, Fly distance: {FlyDistance} km, Color: {Color}");

}
