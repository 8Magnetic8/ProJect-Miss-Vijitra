namespace DateAll
{
    partial class Pet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PetID = new System.Windows.Forms.TextBox();
            this.PetName = new System.Windows.Forms.TextBox();
            this.PetTypeID = new System.Windows.Forms.TextBox();
            this.ownerID = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBrowser = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bShow = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.binsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.PetAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัส";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(58, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "ประเภท";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(355, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "เจ้าของ";
            // 
            // PetID
            // 
            this.PetID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PetID.Location = new System.Drawing.Point(135, 51);
            this.PetID.Name = "PetID";
            this.PetID.Size = new System.Drawing.Size(178, 30);
            this.PetID.TabIndex = 6;
            
            // 
            // PetName
            // 
            this.PetName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PetName.Location = new System.Drawing.Point(135, 108);
            this.PetName.Name = "PetName";
            this.PetName.Size = new System.Drawing.Size(178, 30);
            this.PetName.TabIndex = 7;
            // 
            // PetTypeID
            // 
            this.PetTypeID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PetTypeID.Location = new System.Drawing.Point(135, 305);
            this.PetTypeID.Name = "PetTypeID";
            this.PetTypeID.Size = new System.Drawing.Size(178, 30);
            this.PetTypeID.TabIndex = 8;
            // 
            // ownerID
            // 
            this.ownerID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ownerID.Location = new System.Drawing.Point(427, 51);
            this.ownerID.Name = "ownerID";
            this.ownerID.Size = new System.Drawing.Size(178, 30);
            this.ownerID.TabIndex = 10;
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.radioButton2);
            this.Sex.Controls.Add(this.radioButton1);
            this.Sex.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Sex.Location = new System.Drawing.Point(62, 208);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(342, 91);
            this.Sex.TabIndex = 12;
            this.Sex.TabStop = false;
            this.Sex.Text = "เพศ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "เพศผู้";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "เพศเมีย";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 212);
            this.dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(726, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 224);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bBrowser
            // 
            this.bBrowser.Location = new System.Drawing.Point(770, 299);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(122, 41);
            this.bBrowser.TabIndex = 15;
            this.bBrowser.Text = "Browser";
            this.bBrowser.UseVisualStyleBackColor = true;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(387, 626);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(64, 20);
            this.bShow.TabIndex = 32;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(665, 626);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(64, 20);
            this.bClose.TabIndex = 31;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(318, 626);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(64, 20);
            this.bAdd.TabIndex = 30;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(596, 626);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 20);
            this.bDelete.TabIndex = 29;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(526, 626);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(64, 20);
            this.bUpdate.TabIndex = 28;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // binsert
            // 
            this.binsert.Location = new System.Drawing.Point(457, 626);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(64, 20);
            this.binsert.TabIndex = 27;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(249, 626);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(64, 20);
            this.bNew.TabIndex = 26;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // PetAge
            // 
            this.PetAge.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PetAge.Location = new System.Drawing.Point(135, 160);
            this.PetAge.Name = "PetAge";
            this.PetAge.Size = new System.Drawing.Size(178, 30);
            this.PetAge.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(58, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "อายุ";
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 703);
            this.Controls.Add(this.PetAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.ownerID);
            this.Controls.Add(this.PetTypeID);
            this.Controls.Add(this.PetName);
            this.Controls.Add(this.PetID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pet";
            this.Text = "Pet";
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PetID;
        private System.Windows.Forms.TextBox PetName;
        private System.Windows.Forms.TextBox PetTypeID;
        private System.Windows.Forms.TextBox ownerID;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bBrowser;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox PetAge;
        private System.Windows.Forms.Label label7;
    }
}