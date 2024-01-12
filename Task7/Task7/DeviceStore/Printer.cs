using System;
using System.Security.Cryptography.X509Certificates;

class Printer : Device, IPrint
{
    string Model { get; set; }

    double Price { get; set; }

    string Brand { get; set; }

    public Printer(string model, string brand, double price)
    {
        Model = model;
        Brand = brand;
        Price = price;
    }

    public override void Charge() => Console.WriteLine("Printer is always plugged on");

    public override void TurnOn() => Console.WriteLine("To turn on  just press the Button On");

    public override void TurnOff() => Console.WriteLine("To turn off hold the Button On for 3 sec");

    public void Print()
    {
        Console.WriteLine("Printer prints on blank paper");
    }

    public override void DeviceInfo() => Console.WriteLine($"Printer model: {Model}, Brand: {Brand}, price: {Price}$");

}

