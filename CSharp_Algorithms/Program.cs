using System;
using CSharp_Algorithms.SortingAlgorithms;

namespace CSharp_Algorithms
{
	class Program
	{
		static void Main( string [] args )
		{
			Console.WriteLine( "Hello Algorithms!" );
			int[] test = { 75, 0, 2, 55, 43, 97, 62, 12, 3, 17 };

			ShellSort sorter = new ShellSort();

			sorter.Sort( test );
			foreach( int number in test )
			{
				Console.WriteLine( number );
			}
		}
	}
}