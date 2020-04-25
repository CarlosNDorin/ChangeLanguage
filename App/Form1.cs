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
    public partial class Form1 : Form
    {
        public static DictionaryManagment dictionaryManagment;
        public Form1()
        {
            InitializeComponent();
            dictionaryManagment = new DictionaryManagment();
        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
           txtBox_Translated.Text = dictionaryManagment.Translate("ENG","HEB",txtBox_ToTranslate.Text);
        }
    }
}
