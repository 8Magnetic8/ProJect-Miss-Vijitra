namespace Pet
{
    partial class FormPet
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
            label1 = new Label();
            label2 = new Label();
            Owner = new TextBox();
            PetCode = new ComboBox();
            PetName = new TextBox();
            label3 = new Label();
            PetType = new TextBox();
            label4 = new Label();
            old = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            bBrowser = new Button();
            pictureBox1 = new PictureBox();
            bNew = new Button();
            bAdd = new Button();
            bShow = new Button();
            bInsert = new Button();
            bUpdate = new Button();
            bDelete = new Button();
            bClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 58);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "เจ้าของ";
            // 
            // Owner
            // 
            Owner.Location = new Point(264, 84);
            Owner.Name = "Owner";
            Owner.Size = new Size(237, 23);
            Owner.TabIndex = 3;
            // 
            // PetCode
            // 
            PetCode.FormattingEnabled = true;
            PetCode.Items.AddRange(new object[] { "0001" });
            PetCode.Location = new Point(264, 55);
            PetCode.Name = "PetCode";
            PetCode.Size = new Size(121, 23);
            PetCode.TabIndex = 4;
            // 
            // PetName
            // 
            PetName.Location = new Point(264, 113);
            PetName.Name = "PetName";
            PetName.Size = new Size(237, 23);
            PetName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 121);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 5;
            label3.Text = "ชื่อ";
            // 
            // PetType
            // 
            PetType.Location = new Point(264, 142);
            PetType.Name = "PetType";
            PetType.Size = new Size(237, 23);
            PetType.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 150);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "ประเภท";
            // 
            // old
            // 
            old.Location = new Point(264, 171);
            old.Name = "old";
            old.Size = new Size(121, 23);
            old.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 179);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 9;
            label5.Text = "อายุ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(180, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 242);
            dataGridView1.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(264, 210);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "เพศผู้";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(398, 212);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "เพศเมีย";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 212);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 14;
            label6.Text = "เพศ";
            // 
            // bBrowser
            // 
            bBrowser.Location = new Point(773, 212);
            bBrowser.Name = "bBrowser";
            bBrowser.Size = new Size(75, 23);
            bBrowser.TabIndex = 15;
            bBrowser.Text = "Browser";
            bBrowser.UseVisualStyleBackColor = true;
            bBrowser.Click += bBrowser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(729, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 145);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // bNew
            // 
            bNew.Location = new Point(221, 523);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 23);
            bNew.TabIndex = 17;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(302, 523);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 18;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bShow
            // 
            bShow.Location = new Point(383, 523);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 23);
            bShow.TabIndex = 19;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bInsert
            // 
            bInsert.Location = new Point(464, 523);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(75, 23);
            bInsert.TabIndex = 20;
            bInsert.Text = "Insert";
            bInsert.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            bUpdate.Location = new Point(545, 523);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(75, 23);
            bUpdate.TabIndex = 21;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(626, 523);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(75, 23);
            bDelete.TabIndex = 22;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            bClose.Location = new Point(707, 523);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 23);
            bClose.TabIndex = 23;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // FormPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 619);
            Controls.Add(bClose);
            Controls.Add(bDelete);
            Controls.Add(bUpdate);
            Controls.Add(bInsert);
            Controls.Add(bShow);
            Controls.Add(bAdd);
            Controls.Add(bNew);
            Controls.Add(pictureBox1);
            Controls.Add(bBrowser);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dataGridView1);
            Controls.Add(old);
            Controls.Add(label5);
            Controls.Add(PetType);
            Controls.Add(label4);
            Controls.Add(PetName);
            Controls.Add(label3);
            Controls.Add(PetCode);
            Controls.Add(Owner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPet";
            Text = "FormPet";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Owner;
        private ComboBox PetCode;
        private TextBox PetName;
        private Label label3;
        private TextBox PetType;
        private Label label4;
        private TextBox old;
        private Label label5;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private Button bBrowser;
        private PictureBox pictureBox1;
        private Button bNew;
        private Button bAdd;
        private Button bShow;
        private Button bInsert;
        private Button bUpdate;
        private Button bDelete;
        private Button bClose;
        private OpenFileDialog openFileDialog1;
    }
}