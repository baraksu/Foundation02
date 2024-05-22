namespace Bagrut2019Q01
{
    public class Bagrut2019Q01Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Exact(string[] arr, int num)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == num)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
