using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inheritance {
  public class CommissionEmployee {
    public string em_name;
    public decimal grossSales;
    public decimal commissionRate;
    public CommissionEmployee(string name, decimal sales, decimal rate) {
    	em_name = name;
		grossSales = sales;
	    commissionRate = rate;
	    }
        // CommissionRate property
    public decimal CommissionRate {
	    get { return commissionRate; }
	    set { commissionRate = (value > 0 && value < 1) ? value: 0;}
        }
	  public virtual decimal Earnings() {
		  return (commissionRate * grossSales);
	  }
	  public virtual void PrintInfo() {
		  Console.WriteLine("Name = " +em_name + "\ngross sale =" + grossSales);
		  Console.WriteLine("Commission=" + commissionRate);
		  Console.WriteLine("Earning Salary =" + Earnings());
		}
  }
  public class BasePlusCommissionEmployee: CommissionEmployee {
	  public decimal baseSalary;
	  public BasePlusCommissionEmployee(string n, decimal sales, decimal rate, decimal salary):base(n, sales, rate)
		  { baseSalary = salary;}
	  public override decimal Earnings(){
	    return baseSalary + (commissionRate * grossSales); }
	  public override void PrintInfo() {
		  Console.WriteLine("Name = " +em_name + "\ngross sale =" + grossSales);
		  Console.WriteLine("Commission=" + commissionRate);
		  Console.WriteLine("Earning Salary =" + Earnings());
	  }
  }
  public class BasePlusCommissionEmployeeTest {
	  public static void Main(string[] args) {
		  BasePlusCommissionEmployee emp1 = new BasePlusCommissionEmployee("Bob", 5000.00M, .04M, 300.00M);
		  Console.WriteLine("Employee Information obtained by properties and methods:\n");
		  emp1.PrintInfo();
		  emp1.baseSalary = 1000.00M; // set base Salary
		  Console.WriteLine("\nUpdated employee information obtained by ToString");
		  Console.WriteLine("earning:{0}", emp1.Earnings());
		  Console.ReadLine();
	  }
  }
}//end namespace 
