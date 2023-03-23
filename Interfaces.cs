using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IFlying
{
    void Fly()
    {
        Console.WriteLine("I'm flying!");
    }
}

public interface ISwimming
{
    void Swim()
    {
        Console.WriteLine("I'm swimming!");
    }
}
