namespace AracKullanimlari2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Ankara", "Balıkesir", "Elazığ", "Malatya", "Ankara" });
            comboBox1.Location = new Point(34, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(34, 150);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 150);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 2;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 106);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 3;
            label1.Text = "Şehir: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "Muslera", "İcardi", "Emre", "Saha", "Fernandes" });
            listBox1.Location = new Point(35, 231);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 80);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(39, 332);
            button3.Name = "button3";
            button3.Size = new Size(116, 45);
            button3.TabIndex = 6;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(411, 301);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 7;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 265);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 8;
            label2.Text = "Meslek: ";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(362, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 27);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(639, 480);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Araç Kullanımları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}
