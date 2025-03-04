using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLettersAtmessages
{
    public static class countingLetters
    {
        // steps 
        //message ==> "hello world"
        // loop at this string 
        //index [h]  ==> convert it into asci code 
        // result =[]
        // search at this array if this index exist at this array or not
        // if exist +1
        // else add and set the counter 1
        //log each index at the message and log the log the times it repeated 


        public static void countIndex(string message)
        {
            int[] asciArray = new int[127];

            for (int i = 0; i < message.Length; i++)
            {
                int AsciCodeOfTheChara = (int)message[i];
                asciArray[AsciCodeOfTheChara] += 1;
            }
            for (int i = 0; i < asciArray.Length; i++)
            {
                if (asciArray[i] > 0)
                {
                    char c = (char)i;
                    Console.Write(c + " ");
                    Console.WriteLine(asciArray[i]);
                }
            }
        }
    }
}
