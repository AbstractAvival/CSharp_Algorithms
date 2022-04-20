using System;
using CSharp_Algorithms.SortingAlgorithms;

namespace CSharp_Algorithms
{
	class Program
	{
		static void Main( string [] args )
		{
			Console.WriteLine( "Hello Algorithms!" );
			SelectionSort sorter = new SelectionSort();

			int [] values = { 84, 55, 12, 110, 37, 41, 74, 9, 62, 29 };

			foreach( int number in values )
			{
				Console.WriteLine( number );
			}

			Console.WriteLine( "\n" );
			sorter.Sort( values );

			foreach( int number in values )
			{
				Console.WriteLine( number );
			}
		}
	}
}