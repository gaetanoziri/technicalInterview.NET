using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.studentclass
{
    public class Class
    {

        private readonly List<Student> students;

        public Class(List<Student> students)
        {
            this.students = students;
        }

        public Class()
        {
            this.students = GenerateStudents(10);
        }

        public Student GetBestStudent()
        {
            Student best = students[0];
            foreach (Student student in students)
            {
                if (student.Grade > best.Grade)
                {
                    best = student;
                }

            }
            return best;
        }

        public Student GetWorsStudent()
        {
            Student wors = students[0];
            foreach (Student student in students)
            {
                if (student.Grade < wors.Grade)
                {
                    wors = student;
                }

            }
            return wors;
        }

        /// <summary>
        /// Return the list of the student with the grade with ascending order
        /// </summary>
        /// <returns></returns>
        public List<Student> GetOrderedStudentList()
        {
            students.Sort((a, b) => a.CompareTo(b));
            return students;
        }

        static List<Student> GenerateStudents(int count)
        {
            List<Student> students = new List<Student>(count);
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                students[i] = new Student("Student " + i, random.Next(0, 30));
            }
            return students;
        }

    }
}
