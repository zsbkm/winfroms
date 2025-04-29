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
            buttonBerszamfejtes = new Button();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, szulHelyDataGridViewTextBoxColumn, szulIdoDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, facebookDataGridViewTextBoxColumn, bioDataGridViewTextBoxColumn, mottoDataGridViewTextBoxColumn, sportokDataGridViewTextBoxColumn, dnnAzonositoDataGridViewTextBoxColumn, napszakDataGridViewTextBoxColumn, aktivDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, oraberDataGridViewTextBoxColumn, bankszamlaszamDataGridViewTextBoxColumn, adoazonositoDataGridViewTextBoxColumn, foglalasokDataGridViewTextBoxColumn });
            dataGridView1.DataSource = szemelyiEdzokBindingSource;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(942, 171);
            dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.ReadOnly = true;
            nevDataGridViewTextBoxColumn.Width = 53;
            // 
            // szulHelyDataGridViewTextBoxColumn
            // 
            szulHelyDataGridViewTextBoxColumn.DataPropertyName = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.HeaderText = "SzulHely";
            szulHelyDataGridViewTextBoxColumn.Name = "szulHelyDataGridViewTextBoxColumn";
            szulHelyDataGridViewTextBoxColumn.ReadOnly = true;
            szulHelyDataGridViewTextBoxColumn.Width = 77;
            // 
            // szulIdoDataGridViewTextBoxColumn
            // 
            szulIdoDataGridViewTextBoxColumn.DataPropertyName = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.HeaderText = "SzulIdo";
            szulIdoDataGridViewTextBoxColumn.Name = "szulIdoDataGridViewTextBoxColumn";
            szulIdoDataGridViewTextBoxColumn.ReadOnly = true;
            szulIdoDataGridViewTextBoxColumn.Width = 70;
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            telefonszamDataGridViewTextBoxColumn.ReadOnly = true;
            telefonszamDataGridViewTextBoxColumn.Width = 98;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 61;
            // 
            // facebookDataGridViewTextBoxColumn
            // 
            facebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook";
            facebookDataGridViewTextBoxColumn.HeaderText = "Facebook";
            facebookDataGridViewTextBoxColumn.Name = "facebookDataGridViewTextBoxColumn";
            facebookDataGridViewTextBoxColumn.ReadOnly = true;
            facebookDataGridViewTextBoxColumn.Width = 83;
            // 
            // bioDataGridViewTextBoxColumn
            // 
            bioDataGridViewTextBoxColumn.DataPropertyName = "Bio";
            bioDataGridViewTextBoxColumn.HeaderText = "Bio";
            bioDataGridViewTextBoxColumn.Name = "bioDataGridViewTextBoxColumn";
            bioDataGridViewTextBoxColumn.ReadOnly = true;
            bioDataGridViewTextBoxColumn.Width = 49;
            // 
            // mottoDataGridViewTextBoxColumn
            // 
            mottoDataGridViewTextBoxColumn.DataPropertyName = "Motto";
            mottoDataGridViewTextBoxColumn.HeaderText = "Motto";
            mottoDataGridViewTextBoxColumn.Name = "mottoDataGridViewTextBoxColumn";
            mottoDataGridViewTextBoxColumn.ReadOnly = true;
            mottoDataGridViewTextBoxColumn.Width = 65;
            // 
            // sportokDataGridViewTextBoxColumn
            // 
            sportokDataGridViewTextBoxColumn.DataPropertyName = "Sportok";
            sportokDataGridViewTextBoxColumn.HeaderText = "Sportok";
            sportokDataGridViewTextBoxColumn.Name = "sportokDataGridViewTextBoxColumn";
            sportokDataGridViewTextBoxColumn.ReadOnly = true;
            sportokDataGridViewTextBoxColumn.Width = 73;
            // 
            // dnnAzonositoDataGridViewTextBoxColumn
            // 
            dnnAzonositoDataGridViewTextBoxColumn.DataPropertyName = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.HeaderText = "DnnAzonosito";
            dnnAzonositoDataGridViewTextBoxColumn.Name = "dnnAzonositoDataGridViewTextBoxColumn";
            dnnAzonositoDataGridViewTextBoxColumn.ReadOnly = true;
            dnnAzonositoDataGridViewTextBoxColumn.Width = 107;
            // 
            // napszakDataGridViewTextBoxColumn
            // 
            napszakDataGridViewTextBoxColumn.DataPropertyName = "Napszak";
            napszakDataGridViewTextBoxColumn.HeaderText = "Napszak";
            napszakDataGridViewTextBoxColumn.Name = "napszakDataGridViewTextBoxColumn";
            napszakDataGridViewTextBoxColumn.ReadOnly = true;
            napszakDataGridViewTextBoxColumn.Width = 76;
            // 
            // aktivDataGridViewTextBoxColumn
            // 
            aktivDataGridViewTextBoxColumn.DataPropertyName = "Aktiv";
            aktivDataGridViewTextBoxColumn.HeaderText = "Aktiv";
            aktivDataGridViewTextBoxColumn.Name = "aktivDataGridViewTextBoxColumn";
            aktivDataGridViewTextBoxColumn.ReadOnly = true;
            aktivDataGridViewTextBoxColumn.Width = 59;
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            lakcimDataGridViewTextBoxColumn.ReadOnly = true;
            lakcimDataGridViewTextBoxColumn.Width = 70;
            // 
            // oraberDataGridViewTextBoxColumn
            // 
            oraberDataGridViewTextBoxColumn.DataPropertyName = "Oraber";
            oraberDataGridViewTextBoxColumn.HeaderText = "Oraber";
            oraberDataGridViewTextBoxColumn.Name = "oraberDataGridViewTextBoxColumn";
            oraberDataGridViewTextBoxColumn.ReadOnly = true;
            oraberDataGridViewTextBoxColumn.Width = 68;
            // 
            // bankszamlaszamDataGridViewTextBoxColumn
            // 
            bankszamlaszamDataGridViewTextBoxColumn.DataPropertyName = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.HeaderText = "Bankszamlaszam";
            bankszamlaszamDataGridViewTextBoxColumn.Name = "bankszamlaszamDataGridViewTextBoxColumn";
            bankszamlaszamDataGridViewTextBoxColumn.ReadOnly = true;
            bankszamlaszamDataGridViewTextBoxColumn.Width = 121;
            // 
            // adoazonositoDataGridViewTextBoxColumn
            // 
            adoazonositoDataGridViewTextBoxColumn.DataPropertyName = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.HeaderText = "Adoazonosito";
            adoazonositoDataGridViewTextBoxColumn.Name = "adoazonositoDataGridViewTextBoxColumn";
            adoazonositoDataGridViewTextBoxColumn.ReadOnly = true;
            adoazonositoDataGridViewTextBoxColumn.Width = 105;
            // 
            // foglalasokDataGridViewTextBoxColumn
            // 
            foglalasokDataGridViewTextBoxColumn.DataPropertyName = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.HeaderText = "Foglalasok";
            foglalasokDataGridViewTextBoxColumn.Name = "foglalasokDataGridViewTextBoxColumn";
            foglalasokDataGridViewTextBoxColumn.ReadOnly = true;
            foglalasokDataGridViewTextBoxColumn.Visible = false;
            foglalasokDataGridViewTextBoxColumn.Width = 88;
            // 
            // szemelyiEdzokBindingSource
            // 
            szemelyiEdzokBindingSource.DataSource = typeof(Models.SzemelyiEdzok);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 1;
            label1.Text = "Keresés név alapján";
            // 
            // textBoxEdzoSzuro
            // 
            textBoxEdzoSzuro.Cursor = Cursors.IBeam;
            textBoxEdzoSzuro.Location = new Point(12, 53);
            textBoxEdzoSzuro.Name = "textBoxEdzoSzuro";
            textBoxEdzoSzuro.Size = new Size(218, 23);
            textBoxEdzoSzuro.TabIndex = 1;
            textBoxEdzoSzuro.TextChanged += textBoxEdzoSzuro_TextChanged;
            // 
            // buttonAddNewCoach
            // 
            buttonAddNewCoach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddNewCoach.BackColor = Color.SlateGray;
            buttonAddNewCoach.Cursor = Cursors.Hand;
            buttonAddNewCoach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddNewCoach.ForeColor = SystemColors.Window;
            buttonAddNewCoach.Location = new Point(392, 26);
            buttonAddNewCoach.Name = "buttonAddNewCoach";
            buttonAddNewCoach.Size = new Size(182, 75);
            buttonAddNewCoach.TabIndex = 3;
            buttonAddNewCoach.Text = "Új edző hozááadása";
            buttonAddNewCoach.UseVisualStyleBackColor = false;
            buttonAddNewCoach.Click += buttonAddNewCoach_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.SlateGray;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.Window;
            buttonEdit.Location = new Point(580, 26);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(182, 75);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edző szerkesztése";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.SlateGray;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.Window;
            buttonDelete.Location = new Point(768, 26);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(186, 75);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Edző törlése";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(241, 33);
            label2.Name = "label2";
            label2.Size = new Size(132, 17);
            label2.TabIndex = 7;
            label2.Text = "Rendezési szempont";
            // 
            // buttonKilep
            // 
            buttonKilep.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonKilep.Cursor = Cursors.Hand;
            buttonKilep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKilep.Location = new Point(804, 310);
            buttonKilep.Name = "buttonKilep";
            buttonKilep.Size = new Size(150, 42);
            buttonKilep.TabIndex = 7;
            buttonKilep.Text = "Kilépés";
            buttonKilep.UseVisualStyleBackColor = true;
            buttonKilep.Click += buttonKilep_Click;
            // 
            // buttonBerszamfejtes
            // 
            buttonBerszamfejtes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBerszamfejtes.BackColor = Color.LightSlateGray;
            buttonBerszamfejtes.Cursor = Cursors.Hand;
            buttonBerszamfejtes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBerszamfejtes.ForeColor = SystemColors.Window;
            buttonBerszamfejtes.Location = new Point(12, 310);
            buttonBerszamfejtes.Name = "buttonBerszamfejtes";
            buttonBerszamfejtes.Size = new Size(150, 42);
            buttonBerszamfejtes.TabIndex = 8;
            buttonBerszamfejtes.Text = "Bérszámfejtés";
            buttonBerszamfejtes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(966, 364);
            Controls.Add(buttonBerszamfejtes);
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
        private Button buttonBerszamfejtes;
    }
}
