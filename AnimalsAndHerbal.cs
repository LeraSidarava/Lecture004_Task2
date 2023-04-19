using System;

public abstract class Alive
{
    public abstract string SpeciesName();
}

public class Animal : Alive
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public override string SpeciesName()
    {
        return "Animal";
    }

    public virtual string GetName()
    {
        return name;
    }
}

public abstract class Carnivore : Animal
{
    protected string speciesName;

    public Carnivore(string name, string speciesName) : base(name)
    {
        this.speciesName = speciesName;
    }

    public override string SpeciesName()
    {
        return speciesName;
    }

    public abstract void Eat(Animal animal);
}

public abstract class Herbivore : Animal
{
    public Herbivore(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Herbivore";
    }

    public abstract void Eat(Herbal herbal);
}

public abstract class Omnivore : Animal
{
    public Omnivore(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Omnivore";
    }

    public abstract void Eat(Alive alive);
}

public class Wolf : Carnivore
{
    public Wolf(string name) : base(name, "Carnivore")
    {
    }

    public override void Eat(Animal animal)
    {
        Console.WriteLine("{0} is eating {1}", GetName(), animal.GetName());
    }
}

public class Rabbit : Herbivore
{
    public Rabbit(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Herbivore";
    }

    public override void Eat(Herbal herbal)
    {
        Console.WriteLine("{0} is eating {1}", GetName(), herbal.GetName());
    }
}


public class Bear : Omnivore
{
    public Bear(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Omnivore";
    }

    public override void Eat(Alive alive)
    {
        if (alive is Animal)
        {
            Console.WriteLine("{0} is eating {1}", GetName(), ((Animal)alive).GetName());
        }
        else if (alive is Herbal)
        {
            Console.WriteLine("{0} is eating {1}", GetName(), ((Herbal)alive).GetName());
        }
    }
}

public class Rose : Herbal
{
    public Rose(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Herbal";
    }
}

public class Grass : Herbal
{
    public Grass(string name) : base(name)
    {
    }

    public override string SpeciesName()
    {
        return "Herbal";
    }
}

public abstract class Herbal : Alive
{
    private string name;

    public Herbal(string name)
    {
        this.name = name;
    }

    public override string SpeciesName()
    {
        return "Herbal";
    }

    public string GetName()
    {
        return name;
    }
}
