using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshmanYear
{
    public partial class frmFreshmanCryptoMain : Form
    {
        public frmFreshmanCryptoMain()
        {
            InitializeComponent();
        }

        private void frmFreshmanCryptoMain_Load(object sender, EventArgs e)
        {

        }

        private void btnIntroMission_Click(object sender, EventArgs e)
        {
            Form frmMission = new frmCryptoFreshmanMission();
            frmMission.Text = "Intro to Cryptography";
            frmMission.Show();
            this.Hide();
        }

        private void btnBruteMission_Click(object sender, EventArgs e)
        {
            Form frmMission = new frmCryptoFreshmanMission();
            frmMission.Text = "Brute Force Attacks";
            frmMission.Show();
            this.Hide();
        }

        private void btnHistoryMission_Click(object sender, EventArgs e)
        {
            Form frmMission = new frmCryptoFreshmanMission();
            frmMission.Text = "History of Cryptography";
            frmMission.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit the game?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to begin the final? If you proceed, you will not be able to return to the missions until the final is completed.", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form frmFinal = new frmCryptoFreshmanFinal();
                frmFinal.Show();
            }
        }

        private void btnTextbook_Click(object sender, EventArgs e)
        {
            Form frmTextbook = new frmFreshmanTextbook();
            frmTextbook.Show();
            this.Hide();
        }
    }
}
