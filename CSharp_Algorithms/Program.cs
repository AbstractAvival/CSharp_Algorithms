using System;
using CSharp_Algorithms.SortingAlgorithms;

namespace CSharp_Algorithms
{
	class Program
	{
		static void Main( string [] args )
		{
			Console.WriteLine( "Hello Algorithms!" );
			int [] test = { 327, 547, 689, 0, 12, 1, 333, 998, 0, 12, 32 };

			BubbleSort sorter = new BubbleSort();
			sorter.Sort( test );

			foreach( int number in test )
			{
				Console.WriteLine( number );
			}
		}
	}
}