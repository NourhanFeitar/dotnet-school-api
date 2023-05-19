using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Course")]
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }=string.Empty;
        public int creditHours { get; set; }

    }
}
