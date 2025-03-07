namespace ClubInterface
{
    interface IClub
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string FullName();
    }

    internal class Program
    {

        class GamingClub : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int numMembers;
            public string clubName;
            public int roomNum;

            public GamingClub(int numMembers, string clubName, int roomNum, int id, string first, string last)
            {
                this.numMembers = numMembers;
                this.clubName = clubName;
                this.roomNum = roomNum;
                Id = id;
                FirstName = first;
                LastName = last;
            }

            public GamingClub()
            {
                numMembers = 7;
                clubName = "Kranatos";
                roomNum = 120;
                Id = 20;
                FirstName = "Kevin";
                LastName = "Licerice";
            }

            public string FullName()
            {
                return FirstName + " " + LastName;
            }

            public void stats()
            {
                Console.WriteLine($"Name: {clubName}. Room: {roomNum}. ID: {Id}. Members: {numMembers}.");
            }
        }

        static void Main(string[] args)
        {
            GamingClub club = new GamingClub();

            club.stats();
        }
    }
}
