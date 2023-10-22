namespace TheZoo
{
    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }      //Characteristics of all the animals
        public string Species { get; set; }

        public bool IsWild { get; set; }
        public int NumberOfLegs { get; set; }


        public Animal(string name, int age, string species, bool isWild, int numberOfLegs) // Constructor
        {
            Name = name;
            Age = age;
            Species = species;
            IsWild = isWild;
            NumberOfLegs = numberOfLegs;
        }


        public virtual void makeSound() //generic animal sound method which can be overridden
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Lion : Animal
    {
        public bool HasMane { get; set; }

        public Lion(string name, int age) : base(name, age, "Lion", true, 4)
        {
            HasMane = true;
        }

        public override void makeSound()
        {
            Console.WriteLine("ROOOAR");
        }
    }

    public class Elephant : Animal
    {
        public int TuskLength { get; set; }

        public Elephant(string name, int age) : base(name, age, "Elephant", true, 4)
        {
            TuskLength = 0;
        }

        public override void makeSound()
        {
            Console.WriteLine("TOOOOOOOOOOT");
        }
    }

    public class GreyBird : Bird
    {
        public bool canFly { get; set; }

        public GreyBird (string name, int age) : base(name, age)
        {
            canFly = true;
        }

        public override void makeSound()
        {
            Console.WriteLine("*Grey bird noices*");
        }
    }

    public class WhiteBird : Bird
    {
        public bool canSwim { get; set; }

        public WhiteBird(string name, int age) : base(name, age)
        {
            canSwim = true;
        }

        public override void makeSound()
        {
            Console.WriteLine("*Noice of wings flapping*");
        }
    }

    public class Bird : Animal
    {
        public string Breed { get; set; }

        public Bird (string name, int age) : base(name, age, "Bird", false, 4)
        {
            Breed = "Black Bird";
        }

        public void Fly()
        {
            Console.WriteLine("The Black Bird can fly long distances");
        }
        public override void makeSound()
        {
            Console.WriteLine("*Black Bird noices*");
        }
    }

    class Program
    {
        static void Main()
        {
            Lion lion = new Lion("Sanna", 5);
            Elephant elephant = new Elephant("Elias", 10);
            Bird bird = new Bird("Filip", 21);
            GreyBird greybird = new GreyBird("Stumpan", 3);
            WhiteBird whitebird = new WhiteBird("Felicia", 2);

            Animal[] zoo = { lion, elephant, greybird, whitebird, bird };

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Name: {animal.Name}, Species: {animal.Species}, Age: {animal.Age}");
                animal.makeSound();
                Console.WriteLine();
            }
        }
    }
}