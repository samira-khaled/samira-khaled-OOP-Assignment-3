using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class StudentStore
    {
      private  List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }
        
        public Student GetById(int id)
        {
            foreach(var s in students)
            {
                if (s.Id == id)
                {
                    return s;
                }     
            }
            return null;

        }
        public List<Student> GetAll()
        {
            return students;

        }
        public void Remove(int id)
        {
            Student student = GetById(id);

            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
}
