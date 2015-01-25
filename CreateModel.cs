using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RbxGifGen
{
    public partial class CreateModel : Form
    {
        int width = 0;
        int height = 0;
        double dpf = 0;
        string exportFile = "";
        Form form = null;
        GifImage currentImage = null;
        Image gif_canvas = null;
        Image map_canvas = null;

        public CreateModel(string gifPath, string spritePath, double dpf_, Form parentForm = null)
        {
            InitializeComponent();
            currentImage = new GifImage(gifPath);
            gif_canvas = Image.FromFile(gifPath);
            map_canvas = Image.FromFile(spritePath);
            dpf = dpf_;
            form = parentForm;
        }

        private void CreateModel_Load(object sender, EventArgs e)
        {
            MessageBox.Show("We will now generate a roblox model file for you to use with this gif.\n\nThis will require you to upload the image as a decal to roblox\nand supply the program with the decal's url\n\nWe will take care of the rest!", "Upload Prompt");
            Process.Start("http://www.roblox.com/develop?View=13");
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            byte[] sampleFile = Properties.Resources.Sample;
            string sample = Encoding.UTF8.GetString(sampleFile);
            sample = sample.Replace("%DECAL_URL%", urlInput.Text);
            sample = sample.Replace("%GIF_WIDTH%", gif_canvas.Width.ToString());
            sample = sample.Replace("%GIF_HEIGHT%", gif_canvas.Height.ToString());
            sample = sample.Replace("%MAP_WIDTH%", map_canvas.Width.ToString());
            sample = sample.Replace("%MAP_HEIGHT%", map_canvas.Height.ToString());
            sample = sample.Replace("%GIF_FRAMES%", currentImage.frameCount.ToString());
            sample = sample.Replace("%GIF_DPF%", dpf.ToString());
            exportFile = sample;
            saveFileDialog.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (form != null)
            {
                form.Show();
            }  
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            FileStream file = File.Create(saveFileDialog.FileName);
            byte[] stream = Encoding.Default.GetBytes(exportFile);
            file.Write(stream, 0, stream.Length);
            this.Close();
            if (form != null)
            {
                form.Show();
            }
            file.Close();
        }
    }
}
