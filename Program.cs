using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = GenerateRandomIntList(1000, 50000);
            List<int> revIntList = intList;
            revIntList.Sort();
            List<int> nearSort = new List<int>(revIntList);
            for (int i = 0; i >= 0.0125* nearSort.Count; i++)
            {
                int end = (int)(0.025 * nearSort.Count);
                int temp = nearSort[i];
                nearSort[i] = nearSort[end];
                nearSort[end] = temp;
            }
            revIntList.Reverse();

;           List<double> doubleList = GenerateRandomDoubleList(100, 500);

            Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));

         
            Console.WriteLine("INSERTION SORT");
            InsertionSort<int> insertionSort = new InsertionSort<int>();
            double avg = 0;
            double wst = 0;
            double best = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort(insertionSort, intListCopy);
                wst += TimeSort(insertionSort, revIntListCopy);
                best += TimeSort(insertionSort, nearSortCopy); ;
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();


            Console.WriteLine("SELECTION SORT");
            SelectionSort<int> selectionSort = new SelectionSort<int>();
            avg = 0;
            wst = 0;
            best = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort(selectionSort, intListCopy);
                wst += TimeSort(selectionSort, revIntListCopy);
                best += TimeSort(selectionSort, nearSortCopy); ;
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();


            Console.WriteLine("QUICK SORT");
            QuickSort<int> quickSort = new QuickSort<int>();
            avg = 0;
            wst = 0;
            best = 0;
            for ( int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort (quickSort, intListCopy);
                wst += TimeSort(quickSort, revIntListCopy);
                best += TimeSort(quickSort, nearSortCopy); ;
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();


            Console.WriteLine("MERGE SORT");
            MergeSort<int> mergeSort = new MergeSort<int>();
            avg = 0;
            wst = 0;
            best = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort (mergeSort, intListCopy);
                wst += TimeSort(mergeSort, revIntListCopy);
                best += TimeSort(mergeSort, nearSortCopy); ;
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();


            Console.WriteLine("BUCKET SORT");
            BucketSort bucketSort = new BucketSort();
            avg = 0;
            wst = 0;
            best = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort(bucketSort, intListCopy);
                wst += TimeSort(bucketSort, revIntListCopy);
                best += TimeSort(bucketSort, nearSortCopy); 
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();


            Console.WriteLine("RADIX SORT");
            RadixSort radixSort = new RadixSort();
            avg = 0;
            wst = 0;
            best = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> revIntListCopy = new List<int>(revIntList);
                List<int> intListCopy = new List<int>(intList);
                List<int> nearSortCopy = new List<int>(nearSort);
                avg += TimeSort(radixSort, intListCopy);
                wst += TimeSort(radixSort, revIntListCopy);
                best += TimeSort(radixSort, nearSortCopy); ;
            }
            avg /= 11;
            wst /= 11;
            best /= 11;
            Console.WriteLine("Average Case");
            Console.WriteLine(avg);
            Console.WriteLine("Worst Case");
            Console.WriteLine(wst);
            Console.WriteLine("Best Case");
            Console.WriteLine(best);
            Console.WriteLine();

        }

        public static double TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            //Console.WriteLine(elapsedTime);
            return (ts.TotalSeconds);

        }

        public static double TimeSort(ISortableInt sortable, List<int> items)
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(items.ToArray());

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            //Console.WriteLine(elapsedTime);
            return (ts.TotalSeconds);
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for(int i=0; i < length; i++)
            {
                list.Add(random.Next(maxValue));               
            }

            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble()* maxValue);
            }

            return list;
        }
    }
}
