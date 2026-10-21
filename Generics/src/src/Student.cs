using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Student:IHasId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int Id,String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
