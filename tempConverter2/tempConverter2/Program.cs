using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert, intCelsius=0, intFahrenheit=0;
            double dblNumToConvert, dblCelsius=0, dblFahrenheit=0;
            bool stop = false;
            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();
                    while (!double.TryParse(numberToConvert, out dblNumToConvert) && !int.TryParse(numberToConvert, out intNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }
                    if (intNumToConvert > 0)
                    {
                        convertTemp(intNumToConvert, ref intCelsius, ref intFahrenheit);
                        Console.WriteLine($"The original number was {intNumToConvert}");
                        Console.WriteLine($"Converting to Celcius results in {intCelsius};");
                        Console.WriteLine($"Converting to Fahrnheit results in {intFahrenheit}");
                        intCelsius = 0;
                        intFahrenheit = 0;
                    }
                    else
                    {
                        convertTemp(dblNumToConvert, ref dblCelsius, ref dblFahrenheit);
                        Console.WriteLine($"The original number was {intNumToConvert}");
                        Console.WriteLine($"Converting to Celcius results in {dblCelsius};");
                        Console.WriteLine($"Converting to Fahrnheit results in {dblFahrenheit}");
                        dblFahrenheit = 0;
                        dblCelsius = 0;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;
                    while (!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Pleaase enter a valid character, try again...");
                    }
                    if (Char.ToLower(more) != 'y')
                        stop = true;
                }
            } while (!stop);

        }
        private static void convertTemp(int intNumToConvert, ref int celsius, ref int fahrenheit)
        {

            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("An issue occurred while converting the teperature. Please try again.");
                Console.WriteLine($"The exact error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");
                Console.WriteLine($"The exact error: {e.Message}");
            }
            finally
            {
                if (fahrenheit == 0 && celsius == 0)
                {
                    Console.WriteLine("The temperature could not be converted.");
                }
            }

            return;
        }
        private static void convertTemp(double intNumToConvert, ref double celsius, ref double fahrenheit)
        {

            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("An issue occurred while converting the teperature. Please try again.");
                Console.WriteLine($"The exact error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");
                Console.WriteLine($"The exact error: {e.Message}");
            }
            finally
            {
                if (fahrenheit == 0 && celsius == 0)
                {
                    Console.WriteLine("The temperature could not be converted.");
                }
            }
            return;
        }

    }
}