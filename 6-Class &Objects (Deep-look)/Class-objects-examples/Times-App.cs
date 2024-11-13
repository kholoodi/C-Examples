using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TimesApp
{
    public class Time1{
    private int hour; //0-23
    private int minute; //0-59
    private int second; //0-59
    
    public void SetTime(int h , int m, int s){
      hour = ((h >= 0 && h < 24)? h:0);
      minute = ((m >= 0 && m < 60)? m:0);
      second = ((s >= 0 && s < 60)? s:0);
    }
    
    public string ToUniversalString(){
      return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
    }
    public override string ToString(){
      return string.Format("{0}:{1:D2}:{2:D2}{3}", 
      ((hour == 0 || hour == 12) ? 12:hour%12),
      minute, second, (hour < 12?"AM":"PM"));
    }
  }//end class Time1

	public class Time1Test
	{
		public static void Main(string[] args)
		{
            Time1 time = new Time1();
            Console.Write("The initial universal time is:");
            Console.WriteLine(time.ToUniversalString()); //00.00.00
            Console.Write("The initial standard time is:");
            Console.WriteLine(time.ToString()); // 12.00:00Am
            Console.WriteLine();
            time.SetTime(13 ,27, 6);
            Console.Write("Universal time after SetTime is:");
            Console.WriteLine(time.ToUniversalString()); //13:27:6
            Console.Write("Standard time after SetTime is:");
            Console.WriteLine(time.ToString()); //1:27:66 PM
            Console.WriteLine(); // output a blank Writeline
            time.SetTime(99 ,99, 99);
            Console.WriteLine("After attempting invalid settings:");
            Console.Write("Universal time:");
            Console.WriteLine(time.ToUniversalString());//99.99.99
            Console.Write("Standard time:");
            Console.WriteLine(time.ToString());//12:00:00 AM
            Console.ReadLine();
			
		}
	}//end class 
}//end namespace