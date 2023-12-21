namespace Lb2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savingToDemandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryCourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.savingToDemandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courierAndLoadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcel = new System.Windows.Forms.ListBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseOperationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseOperationToolStripMenuItem
            // 
            this.chooseOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.addNewCardToolStripMenuItem});
            this.chooseOperationToolStripMenuItem.Name = "chooseOperationToolStripMenuItem";
            this.chooseOperationToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.chooseOperationToolStripMenuItem.Text = "Choose Operation";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingToDemandToolStripMenuItem,
            this.deliveryCourierToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Regular delivery";
            // 
            // savingToDemandToolStripMenuItem
            // 
            this.savingToDemandToolStripMenuItem.Name = "savingToDemandToolStripMenuItem";
            this.savingToDemandToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.savingToDemandToolStripMenuItem.Text = "Saving to demand";
            this.savingToDemandToolStripMenuItem.Click += new System.EventHandler(this.savingToDemandToolStripMenuItem_Click);
            // 
            // deliveryCourierToolStripMenuItem
            // 
            this.deliveryCourierToolStripMenuItem.Name = "deliveryCourierToolStripMenuItem";
            this.deliveryCourierToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.deliveryCourierToolStripMenuItem.Text = "By courier";
            this.deliveryCourierToolStripMenuItem.Click += new System.EventHandler(this.deliveryCourierToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingToDemandToolStripMenuItem1,
            this.courierAndLoadersToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Cargo delivery";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // savingToDemandToolStripMenuItem1
            // 
            this.savingToDemandToolStripMenuItem1.Name = "savingToDemandToolStripMenuItem1";
            this.savingToDemandToolStripMenuItem1.Size = new System.Drawing.Size(222, 26);
            this.savingToDemandToolStripMenuItem1.Text = "Saving to demand";
            this.savingToDemandToolStripMenuItem1.Click += new System.EventHandler(this.savingToDemandToolStripMenuItem1_Click);
            // 
            // courierAndLoadersToolStripMenuItem
            // 
            this.courierAndLoadersToolStripMenuItem.Name = "courierAndLoadersToolStripMenuItem";
            this.courierAndLoadersToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.courierAndLoadersToolStripMenuItem.Text = "Courier and loaders";
            this.courierAndLoadersToolStripMenuItem.Click += new System.EventHandler(this.courierAndLoadersToolStripMenuItem_Click);
            // 
            // addNewCardToolStripMenuItem
            // 
            this.addNewCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCardToolStripMenuItem1,
            this.addClientToolStripMenuItem,
            this.deleteCardToolStripMenuItem,
            this.taxesToolStripMenuItem});
            this.addNewCardToolStripMenuItem.Name = "addNewCardToolStripMenuItem";
            this.addNewCardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCardToolStripMenuItem.Text = "Service";
            // 
            // addNewCardToolStripMenuItem1
            // 
            this.addNewCardToolStripMenuItem1.Name = "addNewCardToolStripMenuItem1";
            this.addNewCardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addNewCardToolStripMenuItem1.Text = "Add New Card";
            this.addNewCardToolStripMenuItem1.Click += new System.EventHandler(this.addNewCardToolStripMenuItem1_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // deleteCardToolStripMenuItem
            // 
            this.deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            this.deleteCardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteCardToolStripMenuItem.Text = "Delete Card";
            this.deleteCardToolStripMenuItem.Click += new System.EventHandler(this.deleteCardToolStripMenuItem_Click);
            // 
            // listParcel
            // 
            this.listParcel.FormattingEnabled = true;
            this.listParcel.HorizontalScrollbar = true;
            this.listParcel.ItemHeight = 16;
            this.listParcel.Location = new System.Drawing.Point(12, 68);
            this.listParcel.Name = "listParcel";
            this.listParcel.Size = new System.Drawing.Size(490, 356);
            this.listParcel.TabIndex = 1;
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(509, 68);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(104, 38);
            this.buttonPickUp.TabIndex = 5;
            this.buttonPickUp.Text = "Pick up";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of uncollected parcels";
            // 
            // taxesToolStripMenuItem
            // 
            this.taxesToolStripMenuItem.Name = "taxesToolStripMenuItem";
            this.taxesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.taxesToolStripMenuItem.Text = "Taxes";
            this.taxesToolStripMenuItem.Click += new System.EventHandler(this.taxesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPickUp);
            this.Controls.Add(this.listParcel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savingToDemandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryCourierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem savingToDemandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem courierAndLoadersToolStripMenuItem;
        private System.Windows.Forms.ListBox listParcel;
        private System.Windows.Forms.Button buttonPickUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxesToolStripMenuItem;
    }
}

