namespace DiplomProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveToExcelBtn1 = new System.Windows.Forms.Button();
            this.addBtn1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMChangeServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMAddBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMAddSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMAddGood = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMAddDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDeleteBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDeleteSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDeleteGood = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMDeleteDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMExportBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMExportSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMExportGood = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMExportDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(565, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveToExcelBtn1
            // 
            this.saveToExcelBtn1.Location = new System.Drawing.Point(193, 118);
            this.saveToExcelBtn1.Name = "saveToExcelBtn1";
            this.saveToExcelBtn1.Size = new System.Drawing.Size(182, 46);
            this.saveToExcelBtn1.TabIndex = 8;
            this.saveToExcelBtn1.Text = "Экспортировать список покупателей в Excel";
            this.saveToExcelBtn1.UseVisualStyleBackColor = true;
            this.saveToExcelBtn1.Click += new System.EventHandler(this.saveToExcelBtn_Click);
            // 
            // addBtn1
            // 
            this.addBtn1.Location = new System.Drawing.Point(193, 89);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(182, 31);
            this.addBtn1.TabIndex = 9;
            this.addBtn1.Text = "Добавить покупателя";
            this.addBtn1.UseVisualStyleBackColor = true;
            this.addBtn1.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 352);
            this.dataGridView1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMChangeServer,
            this.tSMAdd,
            this.tSMDelete,
            this.tSMExport});
            this.menuStrip1.Location = new System.Drawing.Point(12, 367);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tSMChangeServer
            // 
            this.tSMChangeServer.Name = "tSMChangeServer";
            this.tSMChangeServer.Size = new System.Drawing.Size(108, 20);
            this.tSMChangeServer.Text = "Сменить сервер";
            this.tSMChangeServer.Click += new System.EventHandler(this.tSMChangeServer_Click);
            // 
            // tSMAdd
            // 
            this.tSMAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMAddBuyer,
            this.tSMAddSeller,
            this.tSMAddGood,
            this.tSMAddDeal});
            this.tSMAdd.Name = "tSMAdd";
            this.tSMAdd.Size = new System.Drawing.Size(71, 20);
            this.tSMAdd.Text = "Добавить";
            // 
            // tSMAddBuyer
            // 
            this.tSMAddBuyer.Name = "tSMAddBuyer";
            this.tSMAddBuyer.Size = new System.Drawing.Size(139, 22);
            this.tSMAddBuyer.Text = "Покупателя";
            this.tSMAddBuyer.Click += new System.EventHandler(this.tSMAddBuyer_Click);
            // 
            // tSMAddSeller
            // 
            this.tSMAddSeller.Name = "tSMAddSeller";
            this.tSMAddSeller.Size = new System.Drawing.Size(139, 22);
            this.tSMAddSeller.Text = "Продавца";
            this.tSMAddSeller.Click += new System.EventHandler(this.tSMAddSeller_Click);
            // 
            // tSMAddGood
            // 
            this.tSMAddGood.Name = "tSMAddGood";
            this.tSMAddGood.Size = new System.Drawing.Size(139, 22);
            this.tSMAddGood.Text = "Товар";
            this.tSMAddGood.Click += new System.EventHandler(this.tSMAddGood_Click);
            // 
            // tSMAddDeal
            // 
            this.tSMAddDeal.Name = "tSMAddDeal";
            this.tSMAddDeal.Size = new System.Drawing.Size(139, 22);
            this.tSMAddDeal.Text = "Сделку";
            this.tSMAddDeal.Click += new System.EventHandler(this.tSMAddDeal_Click);
            // 
            // tSMDelete
            // 
            this.tSMDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMDeleteBuyer,
            this.tSMDeleteSeller,
            this.tSMDeleteGood,
            this.tSMDeleteDeal});
            this.tSMDelete.Name = "tSMDelete";
            this.tSMDelete.Size = new System.Drawing.Size(63, 20);
            this.tSMDelete.Text = "Удалить";
            // 
            // tSMDeleteBuyer
            // 
            this.tSMDeleteBuyer.Name = "tSMDeleteBuyer";
            this.tSMDeleteBuyer.Size = new System.Drawing.Size(139, 22);
            this.tSMDeleteBuyer.Text = "Покупателя";
            // 
            // tSMDeleteSeller
            // 
            this.tSMDeleteSeller.Name = "tSMDeleteSeller";
            this.tSMDeleteSeller.Size = new System.Drawing.Size(139, 22);
            this.tSMDeleteSeller.Text = "Продавца";
            // 
            // tSMDeleteGood
            // 
            this.tSMDeleteGood.Name = "tSMDeleteGood";
            this.tSMDeleteGood.Size = new System.Drawing.Size(139, 22);
            this.tSMDeleteGood.Text = "Товар";
            // 
            // tSMDeleteDeal
            // 
            this.tSMDeleteDeal.Name = "tSMDeleteDeal";
            this.tSMDeleteDeal.Size = new System.Drawing.Size(139, 22);
            this.tSMDeleteDeal.Text = "Сделку";
            // 
            // tSMExport
            // 
            this.tSMExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMExportBuyer,
            this.tSMExportSeller,
            this.tSMExportGood,
            this.tSMExportDeal});
            this.tSMExport.Name = "tSMExport";
            this.tSMExport.Size = new System.Drawing.Size(146, 20);
            this.tSMExport.Text = "Экспортировать в Excel";
            // 
            // tSMExportBuyer
            // 
            this.tSMExportBuyer.Name = "tSMExportBuyer";
            this.tSMExportBuyer.Size = new System.Drawing.Size(188, 22);
            this.tSMExportBuyer.Text = "Список покупателей";
            this.tSMExportBuyer.Click += new System.EventHandler(this.tSMExportBuyer_Click);
            // 
            // tSMExportSeller
            // 
            this.tSMExportSeller.Name = "tSMExportSeller";
            this.tSMExportSeller.Size = new System.Drawing.Size(188, 22);
            this.tSMExportSeller.Text = "Список продавцов";
            this.tSMExportSeller.Click += new System.EventHandler(this.tSMExportSeller_Click);
            // 
            // tSMExportGood
            // 
            this.tSMExportGood.Name = "tSMExportGood";
            this.tSMExportGood.Size = new System.Drawing.Size(188, 22);
            this.tSMExportGood.Text = "Список товаров";
            this.tSMExportGood.Click += new System.EventHandler(this.tSMExportGood_Click);
            // 
            // tSMExportDeal
            // 
            this.tSMExportDeal.Name = "tSMExportDeal";
            this.tSMExportDeal.Size = new System.Drawing.Size(188, 22);
            this.tSMExportDeal.Text = "Список сделок";
            this.tSMExportDeal.Click += new System.EventHandler(this.tSMExportDeal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Выберите таблицу:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn1);
            this.Controls.Add(this.saveToExcelBtn1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт продаж";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveToExcelBtn1;
        private System.Windows.Forms.Button addBtn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMChangeServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tSMAdd;
        private System.Windows.Forms.ToolStripMenuItem tSMDelete;
        private System.Windows.Forms.ToolStripMenuItem tSMExport;
        private System.Windows.Forms.ToolStripMenuItem tSMAddBuyer;
        private System.Windows.Forms.ToolStripMenuItem tSMAddSeller;
        private System.Windows.Forms.ToolStripMenuItem tSMAddGood;
        private System.Windows.Forms.ToolStripMenuItem tSMAddDeal;
        private System.Windows.Forms.ToolStripMenuItem tSMDeleteBuyer;
        private System.Windows.Forms.ToolStripMenuItem tSMDeleteSeller;
        private System.Windows.Forms.ToolStripMenuItem tSMDeleteGood;
        private System.Windows.Forms.ToolStripMenuItem tSMDeleteDeal;
        private System.Windows.Forms.ToolStripMenuItem tSMExportBuyer;
        private System.Windows.Forms.ToolStripMenuItem tSMExportSeller;
        private System.Windows.Forms.ToolStripMenuItem tSMExportGood;
        private System.Windows.Forms.ToolStripMenuItem tSMExportDeal;


    }
}