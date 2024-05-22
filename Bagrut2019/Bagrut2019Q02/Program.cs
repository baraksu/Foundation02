namespace Bagrut2019Q02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Flashlight[] arr = new Flashlight[4];
            arr[0] = new Flashlight("A", 10);
            arr[1] = new Flashlight("B", 20);
            arr[2] = new Flashlight("C", 30);
            arr[3] = new Flashlight("D", 40);
            ThreeFlashlight(arr, 90);
            Console.ReadKey();
        }

        public static void ThreeFlashlight(Flashlight[] arr, double total)
        {
            bool found = false;
            for (int i = 0; i < arr.Length && !found; i++)
            {
                for (int j = i+1; j < arr.Length && !found; j++)
                {
                    for (int k = j+1; k < arr.Length && !found; k++)
                    {
                        if (arr[i].GetPrice() + arr[j].GetPrice() + arr[k].GetPrice() == total)
                        {
                            found= true;
                            Console.WriteLine(arr[i].GetModel() + " " + arr[j].GetModel() + " " + arr[k].GetModel());
                        }
                    }
                }
            }


        }
    }
}
