
// C# program for Merge Sort
using System;

namespace SortTimer
{
    class MergeSort
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        void mMerge(ref int[] arr, int l, int m, int r, bool v)
        {

            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public long Sort(ref int[] arr, bool v)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            arr = sortRec(ref arr, 0, arr.Length - 1, v);
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            return time; ;
        }

        public ref int[] sortRec(ref int[] arr, int l, int r, bool v)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sortRec(ref arr, l, m, v);
                sortRec(ref arr, m + 1, r, v);

                // Merge the sorted halves
                mMerge(ref arr, l, m, r, v);
            }

            return ref arr;
        }


    }

    class SelectionSort
    {

        public long Sort(ref int[] arr, bool v)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            return time;
        }

    }

    class QuickSort
    {
        public long Sort(ref int[] arr, bool v)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            arr = sortRec(ref arr, 0, arr.Length - 1);
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            return time;
        }

        ref int[] sortRec(ref int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(ref arr, start, end);

                sortRec(ref arr, start, i - 1);
                sortRec(ref arr, i + 1, end);
            }

            return ref arr;
        }

        int Partition(ref int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }

    class ShellSort
    {
        /* function to sort arr using shellSort */
        public long Sort(ref int[] arr, bool v)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int n = arr.Length;

            // Start with a big gap,
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    int temp = arr[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    // put temp (the original a[i])
                    // in its correct location
                    arr[j] = temp;
                }
            }
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            return time;
        }

    }


}

