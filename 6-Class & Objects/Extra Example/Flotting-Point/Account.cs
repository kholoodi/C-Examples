using System;
using App;
class Account{
    private decimal balance;    // instance variable that stores the balance 
    //constructor 
    public Account(decimal initialBalance){
        Balance = initialBalance;   //set balance using property 
    }
    //credit (add) an amount to the account 
    public void credit(decimal amount){
        Balance = Balance + amount;     //add amount to balance 
    }
    // A property to get and set the account balance 
    public decimal Balance
    {
        get{    return balance;}
        set {   
            //variable that value is geater that or equal to 0;
            //if it is not, blance is left unchangeed 
            if( value >= 0)
            balance = value;
        }
    }
    
}