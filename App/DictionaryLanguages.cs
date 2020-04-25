using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class DictionaryLanguages
    {
        
        private static Dictionary<string, Dictionary<char, int>> _generalDictionary;

        private static Dictionary<char, int> _ENG = new Dictionary<char, int>()
        {
                {'q', 0 },
                {'w', 1 },
                {'e', 2 },
                {'r', 3 },
                {'t', 4 },
                {'y', 5 },
                {'u', 6 },
                {'i', 7 },
                {'o', 8 },
                {'p', 9 },
                {'a', 10 },
                {'s', 11 },
                {'d', 12 },
                {'f', 13 },
                {'g', 14 },
                {'h', 15 },
                {'j', 16 },
                {'k', 17 },
                {'l', 18 },
                {';', 19 },
                {'z', 20 },
                {'x', 21 },
                {'c', 22 },
                {'v', 23 },
                {'b', 24 },
                {'n', 25 },
                {'m', 26 },
                {',', 27 },
                {'.', 28 },
        };
        private static Dictionary<char, int> _HEB = new Dictionary<char, int>()
        {
                {'/', 0 },
                {'\'', 1 },
                {'ק', 2 },
                {'ר', 3 },
                {'א', 4 },
                {'ט', 5 },
                {'ו', 6 },
                {'ן', 7 },
                {'ם', 8 },
                {'פ', 9 },
                {'ש', 10 },
                {'ד', 11 },
                {'ג', 12 },
                {'כ', 13 },
                {'ע', 14 },
                {'י', 15 },
                {'ח', 16 },
                {'ל', 17 },
                {'ך', 18 },
                {'ף', 19 },
                {'ז', 20 },
                {'ס', 21 },
                {'ב', 22 },
                {'ה', 23 },
                {'נ', 24 },
                {'מ', 25 },
                {'צ', 26 },
                {'ת', 27 },
                {'ץ', 28 },
        };

        public DictionaryLanguages()
        { 
            _generalDictionary = new Dictionary<string, Dictionary<char, int>>();
            _generalDictionary.Add("ENG", _ENG);
            _generalDictionary.Add("HEB", _HEB);
        }

        public Dictionary<char,int> GetDic(string language)
        {
            return _generalDictionary[language];
        }

        public string Translate(string From,string To,string TextToTranslate)
        {
            string translation = string.Empty;
            Dictionary<char, int> from = GetDic(From);
            Dictionary<char, int> to = GetDic(To);

            foreach (char c in TextToTranslate)
            {
                int key = from[Char.ToLower(c)];
                translation += to.First(x => x.Value == key).Key; 
                // Return the first value of all the values of the dictionary where the value is equal to the key, and return the key of this value.
            }
            return translation;
        }
    }
}
