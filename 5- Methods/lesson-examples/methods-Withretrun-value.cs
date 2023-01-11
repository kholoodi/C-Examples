//Declaring the method takes one parameter
double Square (double a) {
 return a * a;
}
//Declaring the method takes two parameters 
int add (int a, int b ){
    return a + b;
}
//Save the return value in variable
double num = Square (3);   //calling the Square  method 
Console.WriteLine(num);

//Print the return value  
Console.WriteLine(add(2,3)); //calling the add method within WriteLine method 