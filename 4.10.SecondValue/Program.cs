using System.Text;

class Program
{
    /*  public static void BubbleSort(int[] array)
      {
          int n = array.Length;
          for (int i = 0; i < n - 1; i++)
          {
              for (int j = 0; j < n - i - 1; j++)
              {
                  if (array[j] < array[j + 1])
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

          Console.Write(" Gia Tri lon thu 2 la: "+ array[1]);


      }*/


    static int SecondLargest(int[] array)
    {
        if (array.Length < 2)
        {
            throw new ArgumentException("Mảng phải chứa ít nhất hai phần tử.");
        }
        return array.OrderByDescending(x => x).Skip(1).First();
       /* Array.Sort(array); // Sắp xếp mảng giảm dần
        return array[1];*/
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
        int secondLargest = SecondLargest(array);
        Console.WriteLine("Số lớn thứ hai trong mảng là: " + secondLargest);
    }
}

