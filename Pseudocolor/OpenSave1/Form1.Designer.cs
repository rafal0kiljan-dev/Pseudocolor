namespace OpenSave1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Compression = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.negative = new System.Windows.Forms.Button();
            this.negatBar = new System.Windows.Forms.TrackBar();
            this.vcolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonwyostrz = new System.Windows.Forms.Button();
            this.buttonrozm = new System.Windows.Forms.Button();
            this.buttonsobel = new System.Windows.Forms.Button();
            this.buttonuse = new System.Windows.Forms.Button();
            this.jasnosc = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.binarBar = new System.Windows.Forms.TrackBar();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negatBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 580);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hight";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vertical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horizontal";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "New Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Save as";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Compression
            // 
            this.Compression.Location = new System.Drawing.Point(27, 305);
            this.Compression.Name = "Compression";
            this.Compression.Size = new System.Drawing.Size(75, 23);
            this.Compression.TabIndex = 14;
            this.Compression.Text = "Compression";
            this.Compression.UseVisualStyleBackColor = true;
            this.Compression.Click += new System.EventHandler(this.Compression_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 334);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(75, 20);
            this.textBox6.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(461, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 529);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(886, 12);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(453, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "jasność";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "kontrast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "binaryzacja";
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(845, 200);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 23);
            this.negative.TabIndex = 31;
            this.negative.Text = "Negative";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // negatBar
            // 
            this.negatBar.Location = new System.Drawing.Point(926, 200);
            this.negatBar.Maximum = 256;
            this.negatBar.Name = "negatBar";
            this.negatBar.Size = new System.Drawing.Size(322, 45);
            this.negatBar.TabIndex = 34;
            this.negatBar.Value = 128;
            // 
            // vcolor
            // 
            this.vcolor.Location = new System.Drawing.Point(27, 367);
            this.vcolor.Name = "vcolor";
            this.vcolor.Size = new System.Drawing.Size(75, 23);
            this.vcolor.TabIndex = 36;
            this.vcolor.Text = "Plasma";
            this.vcolor.UseVisualStyleBackColor = true;
            this.vcolor.Click += new System.EventHandler(this.vcolor_Click);
            // 
            // buttonwyostrz
            // 
            this.buttonwyostrz.Location = new System.Drawing.Point(995, 331);
            this.buttonwyostrz.Name = "buttonwyostrz";
            this.buttonwyostrz.Size = new System.Drawing.Size(75, 23);
            this.buttonwyostrz.TabIndex = 42;
            this.buttonwyostrz.Text = "Wyostrz";
            this.buttonwyostrz.UseVisualStyleBackColor = true;
            this.buttonwyostrz.Click += new System.EventHandler(this.buttonwyostrz_Click);
            // 
            // buttonrozm
            // 
            this.buttonrozm.Location = new System.Drawing.Point(1091, 331);
            this.buttonrozm.Name = "buttonrozm";
            this.buttonrozm.Size = new System.Drawing.Size(75, 23);
            this.buttonrozm.TabIndex = 43;
            this.buttonrozm.Text = "Rozmycie";
            this.buttonrozm.UseVisualStyleBackColor = true;
            this.buttonrozm.Click += new System.EventHandler(this.buttonrozm_Click);
            // 
            // buttonsobel
            // 
            this.buttonsobel.Location = new System.Drawing.Point(1182, 331);
            this.buttonsobel.Name = "buttonsobel";
            this.buttonsobel.Size = new System.Drawing.Size(75, 23);
            this.buttonsobel.TabIndex = 44;
            this.buttonsobel.Text = "Sobel";
            this.buttonsobel.UseVisualStyleBackColor = true;
            this.buttonsobel.Click += new System.EventHandler(this.buttonsobel_Click);
            // 
            // buttonuse
            // 
            this.buttonuse.Location = new System.Drawing.Point(1091, 151);
            this.buttonuse.Name = "buttonuse";
            this.buttonuse.Size = new System.Drawing.Size(71, 23);
            this.buttonuse.TabIndex = 50;
            this.buttonuse.Text = "Use";
            this.buttonuse.UseVisualStyleBackColor = true;
            this.buttonuse.Click += new System.EventHandler(this.buttonuse_Click);
            // 
            // jasnosc
            // 
            this.jasnosc.Location = new System.Drawing.Point(897, 47);
            this.jasnosc.Maximum = 255;
            this.jasnosc.Minimum = -255;
            this.jasnosc.Name = "jasnosc";
            this.jasnosc.Size = new System.Drawing.Size(442, 45);
            this.jasnosc.TabIndex = 51;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(897, 77);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(442, 45);
            this.trackBar2.TabIndex = 52;
            // 
            // binarBar
            // 
            this.binarBar.Location = new System.Drawing.Point(897, 107);
            this.binarBar.Maximum = 255;
            this.binarBar.Name = "binarBar";
            this.binarBar.Size = new System.Drawing.Size(442, 45);
            this.binarBar.TabIndex = 53;
            this.binarBar.Value = 128;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1091, 362);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 20);
            this.textBox7.TabIndex = 54;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1156, 362);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(39, 20);
            this.textBox8.TabIndex = 55;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1218, 362);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(39, 20);
            this.textBox9.TabIndex = 56;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1091, 388);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 20);
            this.textBox10.TabIndex = 59;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1156, 388);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(39, 20);
            this.textBox11.TabIndex = 58;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1218, 389);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(39, 20);
            this.textBox12.TabIndex = 57;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1091, 415);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(39, 20);
            this.textBox13.TabIndex = 62;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(1156, 414);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(39, 20);
            this.textBox14.TabIndex = 61;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1218, 415);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(39, 20);
            this.textBox15.TabIndex = 60;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(995, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 39);
            this.button6.TabIndex = 63;
            this.button6.Text = "Zastosuj maske";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 64;
            this.button5.Text = "Jet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 643);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.binarBar);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.jasnosc);
            this.Controls.Add(this.buttonuse);
            this.Controls.Add(this.buttonsobel);
            this.Controls.Add(this.buttonrozm);
            this.Controls.Add(this.buttonwyostrz);
            this.Controls.Add(this.vcolor);
            this.Controls.Add(this.negatBar);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Compression);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negatBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binarBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Compression;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.TrackBar negatBar;
        private System.Windows.Forms.Button vcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonwyostrz;
        private System.Windows.Forms.Button buttonrozm;
        private System.Windows.Forms.Button buttonsobel;
        private System.Windows.Forms.Button buttonuse;
        private System.Windows.Forms.TrackBar jasnosc;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar binarBar;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

