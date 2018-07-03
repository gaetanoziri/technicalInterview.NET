using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.studentclass
{
    public class Student : IComparable<Student>
    {
        private int grade;
        private string name;

        public int Grade { get => grade; set => grade = value; }
        public string Name { get => name; set => name = value; }

        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public int CompareTo(Student other)
        {
            // TODO: implements the method
            throw new NotImplementedException();
        }
    }
}
