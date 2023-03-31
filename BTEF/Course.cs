using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTEF
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CourseID302 { get; set; }
        public string Title302 { get; set; }
        public int Credits302 { get; set; }

        public ICollection<Enrollment> Enrollments302 { get; set; }
    }
}
