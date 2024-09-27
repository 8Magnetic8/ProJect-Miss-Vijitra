namespace DateAll
{
    partial class MenuMain
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
            menuStrip1 = new MenuStrip();
            dataAllToolStripMenuItem = new ToolStripMenuItem();
            formPetToolStripMenuItem = new ToolStripMenuItem();
            medicineToolStripMenuItem = new ToolStripMenuItem();
            medicineTypeToolStripMenuItem = new ToolStripMenuItem();
            typePetToolStripMenuItem = new ToolStripMenuItem();
            dataAllToolStripMenuItem1 = new ToolStripMenuItem();
            รหสวธการรกษาToolStripMenuItem = new ToolStripMenuItem();
            การรกษาToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataAllToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataAllToolStripMenuItem
            // 
            dataAllToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formPetToolStripMenuItem, medicineToolStripMenuItem, medicineTypeToolStripMenuItem, typePetToolStripMenuItem, dataAllToolStripMenuItem1, รหสวธการรกษาToolStripMenuItem, การรกษาToolStripMenuItem });
            dataAllToolStripMenuItem.Name = "dataAllToolStripMenuItem";
            dataAllToolStripMenuItem.Size = new Size(83, 33);
            dataAllToolStripMenuItem.Text = "ข้อมูล";
            // 
            // formPetToolStripMenuItem
            // 
            formPetToolStripMenuItem.Name = "formPetToolStripMenuItem";
            formPetToolStripMenuItem.Size = new Size(325, 34);
            formPetToolStripMenuItem.Text = "ข้อมูลสัตว์";
            // 
            // medicineToolStripMenuItem
            // 
            medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            medicineToolStripMenuItem.Size = new Size(325, 34);
            medicineToolStripMenuItem.Text = "ยา";
            // 
            // medicineTypeToolStripMenuItem
            // 
            medicineTypeToolStripMenuItem.Name = "medicineTypeToolStripMenuItem";
            medicineTypeToolStripMenuItem.Size = new Size(325, 34);
            medicineTypeToolStripMenuItem.Text = "ประเภทยา";
            // 
            // typePetToolStripMenuItem
            // 
            typePetToolStripMenuItem.Name = "typePetToolStripMenuItem";
            typePetToolStripMenuItem.Size = new Size(325, 34);
            typePetToolStripMenuItem.Text = "ประเภทสัตว์";
            // 
            // dataAllToolStripMenuItem1
            // 
            dataAllToolStripMenuItem1.Name = "dataAllToolStripMenuItem1";
            dataAllToolStripMenuItem1.Size = new Size(325, 34);
            dataAllToolStripMenuItem1.Text = "ข้อมูลลูกค้าและพนักงาน";
            // 
            // รหสวธการรกษาToolStripMenuItem
            // 
            รหสวธการรกษาToolStripMenuItem.Name = "รหสวธการรกษาToolStripMenuItem";
            รหสวธการรกษาToolStripMenuItem.Size = new Size(325, 34);
            รหสวธการรกษาToolStripMenuItem.Text = "วิธีการรักษา";
            // 
            // การรกษาToolStripMenuItem
            // 
            การรกษาToolStripMenuItem.Name = "การรกษาToolStripMenuItem";
            การรกษาToolStripMenuItem.Size = new Size(325, 34);
            การรกษาToolStripMenuItem.Text = "การรักษา";
            // 
            // MenuMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuMain";
            Text = "MenuMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataAllToolStripMenuItem;
        private ToolStripMenuItem formPetToolStripMenuItem;
        private ToolStripMenuItem medicineToolStripMenuItem;
        private ToolStripMenuItem medicineTypeToolStripMenuItem;
        private ToolStripMenuItem typePetToolStripMenuItem;
        private ToolStripMenuItem dataAllToolStripMenuItem1;
        private ToolStripMenuItem รหสวธการรกษาToolStripMenuItem;
        private ToolStripMenuItem การรกษาToolStripMenuItem;
    }
}