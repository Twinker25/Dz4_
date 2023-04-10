﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutMorze
{
    class Outmorze
    {
        public static string outmorze(string input)
        {
            string[] alphabit = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "/", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };

            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string output = "";

            foreach (string word in words)
            {
                int i = Array.IndexOf(alphabit, word);
                if (i >= 0)
                {
                    output += letters[i];
                }
            }
            return output;
        }
    }
}