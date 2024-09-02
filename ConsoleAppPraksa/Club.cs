using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPraksa
{
    public abstract class Club:IClub
    {

        public Club() { }
        public Club(string name) { }

        public string? Name { get; set; }

        public string? City { get; set; }

        public DateOnly? DateOfEstablishment { get; set; }

        public int CalculateClubAge()
        {
            var todayDate = DateOnly.FromDateTime(DateTime.Now);
            if (DateOfEstablishment.Equals(todayDate) || DateOfEstablishment == null)
            {
                return 0;
            }
            else
            {
                var age = todayDate.Year - this.DateOfEstablishment.Value.Year;
                if(todayDate < DateOfEstablishment.Value.AddYears(age))
                {
                    age--;
                }
                return age;
                
            }
                
        }

        public abstract string? WriteClubInfo();
    }
}
