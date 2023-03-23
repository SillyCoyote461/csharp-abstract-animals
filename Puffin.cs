using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Puffin : Animal, IFlying, ISwimming
{
    public override void AnimalCall()
    {
        throw new NotImplementedException();
    }

    public override void AnimalDiet()
    {
        throw new NotImplementedException();
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

