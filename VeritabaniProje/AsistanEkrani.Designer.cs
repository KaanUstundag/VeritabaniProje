namespace VeritabaniProje
{
    partial class AsistanEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistanEkrani));
            pictureBox1 = new PictureBox();
            button1 = new Class1();
            button2 = new Class1();
            class11 = new Class1();
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(441, 252);
            button1.Name = "button1";
            button1.Size = new Size(191, 43);
            button1.TabIndex = 4;
            button1.Text = "İtirazlarım";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(441, 363);
            button2.Name = "button2";
            button2.Size = new Size(191, 43);
            button2.TabIndex = 5;
            button2.Text = "Müşteri Çağrı Listesi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // class11
            // 
            class11.BackColor = Color.Red;
            class11.FlatAppearance.BorderSize = 0;
            class11.FlatStyle = FlatStyle.Flat;
            class11.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            class11.ForeColor = Color.White;
            class11.Location = new Point(441, 472);
            class11.Name = "class11";
            class11.Size = new Size(191, 43);
            class11.TabIndex = 6;
            class11.Text = "Primlerim-Pirm İtiraz";
            class11.UseVisualStyleBackColor = false;
            // 
            // AsistanEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 850);
            Controls.Add(class11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AsistanEkrani";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Class1 button1;
        private Class1 button2;
        private Class1 class11;
    }
}