using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReader
{
    public class Reader
    {
        public int CountWords(string input, string query)
        {
            var words = input.Split(' ');
            return words.Length;
        }
    }
}