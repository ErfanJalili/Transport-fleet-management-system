﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class CarStatus
    {

        public int Id { get; set; }
        public string StatusName { get; set; }
        public int PercentageError{ get; set; }

    }
}
