namespace FreshmanYear
{
    partial class frmCryptoFreshmanIntro
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
            this.webFreshmanVideo = new System.Windows.Forms.WebBrowser();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webFreshmanVideo
            // 
            this.webFreshmanVideo.Location = new System.Drawing.Point(0, 53);
            this.webFreshmanVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFreshmanVideo.Name = "webFreshmanVideo";
            this.webFreshmanVideo.Size = new System.Drawing.Size(784, 382);
            this.webFreshmanVideo.TabIndex = 1;
            this.webFreshmanVideo.Url = new System.Uri("https://www.youtube.com/watch?v=Kf9KjCKmDcU", System.UriKind.Absolute);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(578, 493);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(194, 56);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinueFreshmanIntroVid_Click);
            // 
            // frmCryptoFreshmanIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.webFreshmanVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCryptoFreshmanIntro";
            this.Text = "CyberGAW U- Freshman Cryptography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webFreshmanVideo;
        private System.Windows.Forms.Button btnContinue;
    }
}

