﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.algorithm
{
    /// <summary>
    /// In this excercise you have to write a simple Morse code decoder.
    /// While the Morse code is now mostly superceded by voice and digital data communication channels, it still has its use in some applications around the world.
    /// The Morse code encodes every character as a sequence of "dots" and "dashes".
    /// For example:
    ///   the letter A is coded as ·−,
    ///   letter Q is coded as −−·−, 
    ///   and digit 1 is coded as ·−−−. 
    /// The Morse code is case-insensitive, traditionally capital letters are used. 
    /// When the message is written in Morse code, a single space is used to separate the character codes and 3 spaces are used to separate words.
    /// For example, the message HEY JUDE in Morse code is ···· · −·−−   ·−−− ··− −·· ·.
    /// 
    /// NOTE: Extra spaces before or after the code have no meaning and should be ignored.
    /// In addition to letters, digits and some punctuation, there are some special service codes, 
    /// the most notorious of those is the international distress signal SOS (that was first issued by Titanic),
    /// that is coded as ···−−−···. These special codes are treated as single special characters, 
    /// and usually are transmitted as separate words.
    /// 
    /// Your task is to implement a function decodeMorse(morseCode),
    /// that would take the morse code as input and return a decoded human-readable string.
    /// For example:
    /// MorseCodeDecoder.decode(".... . -.--   .--- ..- -.. .")
    /// should return "HEY JUDE"
    /// The Morse code table is preloaded for you as a dictionary and you can use it by MorseCode.get ex MorseCode.get('.-') will return A
    /// </summary>
    public class MorseCode
    {

        static readonly Dictionary<string, string> morseAlphabet = new Dictionary<string, string>() {
            { ".-", "A" },
            {"-...", "B"},
            {"-.-.", "C"},
            {"-..", "D"},
            {".", "E"},
            {"..-.", "F"},
            {"--.", "G"},
            {"....", "H"},
            {"..", "I"},
            {".---", "J"},
            {"-.-", "K"},
            {".-..", "L"},
            {"--", "M"},
            {"-.", "N"},
            {"---", "O"},
            {".--.", "P"},
            {"--.-", "Q"},
            {".-.", "R"},
            {"...", "S"},
            {"-", "T"},
            {"..-", "U"},
            {"...-", "V"},
            {".--", "W"},
            {"-..-", "X"},
            {"-.--", "Y"},
            {"--..", "Z"},
            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-", "4"},
            {".....", "5"},
            {"-....", "6"},
            {"--...", "7"},
            {"---..", "8"},
            {"----.", "9"},
            {"...---...", "SOS"},
            {".-.-.-", "."},
            {"-.-.--", "!" }
        };

        public static string Decode(string s)
        {
            StringBuilder buf = new StringBuilder();
            s = s.Trim().ToUpper();
            foreach (String word in s.Split(new string[] { "   " }, StringSplitOptions.None))
            {
                foreach (String symbol in word.Split(' '))
                {
                    String letter = morseAlphabet[symbol];
                    buf.Append(letter);

                }
                buf.Append(" ");
            }
            return buf.ToString().Trim();
        }
    }
}
