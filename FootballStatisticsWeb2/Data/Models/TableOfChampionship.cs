using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStatisticsWeb2.Data.Models
{
    public class TableOfChampionship
    {
        public int Id { get; set; }
        public string Season { get; set; }

        public int champshipID { get; set; }
        public Championship champship { get; set; }




    }
}
