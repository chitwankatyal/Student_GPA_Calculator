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
    public static class GradeUtils
    {
        //Methods
        public static string GpaToLetter(double gpa)
        {
            string letterGrade = "";

            if (gpa == 4.5)
            {
                letterGrade = "A+";
            }
            else if (gpa >= 4.0 && gpa <= 4.4)
            {
                letterGrade = "A";
            }
            else if (gpa >= 3.5 && gpa <= 3.9)
            {
                letterGrade = "B+";
            }
            else if (gpa >= 3.0 && gpa <= 3.4)
            {
                letterGrade = "B";
            }
            else if (gpa >= 2.5 && gpa <= 2.9)
            {
                letterGrade = "C+";
            }
            else if (gpa >= 2.0 && gpa <= 2.4)
            {
                letterGrade = "C";
            }
            else if (gpa >= 1.5 && gpa <= 1.9)
            {
                letterGrade = "D+";
            }
            else if (gpa >= 1.0 && gpa <= 1.4)
            {
                letterGrade = "D";
            }
            else if (gpa >= 0.0 && gpa <= 0.9)
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
        public static double LetterToGpa(string letter)
        {
            double gpa = 0.0;

            if (letter.ToUpper() == "A+")
            {
                gpa = 4.5;
            }
            else if (letter.ToUpper() == "A")
            {
                gpa = 4.0;
            }
            else if (letter.ToUpper() == "B+")
            {
                gpa = 3.5;
            }
            else if (letter.ToUpper() == "B")
            {
                gpa = 3.0;
            }
            else if (letter.ToUpper() == "C+")
            {
                gpa = 2.5;
            }
            else if (letter.ToUpper() == "C")
            {
                gpa = 2.0;
            }
            else if (letter.ToUpper() == "D+")
            {
                gpa = 1.5;
            }
            else if (letter.ToUpper() == "D")
            {
                gpa = 1.0;
            }
            else if (letter.ToUpper() == "F")
            {
                gpa = 0.0;
            }
            return gpa;
        }
        public static string ToLetterGrade(double number)
        {
            string letterGrade = "";

            if (number >= 90 && number <= 100)
            {
                letterGrade = "A+";
            }
            else if (number >= 80 && number <= 89)
            {
                letterGrade = "A";
            }
            else if (number >= 75 && number <= 79)
            {
                letterGrade = "B+";
            }
            else if (number >= 70 && number <= 74)
            {
                letterGrade = "B";
            }
            else if (number >= 65 && number <= 69)
            {
                letterGrade = "C+";
            }
            else if (number >= 60 && number <= 64)
            {
                 letterGrade = "C";
            }
            else if (number >= 55 && number <= 59)
            {
                letterGrade = "D+";
            }
            else if (number >= 50 && number <= 54)
            {
                letterGrade = "D";
            }
            else if (number >= 0 && number <= 49)
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
    }
}
