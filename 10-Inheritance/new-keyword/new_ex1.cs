using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*-----using new with inhert ------*/

class BaseClass
{
    public void Display()
    {
        Console.WriteLine("This is the Display method in BaseClass.");
    }
}

class DerivedClass : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("This is the Display method in DerivedClass.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass();
        baseObj.Display(); // Output: This is the Display method in BaseClass.

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.Display(); // Output: This is the Display method in DerivedClass.

        BaseClass polymorphicObj = new DerivedClass();
        polymorphicObj.Display(); // Output: This is the Display method in BaseClass.
    }
}