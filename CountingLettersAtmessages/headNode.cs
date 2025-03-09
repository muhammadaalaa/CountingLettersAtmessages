using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLettersAtmessages
{
    public class headNode
    {
        // the parent node contain 
        //1- data 
        //2- ref loc of the child right node
        //3- ref loc of the child left node
        //4- also may contain the variable which is the letters

        public int freq { get; set; }
        public char data { get; set; }
        public headNode left { get; set; }
        public headNode right { get; set; }
        public headNode(char data, int freq)
        {
            this.freq = freq;
            this.data = data;
            left = right = null;

        }
    }
}
