namespace AbstractAnimalClass
{
    internal class Program
    {
        abstract class Animal
        {
            // Property
            public abstract string Name { get; set; }
            // Methods
            public abstract string Describe();
            public string whatAmI()
            {
                return "I am an animal";
            }
        }

        class Capybara : Animal
        {
            public override string Name { get; set; }
            public double Height;
            public int Friendliness;

            public Capybara(string name, double height, int friendliness)
            {
                Name = name;
                Height = height;
                Friendliness = friendliness;
            }

            public Capybara()
            {
                Name = "Brian";
                Height = 2.5;
                Friendliness = 7;
            }

            public override string Describe()
            {
                return $"Capybara with {Friendliness} Friendliness. Is {Height} meters tall. Is named {Name}.";
            }


        }

        static void Main(string[] args)
        {
            Capybara capy1 = new Capybara();
            Capybara capy2 = new Capybara("Chad",3.7,10);

            capy1.Describe();
            capy2.Describe();
        }
    }
}
