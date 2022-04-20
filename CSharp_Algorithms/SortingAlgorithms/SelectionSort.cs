/***************************************
Selection Sort:

Sorts an array by repeatedly finding the minimum element
(or largest, depending on sorting order) in the unsorted list,
swapping it with the leftmost unsorted element, and moving
the sublist boundaries one element to the right.

Similiar to Insertion Sort, but generally performs worse.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class SelectionSort
	{
		public void Sort( int [] array )
		{
			for( int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++ )
			{
				int minimumIndex = currentIndex;
				int offsetIndex = minimumIndex + 1;
				while( offsetIndex < array.Length )
				{
					if( array[ offsetIndex ] < array[ minimumIndex ] )
					{
						minimumIndex = offsetIndex;
					}
					offsetIndex++;
				}
				int valueholder = array[ currentIndex ];
				array[ currentIndex ] = array[ minimumIndex ];
				array[ minimumIndex ] = valueholder;
			}
		}
	}
}