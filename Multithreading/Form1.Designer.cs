namespace Multithreading
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCountFun = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listBoxText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCountFun
            // 
            this.btnCountFun.Location = new System.Drawing.Point(39, 33);
            this.btnCountFun.Name = "btnCountFun";
            this.btnCountFun.Size = new System.Drawing.Size(300, 39);
            this.btnCountFun.TabIndex = 0;
            this.btnCountFun.Text = "Do Time Counsuming Work";
            this.btnCountFun.UseVisualStyleBackColor = true;
            this.btnCountFun.Click += new System.EventHandler(this.btnCountFun_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(39, 99);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(300, 41);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Number";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // listBoxText
            // 
            this.listBoxText.FormattingEnabled = true;
            this.listBoxText.ItemHeight = 15;
            this.listBoxText.Location = new System.Drawing.Point(39, 167);
            this.listBoxText.Name = "listBoxText";
            this.listBoxText.Size = new System.Drawing.Size(300, 229);
            this.listBoxText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 409);
            this.Controls.Add(this.listBoxText);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCountFun);
            this.Name = "Form1";
            this.Text = "MultiThreading Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountFun;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox listBoxText;
    }
}
