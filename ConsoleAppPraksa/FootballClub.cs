using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPraksa
{
    public class FootballClub: Club
    {

        public override string? WriteClubInfo()
        {
            return $"{this.Name}, football club in {this.City}";
        }
    }
}
