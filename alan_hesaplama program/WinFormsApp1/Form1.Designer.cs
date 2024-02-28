namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            radioButton2 = new RadioButton();
            tabPageka = new TabPage();
            label10 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPageu = new TabPage();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            tabPaged = new TabPage();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            tabPagek = new TabPage();
            label9 = new Label();
            label8 = new Label();
            button7 = new Button();
            button8 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageka.SuspendLayout();
            tabPageu.SuspendLayout();
            tabPaged.SuspendLayout();
            tabPagek.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 49F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(94, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 154);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "■";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI Black", 49F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(94, 152);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 162);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "○";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Image = (Image)resources.GetObject("radioButton4.Image");
            radioButton4.Location = new Point(256, 190);
            radioButton4.Name = "radioButton4";
            radioButton4.RightToLeft = RightToLeft.No;
            radioButton4.Size = new Size(115, 86);
            radioButton4.TabIndex = 3;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPageka);
            tabControl.Controls.Add(tabPageu);
            tabControl.Controls.Add(tabPaged);
            tabControl.Controls.Add(tabPagek);
            tabControl.Location = new Point(-7, -25);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(491, 456);
            tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(radioButton4);
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(483, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 49F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(256, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 86);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "△";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // tabPageka
            // 
            tabPageka.BackColor = Color.DarkOrange;
            tabPageka.Controls.Add(label10);
            tabPageka.Controls.Add(label5);
            tabPageka.Controls.Add(button2);
            tabPageka.Controls.Add(button1);
            tabPageka.Controls.Add(label1);
            tabPageka.Controls.Add(textBox1);
            tabPageka.Location = new Point(4, 24);
            tabPageka.Name = "tabPageka";
            tabPageka.Padding = new Padding(3);
            tabPageka.Size = new Size(483, 428);
            tabPageka.TabIndex = 1;
            tabPageka.Text = "tabPage2";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(203, 192);
            label10.Name = "label10";
            label10.Size = new Size(77, 44);
            label10.TabIndex = 7;
            label10.Text = "   Değer       Giriniz";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 125);
            label5.Name = "label5";
            label5.Size = new Size(77, 44);
            label5.TabIndex = 6;
            label5.Text = "   Değer       Giriniz";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(360, 322);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 5;
            button2.Text = "← Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(158, 248);
            button1.Name = "button1";
            button1.Size = new Size(135, 69);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 3);
            label1.Name = "label1";
            label1.Size = new Size(375, 37);
            label1.TabIndex = 3;
            label1.Text = "Karenin Alanını Hesaplama";
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.Append;
            textBox1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(132, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 60);
            textBox1.TabIndex = 2;
            // 
            // tabPageu
            // 
            tabPageu.BackColor = Color.Chocolate;
            tabPageu.Controls.Add(label11);
            tabPageu.Controls.Add(label7);
            tabPageu.Controls.Add(label6);
            tabPageu.Controls.Add(textBox5);
            tabPageu.Controls.Add(button3);
            tabPageu.Controls.Add(button4);
            tabPageu.Controls.Add(label2);
            tabPageu.Controls.Add(textBox2);
            tabPageu.Location = new Point(4, 24);
            tabPageu.Name = "tabPageu";
            tabPageu.Padding = new Padding(3);
            tabPageu.Size = new Size(483, 428);
            tabPageu.TabIndex = 2;
            tabPageu.Text = "tabPage3";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 163);
            label7.Name = "label7";
            label7.Size = new Size(77, 60);
            label7.TabIndex = 12;
            label7.Text = "   Yükseklik    Giriniz";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 85);
            label6.Name = "label6";
            label6.Size = new Size(77, 44);
            label6.TabIndex = 11;
            label6.Text = "   Taban       Giriniz";
            // 
            // textBox5
            // 
            textBox5.AutoCompleteMode = AutoCompleteMode.Append;
            textBox5.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(129, 85);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 60);
            textBox5.TabIndex = 10;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(360, 322);
            button3.Name = "button3";
            button3.Size = new Size(102, 45);
            button3.TabIndex = 9;
            button3.Text = "← Geri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(158, 248);
            button4.Name = "button4";
            button4.Size = new Size(135, 69);
            button4.TabIndex = 8;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 3);
            label2.Name = "label2";
            label2.Size = new Size(379, 37);
            label2.TabIndex = 7;
            label2.Text = "Üçgenin Alanını Hesaplama";
            // 
            // textBox2
            // 
            textBox2.AutoCompleteMode = AutoCompleteMode.Append;
            textBox2.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(129, 171);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 60);
            textBox2.TabIndex = 6;
            // 
            // tabPaged
            // 
            tabPaged.BackColor = Color.DarkGoldenrod;
            tabPaged.Controls.Add(textBox6);
            tabPaged.Controls.Add(button5);
            tabPaged.Controls.Add(button6);
            tabPaged.Controls.Add(label3);
            tabPaged.Controls.Add(textBox3);
            tabPaged.Location = new Point(4, 24);
            tabPaged.Name = "tabPaged";
            tabPaged.Padding = new Padding(3);
            tabPaged.Size = new Size(483, 428);
            tabPaged.TabIndex = 3;
            tabPaged.Text = "tabPage4";
            // 
            // textBox6
            // 
            textBox6.AutoCompleteMode = AutoCompleteMode.Append;
            textBox6.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(129, 85);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(195, 60);
            textBox6.TabIndex = 11;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(360, 322);
            button5.Name = "button5";
            button5.Size = new Size(102, 45);
            button5.TabIndex = 9;
            button5.Text = "← Geri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(158, 248);
            button6.Name = "button6";
            button6.Size = new Size(135, 69);
            button6.TabIndex = 8;
            button6.Text = "Hesapla";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 3);
            label3.Name = "label3";
            label3.Size = new Size(421, 37);
            label3.TabIndex = 7;
            label3.Text = "Daire'nin Çevresini Hesaplama";
            // 
            // textBox3
            // 
            textBox3.AutoCompleteMode = AutoCompleteMode.Append;
            textBox3.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(129, 171);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 60);
            textBox3.TabIndex = 6;
            // 
            // tabPagek
            // 
            tabPagek.BackColor = Color.Orange;
            tabPagek.Controls.Add(label9);
            tabPagek.Controls.Add(label8);
            tabPagek.Controls.Add(button7);
            tabPagek.Controls.Add(button8);
            tabPagek.Controls.Add(label4);
            tabPagek.Controls.Add(textBox4);
            tabPagek.Location = new Point(4, 24);
            tabPagek.Name = "tabPagek";
            tabPagek.Padding = new Padding(3);
            tabPagek.Size = new Size(483, 428);
            tabPagek.TabIndex = 4;
            tabPagek.Text = "tabPage5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(208, 174);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 11;
            label9.Text = "Sonuc";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(47, 106);
            label8.Name = "label8";
            label8.Size = new Size(77, 44);
            label8.TabIndex = 10;
            label8.Text = "   Değer       Giriniz";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(360, 322);
            button7.Name = "button7";
            button7.Size = new Size(102, 45);
            button7.TabIndex = 9;
            button7.Text = "← Geri";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(158, 248);
            button8.Name = "button8";
            button8.Size = new Size(135, 69);
            button8.TabIndex = 8;
            button8.Text = "Hesapla";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 3);
            label4.Name = "label4";
            label4.Size = new Size(368, 37);
            label4.TabIndex = 7;
            label4.Text = "Küp'ün Alanını Hesaplama";
            // 
            // textBox4
            // 
            textBox4.AutoCompleteMode = AutoCompleteMode.Append;
            textBox4.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(130, 90);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 60);
            textBox4.TabIndex = 6;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(347, 130);
            label11.Name = "label11";
            label11.Size = new Size(77, 60);
            label11.TabIndex = 13;
            label11.Text = "   Yükseklik    Giriniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 379);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPageka.ResumeLayout(false);
            tabPageka.PerformLayout();
            tabPageu.ResumeLayout(false);
            tabPageu.PerformLayout();
            tabPaged.ResumeLayout(false);
            tabPaged.PerformLayout();
            tabPagek.ResumeLayout(false);
            tabPagek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPageka;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TabPage tabPageu;
        private TabPage tabPaged;
        private Button button2;
        private Button button1;
        private Label label1;
        private TabPage tabPagek;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private Button button5;
        private Button button6;
        private Label label3;
        private TextBox textBox3;
        private Button button7;
        private Button button8;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}