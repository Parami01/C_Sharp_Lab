using System;

class ArrayManager
{
    public int[] ArrWtZros(int size)
    {
        int[] arr = new int[size * 2];
        for (int i = 0; i < size * 2; i += 2)
        {
            Console.Write($"Enter value for index {i / 2}: ");
            arr[i] = int.Parse(Console.ReadLine());
            arr[i + 1] = 0;
        }
        return arr;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array > ");
        int size = int.Parse(Console.ReadLine());

        ArrayManager arrayManager = new ArrayManager();
        int[] array = arrayManager.ArrWtZros(size);

        Console.WriteLine("\nArray with user inputs followed by 0s:");
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