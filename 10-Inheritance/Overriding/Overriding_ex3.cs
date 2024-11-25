using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Using base members 
  class Computer {
    int id;
    public Computer (int i){
      id = i;
      Console.WriteLine("PC Computers");
    }
    public virtual void Print(){
      Console.WriteLine("ID ="+ id);
    }
    public void Price(){
      Console.WriteLine("price = 3000");

    }
  }
  class LapTop:Computer {
    int price;
    public LapTop (int p, int i):base(i) {
      price = p;
      Console.WriteLine("Mini Computers");

    }
    public override void Print(){
      Console.WriteLine("LapTop");
    }
    public void Price(){
      Console.WriteLine("price=" +price);

    }
  }
  	public class Program
	{
		public static void Main(string[] args)
		{
      LapTop lap1 =  new LapTop(5000,1);
			lap1.Price();
      lap1.Print();
		}
	}
}
/*
Output:

PC Computers
Mini Computers
price=5000
LapTop
*/