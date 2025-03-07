namespace SealedClass
{
    internal class Program
    {
        interface IEmployee
        {
            //Properties
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            //Methods
            public string Fullname();
            public double Pay();
        }
        class Employee : IEmployee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public virtual double Pay()
            {
                double salary;
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }

        }

        class Executive : Employee
        {
            public string Title;
            public double Salary;

            public Executive(string title, int salary, string first, string last)
            {
                Title = title;
                Salary = salary;
                FirstName = first;
                LastName = last;
            }

            public Executive()
            {
                Title = "Stupid Face";
                Salary = Pay();
            }

            public override double Pay()
            {
                if (Salary < 2000)
                {
                    Salary = 30903;
                }

                return Salary;
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Mark","Stein");
            Executive exe = new Executive("Stupid",2300,"Klein","Slesh");

            emp.Fullname();
            emp.Pay();
            exe.Fullname();
            exe.Pay();
        }
    }
}
