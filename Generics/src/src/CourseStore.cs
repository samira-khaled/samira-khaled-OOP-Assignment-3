
using System.Collections.Generic;

namespace src
{
    public class CourseStore
    {
        private List<Course> courses = new List<Course>();

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public Course GetById(int id)
        {
            foreach (var c in courses)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }

            return null;
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Remove(int id)
        {
            Course course = GetById(id);

            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}
