public static void Main(string[] args)
  {
     int x , y;
     double z;
     x = Convert.ToInt32(Console.ReadLine());
     y =  Convert.ToInt32(Console.ReadLine());
        z = x/y;
     Console.WriteLine("Z" + z);
     Console.ReadLine();
   
     } 
     /*----Output---
     Sft
Unhandled exception. System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Convert.ToInt32(String value)
     */