﻿/***************************************
Shell Sort:

An improved insertion sort. Starts by sorting pairs of
elements far apart from each other, then progressively
reduces the gap between elements to be compared. Running 
time is heavily dependent on the gap sequence used.
***************************************/

namespace CSharp_Algorithms.SortingAlgorithms
{
	public class ShellSort
	{
		//Using shell sort's original gap sequence: k = n / 2
		public void Sort( int [] array )
		{
			int interval = array.Length / 2;
			while( interval > 0 )
			{
				for( int currentIndex = 0; currentIndex < interval; currentIndex++ )
				{
					for( int sortPosition = currentIndex; sortPosition < array.Length; sortPosition += interval )
					{
						int placeholder = array[ sortPosition ];
						int reverseInterval = sortPosition;
						for( ; reverseInterval >= interval && array[ reverseInterval - interval ] > placeholder; reverseInterval -= interval )
						{
							array[ reverseInterval ] = array[ reverseInterval - interval ];
						}
						array[ reverseInterval ] = placeholder;
					}
				}
				interval /= 2;
			}
		}
	}
}