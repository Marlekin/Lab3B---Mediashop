namespace MediaShop
{
    partial class Hub
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
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.Cashier = new System.Windows.Forms.TabPage();
            this.Warehouse = new System.Windows.Forms.TabPage();
            this.TabMenu.SuspendLayout();
            this.Cashier.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.Cashier);
            this.TabMenu.Controls.Add(this.Warehouse);
            this.TabMenu.Location = new System.Drawing.Point(12, 12);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(759, 445);
            this.TabMenu.TabIndex = 0;
            // 
            // Cashier
            // 
            this.Cashier.BackColor = System.Drawing.Color.Transparent;
            this.Cashier.Location = new System.Drawing.Point(4, 22);
            this.Cashier.Name = "Cashier";
            this.Cashier.Padding = new System.Windows.Forms.Padding(3);
            this.Cashier.Size = new System.Drawing.Size(751, 419);
            this.Cashier.TabIndex = 0;
            this.Cashier.Text = "Cashier";
            // 
            // Warehouse
            // 
            this.Warehouse.BackColor = System.Drawing.Color.Transparent;
            this.Warehouse.Location = new System.Drawing.Point(4, 22);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Padding = new System.Windows.Forms.Padding(3);
            this.Warehouse.Size = new System.Drawing.Size(751, 419);
            this.Warehouse.TabIndex = 1;
            this.Warehouse.Text = "Warehouse";
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(783, 469);
            this.Controls.Add(this.TabMenu);
            this.Name = "Hub";
            this.Text = "MediaShop";
            this.TabMenu.ResumeLayout(false);
            this.Cashier.ResumeLayout(false);
          
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage Cashier;
        private System.Windows.Forms.TabPage Warehouse;
       
       
    }
}

