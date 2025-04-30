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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.Location = new Point(649, 544);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(99, 36);
            buttonOk.TabIndex = 17;
            buttonOk.Text = "Mentés";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 29);
            textBox1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.SzemelyiEdzok);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 5);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 2;
            label1.Text = "Név";
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(543, 544);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 36);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 5;
            label2.Text = "Születési hely";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "SzulHely", true));
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(14, 93);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 29);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 196);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 7;
            label3.Text = "Telefonszám";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Telefonszam", true));
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(14, 220);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 29);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 135);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 9;
            label4.Text = "Születési idő";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "SzulIdo", true));
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(14, 159);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 29);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 257);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(14, 281);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 29);
            textBox5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 321);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 13;
            label6.Text = "Facebook";
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Facebook", true));
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(14, 345);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 29);
            textBox6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(281, 257);
            label7.Name = "label7";
            label7.Size = new Size(34, 23);
            label7.TabIndex = 15;
            label7.Text = "Bio";
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Bio", true));
            textBox7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(281, 281);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(467, 156);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(281, 448);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 17;
            label8.Text = "Mottó";
            // 
            // textBox8
            // 
            textBox8.Cursor = Cursors.IBeam;
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "Motto", true));
            textBox8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(281, 472);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(467, 29);
            textBox8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(14, 384);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 19;
            label9.Text = "Sportok";
            // 
            // textBox9
            // 
            textBox9.Cursor = Cursors.IBeam;
            textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "Sportok", true));
            textBox9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(14, 408);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(202, 29);
            textBox9.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 448);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 21;
            label10.Text = "Napszak";
            // 
            // textBox10
            // 
            textBox10.Cursor = Cursors.IBeam;
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "Napszak", true));
            textBox10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(14, 472);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(202, 29);
            textBox10.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(281, 196);
            label11.Name = "label11";
            label11.Size = new Size(62, 23);
            label11.TabIndex = 23;
            label11.Text = "Lakcím";
            // 
            // textBox11
            // 
            textBox11.Cursor = Cursors.IBeam;
            textBox11.DataBindings.Add(new Binding("Text", bindingSource1, "Lakcim", true));
            textBox11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(281, 220);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(467, 29);
            textBox11.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(281, 5);
            label12.Name = "label12";
            label12.Size = new Size(63, 23);
            label12.TabIndex = 25;
            label12.Text = "Órabér";
            // 
            // textBox12
            // 
            textBox12.Cursor = Cursors.IBeam;
            textBox12.DataBindings.Add(new Binding("Text", bindingSource1, "Oraber", true));
            textBox12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(281, 29);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(202, 29);
            textBox12.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(281, 71);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 27;
            label13.Text = "Bankszámlaszám";
            // 
            // textBox13
            // 
            textBox13.Cursor = Cursors.IBeam;
            textBox13.DataBindings.Add(new Binding("Text", bindingSource1, "Bankszamlaszam", true));
            textBox13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(281, 95);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(467, 29);
            textBox13.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(281, 135);
            label14.Name = "label14";
            label14.Size = new Size(115, 23);
            label14.TabIndex = 29;
            label14.Text = "Adóazonosító";
            // 
            // textBox14
            // 
            textBox14.Cursor = Cursors.IBeam;
            textBox14.DataBindings.Add(new Binding("Text", bindingSource1, "Adoazonosito", true));
            textBox14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(281, 159);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(467, 29);
            textBox14.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(281, 523);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(216, 27);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Jelenjen meg az oldalon";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(762, 596);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEdit";
            Text = "FormEdit";
            Load += FormEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
    }
}