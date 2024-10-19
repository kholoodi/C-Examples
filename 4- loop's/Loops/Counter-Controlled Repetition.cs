
// See https://aka.ms/new-console-template for more information

   //initialize variable in declarations 
	int passes = 0; 	//number of passes 
	int failures = 0; 	//number of failures 
	int studentCounter = 1; 	//student counter 
	int result; 	//one exam result from user 
 	while(studentCounter <= 10)	
	{
	//prompt user for input and obtain a value from the user 
	Console.Write("Enter result  (1 = pass, 2 = fail):");
		result = Convert.ToInt32(Console.ReadLine());
		//if…else nested in while 
		if( result ==1) //if result =1
		passes = passes + 1; //increment passes 
		else 	//else result is not  1, so 
		failures = failures + 1; 	//increment  failures 
//increment studentCounter so loop eventually terminates 
	studentCounter = studentCounter +1;
	
	}
	 Console.WriteLine("Passed : {0} \n Failed :{1}" , passes, failures );
	//determine whether more than 8 students passed 
	if( passes > 8 )
		Console.WriteLine("Raise Tuition");



