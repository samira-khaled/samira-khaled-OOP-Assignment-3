using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
     public class Store<T> where T : IHasId
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
                    if (item.Id == id)
                    {
                        return item;
                    }
                }

                return default(T);
            }

            public List<T> GetAll()
            {
                return items;
            }

            public void Remove(int id)
            {
            T Item = GetById(id);

            if (Item != null)
            {
                items.Remove(Item);
            }
        }
     }
}
