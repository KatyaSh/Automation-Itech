using System;
using System.Collections.Generic;
public abstract class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    protected Human() { }
}
