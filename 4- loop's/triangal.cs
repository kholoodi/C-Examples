int size =5,k =0;
while(k < size+1 )
{
	for (int i = size; i > k ; i--)
	{
		Console.Write(" ");
	}
	for (int j=0; j< (2*k-1); j++)
	{
		Console.Write("*");
	}
		Console.WriteLine();
		++k;	
}