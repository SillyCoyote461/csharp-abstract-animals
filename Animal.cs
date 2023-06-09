﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    public abstract void AnimalCall();
    public abstract void AnimalDiet();
    public void Sleep() => Console.WriteLine("ZZZzzz...");

    public void DoFly(IFlying animal) => animal.Fly();

    public void DoSwim(ISwimming animal) => animal.Swim();
}