using System;
using System.Diagnostics;
using System.Linq;

namespace Exercicio001
{
    internal class Program
    {
        private static int[] array100;
        private static int[] array1000;
        private static int[] array10000;

        static void Main(string[] args)
        {
            PopularArrays();

            var stopwatch = new Stopwatch();

            Console.WriteLine("// ARRAY DE 100 //");

            stopwatch.Start();
            TestarQuickSortRecursivo(ObterArray100());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort recursivo: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSort(ObterArray100());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort: {stopwatch.Elapsed}");
            stopwatch.Reset();

            Console.WriteLine("// ARRAY DE 1000 //");

            stopwatch.Start();
            TestarQuickSortRecursivo(ObterArray1000());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort recursivo: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSort(ObterArray1000());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort: {stopwatch.Elapsed}");
            stopwatch.Reset();

            Console.WriteLine("// ARRAY DE 10000 //");

            stopwatch.Start();
            TestarQuickSortRecursivo(ObterArray10000());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort recursivo: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSort(ObterArray10000());
            stopwatch.Stop();

            Console.WriteLine($"Quick sort: {stopwatch.Elapsed}");
            stopwatch.Reset();
        }

        private static void PopularArrays()
        {
            var random = new Random();
            array100 = new int[100];
            array1000 = new int[1000];
            array10000 = new int[10000];

            PopularArray(array100, random);
            PopularArray(array1000, random);
            PopularArray(array10000, random);
        }

        private static void PopularArray(int[] array, Random random)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(0, array.Length);
            }
        }

        private static void TestarQuickSort(int[] arr)
        {
            new QuickSort().Sort(arr);
        }

        private static void TestarQuickSortRecursivo(int[] arr)
        {
            new QuickSortRecursivo().Sort(ref arr, 0, arr.Length - 1);
        }

        private static int[] ObterArray100()
        {
            int[] arr = new int[100];
            Array.Copy(array100, arr, array100.Length);
            return arr;
        }

        private static int[] ObterArray1000()
        {
            int[] arr = new int[1000];
            Array.Copy(array1000, arr, array1000.Length);
            return arr;
        }

        private static int[] ObterArray10000()
        {
            int[] arr = new int[10000];
            Array.Copy(array10000, arr, array10000.Length);
            return arr;
        }
    }
}
