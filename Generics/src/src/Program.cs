using System;
using System.Collections.Generic;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store<Student> students = new Store<Student>();

            students.Add(new Student(1, "Ahmed"));
            students.Add(new Student(2, "Mona"));
            students.Add(new Student(3, "Ali"));
            students.Add(new Student(4, "Sara"));
            students.Add(new Student(5, "Omar"));

            Store<Course> courses = new Store<Course>();

            courses.Add(new Course(101, "CSharp", 1000m));
            courses.Add(new Course(102, "SQL", 800m));
            courses.Add(new Course(103, "ASP.NET", 1500m));

            // Get one student and one course by ID
            Student student = students.GetById(2);
            Course course = courses.GetById(102);

            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Course: {course.Title}");

            // Try to add a duplicate student ID
            try
            {
                students.Add(new Student(2, "Duplicate"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Print page 2 with page size 2
            Console.WriteLine("Page 2:");

            foreach (KeyValuePair<int, Student> entry
         in students.GetAll().Page(2, 2))
            {
                Student item = entry.Value;
                Console.WriteLine($"{item.Id} - {item.Name}");
            }

            // FindById on a regular List<Course>
            List<Course> courseList = new List<Course>
            {
                new Course(201, "OOP", 900m),
                new Course(202, "Database", 700m),
                new Course(203, "Networks", 600m)
            };

            Course foundCourse = courseList.FindById(202);

            Console.WriteLine($"Found course: {foundCourse?.Title}");

            // must NOT compile
            // new Store<string>();
        }
    }
}