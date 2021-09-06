using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Submitted By: Chitwan Katyal
 * Student ID: 301169422
 * COMP123-011
 * Assignment 02
 */

namespace Comp123_ckatyal_Assign02
{
   public class Student
    {
        //Properties
        public string FirstName { get; set; }
        public double GPA
        {
            get
            {
                return AverageGPA();
            }
        }
        
        public List<Grade> Grades { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }

        //Methods
        private double AverageGPA()
        {
            foreach (Grade grade in Grades)
            {
                grade.LetterGrade = GradeUtils.ToLetterGrade(grade.NumberGrade);
            }

            double gpa = 0.0;

            foreach (Grade grade2 in Grades)
            {
                gpa += GradeUtils.LetterToGpa(grade2.LetterGrade);
            }

            double average = gpa / 3;
            return average;
            
        }
    }
}
