using System.Security.Cryptography.X509Certificates;

namespace CustomAbstract
{
    internal class Program
    {
        abstract class Clash
        {
            public abstract int Number { get; set; }
            public abstract string Name { get; set; }

            public abstract void Display();
        }

        class Mech : Clash
        {
            public override int Number { get; set; }
            public override string Name { get; set; }

            public Mech(int number, string name)
            {
                Number = number;
                Name = name;
            }

            public override void Display()
            {
                Console.WriteLine($"I just made random stuff. The name of this stuff is {Name} and there are {Number} of them.");
            }
        }
        static void Main(string[] args)
        {
            Mech done = new Mech(20,"vygtrnfijkml");
            done.Display();
        }
    }
}
