List <Animal> animals = new List <Animal>();
animals.Add(new Dog());
animals.Add(new Sheep());
animals.Add(new Shark());
animals.Add(new Eagle());

foreach (var animal in animals)
{
    animal.AnimalCall();
    animal.AnimalDiet();

    if (animal is IFlying f) f.Fly();
    if (animal is ISwimming s) s.Swim();

    animal.Sleep();

}
