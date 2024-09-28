using System.Drawing;
using System.Windows.Forms;

namespace DateAll
{
    partial class DataAll
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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Browse = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.ComboBox();
            this.cClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cDelete = new System.Windows.Forms.Button();
            this.cUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cInsert = new System.Windows.Forms.Button();
            this.cNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenumber1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.mail1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.ownerID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Browse);
            this.panel3.Controls.Add(this.position);
            this.panel3.Controls.Add(this.cClose);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.cDelete);
            this.panel3.Controls.Add(this.cUpdate);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cInsert);
            this.panel3.Controls.Add(this.cNew);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.phonenumber1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.employeeID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.employeeName);
            this.panel3.Controls.Add(this.mail1);
            this.panel3.Location = new System.Drawing.Point(549, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 504);
            this.panel3.TabIndex = 5;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(377, 206);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(76, 23);
            this.Browse.TabIndex = 22;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(87, 130);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(194, 37);
            this.position.TabIndex = 21;
            // 
            // cClose
            // 
            this.cClose.Location = new System.Drawing.Point(417, 470);
            this.cClose.Name = "cClose";
            this.cClose.Size = new System.Drawing.Size(76, 23);
            this.cClose.TabIndex = 18;
            this.cClose.Text = "Close";
            this.cClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 162);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cDelete
            // 
            this.cDelete.Location = new System.Drawing.Point(325, 470);
            this.cDelete.Name = "cDelete";
            this.cDelete.Size = new System.Drawing.Size(76, 23);
            this.cDelete.TabIndex = 17;
            this.cDelete.Text = "Delete";
            this.cDelete.UseVisualStyleBackColor = true;
            // 
            // cUpdate
            // 
            this.cUpdate.Location = new System.Drawing.Point(231, 470);
            this.cUpdate.Name = "cUpdate";
            this.cUpdate.Size = new System.Drawing.Size(76, 23);
            this.cUpdate.TabIndex = 16;
            this.cUpdate.Text = "Update";
            this.cUpdate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "ตำแหน่ง";
            // 
            // cInsert
            // 
            this.cInsert.Location = new System.Drawing.Point(136, 470);
            this.cInsert.Name = "cInsert";
            this.cInsert.Size = new System.Drawing.Size(76, 23);
            this.cInsert.TabIndex = 15;
            this.cInsert.Text = "Insert";
            this.cInsert.UseVisualStyleBackColor = true;
            // 
            // cNew
            // 
            this.cNew.Location = new System.Drawing.Point(42, 470);
            this.cNew.Name = "cNew";
            this.cNew.Size = new System.Drawing.Size(76, 23);
            this.cNew.TabIndex = 14;
            this.cNew.Text = "New";
            this.cNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "mail";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(483, 166);
            this.dataGridView2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "เบอร์โทร";
            // 
            // phonenumber1
            // 
            this.phonenumber1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.phonenumber1.Location = new System.Drawing.Point(85, 181);
            this.phonenumber1.Name = "phonenumber1";
            this.phonenumber1.Size = new System.Drawing.Size(197, 36);
            this.phonenumber1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ชื่อ";
            // 
            // employeeID
            // 
            this.employeeID.Font = new System.Drawing.Font("Tahoma", 18F);
            this.employeeID.Location = new System.Drawing.Point(85, 16);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(115, 36);
            this.employeeID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "รหัส";
            // 
            // employeeName
            // 
            this.employeeName.Font = new System.Drawing.Font("Tahoma", 18F);
            this.employeeName.Location = new System.Drawing.Point(85, 78);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(197, 36);
            this.employeeName.TabIndex = 10;
            // 
            // mail1
            // 
            this.mail1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.mail1.Location = new System.Drawing.Point(85, 235);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(197, 36);
            this.mail1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "รหัส";
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Tahoma", 18F);
            this.mail.Location = new System.Drawing.Point(87, 173);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(197, 36);
            this.mail.TabIndex = 4;
            // 
            // phonenumber
            // 
            this.phonenumber.Font = new System.Drawing.Font("Tahoma", 18F);
            this.phonenumber.Location = new System.Drawing.Point(87, 107);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(197, 36);
            this.phonenumber.TabIndex = 3;
            // 
            // ownerName
            // 
            this.ownerName.Font = new System.Drawing.Font("Tahoma", 18F);
            this.ownerName.Location = new System.Drawing.Point(276, 46);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(197, 36);
            this.ownerName.TabIndex = 2;
            // 
            // ownerID
            // 
            this.ownerID.Font = new System.Drawing.Font("Tahoma", 18F);
            this.ownerID.Location = new System.Drawing.Point(87, 46);
            this.ownerID.Name = "ownerID";
            this.ownerID.Size = new System.Drawing.Size(115, 36);
            this.ownerID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bClose);
            this.panel2.Controls.Add(this.bDelete);
            this.panel2.Controls.Add(this.bUpdate);
            this.panel2.Controls.Add(this.bInsert);
            this.panel2.Controls.Add(this.bNew);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mail);
            this.panel2.Controls.Add(this.phonenumber);
            this.panel2.Controls.Add(this.ownerName);
            this.panel2.Controls.Add(this.ownerID);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 504);
            this.panel2.TabIndex = 4;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(414, 436);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 23);
            this.bClose.TabIndex = 13;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(321, 436);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(76, 23);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(227, 436);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(76, 23);
            this.bUpdate.TabIndex = 11;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(133, 436);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(76, 23);
            this.bInsert.TabIndex = 10;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(39, 436);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(76, 23);
            this.bNew.TabIndex = 9;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "เบอร์โทร";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // DataAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataAll";
            this.Text = "DataAll";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource2;
        private BindingSource bindingSource1;
        private Panel panel3;
        private Button cClose;
        private PictureBox pictureBox1;
        private Button cDelete;
        private Button cUpdate;
        private Label label11;
        private Button cInsert;
        private Button cNew;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private TextBox phonenumber1;
        private Label label8;
        private TextBox employeeID;
        private Label label9;
        private TextBox employeeName;
        private TextBox mail1;
        private Label label3;
        private Label label2;
        private TextBox mail;
        private TextBox phonenumber;
        private TextBox ownerName;
        private TextBox ownerID;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button bClose;
        private Button bDelete;
        private Button bUpdate;
        private Button bInsert;
        private Button bNew;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private ComboBox position;
        private Button Browse;
    }
}