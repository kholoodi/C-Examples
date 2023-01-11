
// GradeBook class uses switch statement to count letter grades 

int total = 0;	//sum of grades
int grade_counter = 0; // number of grades entered 
int count_A = 0; 		// count of A grades 
int count_B = 0; 		// count of B grades 
int count_C = 0; 		// count of C grades 
int count_D = 0; 		// count of D grades 
int count_F = 0; 		// count of F grades 
string name ;
int grade;		//grade entered by user 
string input;	// text entered by the user

Console.Write("Enter Couurse name: ");
name = Console.ReadLine();
Console.WriteLine("Welcome ti the grade book for \n{0}\n", name);

Console.WriteLine("{0}\n{1}","Enter the integer grade in the range 0-100.",
						"Type <Ctrl+z and press Enter to terminate input:");

input = Console.ReadLine();			//read user input 

while(input != null)
{
	grade = Convert.ToInt32(input); 	//read grade off user input 
	total += grade;		//add grade to total
	++grade_counter;

	switch(grade /10)
	{
		case 9:				//grade was in the 90s
		case 10:			//grade was 100
			++count_A;		//increment count_A 
			break;			// necessary to exit switch 
		case 8:				//grade was between 80 to 89
			++count_B;		//increment count_B
			break;			//exit switch 
		case 7:				//grade was between 70 to 79
			++count_C;		//increment count_C
			break;			//exit switch 
		case 6:				//grade was between 60 to 69
			++count_D;		//increment count_D
			break;			//exit switch 
		
		default:			//grade was less than 60
			++count_F;		//increment count_f
			break;			//exit switch
	}//end switch
	input = Console.ReadLine();		//read user input 
}//end while

//display a report based on the grades entered by the user 
Console.WriteLine("\nGrade Report:");

//if user entered at least one grade...
if(grade_counter != 0)
{
	//calculate average of all grades entered 
	double average = (double) total / grade_counter;

	//output summary of results 
	Console.WriteLine("Total of the {0} grades entered is {1}", grade_counter, total);
	Console.WriteLine("Class average is {0:F}", average);
	Console.WriteLine("{0}A: {1}\nB:{2}\nC:{3}\nD:{4}\nF:{5}",
						"Number of students who received each grade:\n",
						count_A, count_B, count_C, count_D, count_F); //display number for each evaluation

}//end if
	else
		//no grade were entered, so output appropiate message 
		Console.WriteLine("No grades were entered");

 




