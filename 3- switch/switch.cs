


/*Console.Write(" Please enter the grade between 1 and 100 :" );
int grade = Convert.ToInt32(Console.ReadLine());
if ( grade >= 90)
	Console.WriteLine('A');
	else if ( grade >= 80)
		Console.WriteLine('B');	
        else if ( grade >= 70)
		Console.WriteLine('C');
		    else if ( grade >= 60)
			Console.WriteLine('D');
			else
				Console.WriteLine('F');*/

//switch Example 
Console.Write(" Please enter the grade between 1 and 100 :" );
int grade = Convert.ToInt32(Console.ReadLine());
 switch(grade / 10){
    case 9:
    case 10:
        Console.WriteLine('A');
        break;
    case 8:
        Console.WriteLine('B');
        break;
    case 7:
        Console.WriteLine('C');
        break;
    case 6:
        Console.WriteLine('D');
        break;
    default:
        Console.WriteLine('F');
        break;
 }

