namespace PizzaShop
{
    partial class ChefForm
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
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.lbxSortedOrders = new System.Windows.Forms.ListBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 20;
            this.lbxCustomers.Location = new System.Drawing.Point(1, 2);
            this.lbxCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(447, 464);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxCustomers_MouseDoubleClick);
            // 
            // lbxOrders
            // 
            this.lbxOrders.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 20;
            this.lbxOrders.Location = new System.Drawing.Point(1, 1);
            this.lbxOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(446, 464);
            this.lbxOrders.TabIndex = 1;
            this.lbxOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxOrders_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Location = new System.Drawing.Point(15, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 504);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.lbxOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 32);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Size = new System.Drawing.Size(451, 468);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.lbxCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 32);
            this.tabPageCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCustomers.Size = new System.Drawing.Size(451, 468);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // lbxSortedOrders
            // 
            this.lbxSortedOrders.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxSortedOrders.FormattingEnabled = true;
            this.lbxSortedOrders.ItemHeight = 20;
            this.lbxSortedOrders.Location = new System.Drawing.Point(747, 50);
            this.lbxSortedOrders.Name = "lbxSortedOrders";
            this.lbxSortedOrders.Size = new System.Drawing.Size(409, 464);
            this.lbxSortedOrders.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.White;
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenue.Location = new System.Drawing.Point(501, 50);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(215, 116);
            this.lblRevenue.TabIndex = 4;
            this.lblRevenue.Text = "Shop revenue: \\n\\n {revenue}";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaShop.Properties.Resources.pizzashop_background;
            this.ClientSize = new System.Drawing.Size(1168, 534);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lbxSortedOrders);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChefForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.ListBox lbxSortedOrders;
        private System.Windows.Forms.Label lblRevenue;
    }
}