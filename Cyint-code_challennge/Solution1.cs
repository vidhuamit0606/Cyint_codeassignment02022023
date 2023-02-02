using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyint_code_challennge
{
    public class Solution1
    {
        public int RomanToInt(string s)
        {
            var dictionary = new Dictionary<char, int>();
            dictionary.Add('I', 1);
            dictionary.Add('V', 5);
            dictionary.Add('X', 10);
            dictionary.Add('L', 50);
            dictionary.Add('C', 100);
            dictionary.Add('D', 500);
            dictionary.Add('M', 1000);
            //CCXLVII
            int solution = 0;

            /*
                They practically solved it, all we had to do was to read the question:
                    I can be placed before V (5) and X (10) to make 4 and 9. 
                    X can be placed before L (50) and C (100) to make 40 and 90. 
                    C can be placed before D (500) and M (1000) to make 400 and 900.
            */

            /* took care of basic rules as
             * Addition - Smaller value to the right of greater value gets added  
             Substraction: Samller value left of greater value is subtracted Symbols V,L and D are never Subtracted
             
             
             */
            s = s.Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");

            foreach (char c in s)
            {
                solution += dictionary[c];
            }

            return solution;
        }
    }
}
