﻿using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Death
    {
        public Date Date { get; set; }
        public int Level { get; set; }
        public string Reason { get; set; }
        public IEnumerable<Involved> Involved { get; set; }
    }
}
