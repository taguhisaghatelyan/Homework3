using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Delete
    {
        public static void Deleete(int n, int[] array)
        {
            Console.WriteLine(" Which element  you want to delete? (Enter index number)");
            Console.WriteLine();
            int index = Convert.ToInt32(Console.ReadLine());
            int index1 = index - 1;

            List<int> num = new List<int>(array);
            num.RemoveAt(index1);
            array = num.ToArray();
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter array length");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next(9);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                Deleete(n, array);
            }
        }
    }
}
