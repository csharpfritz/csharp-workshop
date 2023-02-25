using System;
using System.Linq;

namespace sample
{
		
	public class Linq 
	{

		public static string Test() 
		{

			int myNullableInt = default;
			Console.WriteLine(myNullableInt);

			var numbers = new string[] {"the", "quick", "brown", "fox"};

			return numbers.FirstOrDefault(x => x.StartsWith("j"));

			//Console.WriteLine(result is null);

		}

	}

}