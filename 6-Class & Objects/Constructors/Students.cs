namespace App
{
public class Students {
    public  string name;
    private int id;
    public int ID{ get; set;}
    
    //Constructor 1 declaration to assigning the default values 
    public Students()
    {
        name = "No name ";
        ID = 0;
    }
    
     //Constructor 2 declaration, if the object send value for name
     public Students(string Name)
     { name = Name;}
     
      //Constructor 2 declaration, if the object send values for name and id
    public Students( string Name, int Id){
        name = Name;
        ID = Id;
    }
   
       public  void WelcomeMessage(string studentName ,int ID)
    {
        Console.WriteLine("Welcome School System: {0}\n your ID is {1}", studentName ,ID);
    }
    }
}