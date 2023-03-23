using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Eagle : Animal, IFlying
{
    public override void AnimalCall()
    {
        Console.WriteLine("*Scream*");
    }

    public override void AnimalDiet()
    {
        Console.WriteLine("Meat");
    }
}

