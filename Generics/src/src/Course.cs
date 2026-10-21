using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace src
{
    public class Course:IHasId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Course(int id,string title,decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            
        }
    }
}
