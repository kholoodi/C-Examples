using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TimesApp
{
  public class Time1{
    public int hour; //0-23
    /*If method's variable has same name the instance variable of class, 
    "this" here refers to the method's variables */
    public void SetTime(int hour){
        //without using "this" we get the wrong result
        /*hour = ((hour >= 0 && hour < 24) ? hour:0);  */ // Erorr output>> 0 
        this.hour = ((hour >= 0 && hour < 24) ? hour:0);  //output>> 10
    }
  }//end class Time1

	public class Time1Test
	{
		public static void Main(string[] args)
		{
		  Time1 time = new Time1();
  		time.SetTime(10);
  		Console.Write(time.hour);
  		Console.ReadLine();
		}
	}
}