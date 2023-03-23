using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Sheep : Animal
{
    public override void AnimalCall()
    {
        Console.WriteLine("Baaa Baaa");
    }

    public override void AnimalDiet()
    {
        Console.WriteLine("Plant");
    }
}

