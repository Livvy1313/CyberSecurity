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
    public partial class frmCryptoFreshmanMission : Form
    {
        public frmCryptoFreshmanMission()
        {
            InitializeComponent();
        }

        private void frmCryptoMission_Load(object sender, EventArgs e)
        {
            webMission.Visible = false;
            txtMissionNotes.Visible = false;
            btnNotes.Visible = true;
            btnVideo.Visible = true;
            mnuMission.Enabled = true;
            btnNotes.Enabled = true;
            btnVideo.Enabled = true;
            txtMissionNotes.Enabled = false;
            radAnswerA.Visible = false;
            radAnswerB.Visible = false;
            radAnswerC.Visible = false;
            radAnswerD.Visible = false;
            lblQuestion.Visible = false;
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            btnSubmit1.Visible = false;
            btnSubmit2.Visible = false;
            btnReturn2.Visible = false;
            btnReturn1.Visible = true;
            lblMissionName.Text = this.Text;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            webMission.Visible = true;
            txtMissionNotes.Visible = false;
            lblQuestion.Visible = true;
            btnSubmit2.Visible = true;
            btnNotes.Visible = false;
            btnVideo.Visible = false;
            btnReturn2.Visible = true;
            btnReturn1.Visible = false;

            if (this.Text == "History of Cryptography")
            {
                lblMissionName.Text = this.Text;
                webMission.Navigate($" link ");
                lblQuestion.Text = "When were forms of cryptography used?";
                radAnswerA.Visible = true;
                radAnswerB.Visible = true;
                radAnswerC.Visible = true;
                radAnswerD.Visible = true;
                radAnswerA.Checked = true;
                radAnswerA.Text = "Revolutionary War era";
                radAnswerB.Text = "Cold War era";
                radAnswerC.Text = "WW2 era";
                radAnswerD.Text = "All of the above";
            }
            else if (this.Text == "Intro to Cryptography")
            {
                lblMissionName.Text = this.Text;
                webMission.Navigate($" link ");
                lblMissionName.Text = this.Text;
                lblQuestion.Visible = true;
                lblQuestion1.Visible = true;
                txtAnswer1.Visible = true;
                lblQuestion.Text = "**Make sure your answer is all lowercase";
                lblQuestion1.Text = "The rough translation of the word cryptography is:";
            }
            else if (this.Text == "Brute Force Attacks")
            {
                lblMissionName.Text = this.Text;
                webMission.Navigate($"https://www.youtube.com/watch?v=nkQAfQ5pwtk"); 
                lblQuestion.Text = "Which password would be hardest to guess through brute force attacks?";
                radAnswerA.Visible = true;
                radAnswerB.Visible = true;
                radAnswerC.Visible = true;
                radAnswerD.Visible = true;
                radAnswerA.Checked = true;
                radAnswerA.Text = "123456";
                radAnswerB.Text = "Password!";
                radAnswerC.Text = "CyB3rS3cUr3!";
                radAnswerD.Text = "adminpassword";
            }
            else
            {
                MessageBox.Show("That no work");
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            webMission.Visible = false;
            txtMissionNotes.Visible = true;
            lblQuestion.Visible = true;
            btnSubmit1.Visible = true;
            btnNotes.Visible = false;
            btnVideo.Visible = false;
            btnReturn2.Visible = true;
            btnReturn1.Visible = false;

            //Olivia
            if (this.Text == "History of Cryptography")
            {
                lblMissionName.Text = this.Text;
                txtMissionNotes.Text = "During ancient times, writing was safe because very few people knew how to read. However, the use of cryptography increased for military purposes- keeping enemies and potential spies from knowing one’s battle plans. In 700 BC, the Spartan military used scytale, a wooden rod wrapped in pieces of leather with letters written on it, to send encrypted information. When the letters were wrapped around another rod of the same length, the message would be revealed. Encryption has developed since, and in World War 2, the Germans implemented the Enigma machine to send encrypted radio transmissions. Alan Turing, an American mathematician, designed the Bombe machine, which decrypted the Enigma code at a speed of 2 messages per minute. Without Turing's invention, it is estimated that the war would have lasted at least 2 more years, with millions more lives lost. In 1977, National Bureau of Standards decided to publish a cryptosystem which could be used by governmental agencies or banks. DES is a symmetric shared secret key cipher used to ensure government systems all used the same, secure standard to facilitate interconnectivity. It is a 56-bit system. AES is a more advanced encryption key than DES, but the significance is that AES has key sizes of 128, 192, and 256 bits. AES is the current encryption standard and has withstood all attacks.";
                lblQuestion.Text = "All the answers below are the standard key sizes of AES except:";
                radAnswerA.Visible = true;
                radAnswerB.Visible = true;
                radAnswerC.Visible = true;
                radAnswerD.Visible = true;
                radAnswerA.Checked = true;
                radAnswerA.Text = "192 bit";
                radAnswerB.Text = "56 bit";
                radAnswerC.Text = "128 bit";
                radAnswerD.Text = "256 bit";
            }
            else if (this.Text == "Intro to Cryptography")
            {
                lblMissionName.Text = this.Text;
                lblQuestion.Visible = true;
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;
                lblQuestion3.Visible = true;
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;
                txtMissionNotes.Text = "Cryptography is the use of mathematics to encrypt and decrypt data. It enables the user to send important information across insecure networks so that only the person meant to get the information can understand it. Cryptography utilizes cryptographic algorithms, which are functions used to encrypt and decrypt data. Ciphers work with keys to encrypt the plaintext. Its security is determined by the strength of the cryptographic algorithm and the secrecy of the key. Strong cryptography refers to ciphertext that isn’t easy to recover without having the proper key. Using different keys for the same cipher will result in different ciphertexts. However, with the continuing advancements of technology, even the strongest cryptography today may be able to be broken with tomorrow’s computers.";
                lblQuestion.Text = "**Make sure your answers are all lowercase";
                lblQuestion1.Text = "The strength of a method of cryptography is determined by the amount of";
                lblQuestion2.Text = "and";
                lblQuestion3.Text = "it would take to revert the plaintext.";
            }
            else if (this.Text == "Brute Force Attacks")
            {
                lblMissionName.Text = this.Text;
                txtMissionNotes.Text = "A Brute-force attack is an attack consisting of the hacker guessing the password multiple times with the hopes of guessing correctly. this method is very fast when used to check all short passwords, but for longer passwords other methods such as the dictionary attack are used because a brute-force search takes too long. Another type of brute force attacks are exhaustive key searches, when the attacker attempts to guess the key (which is often derived from the password using a key derivation function, or KDF) rather than the password itself.";
                lblQuestion.Text = "When should brute-force attacks be used?";
                radAnswerA.Visible = true;
                radAnswerB.Visible = true;
                radAnswerC.Visible = true;
                radAnswerD.Visible = true;
                radAnswerA.Checked = true;
                radAnswerA.Text = "Should be used first at all times";
                radAnswerB.Text = "Should be used only on long and complex passwords";
                radAnswerC.Text = "Never because hacking is wrong";
                radAnswerD.Text = "First resort for short passwords, last resort for long passwords";
            }
            else
            {
                MessageBox.Show("That no work");
            }
        }

        private void resetToMissionScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMissionNotes.ReadOnly = true;
            webMission.Visible = false;
            txtMissionNotes.Visible = false;
            btnNotes.Visible = true;
            btnVideo.Visible = true;
            mnuMission.Enabled = true;
            btnReturn1.Visible = true;
            Form frmMain = new frmFreshmanCryptoMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            webMission.Visible = false;
            txtMissionNotes.Visible = false;
            btnNotes.Visible = true;
            btnVideo.Visible = true;
            mnuMission.Enabled = true;
            btnNotes.Enabled = true;
            btnVideo.Enabled = true;
            txtMissionNotes.Enabled = false;
            radAnswerA.Visible = false;
            radAnswerB.Visible = false;
            radAnswerC.Visible = false;
            radAnswerD.Visible = false;
            lblQuestion.Visible = false;
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            btnSubmit1.Visible = false;
            btnSubmit2.Visible = false;
            btnReturn2.Visible = false;
            btnReturn1.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.Text == "History of Cryptography")
            {
                if (radAnswerB.Checked == true)
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else if (this.Text == "Intro to Cryptography")
            {

                if (txtAnswer1.Text == "time" & txtAnswer2.Text == "resources")
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else if (this.Text == "Brute Force Attacks")
            {
                if (radAnswerD.Checked == true)
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("That no work");
            }
            txtAnswer1.Text = "";
            txtAnswer2.Text = "";
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            if (this.Text == "History of Cryptography")
            {
                if (radAnswerD.Checked == true)
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else if (this.Text == "Intro to Cryptography")
            {

                if (txtAnswer1.Text == "secret writing")
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else if (this.Text == "Brute Force Attacks")
            {
                if (radAnswerC.Checked == true)
                {
                    MessageBox.Show("Congratulations! That is the right answer.");
                }
                else
                {
                    MessageBox.Show("That isn't the right answer. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("That no work");
            }
            txtAnswer1.Text = "";
            txtAnswer2.Text = "";
        }

        private void btnReturn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmMain = new frmFreshmanCryptoMain();
            frmMain.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit the game?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
