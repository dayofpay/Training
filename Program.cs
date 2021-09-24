using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAnswer
{
    class Program
    {
        public static int arrayOne;
        public static int arrayTwo;
        static void Main(string[] args)
        {
            Console.Title = "GitHub | dayofpay";
            Method1:// Method I
            var xPossible = new List<int>();
            Console.Write("Numbers to add to List: ",Console.ForegroundColor = ConsoleColor.Green);
            var addtoArray = int.Parse(Console.ReadLine());
            for(int i = 0; i<= addtoArray; i++)
            {
                xPossible.Add(i);
            }
                Console.WriteLine($"The list has {xPossible.Max()} numbers !");
            // OR //
            foreach (int getNum in xPossible)
            {
                Console.WriteLine($"The list has {xPossible.Max()} numbers !");
            }
            Random setRandom = new Random();
            var genRandom = setRandom.Next(xPossible[0],xPossible.Max());
            Console.WriteLine($"Random Number Selected {genRandom} from total {xPossible.Max()}");
            Console.ReadKey();
            arrayOne = genRandom;
            ArrayTest();
        }
        public static void ArrayTest()
        {
            Console.WriteLine("Total Array: ");
            int[] setArray = new int[] { 1, 2,3,4,5 };
            Console.WriteLine(setArray.Min() + "|" + setArray.Max());
            Console.WriteLine($"Lenght of the array {setArray.Length}");
            arrayTwo = setArray.Length;
            Results(arrayOne, arrayTwo);
        }
        public static void Results(int arrayOne,int arrayTwo)
        {
            Console.WriteLine("Result from the first List Test:" + arrayOne);
            Console.WriteLine("Result from the second Array Test:" + arrayTwo);
        }
        public static void async()
        {
            var list = new List<string>();
            bool validSync = false;
            while(validSync == false)
            {
                foreach (string x in list)
                {
                    list.Add("Game ID:");
                    break;
                }
            }
        }
    }
}
