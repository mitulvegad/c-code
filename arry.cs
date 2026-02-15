using System;
class arry{
	
	static void Main(){
		int n;
		Console.WriteLine("Enter number of elements:");
		n=Convert.ToInt32(Console.ReadLine());
		int []arr=new int[n];
		
		for(int i=0;i<n;i++)
		{
			Console.WriteLine("enter element" + i + " = ");
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("array enter are:");
		
		for(int i=0;i<n;i++)
		{
			Console.WriteLine(arr[i]+ " ");
		}
	}
}