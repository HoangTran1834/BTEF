using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTEF
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students302.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName302="Carson",LastName302="Alexander",EnrollmentDate302=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName302="Meredith",LastName302="Alonso",EnrollmentDate302=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName302="Arturo",LastName302="Anand",EnrollmentDate302=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName302="Gytis",LastName302="Barzdukas",EnrollmentDate302=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName302="Yan",LastName302="Li",EnrollmentDate302=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName302="Peggy",LastName302="Justice",EnrollmentDate302=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName302="Laura",LastName302="Norman",EnrollmentDate302=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName302="Nino",LastName302="Olivetto",EnrollmentDate302=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students302.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID302=1050,Title302="Chemistry",Credits302=3},
            new Course{CourseID302=4022,Title302="Microeconomics",Credits302=3},
            new Course{CourseID302=4041,Title302="Macroeconomics",Credits302=3},
            new Course{CourseID302=1045,Title302="Calculus",Credits302=4},
            new Course{CourseID302=3141,Title302="Trigonometry",Credits302=4},
            new Course{CourseID302=2021,Title302="Composition",Credits302=3},
            new Course{CourseID302=2042,Title302="Literature",Credits302=4}
            };
            foreach (Course c in courses)
            {
                context.Courses302.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID302=1,CourseID302=1050,Grade302=Grade.A},
            new Enrollment{StudentID302=1,CourseID302=4022,Grade302=Grade.C},
            new Enrollment{StudentID302=1,CourseID302=4041,Grade302=Grade.B},
            new Enrollment{StudentID302=2,CourseID302=1045,Grade302=Grade.B},
            new Enrollment{StudentID302=2,CourseID302=3141,Grade302=Grade.F},
            new Enrollment{StudentID302=2,CourseID302=2021,Grade302=Grade.F},
            new Enrollment{StudentID302=3,CourseID302=1050},
            new Enrollment{StudentID302=4,CourseID302=1050},
            new Enrollment{StudentID302=4,CourseID302=4022,Grade302=Grade.F},
            new Enrollment{StudentID302=5,CourseID302=4041,Grade302=Grade.C},
            new Enrollment{StudentID302=6,CourseID302=1045},
            new Enrollment{StudentID302=7,CourseID302=3141,Grade302=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments302.Add(e);
            }
            context.SaveChanges();
        }
    }
}
