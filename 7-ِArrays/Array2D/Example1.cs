
using System;
    class Program
    {
        public static void Main(string[] args)
        {
           int i, j;
           //Declaring multi dimensional array 
           string [,] Books = new string[3,3];
           for(i =0 ; i < 3; i++)
           {
            for(j =0; j < 3 ; j++)
            {
                Console.Write("\nEnter Book Name for {0}. Row and {1} . column:\t", i+1, j+1);
                Books[i,j] = Console.ReadLine();
            }
           }
           Console.WriteLine("\n\n============================");
           Console.WriteLine("All the element of Books array    is:\n\n");
           //Formatting Output 
           Console.Write("\t1\t2\t3\n\n");
           //Outer loop accessing rows
           for(i = 0; i < 3; i++)
           {
            Console.Write("{0}.\t", i+1);
            //inner or nested loop for accessing column     of each row
            for(j =0 ; j < 3 ; j++)
            {
                Console.Write("{0}\t", Books[i,j]);
            }
            Console.Write("\n");
           }
           Console.WriteLine("\n\n============================");
           Console.ReadLine();

        }
    }


