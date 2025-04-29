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
            buttonAddNewCoach = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            buttonKilep = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)szemelyiEdzokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, szulHelyDataGridViewTextBoxColumn, szulIdoDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, facebookDataGridViewTextBoxColumn, bioDataGridViewTextBoxColumn, mottoDataGridViewTextBoxColumn, sportokDataGridViewTextBoxColumn, dnnAzonositoDataGridViewTextBoxColumn, napszakDataGridViewTextBoxColumn, aktivDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, oraberDataGridViewTextBoxColumn, bankszamlaszamDataGridViewTextBoxColumn, adoazonositoDataGridViewTextBoxColumn, foglalasokDataGridViewTextBoxColumn });
            dataGridView1.DataSource = szemelyiEdzokBindingSource;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 262);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szulHelyDataGridViewTextBoxColumn
            // 
            szulHelyDataGridViewTextBoxColumn.DataPropertyName = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.HeaderText = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.Name = "szulHelyDataGridViewTextBoxColumn";
            szulHelyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szulIdoDataGridViewTextBoxColumn
            // 
            szulIdoDataGridViewTextBoxColumn.DataPropertyName = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.HeaderText = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.Name = "szulIdoDataGridViewTextBoxColumn";
            szulIdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            telefonszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facebookDataGridViewTextBoxColumn
            // 
            facebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook";
            facebookDataGridViewTextBoxColumn.HeaderText = "Facebook";
            facebookDataGridViewTextBoxColumn.Name = "facebookDataGridViewTextBoxColumn";
            facebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bioDataGridViewTextBoxColumn
            // 
            bioDataGridViewTextBoxColumn.DataPropertyName = "Bio";
            bioDataGridViewTextBoxColumn.HeaderText = "Bio";
            bioDataGridViewTextBoxColumn.Name = "bioDataGridViewTextBoxColumn";
            bioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mottoDataGridViewTextBoxColumn
            // 
            mottoDataGridViewTextBoxColumn.DataPropertyName = "Motto";
            mottoDataGridViewTextBoxColumn.HeaderText = "Motto";
            mottoDataGridViewTextBoxColumn.Name = "mottoDataGridViewTextBoxColumn";
            mottoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sportokDataGridViewTextBoxColumn
            // 
            sportokDataGridViewTextBoxColumn.DataPropertyName = "Sportok";
            sportokDataGridViewTextBoxColumn.HeaderText = "Sportok";
            sportokDataGridViewTextBoxColumn.Name = "sportokDataGridViewTextBoxColumn";
            sportokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dnnAzonositoDataGridViewTextBoxColumn
            // 
            dnnAzonositoDataGridViewTextBoxColumn.DataPropertyName = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.HeaderText = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.Name = "dnnAzonositoDataGridViewTextBoxColumn";
            dnnAzonositoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napszakDataGridViewTextBoxColumn
            // 
            napszakDataGridViewTextBoxColumn.DataPropertyName = "Napszak";
            napszakDataGridViewTextBoxColumn.HeaderText = "Napszak";
            napszakDataGridViewTextBoxColumn.Name = "napszakDataGridViewTextBoxColumn";
            napszakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivDataGridViewTextBoxColumn
            // 
            aktivDataGridViewTextBoxColumn.DataPropertyName = "Aktiv";
            aktivDataGridViewTextBoxColumn.HeaderText = "Aktiv";
            aktivDataGridViewTextBoxColumn.Name = "aktivDataGridViewTextBoxColumn";
            aktivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            lakcimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oraberDataGridViewTextBoxColumn
            // 
            oraberDataGridViewTextBoxColumn.DataPropertyName = "Oraber";
            oraberDataGridViewTextBoxColumn.HeaderText = "Oraber";
            oraberDataGridViewTextBoxColumn.Name = "oraberDataGridViewTextBoxColumn";
            oraberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankszamlaszamDataGridViewTextBoxColumn
            // 
            bankszamlaszamDataGridViewTextBoxColumn.DataPropertyName = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.HeaderText = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.Name = "bankszamlaszamDataGridViewTextBoxColumn";
            bankszamlaszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoazonositoDataGridViewTextBoxColumn
            // 
            adoazonositoDataGridViewTextBoxColumn.DataPropertyName = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.HeaderText = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.Name = "adoazonositoDataGridViewTextBoxColumn";
            adoazonositoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foglalasokDataGridViewTextBoxColumn
            // 
            foglalasokDataGridViewTextBoxColumn.DataPropertyName = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.HeaderText = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.Name = "foglalasokDataGridViewTextBoxColumn";
            foglalasokDataGridViewTextBoxColumn.ReadOnly = true;
            foglalasokDataGridViewTextBoxColumn.Visible = false;
            // 
            // szemelyiEdzokBindingSource
            // 
            szemelyiEdzokBindingSource.DataSource = typeof(Models.SzemelyiEdzok);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Keresés név alapján";
            // 
            // textBoxEdzoSzuro
            // 
            textBoxEdzoSzuro.Location = new Point(12, 64);
            textBoxEdzoSzuro.Name = "textBoxEdzoSzuro";
            textBoxEdzoSzuro.Size = new Size(218, 23);
            textBoxEdzoSzuro.TabIndex = 2;
            textBoxEdzoSzuro.TextChanged += textBoxEdzoSzuro_TextChanged;
            // 
            // buttonAddNewCoach
            // 
            buttonAddNewCoach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddNewCoach.Location = new Point(15, 390);
            buttonAddNewCoach.Name = "buttonAddNewCoach";
            buttonAddNewCoach.Size = new Size(150, 42);
            buttonAddNewCoach.TabIndex = 3;
            buttonAddNewCoach.Text = "Új hozááadása";
            buttonAddNewCoach.UseVisualStyleBackColor = true;
            buttonAddNewCoach.Click += buttonAddNewCoach_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdit.Location = new Point(200, 390);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 42);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Szerkesztés";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(384, 390);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 42);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 46);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Rendezési szempont";
            // 
            // buttonKilep
            // 
            buttonKilep.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonKilep.Location = new Point(631, 390);
            buttonKilep.Name = "buttonKilep";
            buttonKilep.Size = new Size(150, 42);
            buttonKilep.TabIndex = 8;
            buttonKilep.Text = "Kilépés";
            buttonKilep.UseVisualStyleBackColor = true;
            buttonKilep.Click += buttonKilep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKilep);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddNewCoach);
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
        private BindingSource szemelyiEdzokBindingSource;
        private Button buttonAddNewCoach;
        private Button buttonEdit;
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
        private Button buttonDelete;
        private ComboBox comboBox1;
        private Label label2;
        private Button buttonKilep;
    }
}
