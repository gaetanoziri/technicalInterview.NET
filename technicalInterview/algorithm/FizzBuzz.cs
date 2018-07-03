﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.algorithm
{
    /// <summary>
    /// Write a program that prints the integers from   1   to  N
    /// But:
    /// for multiples of three, print "Fizz"(instead of the number)
    /// for multiples of five, print "Buzz"(instead of the number)
    /// for multiples of both three and five, print "FizzBuzz"(instead of the number)
    /// 
    /// Ex FizzBuzz.Generate(6) will generate "1 2 Fizz 4 Buzz Fizz"
    /// </summary>
    public class FizzBuzz
    {
        public static string Generate(int count)
        {
            return string.Join(" ", Enumerable.Range(1, Math.Max(count, 0)).Select(i => {
                if (i % 15 == 0) return "Fizz Buzz";
                if (i % 3 == 0) return "Fizz";
                if (i % 5 == 0) return "Buzz";
                return i + "";
            }));
        }
    }
}
