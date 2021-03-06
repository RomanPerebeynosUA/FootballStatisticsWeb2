﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStatisticsWeb2.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set;  }
        public string Nationality { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }              
    }
}
