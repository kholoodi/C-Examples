// Sentinel-Controlled Repetition Example 

   string course_name;
	int total = 0; 		//for sum the grades 
	int gradeCounter= 0;	//for count the  grades that be entered  
	int grade;		//grade value entered by the user 	
	double average;	//average of the grades

	Console.Write("Enter Course Name: ");
	course_name = Console.ReadLine();
	Console.WriteLine("Welcome to the grade book for {0}!\n", course_name);

	// lable read_grade 
	read_grade:
		{
		Console.Write("Enter grade or -1 to quit:"); 	//prompt the user 
		grade = Convert.ToInt32(Console.ReadLine());
		}

    while( grade != -1)
	{
		total  += grade ;	//add the grade to total 
		gradeCounter ++;  	//increment the counter by 1
		goto read_grade;	//read the next grade from lable read_grade
	}

	if( gradeCounter != 0)
	{
		//calculate the average of all grades entered 
		average = (double) total / gradeCounter;
		//display the total and the average ( with two digits of precision)
		Console.WriteLine("\n Total of the {0} grades entered is {1}", gradeCounter, total);
		Console.WriteLine("Class average is {0:F}" , average);
	}
	else 	// no grades were entered, so the output error message 
	Console.WriteLine("No grades were entered");
	


