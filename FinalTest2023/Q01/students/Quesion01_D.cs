namespace FinalTest2023.Q01.students
{
    public class Quesion01_D
    {
        public static bool IsZigzag(int[] arr)
        {
            bool okay = true;

            for (int i = 0; i < arr.Length -1; i+=2)
            {
                if (!(arr[i] < arr[i + 1] && arr[i] < arr[i - 1]))
                    okay = false;
            }

            if (!okay)
            {
                for (int i = 0; i < arr.Length - 1; i += 2)
                {
                    if (!(arr[i] > arr[i + 1] && arr[i] >arr[i - 1]))
                        okay = false;
                }
            }

            return okay;

        }
    }
}