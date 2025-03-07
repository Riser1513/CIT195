namespace AnimalInheritance
{
    internal class Program
    {
        class Animal
        {
            private string name;
            protected string type;
            public string color;

            public void setName(string name)
            {
                this.name = name;
            }
            public virtual string getName()
            {
                return this.name;
            }
            public void setType(string type)
            {
                this.type = type;
            }
            public virtual string getType()
            {
                return this.type;
            }
        }

        class Komodo : Animal
        {
            private bool hasTail;
            public int length;
            public int width;

            public Komodo(string color, int length, int width, bool hasTail, string type, string name)
            {
                this.color = color;
                this.length = length;
                this.width = width;
                this.type = type;
                this.hasTail = hasTail;
                base.setName(name);
            }

            public Komodo()
            {
                color = "brown";
                length = 50;
                width = 10;
                hasTail = true;
                type = "reptile";
                base.setName("Gerald");
            }

            public override string getName()
            {
                return base.getName();
            }

            public override string getType()
            {
                return base.getType();
            }

            public void setTail(bool hasTail)
            {
                this.hasTail = hasTail;
            }

            public string getTail()
            {
                if (hasTail)
                {
                    return "Negative";
                }
                else
                {
                    return "Positive";
                }
            }

            public void statistics()
            {
                Console.WriteLine($"Hi, I am a Komodo Dragon. My name is {getName()}. My scale color is {color}, I measure out to be {length} inches long, I'm considered a {type}, and I'm {width} inches wide. Do I have my tail? {getTail()}.");
            }
        }

        static void Main(string[] args)
        {
            Komodo gerald = new Komodo();

            gerald.setTail(false);

            gerald.statistics();

            Komodo sebastian = new Komodo("purple", 80, 40, true, "fluff", "Sebastian");

            sebastian.statistics();
        }
    }
}
