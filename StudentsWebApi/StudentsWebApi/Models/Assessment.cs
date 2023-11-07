using System.ComponentModel.DataAnnotations;

namespace StudentsWebApi.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string AssessmentName { get; set; }
    }
}
