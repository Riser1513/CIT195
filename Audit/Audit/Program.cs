namespace Audit
{
    internal class Program
    {
        class Auditor
        {
            public string Name;
            public string Number;

            public Auditor(string name, string number)
            {
                Name = name;
                Number = number;
            }
        }

        class Business
        {
            public string Name;
            public string Type;
            public string Address;
            public Auditor Audit;

            public Business(string name, string type, string address, Auditor auditor)
            {
                Name = name;
                Type = type;
                Address = address;
                Audit = auditor;
            }

            public void Display()
            {
                Console.WriteLine($"The business' name is {Name};\n The business type is {Type};\n The business address is {Address};\n The Auditor for the business is named {Audit.Name} and their phone number is {Audit.Number}.");
            }
        }

        static void Main(string[] args)
        {
            Auditor auditor = new Auditor("Adam", "231-450-3498");
            Business business = new Business("Vlincle Inc.", "Loan Shark", "8935 Leapant Rd, Kleinma, MI", auditor);

            business.Display();
        }
    }
}
