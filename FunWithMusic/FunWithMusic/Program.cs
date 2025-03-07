namespace FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            Pop,
            Rock,
            Metal,
            Rap,
            Alt
        }
        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private double _Length;
            private Genre? _Genre;

            public Music(string title, string artist, string album, double length, Genre? genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length/60;
                _Genre = genre;
            }

            public void setTitle(string title)
            {
                _Title = title;
            }

            public void setLength(double len)
            {
                _Length = len;
            }

            public string Display()
            {
                return "Title: " + _Title + "\nArtist: " + _Artist + "\nAlbum: " + _Album + "\nLength (in mins): " + _Length + "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArt = Console.ReadLine();
            Console.WriteLine("What is the album it's in?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length (in seconds)?");
            string tempLen = Console.ReadLine();
            double len;
            while (!double.TryParse(tempLen, out len))
            {
                Console.WriteLine("Not a valid number! Try again.");
                Console.WriteLine("What is the length, in seconds?");
                tempLen = Console.ReadLine();
            }
            Console.WriteLine("What is the genre?");
            Console.WriteLine("P - Pop\nK - Rock\nM - Metal\nR - Rap\nA - Alt");
            Genre tempGenre = Genre.Pop;
            char g = char.ToUpper(char.Parse(Console.ReadLine()));
            while (g != 'P' || g != 'K' || g != 'M' || g != 'R' || g != 'A')
            {
                Console.WriteLine("Input was not one of the options. Please try again.");
                Console.WriteLine("What is the genre?");
                Console.WriteLine("P - Pop\nK - Rock\nM - Metal\nR - Rap\nA - Alt");
                g = char.ToUpper(char.Parse(Console.ReadLine()));
            }
            switch (g)
            {
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'K':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'A':
                    tempGenre = Genre.Alt;
                    break;
            }
            Music music = new Music(tempTitle, tempArt, tempAlbum, len, tempGenre);
            Music moreMusic = music;
            Console.WriteLine("What's the title of the next song in the album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What's the length of that song?");
            tempLen = Console.ReadLine();
            while (!double.TryParse(tempLen, out len))
            {
                Console.WriteLine("Input was not a valid number. Please try again!");
                Console.WriteLine("What's the length of that song?");
                tempLen = Console.ReadLine();
            }
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
