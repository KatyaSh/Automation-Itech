using System;

public class Candidate
{

    public string Name { get; set; }
    public string Title { get; set; }
    public int Age { get; set; }

    public Candidate(string name, string title, int age)
    {
        this.Name = name;
        this.Title = title;
        this.Age = age;

    }

}
