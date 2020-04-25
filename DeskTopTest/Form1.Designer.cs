namespace DeskTopTest
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
            this.btnReadCopy = new System.Windows.Forms.Button();
            this.btnWriteCopy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetLanguages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadCopy
            // 
            this.btnReadCopy.Location = new System.Drawing.Point(179, 12);
            this.btnReadCopy.Name = "btnReadCopy";
            this.btnReadCopy.Size = new System.Drawing.Size(45, 25);
            this.btnReadCopy.TabIndex = 0;
            this.btnReadCopy.Text = "Read";
            this.btnReadCopy.UseVisualStyleBackColor = true;
            this.btnReadCopy.Click += new System.EventHandler(this.btnReadCopy_Click);
            // 
            // btnWriteCopy
            // 
            this.btnWriteCopy.Location = new System.Drawing.Point(179, 43);
            this.btnWriteCopy.Name = "btnWriteCopy";
            this.btnWriteCopy.Size = new System.Drawing.Size(45, 25);
            this.btnWriteCopy.TabIndex = 1;
            this.btnWriteCopy.Text = "Write";
            this.btnWriteCopy.UseVisualStyleBackColor = true;
            this.btnWriteCopy.Click += new System.EventHandler(this.btnWriteCopy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 135);
            this.textBox1.TabIndex = 2;
            // 
            // btnGetLanguages
            // 
            this.btnGetLanguages.Location = new System.Drawing.Point(179, 74);
            this.btnGetLanguages.Name = "btnGetLanguages";
            this.btnGetLanguages.Size = new System.Drawing.Size(45, 25);
            this.btnGetLanguages.TabIndex = 3;
            this.btnGetLanguages.Text = "Get";
            this.btnGetLanguages.UseVisualStyleBackColor = true;
            this.btnGetLanguages.Click += new System.EventHandler(this.btnGetLanguages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnGetLanguages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnWriteCopy);
            this.Controls.Add(this.btnReadCopy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCopy;
        private System.Windows.Forms.Button btnWriteCopy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetLanguages;
    }
}

