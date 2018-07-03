using Microsoft.VisualStudio.TestTools.UnitTesting;
using technicalInterview.studentclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.studentclass.Tests
{
    [TestClass()]
    public class ClassTests
    {
        List<Student> students = null;
        Class classRoom = null;

        [TestInitialize()]
        public void Initialize()
        {
            students = new List<Student>()
            {
                new Student("A", 10),
                new Student("B", 1),
                new Student("C", 20)
            };
            classRoom = new Class(students);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            this.students = null;
            this.classRoom = null;
        }

        [TestMethod()]
        public void GetOrderedStudentListTest()
        {
            Assert.AreEqual(classRoom.GetOrderedStudentList()[0].Name, "C");
            Assert.AreEqual(classRoom.GetOrderedStudentList()[1].Name, "A");
            Assert.AreEqual(classRoom.GetOrderedStudentList()[2].Name, "B");
        }

        [TestMethod()]
        public void GetWorsStudentTest()
        {
            Assert.AreEqual(classRoom.GetWorsStudent().Name, "B");
        }

        [TestMethod()]
        public void GetBestStudentTest()
        {
            Assert.AreEqual(classRoom.GetBestStudent().Name, "C");
        }
    }
}