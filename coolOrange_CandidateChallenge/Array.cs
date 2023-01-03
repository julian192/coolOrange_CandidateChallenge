using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {
        /**
         *  returns the maximum value occurring in the array two positions
         */
        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            return -1;
        }

        /**
         *  returns the position of the minimum value in the array between two positions
         */
        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            return -1;
        }

        /**
         *  swaps the elements of the two passed positions in the array
         */
        public static void Swap(int[] array, int position1, int position2)
        {
        }

        /**
         *  shifts all the elements between the passed positions to the left by one position and leaves position2 unchanged
         */
        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
        }

        /**
         *  creates and returns an array with the passed size and random values between min and max (use the Random Class of C#)
         */
        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            return new int[size];
        }

        /**
         *  creates and returns a two-dimensional array with rows and columns of random elements with values between min and max (use the Random Class of C#)
         */
        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            return new int[rows, columns];
        }

        /**
         *  returns a two-dimensional array with the original and the copy of the array
         */
        public static int[,] CopyArray(int[] array)
        {
            return  new int[array.Length,array.Length];
        }

        /**
         *  returns a random position of the passed number in the sorted array. The function returns −1 if the number is not present in the array. 
         * The method assumes that the array is already sorted. 
         * Bonus: Exploit the fact that the array is sorted to find an efficient algorithm.
         * (Hint: Binary search algorithm)
         */
        public static int FindInSortedArrary(int[] array, int number)
        {
            return -1;
        }
    }
}
