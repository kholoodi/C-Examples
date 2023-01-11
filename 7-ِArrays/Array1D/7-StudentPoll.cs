
using System;
    class StudentPoll
    {
        public static void Main(string[] args)
        {
            // array of survay reponses
            int [] responses = {1, 2 ,6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6, 10, 3, 8, 2, 7, 
                                6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6, 4, 8, 6, 8, 10};
            int[] frequency = new int [11]; //array of frequency counters
            Random randomNumers = new Random(); //rendom-number generator
            /*for each answer, select responses element and use that value 
              as frequency index to determine element to increment */
            for(int answer = 0; answer < responses.Length; answer++)
            ++frequency[responses[answer]];
            Console.WriteLine("{0}{1,10}:" ,"Rating" , "Ferquency") ; 
            //output each array element's value
            for (int rating =1; rating < frequency.Length; rating++)
             Console.WriteLine("{0,6}{1,10}:" ,rating, frequency[rating]) ;    
                 
        }
    }



