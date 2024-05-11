using System.Text;
class Program
{
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 5, 7, 8, 3, 15, 2 };
        BubbleSort(array);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
       
    }
}