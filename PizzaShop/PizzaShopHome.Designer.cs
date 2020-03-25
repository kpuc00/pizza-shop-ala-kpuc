namespace PizzaShop
{
    partial class PizzaShopHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaShopHome));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.btnOrderInfo = new System.Windows.Forms.Button();
            this.btnChef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(128, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(716, 84);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Pizza Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(677, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "a la Kpuc";
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderNow.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderNow.Location = new System.Drawing.Point(387, 263);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(187, 54);
            this.btnOrderNow.TabIndex = 2;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderInfo.Location = new System.Drawing.Point(387, 333);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(187, 54);
            this.btnOrderInfo.TabIndex = 3;
            this.btnOrderInfo.Text = "Order Info";
            this.btnOrderInfo.UseVisualStyleBackColor = false;
            this.btnOrderInfo.Click += new System.EventHandler(this.btnOrderInfo_Click);
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.Transparent;
            this.btnChef.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChef.Location = new System.Drawing.Point(826, 505);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(119, 38);
            this.btnChef.TabIndex = 4;
            this.btnChef.Text = "I\'m the chef";
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // PizzaShopHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PizzaShop.Properties.Resources.pizzashop_background_blur;
            this.ClientSize = new System.Drawing.Size(960, 555);
            this.Controls.Add(this.btnChef);
            this.Controls.Add(this.btnOrderInfo);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PizzaShopHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Pizza Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PizzaShopHome_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Button btnOrderInfo;
        private System.Windows.Forms.Button btnChef;
    }
}

