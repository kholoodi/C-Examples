
using System;
    class RollDie
    {
        public static void Main(string[] args)
        {
            Random randomNumers = new Random(); //rendom-number generator
            int[] frequency = new int [7];  //array of ferquency counters
            //roll die 6000 times use die value as frequwency counter 
            for(int roll = 0; roll <= 6000; roll++)
            ++frequency[randomNumers.Next(1,7)];
            Console.WriteLine("{0}{1,10}:" ,"Face" , "Frequency") ; 
            //output each arrayelement’s value
            for (int face =1; face < frequency.Length; face++)
             Console.WriteLine("{0,4}{1,10}:" ,face, frequency[face]) ;  
                 
        }
    }



