

using System.ComponentModel.DataAnnotations.Schema;


namespace Eurofins.GMA.Domain.Entities
{
    [Table("Departments")]
    public partial class Department : AuditEntity<short>
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public string DepartmentName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
