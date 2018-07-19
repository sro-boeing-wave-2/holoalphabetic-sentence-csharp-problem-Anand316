using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input = input.ToLower();
            input = String.Concat(input.ToCharArray().OrderBy(c => c).Distinct());
            if (input.Contains(alphabets))
                return true;
            else
            return false;
        }
    }
}
