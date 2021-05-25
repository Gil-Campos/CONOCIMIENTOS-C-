using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParameterizedConstructor
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string college { get; set; }

        //Default constructor
        public Student()
        {
            college = "Universdad UCA";

        }

        //Parameterized constructor
        public Student(int studentID, string studentName, string college)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.college = college;
        }

        //Constructor overloading
        public Student(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine($"Student ID: {st.studentID}, Name: {st.studentName}, College: {st.college}");

            //Student st = new Student(1, "Martin Romero", "UCA El Salvador");
            //Console.WriteLine($"student id: {st.studentID}, name: {st.studentName}, college: {st.college}");

            //Student st = new Student(1, "Martin Romero";
            //Console.WriteLine($"student id: {st.studentID}, name: {st.studentName}, college: {st.college}");

            Console.ReadKey();
        }
    }
}
