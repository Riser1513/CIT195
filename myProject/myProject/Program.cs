namespace myProject
{
    class Game
    {
        private string _Title;
        private string _Developer;
        private static int _Copies = 0;

        public Game(string title, string developer)
        {
            _Title = title;
            _Developer = developer;
        }

        public Game()
        {

        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetDev()
        {
            return _Developer;
        }

        public void SetDev(string dev)
        {
            _Developer = dev;
        }

        public int GetCopies()
        {
            return _Copies;
        }

        public void SetCopies()
        {
            _Copies += 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();

            game1.SetCopies();
            game1.SetTitle("Terraria");
            game1.SetDev("Re-Logic");

            Game game2 = new Game("Magic","Framility");

            game2.SetCopies();

            Game game3 = new Game();

            game3.SetCopies();

            Console.WriteLine("Type a Title of a game: ");
            game3.SetTitle(Console.ReadLine());
            Console.WriteLine("Type a Developer of the game: ");
            game3.SetDev(Console.ReadLine());

            Game game4 = new Game("Klimitragha","IDK, Man");

            Console.WriteLine();

            Console.WriteLine($"There are {game1.GetCopies()} copies.");
            printGame(game1);
            printGame(game2);
            printGame(game4);
            printGame(game3);
        }

        public static void printGame(Game game)
        {
            Console.WriteLine("The Game is as follows: ");
            Console.WriteLine($"The Title is {game.GetTitle()}");
            Console.WriteLine($"The Developer is {game.GetDev()}");
            Console.WriteLine();
        }
    }
}
