/* sealed class to be inherited by any class */
//Sample code for sealed class 
sealed class MySealedClass{
	private int number;
	public mySealedClass(){ 
        /*…code…*/
        }	
}
// complier raises an error 
class myDerivedClass: MySealedClass{
	/*…..code …*/
}

