using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;

namespace ChangeLanguage
{
    class Program
    {

        static void Main(string[] args)
        {
            var HWND = new SelectedTextBoxHandler();

            /* while(true)
             {
                 HWND.getText(); 
                Clipboard.SetText(txtCopy.Text);
             }*/


            Console.ReadKey();


        }
    }

    public class SelectedTextBoxHandler
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

      //////
        [DllImport("user32.dll", EntryPoint = "GetWindowText",CharSet = CharSet.Auto)]
        static extern IntPtr GetWindowCaption(IntPtr hwnd,StringBuilder lpString, int maxCount);

        [DllImport("user32.dll", EntryPoint = "SendMessage",  CharSet = CharSet.Auto)]
        static extern int SendMessage3(IntPtr hwndControl, uint Msg, int wParam, StringBuilder strBuffer); // get text

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        static extern int SendMessage4(IntPtr hwndControl, uint Msg, int wParam, int lParam);  // text length

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle =  GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public static string GetWindowCaption(IntPtr hwnd)
        {
            StringBuilder sb = new StringBuilder(256);
            GetWindowCaption(hwnd, sb, 256);
            return sb.ToString();
        }

        static int GetTextBoxTextLength(IntPtr hTextBox)
        {
            // helper for GetTextBoxText
            uint WM_GETTEXTLENGTH = 0x000E;
            int result = SendMessage4(hTextBox, WM_GETTEXTLENGTH, 0, 0);
            return result;
        }

        static string GetTextBoxText(IntPtr hTextBox)
        {
            uint WM_GETTEXT = 0x000D;
            int len = GetTextBoxTextLength(hTextBox);
            if (len <= 0) return null;  // no text
            StringBuilder sb = new StringBuilder(len + 1);
            SendMessage3(hTextBox, WM_GETTEXT, len + 1, sb);
            return sb.ToString();
        }


        public void getText()
        {
            IntPtr handle = GetForegroundWindow();
           
        
                string caption = GetTextBoxText(handle);
                Console.WriteLine(caption);
            
        }
    }
}
