using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Dtos
{
    public class DepartmentDto
    {
        public short Id { get; set; }
        public string? AssetId { get; set; }
        public string DepartmentName { get; set; }
    }
}
