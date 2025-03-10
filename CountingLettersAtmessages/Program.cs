﻿namespace CountingLettersAtmessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "The output from Hufman's algorithm can be viewed as a variable length code table for encoding a source symbol. The algorithm derives this table from the estimated probability or frequency of occurrence for each possible value of the source symbol. as in other entropy encoding methods, more common symbols are generally represented using fewer bits than less common symbols. Huffman's method can be efficiently implemented, finding a code in time linear to the number of input weights if these weights are sorted. However, although optimal among methods encoding symbols separately, Huffman coding is not always optimal among all compression methods it is replaced with arithmetic coding or asymmetric numeral systems if better compression ratio is required.";

            //string message = "internet";
            //countingLetters.countIndex(message);
            //countingAnyLetters.countingAnyLettersusingHash(message);
            huffman hf = new huffman(message);

            foreach (var k in hf.code.Keys)
            {
                Console.Write(k + " ");
                Console.WriteLine(hf.code[k]);
            }
        }
    }
}
