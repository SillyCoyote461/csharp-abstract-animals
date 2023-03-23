List<Animal> animals = new List<Animal>
{
    new Dog(),
    new Sheep(),
    new Shark(),
    new Eagle()
};

foreach (var animal in animals)
{
    animal.AnimalCall();
    animal.AnimalDiet();

    if (animal is IFlying f) animal.DoFly(f);
    if (animal is ISwimming s) animal.DoSwim(s);

    animal.Sleep();
}
