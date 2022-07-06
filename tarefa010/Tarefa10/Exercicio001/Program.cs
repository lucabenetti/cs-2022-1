using System;
using System.Diagnostics;

namespace Exercicio001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            TestarQuickSortRecursivo(ObterArrayDesordenado());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort recursivo: {stopwatch.Elapsed}");
            stopwatch.Reset();

            stopwatch.Start();
            TestarQuickSort(ObterArrayDesordenado());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort: {stopwatch.Elapsed}");
        }

        private static void TestarQuickSort(int[] arr)
        {
            new QuickSort().Sort(arr);
        }

        private static void TestarQuickSortRecursivo(int[] arr)
        {
            new QuickSortRecursivo().Sort(arr, 0, arr.Length - 1);
        }

        private static int[] ObterArrayDesordenado()
        {
            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            return arr;
        }
    }
}
