namespace Coaches
{
    partial class FormAdd
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
            label14 = new Label();
            textBox14 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label13 = new Label();
            textBox13 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            buttonCancel = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonOk = new Button();
            textBoxDNNid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(246, 107);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 59;
            label14.Text = "Adóazonosító";
            // 
            // textBox14
            // 
            textBox14.DataBindings.Add(new Binding("Text", bindingSource1, "Adoazonosito", true));
            textBox14.Location = new Point(246, 125);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(409, 23);
            textBox14.TabIndex = 58;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.SzemelyiEdzok);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(246, 59);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 57;
            label13.Text = "Bankszámlaszám";
            // 
            // textBox13
            // 
            textBox13.DataBindings.Add(new Binding("Text", bindingSource1, "Bankszamlaszam", true));
            textBox13.Location = new Point(246, 77);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(409, 23);
            textBox13.TabIndex = 56;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(246, 15);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 55;
            label12.Text = "Órabér";
            // 
            // textBox12
            // 
            textBox12.DataBindings.Add(new Binding("Text", bindingSource1, "Oraber", true));
            textBox12.Location = new Point(246, 33);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(177, 23);
            textBox12.TabIndex = 54;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 153);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 53;
            label11.Text = "Lakcím";
            // 
            // textBox11
            // 
            textBox11.DataBindings.Add(new Binding("Text", bindingSource1, "Lakcim", true));
            textBox11.Location = new Point(246, 171);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(409, 23);
            textBox11.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 342);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 51;
            label10.Text = "Napszak";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "Napszak", true));
            textBox10.Location = new Point(12, 360);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(177, 23);
            textBox10.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 294);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 49;
            label9.Text = "Sportok";
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "Sportok", true));
            textBox9.Location = new Point(12, 312);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(177, 23);
            textBox9.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 342);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 47;
            label8.Text = "Mottó";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "Motto", true));
            textBox8.Location = new Point(246, 360);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(409, 23);
            textBox8.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 199);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 45;
            label7.Text = "Bio";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Bio", true));
            textBox7.Location = new Point(246, 217);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(409, 118);
            textBox7.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 247);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 43;
            label6.Text = "Facebook";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Facebook", true));
            textBox6.Location = new Point(12, 265);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            textBox5.Location = new Point(12, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 39;
            label4.Text = "Születési idő";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "SzulIdo", true));
            textBox4.Location = new Point(12, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 37;
            label3.Text = "Telefonszám";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Telefonszam", true));
            textBox3.Location = new Point(12, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 35;
            label2.Text = "Születési hely";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "SzulHely", true));
            textBox2.Location = new Point(12, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 34;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(475, 414);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 27);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Mégse";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 32;
            label1.Text = "Név";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 31;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(568, 414);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(87, 27);
            buttonOk.TabIndex = 30;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBoxDNNid
            // 
            textBoxDNNid.DataBindings.Add(new Binding("Text", bindingSource1, "DnnAzonosito", true));
            textBoxDNNid.Location = new Point(12, 414);
            textBoxDNNid.Name = "textBoxDNNid";
            textBoxDNNid.Size = new Size(177, 23);
            textBoxDNNid.TabIndex = 60;
            textBoxDNNid.Visible = false;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(textBoxDNNid);
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
            Name = "FormAdd";
            Text = "FormAdd";
            Load += FormAdd_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private TextBox textBox14;
        private Label label13;
        private TextBox textBox13;
        private Label label12;
        private TextBox textBox12;
        private Label label11;
        private TextBox textBox11;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBox1;
        private Button buttonOk;
        private BindingSource bindingSource1;
        private TextBox textBoxDNNid;
    }
}