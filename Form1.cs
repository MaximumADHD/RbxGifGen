using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RbxGifGen
{
    public partial class Form1 : Form
    {
        GifImage currentGif = null;
        Bitmap currentBitmap = null;
        double dpf = 0.03;

        public void showError(string msg)
        {
            MessageBox.Show(msg,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public async void Precache()
        {
            this.gifDisplay.Visible = false;
            this.loadLabel.Visible = true;
            await Task.Delay(500);
            for (int i = 0; i < currentGif.frameCount; i++)
            {
                currentGif.GetNextFrame();
            }
            this.loadLabel.Visible = false;
            this.gifDisplay.Visible = true;
        }

        public void LoadImage(string path)
        {
            filePath.Text = path;
            currentGif = new GifImage(path);
            int count = currentGif.frameCount;
            framesLabel.Text = "Frames: " + count;
            // Precache the image so it doesn't lag during the first loop.
            Precache();
            if (!exportButton.Enabled)
            {
                exportButton.Enabled = true;
                frameRateInput.Enabled = true;
                gifTimer.Start();
            }
        }

        public void SavePath(string path)
        {
            Properties.Settings.Default.SavedDir = path;
            Properties.Settings.Default.Save();
        }

        public Form1()
        {
            InitializeComponent();
            string savedPath = Properties.Settings.Default.SavedDir;
            if (savedPath != "null")
            {
                if (File.Exists(savedPath))
                {
                    LoadImage(savedPath);
                }
                else
                {
                    SavePath("null");
                }
            }
            Console.WriteLine("Path: " + savedPath);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            GifImage image = new GifImage(filePath.Text);
            Image canvas = Image.FromFile(filePath.Text);
            int count = image.frameCount;
            int root = (int)Math.Floor(Math.Sqrt((double)count));
            currentBitmap = new Bitmap(canvas.Width * root, (1+(int)Math.Floor((double)(image.frameCount) / root)) * canvas.Height);
            Graphics main = Graphics.FromImage(currentBitmap);
            while (image.currentFrame < image.frameCount-1)
            {
                Image currentImage = image.GetNextFrame();
                int x = (image.currentFrame % root) * currentImage.Width;
                int y = (int)Math.Floor((double)(image.currentFrame / root)) * currentImage.Height;
                Rectangle drawAt = new Rectangle(x, y, canvas.Width, canvas.Height);
                main.DrawImage(currentImage,drawAt);
            }
            saveFileDialog.ShowDialog();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SavePath(openFileDialog.FileName);
            LoadImage(openFileDialog.FileName);
        }

        private void gifTimer_Tick(object sender, EventArgs e)
        {
            if (currentGif != null)
            {
                gifDisplay.BackgroundImage = currentGif.GetNextFrame();
            }
        }

        private void inputDPF_Click(object sender, EventArgs e)
        {
            double test = 0;
            double.TryParse(frameRateInput.Text, out test);
            if (test == 0)
            {
                showError("Invalid input");
            }
            else if (test >= 0.015)
            {
                dpf = test;
                gifTimer.Interval = (int)(dpf * 1000);
                MessageBox.Show("Input accepted!");
            }
            else
            {
                showError("DPF should be at least 0.015");
            }
            frameRateInput.Text = dpf.ToString();
        }

        private async void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            currentBitmap.Save(saveFileDialog.FileName);
            this.Hide();
            Image canvas = Image.FromFile(filePath.Text);
            CreateModel modelDialog = new CreateModel(filePath.Text,saveFileDialog.FileName,dpf,this);
            await Task.Delay(10);
            modelDialog.Show();
        }
    }
}
