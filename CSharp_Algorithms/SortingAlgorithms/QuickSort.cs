/***************************************
Quick Sort:

A divide and conquer algorithm. It picks an element as
a pivot point and partitions the given array around
said pivot into sub-arrays. The sub-arrays are then 
sorted recursively.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class QuickSort
	{
		public void Sort( int [] array, int startIndex, int endIndex )
		{
			if( startIndex >= endIndex )
				return;

			int partitionIndex = Partition( array, startIndex, endIndex );
			Sort( array, startIndex, partitionIndex - 1 );
			Sort( array, partitionIndex + 1, endIndex );
		}

		private int Partition( int [] array, int startIndex, int endIndex )
		{
			return -1;
		}
	}
}
