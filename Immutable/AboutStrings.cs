using System;

namespace Immutable
{
	class ImmutableDemo
	{

        public static void Main(string[] args)
		{
			string Original = "Hello All";
			Original.Trim();
			Original.Substring(6);
			Original.ToUpper();
			System.Console.WriteLine(Original);
		}
	}

}
