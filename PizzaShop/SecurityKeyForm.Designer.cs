namespace PizzaShop
{
    partial class SecurityKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityKeyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please type the security key:";
            // 
            // tbxKey
            // 
            this.tbxKey.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxKey.Location = new System.Drawing.Point(16, 55);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.PasswordChar = '•';
            this.tbxKey.Size = new System.Drawing.Size(282, 27);
            this.tbxKey.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.Location = new System.Drawing.Point(374, 43);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 49);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SecurityKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaShop.Properties.Resources.pizzashop_background_blur;
            this.ClientSize = new System.Drawing.Size(522, 126);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SecurityKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityKeyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityKeyForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Button btnSubmit;
    }
}