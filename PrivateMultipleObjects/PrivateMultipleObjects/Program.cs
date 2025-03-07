using System.ComponentModel.Design;

namespace PrivateMultipleObjects
{
    internal class Program
    {
        class Spider
        {
            private string _name;
            private int _size;
            private string _color;

            public Spider(string name, int size, string color)
            {
                this._name = name;
                this._size = size;
                this._color = color;
            }

            public Spider()
            {
                _name = "Stanley";
                _size = 20;
                _color = "light grey";
            }

            public virtual void setName(string name)
            {
                this._name = name;
            }

            public void setSize(int size)
            {
                this._size = size;
            }

            public void setColor(string color)
            {
                this._color = color;
            }

            public string getName()
            {
                return _name;
            }

            public virtual int getSize()
            {
                return _size;
            }

            public string getColor()
            {
                return _color;
            }

            public virtual void statistics()
            {
                Console.WriteLine($"Hello there! I'm a spider and my name is {getName()}. My fur is {getColor()} and I'm {getSize()} centimeters in diameter.");
            }

            public virtual void addChange()
            {
                Console.WriteLine("Name?");
                setName(Console.ReadLine());
                Console.WriteLine("Size?");
                setSize(int.Parse(Console.ReadLine()));
                Console.WriteLine("Color?");
                setColor(Console.ReadLine());
            }
        }

        class Tarantula : Spider
        {
            private int _numNests;
            private int _eggs;

            public Tarantula(int numNests, int eggs, string name, string color, int size)
            {
                _numNests = numNests;
                _eggs = eggs;
                setColor(color);
                setSize(size);
                setName(name);
            }

            public Tarantula()
            {
                _numNests = 24;
                _eggs = 1024;
                setColor("silver");
                setSize(40);
                setName("Lux");
            }

            public void setNests(int nests)
            {
                _numNests = nests;
            }

            public void setEggs(int eggs)
            {
                _eggs = eggs;
            }

            public int getNests()
            {
                return _numNests;
            }

            public int getEggs()
            {
                return _eggs;
            }

            public override int getSize()
            {
                if (base.getSize() < 20)
                    base.setSize(30);
                return base.getSize();
            }

            public override void setName(string name)
            {
                base.setName(name);
            }

            public override void statistics()
            {
                Console.WriteLine($"Hello there! I'm a tarantula and my name is {getName()}. My fur is {getColor()}, I'm {getSize()} centimeters in diameter, I have {getEggs()} eggs, and I own {getNests()} nests.");
            }

            public override void addChange()
            {
                base.addChange();
                Console.WriteLine("Nests?");
                setNests(int.Parse(Console.ReadLine()));
                Console.WriteLine("Eggs?");
                setEggs(int.Parse(Console.ReadLine()));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many spiders?");
            int maxSpdrs;
            while (!int.TryParse(Console.ReadLine(), out maxSpdrs))
            {
                Console.WriteLine("That's not a whole number.");
                Console.WriteLine("How many spiders?");
            }
            Spider[] spiders = new Spider[maxSpdrs];
            Console.WriteLine("How many tarantulas?");
            int maxTaras;
            while (!int.TryParse(Console.ReadLine(), out maxTaras))
            {
                Console.WriteLine("That's not a whole number.");
                Console.WriteLine("How many tarantulas?");
            }
            Tarantula[] tarantulas = new Tarantula[maxTaras];

            int choice, rec, type;
            int spdrCounter = 0, taraCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for Tarantula or 2 for Employee");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for Tarantula or 2 for Employee");
                try
                {
                    switch (choice)
                    {
                        case 1:
                            if (type == 1)
                            {
                                if (taraCounter <= maxTaras)
                                {
                                    tarantulas[taraCounter] = new Tarantula();
                                    tarantulas[taraCounter].addChange();
                                    taraCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of Tarantulas has been added");

                            }
                            else
                            {
                                if (spdrCounter <= maxSpdrs)
                                {
                                    spiders[spdrCounter] = new Spider();
                                    spiders[spdrCounter].addChange();
                                    spdrCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of Tarantulas has been added");
                            }

                            break;
                        case 2:
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;
                            if (type == 1)
                            {
                                while (rec > taraCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                tarantulas[rec].addChange();
                            }
                            else
                            {
                                while (rec > spdrCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                spiders[rec].addChange();
                            }
                            break;
                        case 3:
                            if (type == 1)
                            {
                                for (int i = 0; i < taraCounter; i++)
                                    tarantulas[i].statistics();
                            }
                            else
                            {
                                for (int i = 0; i < spdrCounter; i++)
                                    spiders[i].statistics();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();
            }
        }

        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}
