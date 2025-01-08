namespace CRRU
{
    partial class CRRU
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.brun = new System.Windows.Forms.Button();
            this.bnew = new System.Windows.Forms.Button();
            this.bclose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(32, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(802, 639);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "input a\ninput b\n c=a+b\n output c";
            // 
            // brun
            // 
            this.brun.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brun.Location = new System.Drawing.Point(877, 106);
            this.brun.Name = "brun";
            this.brun.Size = new System.Drawing.Size(119, 92);
            this.brun.TabIndex = 1;
            this.brun.Text = "RUN";
            this.brun.UseVisualStyleBackColor = true;
            this.brun.Click += new System.EventHandler(this.brun_Click);
            // 
            // bnew
            // 
            this.bnew.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnew.Location = new System.Drawing.Point(877, 204);
            this.bnew.Name = "bnew";
            this.bnew.Size = new System.Drawing.Size(119, 92);
            this.bnew.TabIndex = 2;
            this.bnew.Text = "NEW";
            this.bnew.UseVisualStyleBackColor = true;
            this.bnew.Click += new System.EventHandler(this.bnew_Click);
            // 
            // bclose
            // 
            this.bclose.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclose.Location = new System.Drawing.Point(877, 448);
            this.bclose.Name = "bclose";
            this.bclose.Size = new System.Drawing.Size(119, 92);
            this.bclose.TabIndex = 3;
            this.bclose.Text = "CLOSE";
            this.bclose.UseVisualStyleBackColor = true;
            this.bclose.Click += new System.EventHandler(this.bclose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CRRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 673);
            this.Controls.Add(this.bclose);
            this.Controls.Add(this.bnew);
            this.Controls.Add(this.brun);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CRRU";
            this.Text = "CRRU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button brun;
        private System.Windows.Forms.Button bnew;
        private System.Windows.Forms.Button bclose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}