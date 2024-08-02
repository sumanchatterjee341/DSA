namespace DSA.Helper
{
    public static class DSAHelpers
    {
        public static int[] Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i] + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
    }
}