using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class DictionaryManagment
    {
     
        private static DictionaryLanguages _dictionaryLanguage;

        public DictionaryManagment()
        {
            _dictionaryLanguage = new DictionaryLanguages();
        }

        public string Translate(string From,string To, string TextToTranslate)
        {
            return _dictionaryLanguage.Translate(From, To, TextToTranslate);
        }

    }
}
