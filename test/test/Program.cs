namespace test
{
    internal class Program
    {
        enum Days:short { Sunday, Monday = 11, Tuesday = 10, Wednesday, Thursday, Friday, Saturday }
        static void Main(string[] args)
        {
                        Days today = 0;
                        Console.WriteLine(today);
                        today = (Days)12;
                        Console.WriteLine(today);
        }
    }
}
