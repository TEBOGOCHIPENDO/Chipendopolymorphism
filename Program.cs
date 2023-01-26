class Animal  // Base class (parent) 
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}


class Goat : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The goat says: Mee Mee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object
        Animal myGoat = new Goat();  // Create a Goat object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
        myGoat.animalSound();
    }
}