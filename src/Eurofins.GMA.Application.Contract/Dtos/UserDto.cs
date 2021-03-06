using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public short DepartmentId { get; set; }
    }
}
