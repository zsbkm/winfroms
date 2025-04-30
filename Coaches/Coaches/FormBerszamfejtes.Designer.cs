namespace Coaches
{
    partial class FormBerszamfejtes
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
            dataGridView1 = new DataGridView();
            comboBoxHonap = new ComboBox();
            label1 = new Label();
            buttonExport = new Button();
            buttonBezaras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 283);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxHonap
            // 
            comboBoxHonap.FormattingEnabled = true;
            comboBoxHonap.Location = new Point(64, 18);
            comboBoxHonap.Name = "comboBoxHonap";
            comboBoxHonap.Size = new Size(202, 23);
            comboBoxHonap.TabIndex = 1;
            comboBoxHonap.SelectedIndexChanged += comboBoxHonap_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Hónap:";
            // 
            // buttonExport
            // 
            buttonExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExport.BackColor = Color.SlateGray;
            buttonExport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExport.ForeColor = Color.White;
            buttonExport.Location = new Point(351, 12);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(204, 56);
            buttonExport.TabIndex = 3;
            buttonExport.Text = "Exportálás excelbe";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // buttonBezaras
            // 
            buttonBezaras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBezaras.Location = new Point(446, 407);
            buttonBezaras.Name = "buttonBezaras";
            buttonBezaras.Size = new Size(109, 31);
            buttonBezaras.TabIndex = 4;
            buttonBezaras.Text = "Bezárás";
            buttonBezaras.UseVisualStyleBackColor = true;
            buttonBezaras.Click += buttonBezaras_Click;
            // 
            // FormBerszamfejtes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(buttonBezaras);
            Controls.Add(buttonExport);
            Controls.Add(label1);
            Controls.Add(comboBoxHonap);
            Controls.Add(dataGridView1);
            Name = "FormBerszamfejtes";
            Text = "FormBerszamfejtes";
            Load += FormBerszamfejtes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxHonap;
        private Label label1;
        private Button buttonExport;
        private Button buttonBezaras;
    }
}