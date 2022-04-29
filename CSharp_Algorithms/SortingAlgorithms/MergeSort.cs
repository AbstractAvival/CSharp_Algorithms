/***************************************
Merge Sort:

An efficient, general-purpose, and comparison-based sorting
algorithm. Merge sort is a divide and conquer algorithm. It 
divides the input array into halves until it has n sublists,
then it repeatedly merges these sublists untill there is only
one sublist remaining. This final sublist is the sorted list.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class MergeSort
	{
		public void Sort( int [] array, int initialIndex, int finalIndex )
		{
			if( initialIndex > finalIndex )
				return;

			int middleIndex = ( initialIndex + finalIndex ) / 2;
			Sort( array, initialIndex, middleIndex );
			Sort( array, middleIndex + 1, finalIndex );
			Merge( array, initialIndex, middleIndex, finalIndex );
		}

		private void Merge( int [] array, int initialIndex, int middleIndex, int finalIndex )
		{
			int firstArraySize = middleIndex - initialIndex + 1;
			int secondArraySize = finalIndex - middleIndex;

			int [] firstArray = new int[ firstArraySize ];
			int [] secondArray = new int[ secondArraySize ];

			CopyArray( array, firstArray, initialIndex );
			CopyArray( array, secondArray, middleIndex + 1 );

			int firstArrayIndex = 0;
			int secondArrayIndex = 0;
			int mergedArrayIndex = initialIndex;

			while( firstArrayIndex < firstArraySize && secondArrayIndex < secondArraySize )
			{
				if( firstArray[ firstArrayIndex ] < secondArray[ secondArrayIndex ] )
				{
					array[ mergedArrayIndex ] = firstArray[ firstArrayIndex ];
					firstArrayIndex++;
				} 
				else
				{
					array[ mergedArrayIndex ] = secondArray[ secondArrayIndex ];
					secondArrayIndex++;
				}
				mergedArrayIndex++;
			}

			while( firstArrayIndex < firstArraySize )
			{
				array[ mergedArrayIndex ] = firstArray[ firstArrayIndex ];
				firstArrayIndex++;
				mergedArrayIndex++;
			}

			while( secondArrayIndex < secondArraySize )
			{
				array[ mergedArrayIndex ] = secondArray[ secondArrayIndex ];
				secondArrayIndex++;
				mergedArrayIndex++;
			}
		}

		private void CopyArray( int [] originalArray, int [] targetArray, int initialIndex )
		{
			for( int index = 0; index < targetArray.Length; index++ )
			{
				targetArray[ index ] = originalArray[ initialIndex + index ];
			}
		}
	}
}
