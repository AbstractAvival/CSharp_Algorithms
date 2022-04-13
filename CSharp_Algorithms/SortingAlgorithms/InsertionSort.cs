/***************************************
Insertion Sort:

A simple sorting algorithm that builds the final sorted array
one item at a time. It's efficient when sorting a small number
of elements.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class InsertionSort
	{
		public int [] Sort( int [] array )
		{
			int key, currentItem;
			for( int index = 1; index < array.Length; index++ )
			{
				key = array[ index ];
				currentItem = index - 1;
				while( currentItem > -1 && array[ currentItem ] > key )
				{
					array[ currentItem + 1 ] = array[ currentItem ];
					currentItem--;
				}
				array[ currentItem + 1 ] = key;
			}
			return array;
		}
	}
}