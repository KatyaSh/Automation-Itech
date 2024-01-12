using System;
public abstract class Device
{
    public string Model { get; set; }

    public double Price { get; set; }

    public string Brand { get; set; }


    public abstract void Charge();

    public abstract void TurnOn();

    public abstract void TurnOff();

    public abstract void DeviceInfo();

}
