using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkShortnerNew.Data.Entities
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid DepartmentID { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public bool? IsActive { get; set; }  // Assuming a manager is also an employee
    }
}
