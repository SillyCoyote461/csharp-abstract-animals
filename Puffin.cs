using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Puffin : Animal, IFlying, ISwimming
{
    public override void AnimalCall()
    {
        Console.WriteLine("*Cip cip*");

    }

    public override void AnimalDiet()
    {
        Console.WriteLine("*Fish*");

    }

    public void Fly()
    {
        Console.WriteLine("I'm flying!");
    }

    public void Swim()
    {
        Console.WriteLine("I'm swimming!");
    }
}

