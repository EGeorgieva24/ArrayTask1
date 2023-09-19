using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Elements stored in the array:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Element {i + 1}: {arr[i]}");
        }
    }
}
