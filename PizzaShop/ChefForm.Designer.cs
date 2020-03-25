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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefForm));
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.lbxSortedOrders = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetRevenue = new System.Windows.Forms.Button();
            this.lblNrCustomers = new System.Windows.Forms.Label();
            this.lblNrOrders = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.HorizontalScrollbar = true;
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
            this.lbxOrders.HorizontalScrollbar = true;
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
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(15, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 504);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.lbxCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 35);
            this.tabPageCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCustomers.Size = new System.Drawing.Size(451, 465);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.lbxOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 35);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Size = new System.Drawing.Size(451, 465);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // lbxSortedOrders
            // 
            this.lbxSortedOrders.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxSortedOrders.FormattingEnabled = true;
            this.lbxSortedOrders.HorizontalScrollbar = true;
            this.lbxSortedOrders.ItemHeight = 20;
            this.lbxSortedOrders.Location = new System.Drawing.Point(747, 50);
            this.lbxSortedOrders.Name = "lbxSortedOrders";
            this.lbxSortedOrders.Size = new System.Drawing.Size(409, 464);
            this.lbxSortedOrders.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnResetRevenue);
            this.panel1.Controls.Add(this.lblNrCustomers);
            this.panel1.Controls.Add(this.lblNrOrders);
            this.panel1.Controls.Add(this.lblRevenue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(475, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 246);
            this.panel1.TabIndex = 5;
            // 
            // btnResetRevenue
            // 
            this.btnResetRevenue.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetRevenue.Location = new System.Drawing.Point(66, 186);
            this.btnResetRevenue.Name = "btnResetRevenue";
            this.btnResetRevenue.Size = new System.Drawing.Size(135, 35);
            this.btnResetRevenue.TabIndex = 6;
            this.btnResetRevenue.Text = "Reset revenue";
            this.btnResetRevenue.UseVisualStyleBackColor = true;
            this.btnResetRevenue.Click += new System.EventHandler(this.btnResetRevenue_Click);
            // 
            // lblNrCustomers
            // 
            this.lblNrCustomers.AutoSize = true;
            this.lblNrCustomers.Location = new System.Drawing.Point(193, 137);
            this.lblNrCustomers.Name = "lblNrCustomers";
            this.lblNrCustomers.Size = new System.Drawing.Size(20, 23);
            this.lblNrCustomers.TabIndex = 6;
            this.lblNrCustomers.Text = "0";
            // 
            // lblNrOrders
            // 
            this.lblNrOrders.AutoSize = true;
            this.lblNrOrders.Location = new System.Drawing.Point(193, 95);
            this.lblNrOrders.Name = "lblNrOrders";
            this.lblNrOrders.Size = new System.Drawing.Size(20, 23);
            this.lblNrOrders.TabIndex = 5;
            this.lblNrOrders.Text = "0";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(193, 57);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(58, 23);
            this.lblRevenue.TabIndex = 4;
            this.lblRevenue.Text = "€ 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of customers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of orders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop revenue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(337, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Edit menu";
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaShop.Properties.Resources.pizzashop_background;
            this.ClientSize = new System.Drawing.Size(1168, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxSortedOrders);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChefForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.ListBox lbxSortedOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNrCustomers;
        private System.Windows.Forms.Label lblNrOrders;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetRevenue;
        private System.Windows.Forms.Label label5;
    }
}