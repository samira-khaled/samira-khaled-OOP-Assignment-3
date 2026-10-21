using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
     public class Store<T>
     {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T GetById(int id)
            {
                foreach (var item in items)
                {
                    if (item.id == id)
                    {
                        return item;
                    }
                }

                return null;
            }

            public List<T> GetAll()
            {
                return items;
            }

            public void Remove(int id)
            {
                item course = GetById(id);

                if (course != null)
                {
                    courses.Remove(course);
                }
            }
        }
    }
