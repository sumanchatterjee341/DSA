using DSA.Helper;

namespace DSA.DSA.Algorithm.Sort
{
    public static class Sort
    {
        /// <summary>
        /// Keeps the minimum at first
        /// Time Complexity O(N^2) => Worst, Avg, Best
        ///  Space Complexity O(N)
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                int minimumIndex = i;
                for (int j = i; j <= arr.Length - 1; j++)
                {
                    if (arr[j] < arr[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }
                DSAHelpers.Swap(arr, minimumIndex, i);
            }

            Console.WriteLine("Sorted Array Length: " + arr.Length);
            DSAHelpers.PrintArray(arr);
        }


        /// <summary>
        /// Pushes the Max no to Last in each step
        /// Time Complexity O(n^2) => Worst and Avg 
        /// Time Complexity O(N) => Best
        /// Space Complexity => O(N)
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int didSwap = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        DSAHelpers.Swap(arr, j, j + 1);
                        didSwap = 1;
                    }
                }
                if (didSwap == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Sorted Array Length: " + arr.Length);
            DSAHelpers.PrintArray(arr);
        }


        /// <summary>
        /// Takes an element and place it in correct place by swaping
        /// Time complexity O(n^2) => Worst and Avg
        /// Time Complexity O(n) => best
        /// Space Complexity => O(N)
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    DSAHelpers.Swap(arr, j, j - 1);
                    j--;
                }
            }

            Console.WriteLine("Sorted Array Length: " + arr.Length);
            DSAHelpers.PrintArray(arr);
        }
    }
}