namespace Music_Player_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nomi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.chiqiw = new System.Windows.Forms.Button();
            this.ellips_button3 = new Music_Player_1.ellips_button();
            this.ellips_button4 = new Music_Player_1.ellips_button();
            this.ellips_button2 = new Music_Player_1.ellips_button();
            this.ellips_button1 = new Music_Player_1.ellips_button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // nomi
            // 
            this.nomi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomi.ForeColor = System.Drawing.Color.White;
            this.nomi.Location = new System.Drawing.Point(214, 305);
            this.nomi.Name = "nomi";
            this.nomi.Size = new System.Drawing.Size(277, 30);
            this.nomi.TabIndex = 0;
            this.nomi.Text = "Wellcome to MyMusic Player!";
            this.nomi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.ellips_button3);
            this.panel2.Controls.Add(this.ellips_button4);
            this.panel2.Controls.Add(this.ellips_button2);
            this.panel2.Controls.Add(this.ellips_button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 73);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(53, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.chiqiw);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nomi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 467);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // chiqiw
            // 
            this.chiqiw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.chiqiw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chiqiw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chiqiw.FlatAppearance.BorderSize = 0;
            this.chiqiw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chiqiw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chiqiw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chiqiw.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiqiw.ForeColor = System.Drawing.Color.White;
            this.chiqiw.Location = new System.Drawing.Point(620, 0);
            this.chiqiw.Name = "chiqiw";
            this.chiqiw.Size = new System.Drawing.Size(60, 35);
            this.chiqiw.TabIndex = 1;
            this.chiqiw.Text = "Exit";
            this.chiqiw.UseVisualStyleBackColor = false;
            this.chiqiw.Click += new System.EventHandler(this.chiqiw_Click);
            // 
            // ellips_button3
            // 
            this.ellips_button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.ellips_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellips_button3.FlatAppearance.BorderSize = 0;
            this.ellips_button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ellips_button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ellips_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellips_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ellips_button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ellips_button3.Location = new System.Drawing.Point(388, 4);
            this.ellips_button3.Name = "ellips_button3";
            this.ellips_button3.Size = new System.Drawing.Size(44, 44);
            this.ellips_button3.TabIndex = 6;
            this.ellips_button3.Text = "Prev";
            this.ellips_button3.UseVisualStyleBackColor = false;
            this.ellips_button3.Click += new System.EventHandler(this.ellips_button3_Click);
            // 
            // ellips_button4
            // 
            this.ellips_button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.ellips_button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellips_button4.FlatAppearance.BorderSize = 0;
            this.ellips_button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ellips_button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ellips_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellips_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ellips_button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ellips_button4.Location = new System.Drawing.Point(318, 4);
            this.ellips_button4.Name = "ellips_button4";
            this.ellips_button4.Size = new System.Drawing.Size(44, 44);
            this.ellips_button4.TabIndex = 5;
            this.ellips_button4.Text = "Stop";
            this.ellips_button4.UseVisualStyleBackColor = false;
            this.ellips_button4.Click += new System.EventHandler(this.ellips_button4_Click);
            // 
            // ellips_button2
            // 
            this.ellips_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.ellips_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellips_button2.FlatAppearance.BorderSize = 0;
            this.ellips_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ellips_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ellips_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellips_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ellips_button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ellips_button2.Location = new System.Drawing.Point(458, 4);
            this.ellips_button2.Name = "ellips_button2";
            this.ellips_button2.Size = new System.Drawing.Size(44, 44);
            this.ellips_button2.TabIndex = 3;
            this.ellips_button2.Text = "Next";
            this.ellips_button2.UseVisualStyleBackColor = false;
            this.ellips_button2.Click += new System.EventHandler(this.ellips_button2_Click);
            // 
            // ellips_button1
            // 
            this.ellips_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.ellips_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellips_button1.FlatAppearance.BorderSize = 0;
            this.ellips_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ellips_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ellips_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellips_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ellips_button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ellips_button1.Location = new System.Drawing.Point(248, 4);
            this.ellips_button1.Name = "ellips_button1";
            this.ellips_button1.Size = new System.Drawing.Size(44, 44);
            this.ellips_button1.TabIndex = 2;
            this.ellips_button1.Text = "Play";
            this.ellips_button1.UseVisualStyleBackColor = false;
            this.ellips_button1.Click += new System.EventHandler(this.ellips_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 467);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nomi;
        private System.Windows.Forms.Panel panel2;
        private ellips_button ellips_button3;
        private ellips_button ellips_button4;
        private ellips_button ellips_button2;
        private ellips_button ellips_button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button chiqiw;
    }
}

