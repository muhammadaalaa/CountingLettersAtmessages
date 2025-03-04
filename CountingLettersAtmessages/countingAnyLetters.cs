using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CountingLettersAtmessages
{
    public static class countingAnyLetters
    {
        // use hash table ==> not sorted 
        // //key and value
        //steps 
        //message
        //loop also 
        //find for example index h 
        // loop at the keys of the hash table 
        // if that index is existesd at the keys of that hash  + tha value by one 
        // else set it's value by one 
        public static void countingAnyLettersusingHash(string message)
        {
            Hashtable hashed = new Hashtable();
            //key and value
            // loop at the keys of that hash 
            for (int i = 0; i < message.Length; i++)
            {
                if (hashed[message[i]] == null)
                {
                    hashed[message[i]] = 1;

                }
                else
                {
                    hashed[message[i]] = (int)hashed[message[i]] + 1;
                }
            }

            foreach (var key in hashed.Keys)
            {
                Console.Write(key + " ");
                Console.WriteLine(hashed[key]);
            }
            converthashtoarray(hashed);

        }


        //we can't sort hash atble so we have to convert it to array first
        // since this hash is key value pair we have to create 2 dimension array 
        //[number of keys,2]
        //and do the meregesort
        public static void converthashtoarray(Hashtable hased)
        {
            int[,] convertedarray = new int[hased.Count, 2];
            int i = 0;
            foreach (char key in hased.Keys)
            {
                convertedarray[i, 0] = (int)key;
                convertedarray[i, 1] = (int)hased[key];
                i++;
            }
            sort(convertedarray, 0, hased.Count - 1);
            Console.WriteLine("Print Sorted data ...");
            for (i = 0; i < hased.Count; i++)
            {
                Console.Write((char)convertedarray[i, 0] + " ");
                Console.WriteLine(convertedarray[i, 1]);
            }
        }


        public static void sort(int[,] arr, int start, int end)
        {
            if (end <= start) return;
            int midpoint = (start + end) / 2;
            sort(arr, start, midpoint);
            sort(arr, midpoint + 1, end);
            merge(arr, start, midpoint, end);
        }
        public static void merge(int[,] arr, int start, int midpoint, int end)
        {

            int i = 0;
            int j = 0;
            int lengthOfTheLeftArray = midpoint - start + 1;
            int lengthOfTherightArray = end - midpoint;
            int[,] leftarray = new int[lengthOfTheLeftArray, 2];
            int[,] rightarray = new int[lengthOfTherightArray, 2];

            for (; i < lengthOfTheLeftArray; i++)
            {
                leftarray[i, 0] = arr[start + i, 0];
                leftarray[i, 1] = arr[start + i, 1];
            }
            for (; j < lengthOfTherightArray; j++)
            {
                rightarray[j, 0] = arr[midpoint + j + 1, 0];
                rightarray[j, 1] = arr[midpoint + j + 1, 1];
            }
            i = 0;
            j = 0;
            int k = start;
            while (i < lengthOfTheLeftArray && j < lengthOfTherightArray)
            {
                if (leftarray[i, 1] <= rightarray[j, 1])
                {
                    arr[k, 0] = leftarray[i, 0];
                    arr[k, 1] = leftarray[i, 1];
                    i++;


                }
                else
                {
                    arr[k, 0] = rightarray[j, 0];
                    arr[k, 1] = rightarray[j, 1];
                    j++;
                }
                k++;
            }
            while (i < lengthOfTheLeftArray)
            {
                arr[k, 0] = leftarray[i, 0];
                arr[k, 1] = leftarray[i, 1];
                i++;
                k++;
            }
            while (j < lengthOfTherightArray)
            {
                arr[k, 0] = rightarray[j, 0];
                arr[k, 1] = rightarray[j, 1];
                j++;
                k++;
            }
        }


    }
}
