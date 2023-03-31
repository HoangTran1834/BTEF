using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTEF
{
    public class Student
    {
        [Key]
        public int ID302 { get; set; }
        public string LastName302 { get; set; }
        public string FirstMidName302 { get; set; }
        public DateTime EnrollmentDate302 { get; set; }

        public ICollection<Enrollment> Enrollments302 { get; set; }
    }
}
