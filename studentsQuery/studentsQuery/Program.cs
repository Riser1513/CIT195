using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsQuery
{
    internal class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Major { get; set; }
            public double Tuition { get; set; }
        }
        public class StudentClubs
        {
            public int StudentID { get; set; }
            public string ClubName { get; set; }
        }
        public class StudentGPA
        {
            public int StudentID { get; set; }
            public double GPA { get; set; }
        }
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 5, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 6, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 7, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
            };
            // Student GPA Collection
            IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };
            // Club collection
            IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
            };
            var groupGPAIDs = studentGPAList.GroupBy(s => s.GPA);
            foreach (var student in groupGPAIDs)
            {
                foreach (StudentGPA id in student)
                {
                    Console.WriteLine(id.StudentID);
                }
            }
            var groupClubIDs = studentClubList.OrderBy(s => s.ClubName).GroupBy(s => s.ClubName);
            foreach (var student in groupClubIDs)
            {
                foreach (StudentClubs id in student)
                {
                    Console.WriteLine(id.StudentID);
                }
            }
            var numBet254 = studentGPAList.Count(s => s.GPA < 4.0 && s.GPA > 2.5);
            Console.WriteLine(numBet254);
            var avgTuition = studentList.Average(s => s.Tuition);
            Console.WriteLine(avgTuition);
            var maxTuition = studentList.Max(s => s.Tuition);
            foreach (Student student in studentList)
            {
                if (student.Tuition >= maxTuition)
                {
                    Console.WriteLine(student.Major);
                    Console.WriteLine(student.Tuition);
                    Console.WriteLine(student.StudentName);
                }
            }
            var joinStudentGPA = studentList.Join(studentGPAList, s => s.StudentID, g => g.StudentID, (s, g) => new
            {
                Name = s.StudentName,
                Major = s.Major,
                GPA = g.GPA
            });
            foreach (var student in joinStudentGPA)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Major);
                Console.WriteLine(student.GPA);
            }
            var joinStudentClub = studentList.Join(studentClubList, s => s.StudentID, g => g.StudentID, (s, g) => new
            {
                Name = s.StudentName,
                Club = g.ClubName
            });
            foreach (var student in joinStudentClub)
            {
                if (student.Club == "Game")
                    Console.WriteLine(student.Name);
            }
        }
    }
}
