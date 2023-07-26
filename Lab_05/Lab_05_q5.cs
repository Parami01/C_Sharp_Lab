using System;

class ArrayOperations
{
    public int FndMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }

    public int FndMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    public double FndAvg(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return (double)sum / arr.Length;
    }

    public void RvsArr(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] array = new int[10];

        Console.Write("Enter the numbers for array > \n");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter value for index {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        ArrayOperations arrayOperations = new ArrayOperations();

        // min
        int min = arrayOperations.FndMin(array);
        Console.WriteLine($"Minimum value: {min}");

        // max
        int max = arrayOperations.FndMax(array);
        Console.WriteLine($"Maximum value: {max}");

        // avg
        double avg = arrayOperations.FndAvg(array);
        Console.WriteLine($"Average value: {avg}");

        // Reverse
        arrayOperations.RvsArr(array);
        Console.WriteLine("Array in reverse order:");
        DisplayArray(array);
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
