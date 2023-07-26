using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        
        int[] array1 = new int[size];
        int[] array2 = new int[size];

        // array 1
        Console.WriteLine("Enter values for Array 1 >");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value for index {i}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        //  array2
        Console.WriteLine("\nEnter values for Array 2 >");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value for index {i}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        // ScSum
        int scalarSum = 0;
        for (int i = 0; i < size; i++)
        {
            scalarSum += array1[i];
        }
        Console.WriteLine($"Scalar Sum: {scalarSum}");

        // VecSum
        int[] vectorSum = new int[size];
        for (int i = 0; i < size; i++)
        {
            vectorSum[i] = array1[i] + array2[i];
        }
        Console.WriteLine("Vector Sum:");
        DisplayArray(vectorSum);

        // VecPrd
        int[] vectorProduct = new int[size];
        for (int i = 0; i < size; i++)
        {
            vectorProduct[i] = array1[i] * array2[i];
        }
        Console.WriteLine("Vector Product:");
        DisplayArray(vectorProduct);

        // ScPrd
        int scalarProduct = 1;
        for (int i = 0; i < size; i++)
        {
            scalarProduct *= array1[i] * array2[i];
        }
        Console.WriteLine($"Scalar Product: {scalarProduct}");
    }

    static void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
