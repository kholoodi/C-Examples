for(int i = 1; i <= 5 ; i++)
	{
		for(int j = 1; j <= i; j++)
		 { 
			Console.Write(" ");
		 }
		for(int k = 1; k <= i; k++)
		{ 
			Console.Write("*");
		}
		for(int j = 1; j <= 3* (4- i + 1); j++)
		{
			Console.Write(" ");
		}
		for(int k = 1; k <= 2 * i - 1; k++)
		{
			Console.Write("*");
		}
		for(int j = 1; j <= 3 * (4 - i +1); j++)
		{
			Console.Write(" ");
		}
		for(int k = 1; k <= i; k++)
		{
			Console.Write("*");
		}
		Console.WriteLine();
	}
	for(int i = 1; i <= 2; i++)
	{
		for(int j = 1; j <= 5 + i -1; j++)
		{
			Console.Write(" ");
		}
		for(int k = 1; k <= 2*( 9 - i + 1) + 1 ; k++)
		{
			Console.Write("*");
		}
	Console.WriteLine();

	}