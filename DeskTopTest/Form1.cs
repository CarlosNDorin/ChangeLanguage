using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows​;
using System.Diagnostics;

namespace DeskTopTest
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr processId);
        private static string buffer;
        public Form1()
        {


           

            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(500);
                    HandleCurrentLanguage();
                    MessageBox.Show(InputLanguage.CurrentInputLanguage.LayoutName);
                }
            });
        }

        IntPtr _currentKeyboardLayout = IntPtr.Zero;
        private void HandleCurrentLanguage()
        {
            var newLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero));
            if (_currentKeyboardLayout != newLayout)
            {
                _currentKeyboardLayout = newLayout;
                System.Threading.Thread.Sleep(500);
                
            }
        }
       



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReadCopy_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                buffer = Clipboard.GetText(TextDataFormat.Text);
            }
            MessageBox.Show(InputLanguage.CurrentInputLanguage.LayoutName);
           
        }

        public void LocalLanguageChanged()
        {

        }

        private void btnWriteCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("text");
        }

        private void btnGetLanguages_Click(object sender, EventArgs e)
        {
            // Gets the list of installed languages.
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                textBox1.Text += lang.Culture.EnglishName + '\n';
            }
        }
    }
}
