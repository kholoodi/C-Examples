using System;
    class Program
    {
        public static void Main(string[] args)
        {
           int [] array ;  //declaring an  array named array.
            //create the spce for array an initialize to default zeros
            array = new int[5];    //5 int elements 
            Console.WriteLine("{0} {1,8}","index","value");
            //output each array element's value 
            for(int i = 0; i < array.Length; i++)
            Console.WriteLine("{0,5} {1,8}", i ,array[i]);  
            
        }   
    }


