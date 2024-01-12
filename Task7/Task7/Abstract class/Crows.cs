using System;

public class Crows : Birds
{
    int Size { get; set; }

    public Crows (int size, string name, int fly) : base(name, fly)
    {
        Size = size;
    }

    public override void MakeSound()
    {
        Console.WriteLine("kar-kar");
    }

    public void WhatEating() => Console.WriteLine("Crows eat everything");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}, Fly distance: {FlyDistance} km, size: {Size} cm");

}
