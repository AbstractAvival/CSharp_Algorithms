﻿/***************************************
Bubble Sort:

A sorting algorithm that compares two adjacent elements and 
swaps them if they are in the wrong order. This is repeated 
until the list is sorted.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class BubbleSort
	{
		public void Sort( int [] array )
		{
			bool swappedElements = false;
			do 
			{
				swappedElements = false;
				for( int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++ )
				{
					if( array[ currentIndex ] > array[ currentIndex + 1 ] )
					{

					}
				}
			} while( swappedElements );
		}

		private void Swap( int [] targetArray, int firstTargetIndex, int secondTargetIndex )
		{
			int tempValue = targetArray[ firstTargetIndex ];
			targetArray[ firstTargetIndex ] = targetArray[ secondTargetIndex ];
			targetArray[ secondTargetIndex ] = tempValue;
		}
	}
}
