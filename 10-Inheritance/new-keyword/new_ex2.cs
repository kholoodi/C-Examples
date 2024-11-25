using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*-----new V.S override ------*/
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("This is the Display method in BaseClass.");
    }
}

class DerivedClassWithOverride : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("This is the Display method in DerivedClassWithOverride.");
    }
}

class DerivedClassWithNew : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("This is the Display method in DerivedClassWithNew.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass();
        DerivedClassWithOverride overrideObj = new DerivedClassWithOverride();
        DerivedClassWithNew newObj = new DerivedClassWithNew();

        BaseClass polymorphicOverride = new DerivedClassWithOverride();
        BaseClass polymorphicNew = new DerivedClassWithNew();

        baseObj.Display(); // Output: This is the Display method in BaseClass.
        overrideObj.Display(); // Output: This is the Display method in DerivedClassWithOverride.
        newObj.Display(); // Output: This is the Display method in DerivedClassWithNew.

        polymorphicOverride.Display(); // Output: This is the Display method in DerivedClassWithOverride.
        polymorphicNew.Display(); // Output: This is the Display method in BaseClass.
    }
}