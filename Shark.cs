using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Shark : Animal
{
    public override void AnimalCall()
    {
        Console.WriteLine("*Blop blop*");
    }

    public override void AnimalDiet()
    {
        Console.WriteLine("Meat");
    }
}

