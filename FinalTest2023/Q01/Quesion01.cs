namespace FinalTest2023
{
    public class Quesion01
    {
        public static bool IsZigzag(int[] arr)
        {
           
            if (arr == null)
            {
                return true;

            }

            if (arr.Length == 1)
            {
                return true;
            }

            if (arr.Length >= 2)
            {
                if (arr[0] == arr[1])
                {
                    return false;
                }

                if (arr.Length == 2)
                {
                    return true;
                }
            }

            for (int i = 2; i < arr.Length; i++)
            {
                
                if (arr[i - 2] < arr[i - 1] && arr[i - 1] <= arr[i])
                    return false;

                if (arr[i - 2] > arr[i - 1] && arr[i - 1] >= arr[i])
                    return false;

            }
            return true;

        }
    }
}