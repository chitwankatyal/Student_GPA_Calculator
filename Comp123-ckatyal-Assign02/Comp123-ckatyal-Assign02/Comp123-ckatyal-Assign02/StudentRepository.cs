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
    public class StudentRepository : IRepository
    {
        //Fields
        private string _fileName = "studentRepository.json";
        private List<Student> _students;

        //Constructor
        public StudentRepository()
        {
            LoadRepository();
        }

        //Method
        public void AddStudent(Student student)
        {
            _students.Add(student);
            SaveRepository();
        }
        public Student GetStudent(string studentId)
        {
            for(int i = 0; i < _students.Count; i++)
            {
                if(_students[i].StudentId == studentId)
                {
                    return _students[i];
                }
            }
            return null;
        }
        public List<Student> GetStudents()
        {
            return _students;
        }
        public void LoadRepository()
        {
            string seedData = "";
            if(File.Exists(_fileName))
            {
                seedData = File.ReadAllText(_fileName);
            }
            else
            {
                seedData = "[ { \"FirstName\":\"Hamed\", \"LastName\":\"Attar\", \"StudentId\":\"1\", \"Grades\":[ {\"NumberGrade\":43.4,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":76.4,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":66.7,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Saynab\", \"LastName\":\"Babatunde\", \"StudentId\":\"2\", \"Grades\":[ {\"NumberGrade\":6.0,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":83.0,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":51.4,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Habiba\", \"LastName\":\"Boulos\", \"StudentId\":\"3\", \"Grades\":[ {\"NumberGrade\":96.4,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":66.4,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":57.2,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Pons\", \"LastName\":\"Bourreau\", \"StudentId\":\"4\", \"Grades\":[ {\"NumberGrade\":43.9,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":62.8,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":64.5,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Artem\", \"LastName\":\"Boyko\", \"StudentId\":\"5\", \"Grades\":[ {\"NumberGrade\":71.3,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":80.6,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":43.4,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Apoorva\", \"LastName\":\"Chaudhri\", \"StudentId\":\"6\", \"Grades\":[ {\"NumberGrade\":79.6,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":56.4,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":72.8,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Thao\", \"LastName\":\"Ngo\", \"StudentId\":\"7\", \"Grades\":[ {\"NumberGrade\":90.0,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":82.2,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":99.3,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Silvie\", \"LastName\":\"Ó Rodagh\", \"StudentId\":\"8\", \"Grades\":[ {\"NumberGrade\":95.7,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":63.9,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":93.4,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Františka\", \"LastName\":\"Vávra\", \"StudentId\":\"9\", \"Grades\":[ {\"NumberGrade\":55.4,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":68.1,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":58.4,\"CourseTitle\":\"GHI 789\"}]}, { \"FirstName\":\"Jia\", \"LastName\":\"Yu\", \"StudentId\":\"10\", \"Grades\":[ {\"NumberGrade\":93.8,\"CourseTitle\":\"ABC 123\"}, {\"NumberGrade\":89.7,\"CourseTitle\":\"DEF 456\"}, {\"NumberGrade\":100,\"CourseTitle\":\"GHI 789\"}]} ]";
            }
            _students = JsonSerializer.Deserialize<List<Student>>(seedData);
        }
        public void SaveRepository()
        {
            string jsonString = JsonSerializer.Serialize(_students);
            File.WriteAllText(_fileName, jsonString);
        }
        
    }
}
