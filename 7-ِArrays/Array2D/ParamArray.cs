
using System;
    class ParamArray
    {
        //calculate Average 
        public static double Average (params double[] numbers)
        {
             double total = 0.0;  //initialize total 
           //calculate total using the foreach statement 
           foreach (double d in numbers)
           total += d;

           return total / numbers.Length;
        }
        public static void Main(string[] args)
        {
            double d1 = 10.0;
            double d2 = 20.0;
            double d3 = 30.0;
            double d4 = 40.0;

            Console.WriteLine("d1 = {0:F1}\nd2 = {0:F1}\nd3 = {2:F1}\nd4 = {3:F1}\n", d1, d2,d3,d4); 

            Console.WriteLine("Average of d1 and d2 is {0:F1}", Average(d1, d2));
            Console.WriteLine("Average of d1, d2 and d3 is {0:F1}", Average(d1, d2, d3));
            Console.WriteLine("Average of d1, d2, d3, and d4 is {0:F1}", Average(d1, d2,d3,d4));   
        }
    }

/*--------------------------output-----------
d1 = 10.0
d2 = 10.0
d3 = 30.0
d4 = 40.0

Average of d1 and d2 is 15.0
Average of d1, d2 and d3 is 20.0
Average of d1, d2, d3, and d4 is 25.0
*/
