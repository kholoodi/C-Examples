using System;
namespace App
{
    class AccountTest
    {
        //Main method begins program exexcution 
        public static void Main(string[] args)
        {
            //create Account objects 
            Account account1 =new Account(50.00M);   
            Account account2 =new Account(-7.53M);   

            //display initial balance of each object using a ptoperty 
            Console.WriteLine("account1 balance : {0:c}", account1.Balance); //display Balance property 
            Console.WriteLine("account2 balance : {0:c}", account2.Balance); //display Balance property 

            decimal depositAmount;  //deposit amount read from user 
            //prompt and obtain user input 
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:c} to account1 balance \n ", depositAmount);
            account1.credit(depositAmount); //add to account1 balance 
            //dispaly balances
            Console.WriteLine("account1 balance: {0:c}", account1.Balance);
            Console.WriteLine("account1 balance: {0:c}", account2.Balance);
            //prompt and obtain user input 
            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:c} to account2 balance \n ", depositAmount);
            account2.credit(depositAmount); //add to account1 balance 
            //dispaly balances
            Console.WriteLine("account1 balance: {0:c}", account1.Balance);
            Console.WriteLine("account1 balance: {0:c}", account2.Balance);    
        }
    }

}

