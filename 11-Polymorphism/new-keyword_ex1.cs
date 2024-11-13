using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
  class BC {
    public void Display() {
  		System.Console.WriteLine("BC::Display");
  	}
  }
  class DC:BC {
  	new public void Display() {
  		System.Console.WriteLine("DC::Display");
  	}
  }
  class Demo {
  	 public static void Main(string[] args) {
    		BC b;
    		b = new BC();
    		b.Display()
  	}
  }
}
 //output
//BC::Display
