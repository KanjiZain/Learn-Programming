﻿using System;

class MyProgram
{
    // function for quick sort which calls partition function 
    // to arrange and split the list based on pivot element
    // quicksort is a recursive function
    static void quicksort(int[] Array, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(Array, left, right);
            quicksort(Array, left, pivot - 1);
            quicksort(Array, pivot + 1, right);
        }
    }

    // partition function arrange and split the list 
    // into two list based on pivot element
    // In this example, last element of list is chosen 
    // as pivot element. one list contains all elements 
    // less than the pivot element another list contains 
    // all elements greater than the pivot element
    static int partition(int[] Array, int left, int right)
    {
        int i = left;
        int pivot = Array[right];
        int temp;

        for (int j = left; j <= right; j++)
        {
            if (Array[j] < pivot)
            {
                temp = Array[i];
                Array[i] = Array[j];
                Array[j] = temp;
                i++;
            }
        }

        temp = Array[right];
        Array[right] = Array[i];
        Array[i] = temp;
        return i;
    }

    // function to print array
    static void PrintArray(int[] Array)
    {
        int n = Array.Length;
        for (int i = 0; i < n; i++)
            Console.Write(Array[i] + " ");
        Console.Write("\n");
    }

    // test the code
    static void Main(string[] args)
    {
        int[] MyArray = { -4, 1, 25, 50, 8, 10, 23 };
        int n = MyArray.Length;
        Console.Write("Original Array\n");
        PrintArray(MyArray);

        quicksort(MyArray, 0, n - 1);
        Console.Write("\nSorted Array\n");
        PrintArray(MyArray);
    }
}