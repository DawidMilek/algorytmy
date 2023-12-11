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
            for(int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }

                int tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }
        }

        public void insertion_sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }
        }

        public void quick_sort(int[] arr, int start, int end)
        {
            if(start >= end) return;

            int pivot = partition(arr, start, end);
            quick_sort(arr, start, pivot - 1);
            quick_sort(arr, pivot + 1, end);
        }

        private int partition(int[] arr, int start, int end)
        {
            int pivot = end;
            int j = start - 1;

            for (int i = start; i <= end - 1; i++)
            {
                if (arr[i] < arr[pivot])
                {
                    j++;
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            j++;
            int tmp2 = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = tmp2;
            return j;
        }

        public void merge_sort(int[] arr)
        {
            if (arr.Length == 1) return;

            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[i + left.Length];
            }

            merge_sort(left);
            merge_sort(right);
            merge(arr, left, right);
        }

        private void merge(int[] arr, int[] left, int[] right)
        {
            int i = 0;
            int l = 0;
            int r = 0;

            while (l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                {
                    arr[i] = left[l];
                    i++;
                    l++;
                }
                else
                {
                    arr[i] = right[r];
                    i++;
                    r++;
                }
            }

            while (l < left.Length)
            {
                arr[i] = left[l];
                i++;
                l++;
            }

            while (r < right.Length)
            {
                arr[i] = right[r];
                i++;
                r++;
            }
        }
    }
}
