using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkShortnerNew.Data.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid? DepartmentID { get; set; }  // Foreign key for Department
        public int Age { get; set; }
        public string Phone { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public Guid? ManagerID { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(DepartmentID))]

        public Department? Departments { get; set; }
    }
}
