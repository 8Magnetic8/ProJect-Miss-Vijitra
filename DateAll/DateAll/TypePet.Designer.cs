using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.binsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PetTypeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PetBreedID = new System.Windows.Forms.TextBox();
            this.PetTypeID = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(599, 389);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(64, 20);
            this.bClose.TabIndex = 24;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(252, 389);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(64, 20);
            this.bAdd.TabIndex = 23;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(530, 389);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 20);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(460, 389);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(64, 20);
            this.bUpdate.TabIndex = 21;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // binsert
            // 
            this.binsert.Location = new System.Drawing.Point(391, 389);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(64, 20);
            this.binsert.TabIndex = 20;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(183, 389);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(64, 20);
            this.bNew.TabIndex = 19;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 195);
            this.dataGridView1.TabIndex = 18;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(321, 389);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(64, 20);
            this.bShow.TabIndex = 25;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "รหัส";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ประเภทสัตว์";
            // 
            // PetTypeName
            // 
            this.PetTypeName.Location = new System.Drawing.Point(237, 70);
            this.PetTypeName.Name = "PetTypeName";
            this.PetTypeName.Size = new System.Drawing.Size(157, 20);
            this.PetTypeName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "พันธุ์สัตว์เลิ้ยง";
            // 
            // PetBreedID
            // 
            this.PetBreedID.Location = new System.Drawing.Point(237, 103);
            this.PetBreedID.Name = "PetBreedID";
            this.PetBreedID.Size = new System.Drawing.Size(157, 20);
            this.PetBreedID.TabIndex = 31;
            // 
            // PetTypeID
            // 
            this.PetTypeID.Location = new System.Drawing.Point(237, 39);
            this.PetTypeID.Name = "PetTypeID";
            this.PetTypeID.Size = new System.Drawing.Size(157, 20);
            this.PetTypeID.TabIndex = 32;
            this.PetTypeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PetTypeID_KeyDown);
            // 
            // TypePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 487);
            this.Controls.Add(this.PetTypeID);
            this.Controls.Add(this.PetBreedID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PetTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TypePet";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox PetTypeName;
        private Label label3;
        private TextBox PetBreedID;
        private TextBox PetTypeID;
        private BindingSource bindingSource1;
    }
}