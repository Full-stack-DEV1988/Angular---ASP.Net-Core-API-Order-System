﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VFactoriesForOrdersWithSeason
    {
        public string Idorder { get; set; }
        public string Customer { get; set; }
        public int? SeasonId { get; set; }
        public string T1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
    }
}
