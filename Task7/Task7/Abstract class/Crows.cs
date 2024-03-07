using System;

public class Crows : Birds
{
    private int _size;
    public int Size  
    { 
        get { return _size; }

        set
        {
            if (value >= 10)
            {
                _size = value;
            }

            else
            {
                Console.WriteLine("This crow is too small and cannot fly. Size was set as 10");
                _size = 10; 
            }

        }

    }

    public Crows (int size, string name, int fly) : base(name, fly)
    {
        Size = size;
    }

    public override void MakeSound()
    {
        Console.WriteLine("kar-kar");
    }

    public void WhatEating() => Console.WriteLine("Crows eat everything");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}, Fly distance: {FlyDistance} km, size: {Size} cm v holke");

}
