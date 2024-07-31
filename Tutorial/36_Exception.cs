using System;
class _36_Exception
{

	static void Main(string[] args)
	{
		try
		{
			int no = int.Parse(Console.ReadLine());
			Console.WriteLine("User entered No is : {0}",no);
		}
		catch(FormatException e)
		{
			Console.WriteLine("Give Proper Number",e);
		}
		finally
		{
			Console.WriteLine("These block executes");
		}


	}



}

