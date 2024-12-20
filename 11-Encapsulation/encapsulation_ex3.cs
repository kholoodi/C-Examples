using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/** Creating an inheritance hierachy to a banck which use to represent customer' bank accpunts. 
All customers at this bank can depsit money into accounts and withdraw money form thier accounts.
 More specific types of accounts also exist Checking accounts, for charge a fee per transeation.

-The class Account is a base class should include:
  1- A private instance variable to represent the account balance.
  2- Constructor receiveing an intial balance and uses it to initialize the instance variable.
  3- A public property called Balance with a set-accessor that vaildates the intial balance >= 0.0. if not, the balance should be set to 0.0, and the set accessor should display an error message, that returns the current balance.
  4-Public methods:
    - one called Credit that add an amount to the current balance.
    -And Onther methhod  called Debit that withdraw money from the Account and ensure that the debit amount does not exceed the Account's balance. If it does, the balance should be left unchanged, and the method should print the message "Debit amount exceeds account balance".
-The derived class named CheckingAccount inherit from  base class Account and  should include:
  1- A decimal instance variable that represents the fee changed per transection .
  2- CheckingAccount's constructor should receive  the intial balance, as well as paramtere indicating a fee amount.
  3- Refine methods Credit and Debit so that they subtract the fee form the account balance whenever either transaction is performed successfully. CheckingAccount's versions of these methods shoul invoke the base-class Account verison to perform the updates to an account balance.
-After define the classes in this hierarchy, the application Main method should creates an object of CheckingAccount class and call the Creit and Debit methods.
**/
namespace App
{
  public class Account{
    //private class attributes 
    private decimal balance;
    //constructors
    public Account( decimal d){ balance = d; }
    //Property
    public  decimal Balance{
      set { 
            if (value > 0)
              balance = value;
            else
            {
              value = 0;
              Console.WriteLine("indicating that initial balance was invalid ");
            }
          }
      get { return  balance;}
    }
   
   //Methods 
    public virtual void Credit(decimal amount){
      Balance += amount;
      Console.WriteLine("Your current balance after adding amount is "+ balance) ;
    }
    public virtual void Debit(decimal amount){
      Balance -= amount;
      if(balance <= 0)
        Console.WriteLine("Debit amount exceeds account balance");
      else
        Console.WriteLine("Your current balance after debiting amount is "+ balance) ;
    }
  }
  class CheckingAccount: Account {
    decimal fee ;
    public CheckingAccount(decimal amount, decimal f): base(amount){
      fee = f;
      Balance = amount;
    }
    public override void Credit(decimal amount){
      Balance += amount;
      Balance -= fee;
      Console.WriteLine("Your current balance after adding amount and debit the fee is "+ Balance) ;
    }
    public override void Debit(decimal amount){
      Balance -= amount;
      Balance -= fee;
      Console.WriteLine("Your current balance after debiting amount and fee is "+ Balance) ;
    }
  }
	public class Program
	{
		public static void Main(string[] args)
		{
		  CheckingAccount account0 = new CheckingAccount(1,4); 
      account0.Credit(2);
      account0.Debit(3);
		}
	}
}
/**
Output:

Your current balance after adding amount and debit fee is 101
Your current balance after debiting amount and fee is 97

--if we are put balance = 1 and fee 4 
Output
indicating that initial balance was invalid 
Your current balance after adding amount and debit fee is 3
indicating that initial balance was invalid 
indicating that initial balance was invalid 
Your current balance after debiting amount and fee is 3
**/