using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[10] { 5, 6, 8, 4, 7, 9, 1, 2, 3, 0 };
			Print(array);
			Console.WriteLine("- Defalut Array:");

			Sorting.BubbleSort(array);
			Print(array);
			Console.WriteLine("- Bubble Sort:");

			array = new int[10] { 5, 6, 8, 4, 7, 9, 1, 2, 3, 0 };
			Sorting.SelectionSort(array);
			Print(array);
			Console.WriteLine("- Selection Sort:");

			array = new int[10] { 5, 6, 8, 4, 7, 9, 1, 2, 3, 0 };
			Sorting.InsertionSort(array);
			Print(array);
			Console.WriteLine("- Insertion Sort:");

			array = new int[10] { 5, 6, 8, 4, 7, 9, 1, 2, 3, 0 };
			Sorting.MergeSort(array);
			Print(array);
			Console.WriteLine("- Merge Sort");

			array = new int[10] { 5, 6, 8, 4, 7, 9, 1, 2, 3, 0 };
			Sorting.QuickSort(array);
			Print(array);
			Console.WriteLine("- Quick Sort");

			Console.ReadLine();
		}

		static void Print(int[] array)
		{
			foreach (int i in array)
				Console.Write(i + " ");
        }
	}
}
