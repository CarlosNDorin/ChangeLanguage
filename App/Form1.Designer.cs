namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_ToTranslate = new System.Windows.Forms.TextBox();
            this.txtBox_Translated = new System.Windows.Forms.TextBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_ToTranslate
            // 
            this.txtBox_ToTranslate.Location = new System.Drawing.Point(12, 38);
            this.txtBox_ToTranslate.Name = "txtBox_ToTranslate";
            this.txtBox_ToTranslate.Size = new System.Drawing.Size(163, 20);
            this.txtBox_ToTranslate.TabIndex = 0;
            // 
            // txtBox_Translated
            // 
            this.txtBox_Translated.Location = new System.Drawing.Point(211, 38);
            this.txtBox_Translated.Name = "txtBox_Translated";
            this.txtBox_Translated.Size = new System.Drawing.Size(175, 20);
            this.txtBox_Translated.TabIndex = 1;
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(155, 64);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(75, 23);
            this.btn_Translate.TabIndex = 2;
            this.btn_Translate.Text = "Translate!";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(398, 115);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.txtBox_Translated);
            this.Controls.Add(this.txtBox_ToTranslate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox txtBox_Translated;
        private System.Windows.Forms.Button btn_Translate;
        public System.Windows.Forms.TextBox txtBox_ToTranslate;
    }
}

