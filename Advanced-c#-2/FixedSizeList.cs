using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_c__2
{
    internal class FixedSizeList<M> : List<M>
    {
        List<M> list;
        public FixedSizeList(int size) : base(size)
        {
            list = new List<M>(size);
        }
        public  void Add(M item)
        {
            if (list.Count == Capacity)
            {
                Console.WriteLine("List is full");
            }
            else
            {
                list.Add(item);
            }
        }
        public M Get(int index) {

            if (index <= list.Count) {
                return list[index];
            }
            else
            {
                Console.WriteLine("Index out of range");
                return default;
            }


        }
    }
}
