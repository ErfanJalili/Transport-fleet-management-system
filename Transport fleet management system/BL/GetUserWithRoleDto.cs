using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class GetUserWithRoleDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string NationCode { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public DateTime? InsertDate { get; set; }
        public string RoleName { get; set; }
    }
}
