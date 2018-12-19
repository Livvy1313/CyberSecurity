namespace FreshmanYear
{
    partial class frmFreshmanCryptoMain
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
            this.btnTextbook = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnHistoryMission = new System.Windows.Forms.Button();
            this.btnBruteMission = new System.Windows.Forms.Button();
            this.btnIntroMission = new System.Windows.Forms.Button();
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTextbook
            // 
            this.btnTextbook.Location = new System.Drawing.Point(635, 42);
            this.btnTextbook.Name = "btnTextbook";
            this.btnTextbook.Size = new System.Drawing.Size(135, 31);
            this.btnTextbook.TabIndex = 20;
            this.btnTextbook.Text = "Textbook";
            this.btnTextbook.UseVisualStyleBackColor = true;
            this.btnTextbook.Click += new System.EventHandler(this.btnTextbook_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(320, 236);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(160, 139);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "Final";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnHistoryMission
            // 
            this.btnHistoryMission.Location = new System.Drawing.Point(530, 415);
            this.btnHistoryMission.Name = "btnHistoryMission";
            this.btnHistoryMission.Size = new System.Drawing.Size(118, 94);
            this.btnHistoryMission.TabIndex = 17;
            this.btnHistoryMission.Text = "History of Cryptography";
            this.btnHistoryMission.UseVisualStyleBackColor = true;
            this.btnHistoryMission.Click += new System.EventHandler(this.btnHistoryMission_Click);
            // 
            // btnBruteMission
            // 
            this.btnBruteMission.Location = new System.Drawing.Point(161, 415);
            this.btnBruteMission.Name = "btnBruteMission";
            this.btnBruteMission.Size = new System.Drawing.Size(118, 94);
            this.btnBruteMission.TabIndex = 16;
            this.btnBruteMission.Text = "Brute Force Attacks";
            this.btnBruteMission.UseVisualStyleBackColor = true;
            this.btnBruteMission.Click += new System.EventHandler(this.btnBruteMission_Click);
            // 
            // btnIntroMission
            // 
            this.btnIntroMission.Location = new System.Drawing.Point(340, 83);
            this.btnIntroMission.Name = "btnIntroMission";
            this.btnIntroMission.Size = new System.Drawing.Size(118, 94);
            this.btnIntroMission.TabIndex = 15;
            this.btnIntroMission.Text = "Intro to Cryptography";
            this.btnIntroMission.UseVisualStyleBackColor = true;
            this.btnIntroMission.Click += new System.EventHandler(this.btnIntroMission_Click);
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuExit});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Size = new System.Drawing.Size(784, 24);
            this.mnuMenuBar.TabIndex = 14;
            this.mnuMenuBar.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmFreshmanCryptoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnTextbook);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnHistoryMission);
            this.Controls.Add(this.btnBruteMission);
            this.Controls.Add(this.btnIntroMission);
            this.Controls.Add(this.mnuMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFreshmanCryptoMain";
            this.Text = "CyberGAW U- Freshman Cryptography";
            this.Load += new System.EventHandler(this.frmFreshmanCryptoMain_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTextbook;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnHistoryMission;
        private System.Windows.Forms.Button btnBruteMission;
        private System.Windows.Forms.Button btnIntroMission;
        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}