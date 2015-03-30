using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBased_AA30Mart
{
    public class ItsAlmostAStack<T>
    {

        private List<T> items = new List<T>();
        int size = 0;

        public void Push(T item)
        {
            items.Add(item);
            size++;
        }

        public T Pop()
        {
            if (items.Count > 0)
            {
                T temp = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return temp;
            }
            else
                return default(T);
        }

        public void Remove(int itemAtPosition)
        {
            items.RemoveAt(itemAtPosition);
            size--;
        }

        public int listSize()
        {
            return size;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            ItsAlmostAStack<int> stk = new ItsAlmostAStack<int>();
            stk.Push(15);
            stk.Push(18);

            Console.WriteLine("Silmeden once boyut : "+ stk.listSize());

            stk.Remove(1);

            Console.WriteLine("Sildikten sonra boyut : " + stk.listSize());

            Console.WriteLine(stk.Pop());
            Console.ReadKey();


        }
    }
}
