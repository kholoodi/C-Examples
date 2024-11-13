using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  
  public class Increment
	{
        public readonly int INCREMENT;
	
		public Increment(int IncrementValue)
		{
			INCREMENT = IncrementValue;
		}
		//Any changing after primmentive value is error 
		/*
		public ModiftReadonly(){
		  INCREMENT ++;
		}*/
	}

	public class Program
	{
        public static void Main(string[] args)
		{
			Increment incerment1 = new Increment(2);
			Console.WriteLine(incerment1.INCREMENT);
		}
	}
}