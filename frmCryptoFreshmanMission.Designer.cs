namespace FreshmanYear
{
    partial class frmCryptoFreshmanMission
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
            this.mnuMission = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMissionName = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.webMission = new System.Windows.Forms.WebBrowser();
            this.txtMissionNotes = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.radAnswerD = new System.Windows.Forms.RadioButton();
            this.radAnswerC = new System.Windows.Forms.RadioButton();
            this.radAnswerB = new System.Windows.Forms.RadioButton();
            this.radAnswerA = new System.Windows.Forms.RadioButton();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.btnReturn2 = new System.Windows.Forms.Button();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.btnReturn1 = new System.Windows.Forms.Button();
            this.mnuMission.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMission
            // 
            this.mnuMission.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuExit});
            this.mnuMission.Location = new System.Drawing.Point(0, 0);
            this.mnuMission.Name = "mnuMission";
            this.mnuMission.Size = new System.Drawing.Size(784, 24);
            this.mnuMission.TabIndex = 16;
            this.mnuMission.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.resetToMissionScreenToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblMissionName.Location = new System.Drawing.Point(305, 44);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMissionName.Size = new System.Drawing.Size(170, 31);
            this.lblMissionName.TabIndex = 11;
            this.lblMissionName.Text = "Mission Name";
            this.lblMissionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(136, 231);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(184, 92);
            this.btnVideo.TabIndex = 14;
            this.btnVideo.Text = "Video!";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(455, 231);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(184, 92);
            this.btnNotes.TabIndex = 15;
            this.btnNotes.Text = "Notes!";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // webMission
            // 
            this.webMission.Location = new System.Drawing.Point(26, 94);
            this.webMission.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMission.Name = "webMission";
            this.webMission.Size = new System.Drawing.Size(733, 333);
            this.webMission.TabIndex = 12;
            this.webMission.Visible = false;
            // 
            // txtMissionNotes
            // 
            this.txtMissionNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissionNotes.Location = new System.Drawing.Point(26, 114);
            this.txtMissionNotes.Multiline = true;
            this.txtMissionNotes.Name = "txtMissionNotes";
            this.txtMissionNotes.ReadOnly = true;
            this.txtMissionNotes.Size = new System.Drawing.Size(733, 289);
            this.txtMissionNotes.TabIndex = 13;
            this.txtMissionNotes.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(27, 443);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuestion.Size = new System.Drawing.Size(86, 23);
            this.lblQuestion.TabIndex = 23;
            this.lblQuestion.Text = "Question";
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.txtAnswer1);
            this.grpQuestion.Controls.Add(this.txtAnswer2);
            this.grpQuestion.Controls.Add(this.lblQuestion3);
            this.grpQuestion.Controls.Add(this.lblQuestion2);
            this.grpQuestion.Controls.Add(this.lblQuestion1);
            this.grpQuestion.Controls.Add(this.radAnswerD);
            this.grpQuestion.Controls.Add(this.radAnswerC);
            this.grpQuestion.Controls.Add(this.radAnswerB);
            this.grpQuestion.Controls.Add(this.radAnswerA);
            this.grpQuestion.Location = new System.Drawing.Point(37, 474);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(602, 68);
            this.grpQuestion.TabIndex = 24;
            this.grpQuestion.TabStop = false;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(444, 7);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(157, 26);
            this.txtAnswer1.TabIndex = 29;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(65, 41);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(157, 26);
            this.txtAnswer2.TabIndex = 30;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.Location = new System.Drawing.Point(237, 43);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(365, 24);
            this.lblQuestion3.TabIndex = 28;
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.Location = new System.Drawing.Point(-3, 41);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(49, 24);
            this.lblQuestion2.TabIndex = 27;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.Location = new System.Drawing.Point(-3, 9);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(435, 24);
            this.lblQuestion1.TabIndex = 26;
            // 
            // radAnswerD
            // 
            this.radAnswerD.AutoSize = true;
            this.radAnswerD.Location = new System.Drawing.Point(450, 29);
            this.radAnswerD.Name = "radAnswerD";
            this.radAnswerD.Size = new System.Drawing.Size(25, 17);
            this.radAnswerD.TabIndex = 3;
            this.radAnswerD.TabStop = true;
            this.radAnswerD.Text = "\r\n";
            this.radAnswerD.UseVisualStyleBackColor = true;
            // 
            // radAnswerC
            // 
            this.radAnswerC.AutoSize = true;
            this.radAnswerC.Location = new System.Drawing.Point(301, 29);
            this.radAnswerC.Name = "radAnswerC";
            this.radAnswerC.Size = new System.Drawing.Size(25, 17);
            this.radAnswerC.TabIndex = 2;
            this.radAnswerC.TabStop = true;
            this.radAnswerC.Text = "\r\n";
            this.radAnswerC.UseVisualStyleBackColor = true;
            // 
            // radAnswerB
            // 
            this.radAnswerB.AutoSize = true;
            this.radAnswerB.Location = new System.Drawing.Point(159, 29);
            this.radAnswerB.Name = "radAnswerB";
            this.radAnswerB.Size = new System.Drawing.Size(25, 17);
            this.radAnswerB.TabIndex = 1;
            this.radAnswerB.TabStop = true;
            this.radAnswerB.Text = "\r\n";
            this.radAnswerB.UseVisualStyleBackColor = true;
            // 
            // radAnswerA
            // 
            this.radAnswerA.AutoSize = true;
            this.radAnswerA.Location = new System.Drawing.Point(21, 29);
            this.radAnswerA.Name = "radAnswerA";
            this.radAnswerA.Size = new System.Drawing.Size(25, 17);
            this.radAnswerA.TabIndex = 0;
            this.radAnswerA.TabStop = true;
            this.radAnswerA.Text = "\r\n";
            this.radAnswerA.UseVisualStyleBackColor = true;
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Location = new System.Drawing.Point(666, 481);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(106, 58);
            this.btnSubmit1.TabIndex = 26;
            this.btnSubmit1.Text = "Submit";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReturn2
            // 
            this.btnReturn2.Location = new System.Drawing.Point(37, 41);
            this.btnReturn2.Name = "btnReturn2";
            this.btnReturn2.Size = new System.Drawing.Size(123, 45);
            this.btnReturn2.TabIndex = 27;
            this.btnReturn2.Text = "Return";
            this.btnReturn2.UseVisualStyleBackColor = true;
            this.btnReturn2.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Location = new System.Drawing.Point(666, 481);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(106, 58);
            this.btnSubmit2.TabIndex = 28;
            this.btnSubmit2.Text = "Submit";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // btnReturn1
            // 
            this.btnReturn1.Location = new System.Drawing.Point(37, 41);
            this.btnReturn1.Name = "btnReturn1";
            this.btnReturn1.Size = new System.Drawing.Size(123, 45);
            this.btnReturn1.TabIndex = 29;
            this.btnReturn1.Text = "Return";
            this.btnReturn1.UseVisualStyleBackColor = true;
            this.btnReturn1.Click += new System.EventHandler(this.btnReturn1_Click);
            // 
            // frmCryptoFreshmanMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnReturn1);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.btnReturn2);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.mnuMission);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.txtMissionNotes);
            this.Controls.Add(this.webMission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCryptoFreshmanMission";
            this.Load += new System.EventHandler(this.frmCryptoMission_Load);
            this.mnuMission.ResumeLayout(false);
            this.mnuMission.PerformLayout();
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMission;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.WebBrowser webMission;
        private System.Windows.Forms.TextBox txtMissionNotes;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.RadioButton radAnswerD;
        private System.Windows.Forms.RadioButton radAnswerC;
        private System.Windows.Forms.RadioButton radAnswerB;
        private System.Windows.Forms.RadioButton radAnswerA;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Button btnReturn2;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.Button btnReturn1;
    }
}