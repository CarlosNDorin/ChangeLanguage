using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace App
{
    partial class Form1 : Form
    {


        public static CopyPaste copyPaste;

        public Form1()
        {
            InitializeComponent();
        }
        private void languageChange(object sender, InputLanguageChangedEventArgs e)
        {
            copyPaste.ChangeLanguage(InputLanguage.CurrentInputLanguage.Culture.ThreeLetterWindowsLanguageName);
        }
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InputLanguage.CurrentInputLanguage.LayoutName);
            copyPaste.TranslateText("ENG", "HEB");
            copyPaste.SetTextClipboard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            copyPaste = new CopyPaste();
            copyPaste.RunCopying();
            this.InputLanguageChanged += new InputLanguageChangedEventHandler(languageChange);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            copyPaste.StopMonitoring();
        }
    }
}
