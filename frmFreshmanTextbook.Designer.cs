namespace FreshmanYear
{
    partial class frmFreshmanTextbook
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
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblArrowRight1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArrowRight2 = new System.Windows.Forms.Label();
            this.lblArrowRight3 = new System.Windows.Forms.Label();
            this.lblArrowLeft3 = new System.Windows.Forms.Label();
            this.lblArrowLeft2 = new System.Windows.Forms.Label();
            this.lblArrowLeft1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(148, 35);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(521, 517);
            this.lblNotes.TabIndex = 0;
            // 
            // lblArrowRight1
            // 
            this.lblArrowRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowRight1.Location = new System.Drawing.Point(681, 252);
            this.lblArrowRight1.Name = "lblArrowRight1";
            this.lblArrowRight1.Size = new System.Drawing.Size(72, 40);
            this.lblArrowRight1.TabIndex = 1;
            this.lblArrowRight1.Text = "----->";
            this.lblArrowRight1.Click += new System.EventHandler(this.lblArrowRight1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(186, -8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrowRight2
            // 
            this.lblArrowRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowRight2.Location = new System.Drawing.Point(681, 252);
            this.lblArrowRight2.Name = "lblArrowRight2";
            this.lblArrowRight2.Size = new System.Drawing.Size(72, 34);
            this.lblArrowRight2.TabIndex = 3;
            this.lblArrowRight2.Text = "----->";
            this.lblArrowRight2.Click += new System.EventHandler(this.lblArrowRight2_Click_1);
            // 
            // lblArrowRight3
            // 
            this.lblArrowRight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowRight3.Location = new System.Drawing.Point(681, 252);
            this.lblArrowRight3.Name = "lblArrowRight3";
            this.lblArrowRight3.Size = new System.Drawing.Size(72, 34);
            this.lblArrowRight3.TabIndex = 4;
            this.lblArrowRight3.Text = "----->";
            this.lblArrowRight3.Click += new System.EventHandler(this.lblArrowRight3_Click_1);
            // 
            // lblArrowLeft3
            // 
            this.lblArrowLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowLeft3.Location = new System.Drawing.Point(63, 257);
            this.lblArrowLeft3.Name = "lblArrowLeft3";
            this.lblArrowLeft3.Size = new System.Drawing.Size(72, 34);
            this.lblArrowLeft3.TabIndex = 5;
            this.lblArrowLeft3.Text = "<-----";
            this.lblArrowLeft3.Click += new System.EventHandler(this.lblArrowLeft3_Click_1);
            // 
            // lblArrowLeft2
            // 
            this.lblArrowLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowLeft2.Location = new System.Drawing.Point(63, 257);
            this.lblArrowLeft2.Name = "lblArrowLeft2";
            this.lblArrowLeft2.Size = new System.Drawing.Size(72, 34);
            this.lblArrowLeft2.TabIndex = 6;
            this.lblArrowLeft2.Text = "<-----";
            this.lblArrowLeft2.Click += new System.EventHandler(this.lblArrowLeft2_Click_1);
            // 
            // lblArrowLeft1
            // 
            this.lblArrowLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowLeft1.Location = new System.Drawing.Point(63, 257);
            this.lblArrowLeft1.Name = "lblArrowLeft1";
            this.lblArrowLeft1.Size = new System.Drawing.Size(72, 34);
            this.lblArrowLeft1.TabIndex = 7;
            this.lblArrowLeft1.Text = "<-----";
            this.lblArrowLeft1.Click += new System.EventHandler(this.lblArrowLeft1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 53);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFreshmanTextbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblArrowLeft1);
            this.Controls.Add(this.lblArrowLeft2);
            this.Controls.Add(this.lblArrowRight1);
            this.Controls.Add(this.lblArrowRight2);
            this.Controls.Add(this.lblArrowLeft3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblArrowRight3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFreshmanTextbook";
            this.Text = "CyberGAW U- Cybersecurity Textbook";
            this.Load += new System.EventHandler(this.frmTextbook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblArrowRight1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArrowRight2;
        private System.Windows.Forms.Label lblArrowRight3;
        private System.Windows.Forms.Label lblArrowLeft3;
        private System.Windows.Forms.Label lblArrowLeft2;
        private System.Windows.Forms.Label lblArrowLeft1;
        private System.Windows.Forms.Button btnBack;
    }
}