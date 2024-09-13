using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class2
{
    public string City { get; set; }
    public int ID { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Class1> Class1People { get; set; } = new List<Class1>();
}