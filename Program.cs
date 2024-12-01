using System;
using sortinterface;
class program
{
    static void Main(string[] args)
    {
        int[] element = { 44, 96, 100, 77, 14, 65, 8, 68, 5, 84, 93, 54, 47, 95, 11,
                          53, 80, 4, 90, 86, 0, 40, 57, 75, 101, 97, 61, 87, 89, 2, 52,
                          91, 46, 85, 50, 63, 30, 55, 35, 22, 43, 67, 73, 92, 17, 56,
                          36, 31, 37, 12, 33, 26, 82, 51, 45, 74, 60, 3, 13, 71, 16,
                          15, 7, 49, 72, 66, 25, 1, 38, 88, 59, 69, 79, 81, 42, 28,
                          23, 98, 78, 83, 18, 21, 27, 32, 41, 58, 19, 62, 76, 20,
                          39, 99, 24, 29, 6, 9, 94, 64, 70, 10 };


        Sort sort = new Sort();



        Console.WriteLine("BubbleSort: ");
        sort.BubbleSort(element);
        Console.WriteLine(string.Join(", ", element));


        ResetArray(element);

        Console.WriteLine("InsertionSort: ");
        sort.InsertionSort(element);
        Console.WriteLine(string.Join(", ", element));


        ResetArray(element);

        Console.WriteLine("SelectionSort: ");
        sort.SelectionSort(element);
        Console.WriteLine(string.Join(", ", element));


        ResetArray(element);

        Console.WriteLine("MergeSort: ");
        sort.MergeSort(element, 0, element.Length - 1);
        Console.WriteLine(string.Join(", ", element));
    }
    private static void ResetArray(int[] element)
    {
        int[] original = { 44, 96, 100, 77, 14, 65, 8, 68, 5, 84, 93, 54, 47, 95, 11,
                          53, 80, 4, 90, 86, 0, 40, 57, 75, 101, 97, 61, 87, 89, 2, 52,
                          91, 46, 85, 50, 63, 30, 55, 35, 22, 43, 67, 73, 92, 17, 56,
                          36, 31, 37, 12, 33, 26, 82, 51, 45, 74, 60, 3, 13, 71, 16,
                          15, 7, 49, 72, 66, 25, 1, 38, 88, 59, 69, 79, 81, 42, 28,
                          23, 98, 78, 83, 18, 21, 27, 32, 41, 58, 19, 62, 76, 20,
                          39, 99, 24, 29, 6, 9, 94, 64, 70, 10 };
        Array.Copy(original, element, original.Length);
    }
}

