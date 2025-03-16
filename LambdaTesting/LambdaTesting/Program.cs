namespace LambdaTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers that might have decimals (one at a time): ");
            double num1;
            double num2;
            string tempInt1 = Console.ReadLine();
            while (!double.TryParse(tempInt1, out num1))
            {
                Console.WriteLine("Not a valid number. Please try again. Remember, one at a time.");
                tempInt1 = Console.ReadLine();
            }
            Console.WriteLine("First number accepted. Please enter number 2: ");
            string tempInt2 = Console.ReadLine();
            while (!double.TryParse(tempInt2 , out num2))
            {
                Console.WriteLine("Not a valid number. Please try again.");
                tempInt2 = Console.ReadLine();
            }

            var numAdded = (double num1, double num2) => { return num1 + num2; };
            var numMultiplied = (double num1, double num2) => { return num1 * num2; };
            var smaller = (double num1, double num2) => {
                if (num1 > num2)
                    return num2;
                else
                    return num1;
            };

            Console.WriteLine($"The sum of {num1} and {num2} is {numAdded(num1,num2)}; the product of {num1} and {num2} is {numMultiplied(num1, num2)}; the smaller of {num1} and {num2} is {smaller(num1, num2)}.");
        }
    }
}
