using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace intArrays
{
    public class ArrayOperations
    {
        public int[,] intArray = new int[4,6];
        //int[] intintArrays = { 1, 2, 3, 4, 5, 6 };
        //int index = i
        public void Add(int startingNumber)
        {
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < intArray.GetLength(1); j++)
                {

                    intArray[i,j] = startingNumber;
                    Console.Write($"\t{intArray[i,j]}\t");
                    startingNumber++;
                }
                Console.Write("\n");
            }
        }

        // Linear search
        public void LinearSearch(int v)
        {
           
            string result=String.Empty;
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] == v)
                    {
                        result = $"Position: [{i},{j}]";
                        break;
                    }
                }
            }
            if(result == String.Empty)
            {
                result = "Element not found";
            }
            Console.WriteLine(result);
        }

        // Binary search
        public void BinarySearch(int target)
        {
            int max, min, mid;
            string position=String.Empty;
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                int[] arr = Enumerable.Range(0, intArray.GetLength(1)).Select(x => intArray[i, x]).ToArray();
                max = arr.Length-1;
                if (target>arr[max])
                {
                    continue;
                }
                else
                { 
                    var res = binarysearch(arr, 0, arr.Length - 1, target);
                    position = $"{i},{res}";
                    break;
                }
            }
            if (position == String.Empty)
            {
                position = "Element not found";
            }
            Console.WriteLine(position);

            int binarysearch(int[] arr, int min, int max, int target)
            {
                if (max >= min)
                {
                    mid = min + (max - min) / 2;
                    if (arr[mid] == target)
                        return mid;

                    if (arr[mid] > target)
                        return binarysearch(arr, min, mid - 1, target);

                    return binarysearch(arr, mid + 1, max, target);
                }
                return -1;
            }
            
        }
        
    }
}