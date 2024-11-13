using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public class Employee
  {
  	public static int count = 0;
  	public string FirstName {get; private set;}
  	public Employee(string first){
  	FirstName = first;
  	count++;
  	Console.WriteLine("Employee constructor {0} count = {1}", FirstName, count);
  	}
  	public static int Count{get {return count; }}
  }
  public class EmployeeTest {
      public static void Main( string[] srgs){
        Console.WriteLine("instantiantion: {0}", Employee.count);
        Employee e1 = new Employee("Mona");
        Employee e2 = new Employee("Wala");
        Console.WriteLine("\nafter instantiantion: {0}", Employee.count);
        Console.ReadLine();
    }
  }

}
/*
Output:

instantiantion: 0
Employee constructor Mona count = 1
Employee constructor Wala count = 2

after instantiantion: 2
*/

