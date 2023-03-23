using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animal
{
    public override void AnimalCall()
    {
        Console.WriteLine("Woof woof");
    }

    public override void AnimalDiet()
    {
        Console.WriteLine("Meat");
    }
}

