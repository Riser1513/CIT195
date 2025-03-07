namespace MusicArray
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
                _Length = length / 60;
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

            public void setAlbum(string alb)
            {
                _Album = alb;
            }

            public void setArtist(string art)
            {
                _Artist = art;
            }

            public void setGenre(Genre? gen)
            {
                _Genre = gen;
            }

            public string Display()
            {
                return "Title: " + _Title + "\nArtist: " + _Artist + "\nAlbum: " + _Album + "\nLength (in mins): " + _Length + "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            string tempInt = Console.ReadLine();
            int size;
            while (!int.TryParse(tempInt, out size))
            {
                Console.WriteLine("That's not a valid number, silly.");
                Console.WriteLine("How many songs would you like to enter?");
                tempInt = Console.ReadLine();
            }
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of your favorite song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album it's in?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length (in seconds)?");
                    string tempLen = Console.ReadLine();
                    double len;
                    while (!double.TryParse(tempLen, out len))
                    {
                        Console.WriteLine("Not a valid number! Try again.");
                        Console.WriteLine("What is the length, in seconds?");
                        tempLen = Console.ReadLine();
                    }
                    collection[i].setLength(len);
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
                            collection[i].setGenre(Genre.Pop);
                            break;
                        case 'K':
                            collection[i].setGenre(Genre.Rock);
                            break;
                        case 'M':
                            collection[i].setGenre(Genre.Metal);
                            break;
                        case 'R':
                            collection[i].setGenre(Genre.Rap);
                            break;
                        case 'A':
                            collection[i].setGenre(Genre.Alt);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(collection[i].Display());
                }
            }
        }
    }
}
