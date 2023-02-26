using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static int PreviousPrevious = 0;
        public static int Previous = 0;
        public static int Next = 1;
        //1.Find Fibonacci Series
        public static void FindFibonacciSeries()
        {
            Console.WriteLine("Please Enter The Number To Find FiboniciSeries");
            int input = Convert.ToInt32(Console.ReadLine());
            while (Next < input)
            {
                PreviousPrevious = Previous;
                Previous = Next;
                Next = PreviousPrevious + Previous;
                Console.WriteLine(Previous);
            }
            Console.ReadLine();
        }
    }
}
