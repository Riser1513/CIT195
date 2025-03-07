using System;
using System.Net.NetworkInformation;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal
    class Capybara : Animal
    {
        public int height;
        public string furColor;
        public double happiness;

        public Capybara(int height, string furColor, double happiness, string name)
        {
            this.height = height;
            this.furColor = furColor;
            this.happiness = happiness;
            this.name = name;
        }

        public Capybara()
        {
            height = 56;
            furColor = "teal";
            happiness = 20.87;
            name = "Chad";
        }

        public void statistics()
        {
            Console.WriteLine($"Hi, I am a Capybara. My fur is {furColor}, I stand at {height} inches, and I'm feeling like a {happiness} in terms of happiness.");
        }
    }

    class Axolotl : Animal
    {
        public double length;
        public string scaleColor;
        public int regenStrength;

        public Axolotl(double length, string scaleColor, int regenStrength, string name)
        {
            this.length = length;
            this.scaleColor = scaleColor;
            this.regenStrength = regenStrength;
            this.name = name;
        }

        public Axolotl()
        {
            length = 98;
            scaleColor = "pink";
            regenStrength = 100;
            name = "Rina";
        }

        public void statistics()
        {
            Console.WriteLine($"Hi, I am an Axolotl. My scale color is {scaleColor}, I measure out to be {length} inches long, and my regeneration ability is at {regenStrength}%.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Capybara chad = new Capybara();

            chad.display();
            chad.statistics();

            Axolotl rina = new Axolotl();

            rina.display();
            rina.statistics();

            //derived class object using parameterized constructor
            Capybara evangeline = new Capybara(79, "magenta", 56.87, "Evangeline");

            evangeline.display();
            evangeline.statistics();

            Axolotl lily = new Axolotl(98, "lavender", 87, "Lily");

            lily.display();
            lily.statistics();
        }

    }
}