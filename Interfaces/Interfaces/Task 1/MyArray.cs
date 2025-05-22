using Interfaces.Task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class MyArray : IOutput, IMath
    {
        private int[] array;

        public MyArray(int[] array)
        {
            this.array = array;
        }

        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
            Console.WriteLine($"Info: {info}");
        }
        public int Max()
        {
            if (array.Length == 0) throw new InvalidOperationException("Array is empty");
            return array.Max();
        }
        public int Min()
        {
            if (array.Length == 0) throw new InvalidOperationException("Array is empty");
            return array.Min();
        }
        public float Avg()
        {
            if (array.Length == 0) throw new InvalidOperationException("Array is empty");
            return (float)array.Average();
        }
        public bool Search(int valueToSearch)
        {
            return array.Contains(valueToSearch);
        }
         public void SortAsc()
         {
            Array.Sort(array);
         }
        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public void SortByParam(bool isAsc)
        {
            if(isAsc)
            {
               SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

    }
}
