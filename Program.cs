using System.Runtime.CompilerServices;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region 
			//Task1
			int[] arr1 = { 44, 23, 45, 34, 23, 45, 46, 47, 48, 44 };

			//	foreach (int i in arr1)
			//	{
			//		int count = 0;
			//	foreach (int j in arr1)
			//	{
			//		if (i == j)
			//		{
			//			count++;
			//		}
			//	}
			//	if (count == 1)
			//	{
			//		Console.WriteLine(i);
			//	}

			//}
			#endregion
			#region 
			//Task2
			//int[] arr3 = { 1, 2, 3,4,5,6,7,8,9 };

			//int[] arr4 = new int[arr3.Length];

			//for (int i = 0; i < arr3.Length; i++)
			//{
			//	arr4[i] = arr3[i];
			//	Console.WriteLine(arr4[i]);
			//}
			#endregion
			#region
			//Task 3
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6};

			for (int i = 0; i < nums.Length; i++)
			{
				int count = 0;
				for (int j = 0; j < nums.Length; j++)
				{
					if (nums[i] == nums[j])
					{	
						count++;
                    }
				}
				Console.WriteLine($"{nums[i]} - {count} tekrar etdi ");
			}

			#endregion


		}
	}
}