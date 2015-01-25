namespace RbxGifGen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gifDisplay = new System.Windows.Forms.PictureBox();
            this.imageTitle = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.gifTimer = new System.Windows.Forms.Timer(this.components);
            this.frameRateInput = new System.Windows.Forms.TextBox();
            this.frameRateTitle = new System.Windows.Forms.Label();
            this.framesLabel = new System.Windows.Forms.Label();
            this.inputDPF = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gifDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gifDisplay
            // 
            this.gifDisplay.BackColor = System.Drawing.Color.Transparent;
            this.gifDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gifDisplay.Location = new System.Drawing.Point(16, 56);
            this.gifDisplay.Name = "gifDisplay";
            this.gifDisplay.Size = new System.Drawing.Size(100, 100);
            this.gifDisplay.TabIndex = 0;
            this.gifDisplay.TabStop = false;
            // 
            // imageTitle
            // 
            this.imageTitle.AutoSize = true;
            this.imageTitle.Location = new System.Drawing.Point(13, 13);
            this.imageTitle.Name = "imageTitle";
            this.imageTitle.Size = new System.Drawing.Size(46, 13);
            this.imageTitle.TabIndex = 1;
            this.imageTitle.Text = "GIF File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = ".gif file |*.gif";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // filePath
            // 
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(16, 30);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(173, 20);
            this.filePath.TabIndex = 2;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(195, 29);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(24, 20);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(127, 132);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(92, 24);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // gifTimer
            // 
            this.gifTimer.Interval = 30;
            this.gifTimer.Tick += new System.EventHandler(this.gifTimer_Tick);
            // 
            // frameRateInput
            // 
            this.frameRateInput.Enabled = false;
            this.frameRateInput.Location = new System.Drawing.Point(127, 95);
            this.frameRateInput.Name = "frameRateInput";
            this.frameRateInput.Size = new System.Drawing.Size(67, 20);
            this.frameRateInput.TabIndex = 5;
            this.frameRateInput.Text = "0.03";
            // 
            // frameRateTitle
            // 
            this.frameRateTitle.AutoSize = true;
            this.frameRateTitle.Location = new System.Drawing.Point(124, 77);
            this.frameRateTitle.Name = "frameRateTitle";
            this.frameRateTitle.Size = new System.Drawing.Size(88, 13);
            this.frameRateTitle.TabIndex = 6;
            this.frameRateTitle.Text = "Delay Per Frame:";
            // 
            // framesLabel
            // 
            this.framesLabel.AutoSize = true;
            this.framesLabel.Location = new System.Drawing.Point(124, 116);
            this.framesLabel.Name = "framesLabel";
            this.framesLabel.Size = new System.Drawing.Size(53, 13);
            this.framesLabel.TabIndex = 7;
            this.framesLabel.Text = "Frames: ?";
            // 
            // inputDPF
            // 
            this.inputDPF.Location = new System.Drawing.Point(200, 95);
            this.inputDPF.Name = "inputDPF";
            this.inputDPF.Size = new System.Drawing.Size(19, 20);
            this.inputDPF.TabIndex = 8;
            this.inputDPF.Text = ">";
            this.inputDPF.UseVisualStyleBackColor = true;
            this.inputDPF.Click += new System.EventHandler(this.inputDPF_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG File |*.png";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(11, 159);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(196, 29);
            this.loadLabel.TabIndex = 9;
            this.loadLabel.Text = "LOADING GIF...";
            this.loadLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 197);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.inputDPF);
            this.Controls.Add(this.framesLabel);
            this.Controls.Add(this.frameRateTitle);
            this.Controls.Add(this.frameRateInput);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.imageTitle);
            this.Controls.Add(this.gifDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RbxGifGen";
            ((System.ComponentModel.ISupportInitialize)(this.gifDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gifDisplay;
        private System.Windows.Forms.Label imageTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Timer gifTimer;
        private System.Windows.Forms.TextBox frameRateInput;
        private System.Windows.Forms.Label frameRateTitle;
        private System.Windows.Forms.Label framesLabel;
        private System.Windows.Forms.Button inputDPF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label loadLabel;
    }
}

