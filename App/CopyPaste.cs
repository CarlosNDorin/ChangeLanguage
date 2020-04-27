using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public class CopyPaste
    {
        public static DictionaryManagment dictionaryManagment;
        static string _actualLanguage;
        static string _stringCopy;
        public void RunCopying()
        {
            dictionaryManagment = new DictionaryManagment();
            _actualLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
            StartMonitoring();
        }

        private static void ClipboardMonitor_OnClipboardChange(ClipboardFormat format, object data)
        {
            if (format == ClipboardFormat.Text)
            {
                _stringCopy = data.ToString();
            }

            if (_actualLanguage != InputLanguage.CurrentInputLanguage.LayoutName)
            {
                _actualLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
                string textTranslated = dictionaryManagment.Translate("ENG", "HEB", data.ToString());
                Clipboard.SetText(textTranslated);
            }
        }

                

        public void StartMonitoring()
        {
            ClipboardMonitor.Start();
            ClipboardMonitor.OnClipboardChange += new ClipboardMonitor.OnClipboardChangeEventHandler(ClipboardMonitor_OnClipboardChange);
        }

        public void StopMonitoring()
        {
            ClipboardMonitor.Stop();
        }

    }


}