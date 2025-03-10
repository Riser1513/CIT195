namespace immutableID
{
    internal class Program
    {
        class Student
        {
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }

            public Student(int id)
            {
                Id = id;
                FirstName = "";
                LastName = "";
            }

            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
        }
        static void Main(string[] args)
        {
            Student student = new Student(20);
            Student student1 = new Student(20,"Robbie","Cheskowzi");
            Console.WriteLine($"Student 1 has the id of {student.Id}, and their name is {student.FirstName} {student.LastName}.");
            Console.WriteLine($"Student 2 has the id of {student1.Id}, and their name is {student1.FirstName} {student1.LastName}.");
        }
    }
}
