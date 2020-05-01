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
    public class CopyPaste : System.Windows.Forms.Form
    {
        public static DictionaryManagment dictionaryManagment;
        KeyboardListener keyboardListener;
        private static bool _copied = false; // Perhaps I can delete it.. ?
        static string _stringCopy;
        static string _stringTranslated;
        private bool _WPressed = false;
        private bool _YPressed = false;
        private string _actualLanguage;
        private bool _isInOperation = false;


        public CopyPaste()
        {
            _actualLanguage = InputLanguage.CurrentInputLanguage.Culture.ThreeLetterWindowsLanguageName;
        }

        public void RunCopying()
        {
            dictionaryManagment = new DictionaryManagment();
            StartMonitoring();
        }

        private static void ClipboardMonitor_OnClipboardChange(ClipboardFormat format, object data)
        {
            if (format == ClipboardFormat.Text && !_copied)
            {
                _stringCopy = data.ToString();
            }
        }

        public void TranslateText(string from, string to)
        {
            _stringTranslated = dictionaryManagment.Translate(from, to, _stringCopy);
        }

        public void SetTextClipboard()
        {
            _copied = true;
            Clipboard.SetText(_stringTranslated);
            _copied = false;
        }


        public void StartMonitoring()
        {
            ClipboardMonitor.Start();
            ClipboardMonitor.OnClipboardChange += new ClipboardMonitor.OnClipboardChangeEventHandler(ClipboardMonitor_OnClipboardChange);
            keyboardListener = new KeyboardListener();
            keyboardListener.KeyUp += NewKeyPressed;
        }

        public void NewKeyPressed(object source, RawKeyEventArgs e)
        {
            string keyPressed = e.Key.ToString();

            if (keyPressed == "W")
            {
                _WPressed = true;
                _YPressed = false;
            }
            else
            {
                if (keyPressed == "Y")
                {
                    _WPressed = false;
                    _YPressed = true;
                }
                else
                {
                    if (keyPressed == "LeftCtrl")
                    {
                        if (_WPressed)
                        {
                            _WPressed = false;
                            _isInOperation = true;
                        }

                        if (_YPressed)
                        {
                            _YPressed = false;
                            _isInOperation = false;
                        }
                    }
                    else
                    {
                        _WPressed = false;
                        _YPressed = false;
                    }
                }
            }
        }

        private void AceptedToTranslate(string from, string to)
        {
            TranslateText(from, to);
            SetTextClipboard();
        }

        public void ChangeLanguage(string language)
        {
            if (!_isInOperation)
            {
                _actualLanguage = language;
            }
            else
            {
                AceptedToTranslate(_actualLanguage, language);
            }
        }
        public void StopMonitoring()
        {
            ClipboardMonitor.Stop();
            keyboardListener.Dispose();
        }
    }
}