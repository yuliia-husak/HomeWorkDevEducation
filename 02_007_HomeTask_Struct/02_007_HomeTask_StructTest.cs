using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.IO;

namespace _02_007_HomeTask_Struct
{
    [TestFixture]
    class _02_007_HomeTask_StructTest
    {
        [Test]
        public void CountStudent()
        {
            string[] inputData = File.ReadAllLines("TextInput.txt");
            Student[] students = new Student[inputData.Length];            

            Assert.AreEqual(0, students.Length);
        }

        [Test]
        public void CountStudent2()
        {
            string[] inputData2 = File.ReadAllLines("TextInput2.txt");
            Student[] students = new Student[inputData2.Length];

            Assert.AreEqual(2, students.Length);
        }

        [Test]
        public void CountStudentAdd()
        {
            Student student1 = new Student("Sepon I.B.", "PO", 2, "PSD", 1, 2, 3, 4, 5);
            Student[] stud = new Student[1];
            stud[0] = student1;
            string[] linesToSave = new string[stud.Length + 1];
            for (int i = 0; i < stud.Length; i++)
            {
                Student student = stud[i];
                linesToSave[i] = student.ToString();
            }
            File.AppendAllLines("TextInput.txt", linesToSave);
            Assert.AreEqual(1, stud.Length);
        }

        [Test]
        public void CountStudent4and5()
        {
            Student student1 = new Student("Sepon I.B.", "PO", 2, "PSD", 1, 2, 3, 4, 5);
            Student[] stud = new Student[1];
            stud[0] = student1;
            string[] linesToSave = new string[stud.Length + 1];
            for (int i = 0; i < stud.Length; i++)
            {
                Student student = stud[i];
                linesToSave[i] = student.ToString();
            }
            File.AppendAllLines("TextInput.txt", linesToSave);
            Assert.AreEqual(1, stud.Length);
        }
    }
}
