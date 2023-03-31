using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTEF
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID302 { get; set; }
        public int CourseID302 { get; set; }
        public int StudentID302 { get; set; }
        public Grade? Grade302 { get; set; }

        public Course Course302 { get; set; }
        public Student Student302 { get; set; }
    }
}
