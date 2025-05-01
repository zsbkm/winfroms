namespace Coaches
{
    partial class FormEdit
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
            components = new System.ComponentModel.Container();
            buttonOk = new Button();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            buttonCancel = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            checkBox1 = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(568, 408);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(87, 27);
            buttonOk.TabIndex = 17;
            buttonOk.Text = "Mentés";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 25);
            textBox1.TabIndex = 1;
            textBox1.Validating += textBox1_Validating;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.SzemelyiEdzok);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 2;
            label1.Text = "Név";
            // 
            // buttonCancel
            // 
            buttonCancel.CausesValidation = false;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(475, 408);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 27);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 5;
            label2.Text = "Születési hely";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "SzulHely", true));
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 25);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 7;
            label3.Text = "Telefonszám";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Telefonszam", true));
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 25);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 9;
            label4.Text = "Születési idő";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "SzulIdo", true));
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 25);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(12, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 25);
            textBox5.TabIndex = 5;
            textBox5.Validating += textBox5_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 13;
            label6.Text = "Facebook";
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Facebook", true));
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(12, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 25);
            textBox6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(246, 193);
            label7.Name = "label7";
            label7.Size = new Size(27, 17);
            label7.TabIndex = 15;
            label7.Text = "Bio";
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Bio", true));
            textBox7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(246, 211);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(409, 118);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(246, 336);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 17;
            label8.Text = "Mottó";
            // 
            // textBox8
            // 
            textBox8.Cursor = Cursors.IBeam;
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "Motto", true));
            textBox8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(246, 354);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(409, 23);
            textBox8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 288);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 19;
            label9.Text = "Sportok";
            toolTip1.SetToolTip(label9, "Több sport esetén a formátum: trx;spinning;...");
            // 
            // textBox9
            // 
            textBox9.Cursor = Cursors.IBeam;
            textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "Sportok", true));
            textBox9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(12, 306);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(177, 25);
            textBox9.TabIndex = 7;
            toolTip1.SetToolTip(textBox9, "Több sport esetén a formátum: trx;spinning;...");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 336);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
            label10.TabIndex = 21;
            label10.Text = "Napszak";
            // 
            // textBox10
            // 
            textBox10.Cursor = Cursors.IBeam;
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "Napszak", true));
            textBox10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(12, 354);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(177, 25);
            textBox10.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(246, 147);
            label11.Name = "label11";
            label11.Size = new Size(49, 17);
            label11.TabIndex = 23;
            label11.Text = "Lakcím";
            // 
            // textBox11
            // 
            textBox11.Cursor = Cursors.IBeam;
            textBox11.DataBindings.Add(new Binding("Text", bindingSource1, "Lakcim", true));
            textBox11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(246, 165);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(409, 25);
            textBox11.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(246, 4);
            label12.Name = "label12";
            label12.Size = new Size(50, 17);
            label12.TabIndex = 25;
            label12.Text = "Órabér";
            // 
            // textBox12
            // 
            textBox12.Cursor = Cursors.IBeam;
            textBox12.DataBindings.Add(new Binding("Text", bindingSource1, "Oraber", true));
            textBox12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(246, 22);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(177, 25);
            textBox12.TabIndex = 9;
            textBox12.Validating += textBox12_Validating;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(246, 53);
            label13.Name = "label13";
            label13.Size = new Size(110, 17);
            label13.TabIndex = 27;
            label13.Text = "Bankszámlaszám";
            // 
            // textBox13
            // 
            textBox13.Cursor = Cursors.IBeam;
            textBox13.DataBindings.Add(new Binding("Text", bindingSource1, "Bankszamlaszam", true));
            textBox13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(246, 71);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(409, 25);
            textBox13.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(246, 101);
            label14.Name = "label14";
            label14.Size = new Size(92, 17);
            label14.TabIndex = 29;
            label14.Text = "Adóazonosító";
            // 
            // textBox14
            // 
            textBox14.Cursor = Cursors.IBeam;
            textBox14.DataBindings.Add(new Binding("Text", bindingSource1, "Adoazonosito", true));
            textBox14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(246, 119);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(409, 25);
            textBox14.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(246, 392);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(172, 21);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Jelenjen meg az oldalon";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(667, 447);
            Controls.Add(checkBox1);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label13);
            Controls.Add(textBox13);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(label11);
            Controls.Add(textBox11);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormEdit";
            Text = "FormEdit";
            Load += FormEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private TextBox textBox1;
        private Label label1;
        private BindingSource bindingSource1;
        private Button buttonCancel;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox14;
        private CheckBox checkBox1;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
    }
}