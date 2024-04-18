using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//CSI 120
//Lab Nine
//03.09.2024

namespace LabNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3 
            Student student1 = new Student()
            {
                FirstName = "James",
                LastName = "Hollingshead",
                StudentID = 1,
                Email = "James@gmail.com",
                Phone = "(000) 000-0000",
            };
            Student student2 = new Student()
            {
                FirstName = "Samson",
                LastName = "Dauda",
                StudentID = 2,
                Email = "Samson@gmail.com",
                Phone = "(000) 000-0001",
            };
            Student student3 = new Student()
            {
                FirstName = "Justin",
                LastName = "Shier",
                StudentID = 3,
                Email = "Justin@gmail.com",
                Phone = "(000) 000-0002",
            };
            Student student4 = new Student()
            {
                FirstName = "Chris",
                LastName = "Cormier",
                StudentID = 4,
                Email = "James@gmail.com",
                Phone = "(000) 000-0003",
            };
            //Task 4
            Course Math = new Course()
            {
                CourseName = "Math",
                InstructorName = "Hany",
                RoomNumber = 1,
                CourseID = 1,
                Students = new List<Student>() { student1, student2 },
            };
            Course English = new Course()
            {
                CourseName = "English",
                InstructorName = "Patrick",
                RoomNumber = 2,
                CourseID = 2,
                Students = new List<Student>() { student2, student3 },
            };
            Course Science = new Course()
            {
                CourseName = "Science",
                InstructorName = "Milos",
                RoomNumber = 3,
                CourseID = 3,
                Students = new List<Student>() { student3, student4 },
            };
            //Task 5
            List<Course> courses = new List<Course>() { Math, English, Science };
            PrintCourse(courses);
            FindCourseByInstructor(courses, "James");
            //Note that courses is permanently changed
            PrintCourse(courses);
            //Keep terminal open
            Console.ReadLine();
        }
        //Task 5 part 2. I am confused by this question i am not sure if this is what i was supposed to do
        public static void PrintCourse(List<Course> courses)
        {
            Console.WriteLine("Which course would you like to look at?");
            //Print course names
            for (int k = 0; k < courses.Count; k++)
            {
                Console.Write(courses[k].CourseName + ", ");
            }
            while (true)
            {
                String userInput = Console.ReadLine();
                //Tracks if userInput was found in courses
                bool found = false;
                //Loop through array to look for userInput
                for (int k = 0; k < courses.Count; k++)
                {
                    //Runs if userInput is found
                    if (userInput == courses[k].CourseName)
                    {
                        found = true;
                        Console.WriteLine(courses[k]);
                        //Loops and prints through student list
                        for (int i = 0; i < courses[k].Students.Count; i++)
                        {
                            Console.WriteLine($"Student {i + 1}: {courses[k].Students[i]}");
                        }
                    }
                }
                //Exits out of loop once course was printed
                if (found)
                {
                    break;
                }
                //Loops again if userInput wasnt found
                else
                {
                    Console.WriteLine("Please input a valid course name");
                }
            }
        }
        //Task 6
        public static Student FindStudentByID(List<Student> students, int StudentID)
        {
            for (int k = 0; k < students.Count; k++)
            {
                if (students[k].StudentID == StudentID)
                {
                    return students[k];
                }
            }
            return null;
        }
        //Task 7
        public static bool isStudentEnrolled(Course course, int studentID)
        {
            for (int k = 0; k < course.Students.Count; k++)
            {
                if (course.Students[k].StudentID == studentID)
                {
                    return true;
                }
            }
            return false;
        }
        //Task 8
        public static List<Course> FindCourseByInstructor(List<Course> courses, String instructorName)
        {
            for (int k = 0; k <  courses.Count; k++)
            {
                //Removes all elements which dont match instructor name
                if (courses[k].InstructorName  != instructorName)
                {
                    courses.Remove(courses[k]);
                }
            }
            return courses;
        }
    }
    //Task 1
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int StudentID { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        
        //Task 3 Part 2. Doesnt take student as a parameter though
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, StudentID: {StudentID}, Email: {Email}, Phone: {Phone}";
        }
    }
    //Task 2
    public class Course
    {
        public String CourseName { get; set; }
        public String InstructorName { get; set; }
        public int RoomNumber { get; set; }
        public int CourseID { get; set; }
        public List<Student> Students { get; set; }
        public override string ToString()
        {
            //Students are printed in PrintCourse Method
            return $"CourseName: {CourseName}, IntructorName: {InstructorName}, RoomNumber {RoomNumber}, CourseID {CourseID}";
        }
    }
}
