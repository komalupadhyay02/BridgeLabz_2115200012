using System;
class Factorial
{
	static void Main(string[]args)
	{
		Console.WriteLine("Enter the Number");
		int Number=int.Parse(Console.ReadLine());

		if(Number<0){
			Console.WriteLine("The Number is negative");
		}

		else
		{
			long factorial=1;
			int i=1;
			while(i<=Number){
				factorial*=i;
				i++;
		}
	
            
            Console.WriteLine($"The factorial of {Number} is {factorial}.");
		}
		
	}
}