using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Program
    {

        static void swap<T>(ref T x, ref T y)
        {
          //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }


        static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine();
        }

        static bool IsInOrder<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            string[] array1 = { "Fred", "Zoe", "Angela", "Umbrella", "Ben" };
            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns", 
                "Problem Solving in Java"};
            string[] authors ={ "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };

            Book[] library = new Book[10];

            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
            }

            
            SelectionSort(ref library);

            foreach (Book book in library)
            {
                Console.WriteLine(" {0} ", book);
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        static void SelectionSort(ref Book[] arr)
        {
            int smallestIndex, index, minIndex;
            Book temp;
            for (index = 0; index < arr.Length - 1; index++)
            {
                smallestIndex = index;
                for (minIndex = index; minIndex < arr.Length; minIndex++)
                {
                    IComparable<Book> i = arr[minIndex];
                    if (i.CompareTo(arr[smallestIndex]) < 0)
                      smallestIndex = minIndex;
                      temp = arr[smallestIndex];
                      arr[smallestIndex] = arr[index];
                      arr[index] = temp;
                }
            }
        }

    }
}
