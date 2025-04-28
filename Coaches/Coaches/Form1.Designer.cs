namespace Coaches
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szulHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szulIdoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facebookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mottoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sportokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dnnAzonositoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            napszakDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oraberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankszamlaszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adoazonositoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalasokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szemelyiEdzokBindingSource = new BindingSource(components);
            label1 = new Label();
            textBoxEdzoSzuro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)szemelyiEdzokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, szulHelyDataGridViewTextBoxColumn, szulIdoDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, facebookDataGridViewTextBoxColumn, bioDataGridViewTextBoxColumn, mottoDataGridViewTextBoxColumn, sportokDataGridViewTextBoxColumn, dnnAzonositoDataGridViewTextBoxColumn, napszakDataGridViewTextBoxColumn, aktivDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, oraberDataGridViewTextBoxColumn, bankszamlaszamDataGridViewTextBoxColumn, adoazonositoDataGridViewTextBoxColumn, foglalasokDataGridViewTextBoxColumn });
            dataGridView1.DataSource = szemelyiEdzokBindingSource;
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 312);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // szulHelyDataGridViewTextBoxColumn
            // 
            szulHelyDataGridViewTextBoxColumn.DataPropertyName = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.HeaderText = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.Name = "szulHelyDataGridViewTextBoxColumn";
            // 
            // szulIdoDataGridViewTextBoxColumn
            // 
            szulIdoDataGridViewTextBoxColumn.DataPropertyName = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.HeaderText = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.Name = "szulIdoDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // facebookDataGridViewTextBoxColumn
            // 
            facebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook";
            facebookDataGridViewTextBoxColumn.HeaderText = "Facebook";
            facebookDataGridViewTextBoxColumn.Name = "facebookDataGridViewTextBoxColumn";
            // 
            // bioDataGridViewTextBoxColumn
            // 
            bioDataGridViewTextBoxColumn.DataPropertyName = "Bio";
            bioDataGridViewTextBoxColumn.HeaderText = "Bio";
            bioDataGridViewTextBoxColumn.Name = "bioDataGridViewTextBoxColumn";
            // 
            // mottoDataGridViewTextBoxColumn
            // 
            mottoDataGridViewTextBoxColumn.DataPropertyName = "Motto";
            mottoDataGridViewTextBoxColumn.HeaderText = "Motto";
            mottoDataGridViewTextBoxColumn.Name = "mottoDataGridViewTextBoxColumn";
            // 
            // sportokDataGridViewTextBoxColumn
            // 
            sportokDataGridViewTextBoxColumn.DataPropertyName = "Sportok";
            sportokDataGridViewTextBoxColumn.HeaderText = "Sportok";
            sportokDataGridViewTextBoxColumn.Name = "sportokDataGridViewTextBoxColumn";
            // 
            // dnnAzonositoDataGridViewTextBoxColumn
            // 
            dnnAzonositoDataGridViewTextBoxColumn.DataPropertyName = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.HeaderText = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.Name = "dnnAzonositoDataGridViewTextBoxColumn";
            // 
            // napszakDataGridViewTextBoxColumn
            // 
            napszakDataGridViewTextBoxColumn.DataPropertyName = "Napszak";
            napszakDataGridViewTextBoxColumn.HeaderText = "Napszak";
            napszakDataGridViewTextBoxColumn.Name = "napszakDataGridViewTextBoxColumn";
            // 
            // aktivDataGridViewTextBoxColumn
            // 
            aktivDataGridViewTextBoxColumn.DataPropertyName = "Aktiv";
            aktivDataGridViewTextBoxColumn.HeaderText = "Aktiv";
            aktivDataGridViewTextBoxColumn.Name = "aktivDataGridViewTextBoxColumn";
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            // 
            // oraberDataGridViewTextBoxColumn
            // 
            oraberDataGridViewTextBoxColumn.DataPropertyName = "Oraber";
            oraberDataGridViewTextBoxColumn.HeaderText = "Oraber";
            oraberDataGridViewTextBoxColumn.Name = "oraberDataGridViewTextBoxColumn";
            // 
            // bankszamlaszamDataGridViewTextBoxColumn
            // 
            bankszamlaszamDataGridViewTextBoxColumn.DataPropertyName = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.HeaderText = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.Name = "bankszamlaszamDataGridViewTextBoxColumn";
            // 
            // adoazonositoDataGridViewTextBoxColumn
            // 
            adoazonositoDataGridViewTextBoxColumn.DataPropertyName = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.HeaderText = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.Name = "adoazonositoDataGridViewTextBoxColumn";
            // 
            // foglalasokDataGridViewTextBoxColumn
            // 
            foglalasokDataGridViewTextBoxColumn.DataPropertyName = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.HeaderText = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.Name = "foglalasokDataGridViewTextBoxColumn";
            foglalasokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szemelyiEdzokBindingSource
            // 
            szemelyiEdzokBindingSource.DataSource = typeof(Models.SzemelyiEdzok);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBoxEdzoSzuro
            // 
            textBoxEdzoSzuro.Location = new Point(12, 34);
            textBoxEdzoSzuro.Name = "textBoxEdzoSzuro";
            textBoxEdzoSzuro.Size = new Size(218, 23);
            textBoxEdzoSzuro.TabIndex = 2;
            textBoxEdzoSzuro.TextChanged += textBoxEdzoSzuro_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEdzoSzuro);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)szemelyiEdzokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxEdzoSzuro;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szulHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szulIdoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn facebookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mottoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sportokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dnnAzonositoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napszakDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aktivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oraberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankszamlaszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adoazonositoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foglalasokDataGridViewTextBoxColumn;
        private BindingSource szemelyiEdzokBindingSource;
    }
}
