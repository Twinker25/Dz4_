using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMorze
{
    class Inmorze
    {
        public static string inmorze(string input)
        {
            string[] alphabit = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "/", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };

            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string output = "";

            foreach (char c in input.ToUpper())
            {
                int i = Array.IndexOf(letters, c.ToString());
                if (i >= 0)
                {
                    output += alphabit[i] + " ";
                }
            }
            return output;
        }
    }
}