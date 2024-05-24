namespace VeritabaniProje
{
    partial class KayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitEkrani));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Class1();
            label4 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(413, 233);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(389, 283);
            label2.Name = "label2";
            label2.Size = new Size(53, 22);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(448, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 28);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(448, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 28);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Asistan", "Grup Yöneticisi", "Takım Lideri" });
            comboBox1.Location = new Point(448, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(396, 329);
            label3.Name = "label3";
            label3.Size = new Size(46, 22);
            label3.TabIndex = 6;
            label3.Text = "İşiniz";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(509, 408);
            button2.Name = "button2";
            button2.Size = new Size(110, 47);
            button2.TabIndex = 7;
            button2.Text = "Kayıt ol";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(336, 376);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 8;
            label4.Text = "Yönetici ID'niz";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(448, 374);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 28);
            textBox3.TabIndex = 9;
            textBox3.Visible = false;
            // 
            // KayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 811);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "KayitEkrani";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Class1 button2;
        private Label label4;
        private TextBox textBox3;
    }
}