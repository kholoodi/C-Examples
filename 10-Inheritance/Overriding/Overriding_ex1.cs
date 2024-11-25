using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Using base members 
  class Overriden {
    public int x;
    public Overriden (int a){
        x = a;
    }
    public virtual void Print(){
        Console.WriteLine("x = {0}", x);
    }
  }
  class Derived:Overriden {
    int y;
    public Derived (int a, int b):base(b) {
        y =a;
    }
    public override void Print(){
        base.Print();
        Console.WriteLine("y ="+ y);
    }
  }
  	public class Program
	{
		public static void Main(string[] args)
		{
			Derived der1 = new Derived(5,10);
            der1.Print();
            Console.ReadLine();
		}
	}
}
/*
Output:

x = 10
y =5
*/