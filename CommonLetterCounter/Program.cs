﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLetterCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            int result = CommonLetterCalculator.CommonLetterCount(word1,word2);

            Console.WriteLine("Common letter count is : " + result);
            Console.ReadLine();

        }
        
    }
}
