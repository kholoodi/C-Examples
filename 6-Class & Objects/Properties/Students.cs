using System;
using App;
namespace App
{
public class Students {
     public  string name;
    private int id;
    //Declaration a property 
    public  int Id
    {
        get{ 
            return id;
            }
        set{ 
            id = value ;
            }
    }
    //OR we can use auto-implemented property id implicitly creates
    //public int Id{ get; set;}
    public void WelcomeMessage(string studentName ,int ID)
    {
        Console.WriteLine("Welcome School System: {0}\n your ID is {1}", studentName ,ID);
    }
    }
}