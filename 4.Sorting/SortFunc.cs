
namespace _4.Sorting
{
    public class SortFunc
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
                        // Hoán đổi các phần tử nếu chúng không đúng thứ tự
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên của đoạn chưa được sắp xếp
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }


        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                L[i] = array[left + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                R[j] = array[middle + 1 + j];
            }

            int k = left;
            int p = 0, q = 0;
            while (p < n1 && q < n2)
            {
                if (L[p] <= R[q])
                {
                    array[k] = L[p];
                    p++;
                }
                else
                {
                    array[k] = R[q];
                    q++;
                }
                k++;
            }
            while (p < n1)
            {
                array[k] = L[p];
                p++;
                k++;
            }
            while (q < n2)
            {
                array[k] = R[q];
                q++;
                k++;
            }
        }
    }
}
