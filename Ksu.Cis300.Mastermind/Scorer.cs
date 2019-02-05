using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Mastermind
{
    public static class Scorer
    {
        /// <summary>
        /// The first character used for a color
        /// </summary>
        public const char FirstColorCharacter = '0';

        /// <summary>
        /// The length of the codes
        /// </summary>
        public const int LengthOfCodes = 4;

        /// <summary>
        /// The number of colors
        /// </summary>
        public const int NumberOfColor = 6;

        /// <summary>
        /// A public method to determine whether a given code is valid.
        /// </summary>
        /// <param name="code">a string of which code you want to check</param>
        /// <returns></returns>
        public static bool CodeIsValid(string code)
        {
            if(code.Length == 4)
            {
                for(int i = 0; i < LengthOfCodes; i++)
                {
                    if(code[i] < FirstColorCharacter || code[i] > (char)(FirstColorCharacter + NumberOfColor - 1))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// A public method to compare two codes and get the black hits
        /// </summary>
        /// <param name="code1">the first code you want to compare</param>
        /// <param name="code2">the second code you need to compare</param>
        /// <returns></returns>
        public static int GetBlackHits(string code1, string code2)
        {
            int count = 0;
            for(int i = 0; i < LengthOfCodes; i++)
            {
                if(code1[i] == code2[i])
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// A public method to compare two codes and get the total hits
        /// </summary>
        /// <param name="code1">the first code you want to compare</param>
        /// <param name="code2">the second code you need to compare</param>
        /// <returns></returns>
        public static int GetTotalHits(string code1, string code2)
        {
            int count1;
            int count2;
            int result = 0;
            for(int i = 0; i < NumberOfColor; i++)
            {
                count1 = 0;
                count2 = 0;
                char check = (char)(FirstColorCharacter + i);
                for(int j = 0; j < LengthOfCodes; j++)
                {
                    if(code1[j] == check)
                    {
                        count1++;
                    }
                    if(code2[j] == check)
                    {
                        count2++;
                    }
                }
                if(count1 < count2)
                {
                    result += count1;
                }
                else
                {
                    result += count2;
                }
            }
            return result;
        }
    }
}
