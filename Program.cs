public class Program
{
    static void Main(string[] args)
    {
        Wolf myWolf = new Wolf("Wolf");
        Rabbit myRabbit = new Rabbit("Rabbit");
        Bear myBear = new Bear("Bear");
        Grass myGrass = new Grass("Grass");
        Rose myRose = new Rose("Rose");

        Console.WriteLine(myWolf.GetName());
        Console.WriteLine("{0} is {1}.", myWolf, myWolf.SpeciesName());

        Console.WriteLine(myRabbit.GetName());
        Console.WriteLine("{0} is {1}.", myRabbit, myRabbit.SpeciesName());

        Console.WriteLine(myBear.GetName());
        Console.WriteLine("{0} is {1}.", myBear,myBear.SpeciesName());

        Console.WriteLine(myGrass.GetName());
        Console.WriteLine("{0} is {1}.", myGrass,myGrass.SpeciesName());
        
        Console.WriteLine(myRose.GetName()); 
        Console.WriteLine("{0} is {1}.",myRose,myRose.SpeciesName());

        myWolf.Eat(myRabbit);
        myRabbit.Eat(myGrass);
        myBear.Eat(myRabbit);
        myBear.Eat(myGrass);
        myBear.Eat(myRose);
    }
}