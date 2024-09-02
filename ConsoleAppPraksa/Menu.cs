using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPraksa
{
    public class Menu
    {
        private List<Club> clubs = new List<Club>();

        public void AddNewFootballClub()
        {
            FootballClub footballClub = new FootballClub();
            Console.WriteLine("Name of the club:");
            footballClub.Name = Console.ReadLine().ToLower();

            Console.WriteLine("City:");
            footballClub.City = Console.ReadLine().ToLower();

            Console.WriteLine("Date of establishment:");
            string? input = Console.ReadLine();
            footballClub.DateOfEstablishment = DateOnly.TryParse(input, out DateOnly result) ? result : null;

            clubs.Add(footballClub);
        }

        public void RemoveClub()
        {
            Console.WriteLine("Name of the club:");
            var result = Console.ReadLine().ToLower();
            var itemToRemove = clubs.FirstOrDefault(x => x.Name == result);
            clubs.Remove(itemToRemove);
        }

        public void PrintAllClubs()
        {
            if (!(clubs.Count > 0))
            {
                Console.WriteLine("There is no clubs on the list.");
            }
            foreach (Club club in clubs)
            {
                Console.WriteLine(club.Name + ", " + club.City + ", " + club.DateOfEstablishment);
            }
        }

        public void WriteAllClubsOlderThen()
        {
            Console.WriteLine("Age of the club:");
            var age = Convert.ToInt32(Console.ReadLine());
            var olderClubs = from c in clubs
                             where c.CalculateClubAge() > age
                             select c;
            foreach(Club club in olderClubs)
            {
                Console.WriteLine(club.Name);
            }
        }

        public void FilterByCity()
        {
            Console.WriteLine("City:");
            var city = Console.ReadLine().ToLower();
            var filteredClubs = from club in clubs
                                where club.City == city
                                select club;
            foreach (var club in filteredClubs)
            {
                Console.WriteLine(club.Name);
            }
        }


        public void SortClubsByDateOfEstablishment()
        {
            var sortedClubs = from club in clubs
                              orderby club.DateOfEstablishment
                              select club;
            sortedClubs.ToList().ForEach(club => Console.WriteLine(club.Name));
        }


        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Add new football club");
            Console.WriteLine("2: Remove football club");
            Console.WriteLine("3: Print all clubs");
            Console.WriteLine("4: Print all clubs older then ...");
            Console.WriteLine("5: Filter by city");
            Console.WriteLine("6: Sort clubs by date of establishment");
        }
    }
}
