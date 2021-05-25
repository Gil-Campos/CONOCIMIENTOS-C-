using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    //Class
    class Student
    {
        //fields
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }

        //Methods
        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine($"StudentID: {studentID}, Name: {studentName}, Address: {studentAddress}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Object 
            Student st = new Student();
            st.studentID = 1;
            st.studentName = "Bob Stuart";
            st.studentAddress = "Las Vegas, Nevada";

            st.ShowDetails();
            Console.ReadKey();
        }
    }
}
