using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*-----sealed class ------*/
sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
}

// ِAny attempting to inherit from FinalClass will result in an error.
class DerivedClass : FinalClass // Error: Cannot inherit from sealed class
{
}