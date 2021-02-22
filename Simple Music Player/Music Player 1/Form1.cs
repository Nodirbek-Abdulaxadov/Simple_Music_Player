using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Music_Player_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PlayMusic mp3play = new PlayMusic();
        private string[] a, fayllar;
        private int i = -1;


        private void ellips_button4_Click(object sender, EventArgs e)
        {
            mp3play.stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mp3play.close();
            string files = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose Folder";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                files = fbd.SelectedPath;
            }

            try
            {
                a = Directory.GetFileSystemEntries(fbd.SelectedPath);
                fayllar = new string[a.Length];
                for (i = 0; i < a.Length; i++)
                {
                    fayllar[i] = Path.GetFileName(a[i]);
                }
                i = 0;
                mp3play.open(a[i]);
                nomi.Text = Path.GetFileName(fayllar[i]);
                MessageBox.Show("Uzur so'raymiz!\nAyrim musiqalar pleyer tomonidan qo'llab quvvatlanmasligi mumkin!");
            }
            catch (ArgumentException) { }
        }

        private void ellips_button3_Click(object sender, EventArgs e)
        {
            if (i >0)
            {
                mp3play.stop();
                mp3play.close();
                i--;
                mp3play.open(a[i]);
                nomi.Text = Path.GetFileName(fayllar[i]);
                mp3play.play();
            }
        }

        private void ellips_button2_Click(object sender, EventArgs e)
        {
           if (i>-1)
           {
                mp3play.stop();
                mp3play.close();
                i++;
                mp3play.open(a[i]);
                nomi.Text = Path.GetFileName(fayllar[i]);
                mp3play.play();
           }
        }

        Point lastpoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/nbkabdulaxadov2000");
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/nodirbek_09052000/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fayl belgisini bosing va musiqalar joylashgan papkani tanlang.");
        }

        private void chiqiw_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ellips_button1_Click(object sender, EventArgs e)
        {
            mp3play.play();
        }
    }
}
