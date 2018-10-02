namespace TerbilangApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputnominal = new System.Windows.Forms.TextBox();
            this.hasilterbilang = new System.Windows.Forms.ListBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // inputnominal
            // 
            this.inputnominal.Location = new System.Drawing.Point(136, 39);
            this.inputnominal.Name = "inputnominal";
            this.inputnominal.Size = new System.Drawing.Size(171, 26);
            this.inputnominal.TabIndex = 2;
            // 
            // hasilterbilang
            // 
            this.hasilterbilang.FormattingEnabled = true;
            this.hasilterbilang.ItemHeight = 20;
            this.hasilterbilang.Location = new System.Drawing.Point(137, 107);
            this.hasilterbilang.Name = "hasilterbilang";
            this.hasilterbilang.Size = new System.Drawing.Size(746, 144);
            this.hasilterbilang.TabIndex = 3;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(336, 36);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(123, 32);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Cek Terbilang";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 281);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.hasilterbilang);
            this.Controls.Add(this.inputnominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputnominal;
        private System.Windows.Forms.ListBox hasilterbilang;
        private System.Windows.Forms.Button btnCek;
    }
}

