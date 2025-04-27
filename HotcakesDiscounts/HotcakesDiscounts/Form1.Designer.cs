namespace HotcakesDiscounts
{
    partial class Form1
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
            this.buttonGetWishlist = new System.Windows.Forms.Button();
            this.buttonGetActiveDiscounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetWishlist
            // 
            this.buttonGetWishlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetWishlist.Location = new System.Drawing.Point(300, 84);
            this.buttonGetWishlist.Name = "buttonGetWishlist";
            this.buttonGetWishlist.Size = new System.Drawing.Size(293, 174);
            this.buttonGetWishlist.TabIndex = 0;
            this.buttonGetWishlist.Text = "Kedvencek lekérdezése";
            this.buttonGetWishlist.UseVisualStyleBackColor = true;
            // 
            // buttonGetActiveDiscounts
            // 
            this.buttonGetActiveDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetActiveDiscounts.Location = new System.Drawing.Point(300, 299);
            this.buttonGetActiveDiscounts.Name = "buttonGetActiveDiscounts";
            this.buttonGetActiveDiscounts.Size = new System.Drawing.Size(293, 174);
            this.buttonGetActiveDiscounts.TabIndex = 1;
            this.buttonGetActiveDiscounts.Text = "Aktív kedvezmények lekérdezése";
            this.buttonGetActiveDiscounts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 552);
            this.Controls.Add(this.buttonGetActiveDiscounts);
            this.Controls.Add(this.buttonGetWishlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetWishlist;
        private System.Windows.Forms.Button buttonGetActiveDiscounts;
    }
}

