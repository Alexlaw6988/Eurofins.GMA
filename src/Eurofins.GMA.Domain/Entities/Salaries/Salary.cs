
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eurofins.GMA.Domain.Entities
{
    [Table("Salaries")]
    public partial class Salary : AuditEntity<long>
    {
        public Salary()
        {

        }
        public int UserId { get; set; }
        public float CoefficientsSalary { get; set; }
        public float WorkDays { get; set; }
        public decimal TotalSalary { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
