using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace FileHandlingDemo1
{
    internal class Program
    {
        static void Main()
        {
            int choice = Menu();
            while (choice != 5)
            {
                switch (choice)
                {
                    case 2:
                        ReadFile();
                        break;
                    case 1:
                        AppendToFile();
                        break;
                    case 3:
                        ReadToArray();
                        break;
                    case 4:
                        try
                        {
                            string path = "Words.txt";
                            if (File.Exists(path))
                            {
                                File.Delete(path);
                                Console.WriteLine("File deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("File does not exist.");
                            }
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                        break;
                }
                choice = Menu();
            }

        }
        static int Menu()
        {
            Console.WriteLine("Enter your choice:\n1. Add Word\n2. Read All\n" +
                "3. Read Current Word\n4. Delete File\n5. Exit");
            int choice = 0;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
            return choice;
        }
        static void AppendToFile()
        {
            string path = "Words.txt";

            Console.WriteLine("What's the word of the day?");
            string word = Console.ReadLine();

            while (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Not a valid word. Please try again.");
                word = Console.ReadLine();
            }

            word = word + " : ";

            bool temp = true;

            int counter = 1;

            do
            {
                Console.WriteLine("What's the definition?");
                string definition = Console.ReadLine();

                while (string.IsNullOrEmpty(definition) || string.IsNullOrWhiteSpace(definition))
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                    definition = Console.ReadLine();
                }

                word += counter + ". " + definition + " ";
                Console.WriteLine("Do you want to add another definition?");
                string Temp = Console.ReadLine().ToLower();
                while (string.IsNullOrEmpty(Temp) || string.IsNullOrWhiteSpace(Temp) || (Temp != "y" && Temp != "n" && Temp != "yes" && Temp != "no"))
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                    Temp = Console.ReadLine().ToLower();
                }
                if (Temp == "y" || Temp == "yes")
                {
                    counter++;
                }
                else if (Temp == "n" || Temp == "no")
                {
                    word += "\n";
                    temp = false;
                }
            } while (temp);

            try
            {
                File.AppendAllText(path, word);
                Console.WriteLine("Text appended successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return;
        }
        static void ReadFile()
        {
            string path = "Words.txt";
            try
            {
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine("File Content:\n" + content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return;

        }
        static void ReadToArray()
        {
            string path = "Words.txt";
            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    string currentWord = lines[lines.Length - 1];
                    Console.WriteLine($"Current Word: {currentWord}");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}