using System;
    class PassArray
    {
        public static void Main(string[] args)
        {
            int [] array = {1, 2, 3, 4, 5};
            Console.WriteLine("Effects of passing reference to entier array:\n"+
                            "The values of the original array are:" );
            //output original array elements 
            foreach (int value in array)
            Console.Write("    {0}", value);

            ModifyArray(array);     //pass array reference 
            Console.WriteLine("\n\nThe values of the modified array are:" );
            //output modified array elements 
            foreach (int value in array)
            Console.Write("    {0}", value);

            Console.WriteLine("\n\nEffects of passing array element Value:\n"+
                            "array[3] before ModifyElement: {0}", array[3] );
            ModifyElement(array[3]);    // attempt to modify array[3]

            Console.WriteLine("array[3] after ModifyElement: {0}", array[3] );
                    
        }
        public static void ModifyArray( int[] array2)
        {
            for (int counter = 0; counter < array2.Length; counter++)
            array2[counter] *= 2;
        }
        public static void ModifyElement( int element)
        {
            element *= 2;
            Console.WriteLine( "Value of element in ModifyElement: {0}", element);
        }

    }
//----------Output--------
/*
The values of the original array are:
    1    2    3    4    5

The values of the modified array are:
    2    4    6    8    10

Effects of passing array element Value:
array[3] before ModifyElement: 8
Value of element in ModifyElement: 16
array[3] after ModifyElement: 8
*/
