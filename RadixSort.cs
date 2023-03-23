using System;
					
public class Program
{
    public static void Main() {
		// Unsorted set of numbers
        int[] arr = { 5, 4, 3, 5, 8, 7, 1, 9, 2, 4, 6 };
		// Call sort function
        Radixsort(arr);
		// Print result
        PrintArray(arr);
    }

    // A utility function to print an array
    private static void PrintArray(int[] arr) {
        foreach (int i in arr) {
            Console.Write(i + " ");
        }
    }

    // The main function to do Radix Sort
    private static void Radixsort(int[] arr) {
        // Find the maximum number to know the number of digits
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
        }

        // Do counting sort for every digit
        for (int exp = 1; max / exp > 0; exp *= 10) {
            CountSort(arr, exp);
        }
    }

    // A utility function to do counting sort of arr[] according to
    // the digit represented by exp.
    private static void CountSort(int[] arr, int exp) {
        int n = arr.Length;
        int[] output = new int[n]; // output array
        int[] count = new int[10];

        // Store count of occurrences in count[]
        for (int i = 0; i < n; i++) {
            int index = (arr[i] / exp) % 10;
            count[index]++;
        }

        // Change count[i] so that count[i] now contains actual
        // position of this digit in output[]
        for (int i = 1; i < 10; i++) {
            count[i] += count[i - 1];
        }

        // Build the output array
        for (int i = n - 1; i >= 0; i--) {
            int index = (arr[i] / exp) % 10;
            output[count[index] - 1] = arr[i];
            count[index]--;
        }

        // Copy the output array to arr[], so that arr[] now
        // contains sorted numbers according to current digit
        for (int i = 0; i < n; i++) {
            arr[i] = output[i];
        }
    }
}