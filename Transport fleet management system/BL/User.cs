using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationCode { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public DateTime? InsertDate { get; set; }
    }
}
