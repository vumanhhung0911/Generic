using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell
{
    
    class Program
    {
        public interface IComparable<T>
        {
            int CompareTo(T other);
        }
        static void Initialize<T>(T[] array)where T : new()
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = new T();
        }
        static T Max <T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        static void Main(string[] args)
        {
            //int z = Max(5,10 );
            //string last = Max("ant", "zoo");
        }
    }
}
