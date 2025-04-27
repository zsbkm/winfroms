namespace HotcakesDiscounts
{
    partial class FormKedvencek
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
            this.dataGridViewKedvencek = new System.Windows.Forms.DataGridView();
            this.buttonKedvencekBezaras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKedvencek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKedvencek
            // 
            this.dataGridViewKedvencek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKedvencek.Location = new System.Drawing.Point(11, 21);
            this.dataGridViewKedvencek.Name = "dataGridViewKedvencek";
            this.dataGridViewKedvencek.Size = new System.Drawing.Size(776, 303);
            this.dataGridViewKedvencek.TabIndex = 0;
            // 
            // buttonKedvencekBezaras
            // 
            this.buttonKedvencekBezaras.Location = new System.Drawing.Point(691, 396);
            this.buttonKedvencekBezaras.Name = "buttonKedvencekBezaras";
            this.buttonKedvencekBezaras.Size = new System.Drawing.Size(96, 28);
            this.buttonKedvencekBezaras.TabIndex = 1;
            this.buttonKedvencekBezaras.Text = "Bezárás";
            this.buttonKedvencekBezaras.UseVisualStyleBackColor = true;
            this.buttonKedvencekBezaras.Click += new System.EventHandler(this.buttonKedvencekBezaras_Click);
            // 
            // FormKedvencek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKedvencekBezaras);
            this.Controls.Add(this.dataGridViewKedvencek);
            this.Name = "FormKedvencek";
            this.Text = "FormKedvencek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKedvencek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKedvencek;
        private System.Windows.Forms.Button buttonKedvencekBezaras;
    }
}