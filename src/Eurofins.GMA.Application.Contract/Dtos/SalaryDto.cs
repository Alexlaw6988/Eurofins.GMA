using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Dtos
{
    public class SalaryDto
    {
        public long Id { get; set; }
        public string? SalaryId { get; set; }
        public int UserId { get; set; }
        public float CoefficientsSalary { get; set; }
        public float WorkDays { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
