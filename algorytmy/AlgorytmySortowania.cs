using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    internal class AlgorytmySortowania
    {
        public void bubble_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        public void selection_sort(int[] arr)
        {

        }

        public void insertion_sort(int[] arr)
        {

        }

        public void quick_sort(int[] arr, int start, int end)
        {

        }

        private int partition(int[] arr, int start, int end)
        {
            return 1;
        }

        public void merge_sort(int[] arr)
        {

        }

        private void merge(int[] arr, int[] left, int[] right)
        {

        }
    }
}
