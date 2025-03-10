namespace clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 15;
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                ClubType = "Charlie";
                ClubLocation = "Manhatten";
                MeetingDate = DateTime.Now.ToString();
            }

            //indexer get and set methods

            public void getMembers()
            {
                foreach (string member in Members)
                {
                    Console.WriteLine(member);
                }
            }

            public void setMembers(string[] names)
            {
                Members = names;
            }
        }
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();
            club.setMembers(["Mark","Sebastian","Penelope","Abby","Abbigail","Lux","Luvena"]);
            Console.WriteLine($"The local club is hosting a meeting at {club.ClubLocation} on {club.MeetingDate}. The members attending are:");
            club.getMembers();
        }
    }
}
