namespace Pet
{
    partial class TypePet
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
            bClose = new Button();
            bAdd = new Button();
            bDelete = new Button();
            bUpdate = new Button();
            binsert = new Button();
            bNew = new Button();
            dataGridView1 = new DataGridView();
            bShow = new Button();
            label1 = new Label();
            label2 = new Label();
            PetType = new TextBox();
            label3 = new Label();
            Petbreeds = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.Location = new Point(699, 449);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 24;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(294, 449);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 23;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(618, 449);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(75, 23);
            bDelete.TabIndex = 22;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            bUpdate.Location = new Point(537, 449);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(75, 23);
            bUpdate.TabIndex = 21;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = true;
            // 
            // binsert
            // 
            binsert.Location = new Point(456, 449);
            binsert.Name = "binsert";
            binsert.Size = new Size(75, 23);
            binsert.TabIndex = 20;
            binsert.Text = "Insert";
            binsert.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            bNew.Location = new Point(213, 449);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 19;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(561, 225);
            dataGridView1.TabIndex = 18;
            // 
            // bShow
            // 
            bShow.Location = new Point(375, 449);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 25;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 53);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 26;
            label1.Text = "รหัส";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 89);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 27;
            label2.Text = "ประเภทสัตว์";
            // 
            // PetType
            // 
            PetType.Location = new Point(276, 81);
            PetType.Name = "PetType";
            PetType.Size = new Size(182, 23);
            PetType.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 127);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 30;
            label3.Text = "พันธุ์สัตว์เลิ้ยง";
            // 
            // Petbreeds
            // 
            Petbreeds.Location = new Point(276, 119);
            Petbreeds.Name = "Petbreeds";
            Petbreeds.Size = new Size(182, 23);
            Petbreeds.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(276, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 32;
            // 
            // TypePet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 562);
            Controls.Add(comboBox1);
            Controls.Add(Petbreeds);
            Controls.Add(label3);
            Controls.Add(PetType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bShow);
            Controls.Add(bClose);
            Controls.Add(bAdd);
            Controls.Add(bDelete);
            Controls.Add(bUpdate);
            Controls.Add(binsert);
            Controls.Add(bNew);
            Controls.Add(dataGridView1);
            Name = "TypePet";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bAdd;
        private Button bDelete;
        private Button bUpdate;
        private Button binsert;
        private Button bNew;
        private DataGridView dataGridView1;
        private Button bShow;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox PetType;
        private Label label3;
        private TextBox Petbreeds;
        private ComboBox comboBox1;
    }
}