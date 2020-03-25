namespace PizzaShop
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.tbxReceipt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.Location = new System.Drawing.Point(136, 454);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(194, 53);
            this.btnSaveReceipt.TabIndex = 1;
            this.btnSaveReceipt.Text = "Save Receipt";
            this.btnSaveReceipt.UseVisualStyleBackColor = true;
            this.btnSaveReceipt.Click += new System.EventHandler(this.btnSaveReceipt_Click);
            // 
            // tbxReceipt
            // 
            this.tbxReceipt.BackColor = System.Drawing.Color.White;
            this.tbxReceipt.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxReceipt.Location = new System.Drawing.Point(12, 12);
            this.tbxReceipt.Multiline = true;
            this.tbxReceipt.Name = "tbxReceipt";
            this.tbxReceipt.ReadOnly = true;
            this.tbxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxReceipt.Size = new System.Drawing.Size(443, 424);
            this.tbxReceipt.TabIndex = 2;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 519);
            this.Controls.Add(this.tbxReceipt);
            this.Controls.Add(this.btnSaveReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceiptForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.TextBox tbxReceipt;
    }
}