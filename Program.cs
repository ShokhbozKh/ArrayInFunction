namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1,2,3,4,5};

            Console.WriteLine("array 1");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nArray 2");
            ArrayChange(array);


        }

        static void ArrayChange(int[] arr)
        {
            for (int i = 0; i< arr.Length; i++)
            {
                arr[i] = arr[i] * 2;
            }
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}