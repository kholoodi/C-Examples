using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*-----sealed methods ------*/
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display Method.");
    }
}

class DerivedClass : BaseClass
{
    public sealed override void Display()
    {
        Console.WriteLine("DerivedClass Display Method.");
    }
}

// Any attempting to override sealed method in another class will result in an error.
class AnotherClass : DerivedClass
{
    // Error: The method cannot be overridden because it is marked with sealed.
    /* public override void Display()
        {
         Console.WriteLine("AnotherClass Display Method.");
        }*/
}