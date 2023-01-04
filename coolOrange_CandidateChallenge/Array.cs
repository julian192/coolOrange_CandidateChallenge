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
            int max = array[position1];
            for(int i = position1; i < position2; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        /**
         *  returns the position of the minimum value in the array between two positions
         */
        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            int min = array[position1];
            int minposition = position1;
            for(int i = position1; i < position2; i++)
                if (array[i] < min)
                {
                    min = array[i];
                    minposition = i;
                }
            return minposition;
        }

        /**
         *  swaps the elements of the two passed positions in the array
         */
        public static void Swap(int[] array, int position1, int position2)
        {
            int tmp = array[position1];
            array[position1] = array[position2];
            array[position2] = tmp;
        }

        /**
         *  shifts all the elements between the passed positions to the left by one position and leaves position2 unchanged
         */
        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            int tmp = array[position1];
            for(int i = position1; i < position2 - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[position2 - 1] = tmp;
        }

        /**
         *  creates and returns an array with the passed size and random values between min and max (use the Random Class of C#)
         */
        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            var rand = new Random();
            int[] ret = new int[size];
            for (int i = 0; i < size; i++)
                ret[i] = rand.Next(minValue, maxValue);
            return ret;
        }

        /**
         *  creates and returns a two-dimensional array with rows and columns of random elements with values between min and max (use the Random Class of C#)
         */
        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            var rand = new Random();
            int[,] ret = new int[rows, columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    ret[i, j] = rand.Next(minValue, maxValue);
            return ret;
        }

        /**
         *  returns a two-dimensional array with the original and the copy of the array
         */
        public static int[,] CopyArray(int[] array)
        {
            int[,] ret = new int[array.Length, 2];
            for(int i = 0; i < array.Length; i++)
                ret[i, 0] = ret[i, 1] = array[i];
            return ret;
        }

        /**
         *  returns a random position of the passed number in the sorted array. The function returns −1 if the number is not present in the array. 
         *  The method assumes that the array is already sorted. 
         *  Bonus: Exploit the fact that the array is sorted to find an efficient algorithm.
         *  (Hint: Binary search algorithm)
         */
        public static int FindInSortedArrary(int[] array, int number)
        {
            int start = 0;
            int end = array.Length - 1;
            while(start <= end)
            {
                int middle = start + (end - start) / 2;
                if(number < array[middle])
                    end = middle - 1;
                else if(number > array[middle])
                    start= middle + 1;
                else
                    return middle;
            }
            return -1;
        }
    }
}
