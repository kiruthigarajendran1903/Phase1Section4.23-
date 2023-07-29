using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._23
{
    internal class Program
    {
        public static void Array(string[] arr)
        {
            int n = arr.Length;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j =1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] =arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("After Selection Sort");
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }

static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Elemets");
            int n = int.Parse(Console.ReadLine());
            string[] Arr = new string[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = Console.ReadLine();

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Array(Arr);
            Console.ReadKey();
        }
    }
}
