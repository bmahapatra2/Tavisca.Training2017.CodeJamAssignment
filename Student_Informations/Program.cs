﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detail
{
    public class Student_Details
    {
        static void Main(string[] args)
        {
            Student_Validation student_validation = new Student_Validation();
            Student_Details Student_Details = new Student_Details();
            Student_Details.Display(student_validation);
                
        }

        void Display(Student_Validation validationObject)
        {
            Console.WriteLine("Enter name of the student :");
            string name = Console.ReadLine();
            Console.WriteLine("enter class of student:");
            int Class = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter section of student:");
            string section = Console.ReadLine();
            Console.WriteLine("Enter roll number of student:");
            int roll_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter university name:");
            string university_name = Console.ReadLine();
            Console.WriteLine("Enter age of the student:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Name of the student : {0}", name);
            Console.WriteLine(" Class of the student : {0}", Class);
            Console.WriteLine(" Age of the student : {0}", age);
            Console.WriteLine(" Section of the student : {0}", section);
            validationObject.Rollnumber(roll_number);
            Console.WriteLine(" Roll number of the student : {0}", roll_number);
            Console.WriteLine(" University of the student : {0}", university_name);
            Console.ReadLine();





        }
        
    }
}