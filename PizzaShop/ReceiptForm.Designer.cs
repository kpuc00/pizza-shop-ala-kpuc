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
            this.lbxReceipt = new System.Windows.Forms.ListBox();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 16;
            this.lbxReceipt.Location = new System.Drawing.Point(12, 12);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(370, 436);
            this.lbxReceipt.TabIndex = 0;
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.Location = new System.Drawing.Point(98, 454);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(194, 53);
            this.btnSaveReceipt.TabIndex = 1;
            this.btnSaveReceipt.Text = "Download Receipt";
            this.btnSaveReceipt.UseVisualStyleBackColor = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 519);
            this.Controls.Add(this.btnSaveReceipt);
            this.Controls.Add(this.lbxReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxReceipt;
        private System.Windows.Forms.Button btnSaveReceipt;
    }
}