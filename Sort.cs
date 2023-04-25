using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class Sorting
	{
		// O(n^2) time; O(1) space
		// Push greater elements to the end by swaping with adjacent element
		public static void BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}

		// O(n^2) time; O(1) space
		// Linear search the smallest element and then swap it with the first element
		public static void SelectionSort(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int min = i;

				for (int j = i + 1; j < array.Length; j++)
					if (array[min] > array[j])
						min = j;

				int temp = array[i];
				array[i] = array[min];
				array[min] = temp;
			}
		}

		// O(n^2) time; O(1) space
		// Starting on index 1, save to temp, compare with previous indexes, if smaller, shift element to right
		// if greater, place temp in the free index
		public static void InsertionSort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int temp = array[i];
				int j = i - 1;

				while (j >= 0 && array[j] > temp)
				{
					array[j + 1] = array[j];
					j--;
				}
				array[j + 1] = temp;
			}
		}

		// O(n*log(n)) time; O(n) space
		// Divide array in smaller arrays and merge them in order recursively
		public static void MergeSort(int[] array)
		{
			int length = array.Length;

			if (length <= 1) //base case
				return;

			int middle = length / 2;
			int[] leftArray = new int[middle];
			int[] rightArray = new int[length - middle];
			int rightArrayCursor = 0;

			for (int i = 0; i < length; i++)
			{
				if (i < middle)
					leftArray[i] = array[i];
				else
				{
					rightArray[rightArrayCursor] = array[i];
					rightArrayCursor++;
				}
			}

			MergeSort(leftArray);
			MergeSort(rightArray);
			Merge(leftArray, rightArray, array);
		}

		private static void Merge(int[] leftArray, int[] rightArray, int[] array)
		{
			int leftCursor = 0, rightCursor = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (leftCursor >= leftArray.Length)
					array[i] = rightArray[rightCursor++];
				else if (rightCursor >= rightArray.Length)
					array[i] = leftArray[leftCursor++];
				else if (leftArray[leftCursor] < rightArray[rightCursor])
					array[i] = leftArray[leftCursor++];
				else
					array[i] = rightArray[rightCursor++];
			}
		}

		// O(n*log(n)) time; O(log(n)) space
		// Moves smaller elements to left of a pivot, divides the array in two and repeat on each part recursively
		public static void QuickSort(int[] array, int start, int end)
		{
			if (start >= end)
				return;

			int partitionIndex = Partition(array, start, end);
			QuickSort(array, start, partitionIndex - 1);
			QuickSort(array, partitionIndex + 1, end);
		}

		public static void QuickSort(int[] array)
		{
			QuickSort(array, 0, array.Length - 1);
		}

		private static int Partition(int[] array, int start, int end)
		{
			int pivot = array[end];
			int pivotIndex = start - 1;
			int temp;

			for (int i = start; i <= end - 1; i++)
			{
				if (array[i] < pivot)
				{
					pivotIndex++;
					temp = array[pivotIndex];
					array[pivotIndex] = array[i];
					array[i] = temp;
				}
			}

			pivotIndex++;
			temp = array[pivotIndex];
			array[pivotIndex] = array[end];
			array[end] = temp;

			return pivotIndex;
		}
	}

}
