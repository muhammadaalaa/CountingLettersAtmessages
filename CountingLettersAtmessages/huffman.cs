using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CountingLettersAtmessages
{
    internal class huffman
    {
        public Hashtable code = new Hashtable();

        public PriorityQueue<headNode, int> minheap = new PriorityQueue<headNode, int>();
        #region hashTable for counting the letters 

        public huffman(string message)
        {
            Hashtable CountFreq = new Hashtable();
            int i = 0;
            for (; i < message.Length; i++)
            {
                if (CountFreq[message[i]] == null)
                {
                    CountFreq[message[i]] = 1;
                }
                else
                {
                    CountFreq[message[i]] = (int)CountFreq[message[i]] + 1;
                }
            }

            // we need to create  a priority code to be able to change the location the node and it's chids
            // converting the hash table to priority queue 
            i = 0;
            foreach (char k in CountFreq.Keys)
            {
                // priority <node , int>
                headNode newnode = new headNode(k, (int)CountFreq[k]);
                minheap.Enqueue(newnode, (int)CountFreq[k]);
                i++;
            }
            headNode top, left, right;
            int newfrq;
            while (minheap.Count != 1)
            {
                left = minheap.Dequeue();
                right = minheap.Dequeue();
                newfrq = left.freq + right.freq;
                top = new headNode((char)0, newfrq);
                top.right = right;
                top.left = left;
                minheap.Enqueue(top, newfrq);
            }
            generateCode(minheap.Peek(), "");

        }
        #endregion
        public void generateCode(headNode node, string str)
        {
            if (node == null) return;
            if (node.data != (char)0)
            {
                code[node.data] = str;
            }
            generateCode(node.left, str + "0");
            generateCode(node.right, str + "1");
        }




    }
}
