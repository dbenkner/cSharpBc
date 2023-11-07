using System.ComponentModel.DataAnnotations;

namespace StudentsWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
    }
}
