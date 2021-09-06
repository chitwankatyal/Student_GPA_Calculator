using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
 * Submitted By: Chitwan Katyal
 * Student ID: 301169422
 * COMP123-011
 * Assignment 02
 */

namespace Comp123_ckatyal_Assign02
{
    class Program
    {
        public static StudentRepository _studentRepository;

        //Methods
        static void Main(string[] args)
        {
            _studentRepository = new StudentRepository();

            //Displaying student menu
            List<Student> students = _studentRepository.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].FirstName} {students[i].LastName}");
            }


            string value = "";

            while(value.ToUpper() != "X")
            {
                Console.WriteLine("\nSelect a student number to view their grades and GPA, G to view all students' GPAs, or X to exit. ");
                value = Console.ReadLine();

                if (value.ToUpper() == "X")
                {
                    Console.WriteLine("Goodbye.");
                    Console.ReadKey();

                    return;
                }

                else if (IsValidInput(value.ToUpper()))
                {
                    HandleInput(value);
                    Console.WriteLine();

                    Console.WriteLine("Press any key to continue, or X to exit.");
                    string input = Console.ReadLine();

                    if (input.ToUpper() == "X")
                    {
                        Console.WriteLine("Goodbye.");
                        Console.ReadKey();

                        return;
                    } 
                }
                else
                {
                    Console.WriteLine($"{value} is an invalid input. Try again!");
                }
            }
            Console.ReadKey();
        }
        public static void HandleInput(string input)
        {
            Student student = new Student();
            List<Student> students = _studentRepository.GetStudents();
            List<Grade> grades = new List<Grade>();

            int num;
            if(int.TryParse(input, out num))
            {
                student = _studentRepository.GetStudent(input);
                grades = student.Grades;
            }
            
            switch(input.ToUpper())
            {
                case "1":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for(int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "2":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "3":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "4":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "5":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "6":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "7":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "8":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "9":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "10":
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                    Console.WriteLine("==========");

                    for (int i = 0; i < grades.Count; i++)
                    {
                        Console.WriteLine($"{grades[i].CourseTitle}: {grades[i].NumberGrade}, {GradeUtils.ToLetterGrade(grades[i].NumberGrade)}");
                    }
                    Console.WriteLine($"{student.FirstName}'s GPA is {student.GPA:f1} or {GradeUtils.GpaToLetter(student.GPA)}");
                    break;

                case "G":
                    for(int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine($"{students[i].FirstName} {students[i].LastName} has a {students[i].GPA:f1} GPA");
                    }
                    break;
            }
        }
        public static bool IsValidInput(string input)
        {
            int numberInput;

            if(int.TryParse(input, out numberInput))
            {
                if(numberInput >= 1 && numberInput <= 10)
                {
                    return true;
                }
            }
            else if(input.ToUpper() == "G")
            {
                return true;
            }
            return false;
        }
    }
}
