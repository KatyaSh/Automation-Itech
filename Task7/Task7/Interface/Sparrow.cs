using System;
internal class Sparrow : IBird, IFly, IMakeSound
{
    public string Name { get; set; }

    public void MakeNest() => Console.WriteLine("Sparrow makes nest under the roof");

    public void Sound() => Console.WriteLine("Chick-chirick");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}");

    public void Fly() => Console.WriteLine("sparrow can't fly very high");

}


