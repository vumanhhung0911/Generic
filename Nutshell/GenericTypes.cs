using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell
{
    public class Stack<T>
    {
        int pos = 0;
        T[] data = new T[100];
        public void Push(T obj) { data[pos++] = obj; }
        public T Pop() { return data[--pos]; }

    }
    class GenericTypes
    {
        static void Main(string[] arg)
        {
            Stack<float> stack = new Stack<float>();
            stack.Push(15.5f);
            stack.Push(13.5f);
            stack.Push(12.5f);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.Read();
        }
    }
}
