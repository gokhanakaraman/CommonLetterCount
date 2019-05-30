using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLetterCounter
{
    public class CommonLetterCalculator
    {
        public static int CommonLetterCount(string word1, string word2)
        {
            int counter = 0;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();

            for (int i = 0; i < word1.Length; i++)  //Word1 mapped to dictioanary
            {
                if (!dictionary.ContainsKey(word1[i].ToString())) 
                {
                    dictionary.Add(word1[i].ToString(), i);
                }
            }
            for (int i = 0; i < word2.Length; i++)
            {
                if (!dictionary2.ContainsKey(word2[i].ToString())) 
                {
                    dictionary2.Add(word2[i].ToString(), i);
                    if (dictionary.ContainsKey(word2[i].ToString())) //while word2 mapping to dictionary2 at the same time checking if first dictionary has the same letter
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
