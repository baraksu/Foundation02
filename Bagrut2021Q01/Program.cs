namespace Bagrut2021Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 6,9,2,2,9,4,-3 };

            var arr2 = Filter(arr, 9);

            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static int[] Filter(int[] arr, int num)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!= num)
                {
                    counter++;
                } 
            }

            int[] arr2 = new int[counter];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    arr2[j] = arr[i];
                    j += 1;
                }
            }

            return arr2;
        }
    }

}
