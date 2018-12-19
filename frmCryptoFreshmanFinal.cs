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
    public partial class frmCryptoFreshmanFinal : Form
    {
        public frmCryptoFreshmanFinal()
        {
            InitializeComponent();
        }

        private void lblRightArrow3_Click(object sender, EventArgs e)
        {
            lblRightArrow3.Visible = false;
            lblArrowLeft3.Visible = true;
            lblArrowLeft2.Visible = false;
            lblRightArrow4.Visible = true;
            grpMultipleChoice3.Visible = true;
            lblQuestion1.Visible = false;
            txtAnswer3.Visible = false;
            rad3A.Visible = true;
            rad3B.Visible = true;
            rad3C.Visible = true;
            rad3D.Visible = true;

            lblQuestionNumber.Text = "Question 4";
        }

        private void frmCryptoFreshmanFinal_Load(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = false;
            lblArrowLeft4.Visible = false;
            lblArrowLeft5.Visible = false;
            lblArrowLeft6.Visible = false;
            lblArrowLeft7.Visible = false;
            lblArrowLeft8.Visible = false;
            lblArrowLeft9.Visible = false;
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            lblQuestion4.Visible = false;
            lblQuestionNumber.Visible = false;
            lblRightArrow1.Visible = false;
            lblRightArrow2.Visible = false;
            lblRightArrow3.Visible = false;
            lblRightArrow4.Visible = false;
            lblRightArrow5.Visible = false;
            lblRightArrow6.Visible = false;
            lblRightArrow7.Visible = false;
            lblRightArrow8.Visible = false;
            lblRightArrow9.Visible = false;
            lblSubmit.Visible = false;
            lblTitle.Visible = true;
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            txtAnswer3.Visible = false;
            txtAnswer4.Visible = false;
            txtAnswer5.Visible = false;
            grpMultipleChoice6.Visible = false;
            grpMultipleChoice1.Visible = false;
            grpMultipleChoice2.Visible = false;
            grpMultipleChoice3.Visible = false;
            grpMultipleChoice4.Visible = false;
            grpMultipleChoice5.Visible = false;
            btnStart.Visible = true;
            webFreshmanVideo.Visible = false;
            lnkEnigma.Visible = false;
            lblQuestion5.Visible = false;
            btnContinue.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            lblRightArrow1.Visible = true;
            btnStart.Visible = false;
            lblTitle.Visible = false;
            lblQuestionNumber.Visible = true;
            grpMultipleChoice1.Visible = true;
            rad1A.Visible = true;
            rad1B.Visible = true;
            rad1C.Visible = true;
            rad1D.Visible = true;

            lblQuestionNumber.Text = "Question 1";
        }

        private void lblRightArrow1_Click(object sender, EventArgs e)
        {
            lblRightArrow2.Visible = true;
            lblArrowLeft1.Visible = true;
            lblRightArrow1.Visible = false;
            grpMultipleChoice1.Visible = false;
            grpMultipleChoice2.Visible = true;
            rad1A.Visible = false;
            rad1B.Visible = false;
            rad1C.Visible = false;
            rad1D.Visible = false;
            rad2A.Visible = true;
            rad2B.Visible = true;
            rad2C.Visible = true;
            rad2D.Visible = true;

            lblQuestionNumber.Text = "Question 2";
        }

        private void lblRightArrow2_Click(object sender, EventArgs e)
        {
            lblRightArrow2.Visible = false;
            lblArrowLeft2.Visible = true;
            lblRightArrow3.Visible = true;
            lblArrowLeft1.Visible = false;
            grpMultipleChoice2.Visible = false;
            lblQuestion1.Visible = true;
            txtAnswer3.Visible = true;
            rad2A.Visible = false;
            rad2B.Visible = false;
            rad2C.Visible = false;
            rad2D.Visible = false;
            lblQuestionNumber.Text = "Question 3";
            lblQuestion1.Text = "The answer to this question is a two-digit number; other characters are invalid.  Solve by using brute-force attacks.  Hint - begin from 0, then advance up (00, 01, 02…)";
        }

        private void lblRightArrow4_Click(object sender, EventArgs e)
        {
            lblRightArrow4.Visible = false;
            lblArrowLeft4.Visible = true;
            lblArrowLeft3.Visible = false;
            lblRightArrow5.Visible = true;
            grpMultipleChoice4.Visible = true;
            grpMultipleChoice3.Visible = false;
            rad4A.Visible = true;
            rad4B.Visible = true;
            rad4C.Visible = true;
            rad4D.Visible = true;
            rad3A.Visible = false;
            rad3B.Visible = false;
            rad3C.Visible = false;
            rad3D.Visible = false;

            lblQuestionNumber.Text = "Question 5";
        }

        private void lblRightArrow5_Click(object sender, EventArgs e)
        {
            lblRightArrow5.Visible = false;
            lblArrowLeft5.Visible = true;
            lblRightArrow6.Visible = true;
            lblArrowLeft4.Visible = false;
            grpMultipleChoice4.Visible = false;
            lblQuestion1.Visible = true;
            lblQuestion2.Visible = true;
            lblQuestion3.Visible = true;
            lblQuestion4.Visible = true;
            txtAnswer1.Visible = true;
            txtAnswer2.Visible = true;
            rad4A.Visible = false;
            rad4B.Visible = false;
            rad4C.Visible = false;
            rad4D.Visible = false;
            lblQuestionNumber.Text = "Question 6";
            lblQuestion1.Text = "Ciphertext security is determined by the";
            lblQuestion2.Text = "of the cryptographic algorithm";
            lblQuestion3.Text = "and the";
            lblQuestion4.Text = "of the key.";
        }

        private void lblRightArrow6_Click(object sender, EventArgs e)
        {
            lblRightArrow6.Visible = false;
            lblArrowLeft6.Visible = true;
            lblRightArrow7.Visible = true;
            lblArrowLeft5.Visible = false;
            lblQuestion1.Visible = true;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            lblQuestion4.Visible = false;
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            txtAnswer4.Visible = true;
            lblQuestionNumber.Text = "Question 7";
            lblQuestion1.Text = "True or False: The Caesar Cipher is a random replacement cipher that replaces one letter with a random other letter in the alphabet.";
        }

        private void lblRightArrow7_Click(object sender, EventArgs e)
        {
            lblRightArrow7.Visible = false;
            lblArrowLeft7.Visible = true;
            lblRightArrow8.Visible = true;
            lblArrowLeft6.Visible = false;
            lblQuestion1.Visible = false;
            txtAnswer4.Visible = false;
            grpMultipleChoice5.Visible = true;
            rad5A.Visible = true;
            rad5B.Visible = true;
            rad5C.Visible = true;
            rad5D.Visible = true;

            lblQuestionNumber.Text = "Question 8";
        }

        private void lblRightArrow8_Click(object sender, EventArgs e)
        {
            lblRightArrow8.Visible = false;
            lblArrowLeft8.Visible = true;
            lblRightArrow9.Visible = true;
            lblArrowLeft7.Visible = false;
            grpMultipleChoice5.Visible = false;
            grpMultipleChoice6.Visible = true;
            rad5A.Visible = false;
            rad5B.Visible = false;
            rad5C.Visible = false;
            rad5D.Visible = false;
            rad6A.Visible = true;
            rad6B.Visible = true;
            rad6C.Visible = true;
            rad6D.Visible = true;

            lblQuestionNumber.Text = "Question 9";
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            lblArrowLeft9.Enabled = false;
            lblSubmit.Enabled = false;
            lblQuestion5.Enabled = false;
            lnkEnigma.Enabled = false;
            txtAnswer5.Enabled = false;
            lblSubmit.Enabled = false;
            lblQuestionNumber.Enabled = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit the final?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                double dblRightAnswer = 0;
                if (rad1C.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (rad2B.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (txtAnswer3.Text == "04")
                {
                    dblRightAnswer++;
                }
                if (rad3A.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (rad4D.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (txtAnswer1.Text == "strength" || txtAnswer1.Text == "Strength" || txtAnswer1.Text == "sTRENGTH")
                {
                    dblRightAnswer = dblRightAnswer + 0.5;
                }
                if (txtAnswer2.Text == "secrecy" || txtAnswer2.Text == "Secrecy" || txtAnswer2.Text == "sECRECY")
                {
                    dblRightAnswer = dblRightAnswer + 0.5;
                }
                if (txtAnswer4.Text == "false" || txtAnswer4.Text == "False" || txtAnswer4.Text == "fALSE")
                {
                    dblRightAnswer++;
                }
                if (rad5D.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (rad6A.Checked == true)
                {
                    dblRightAnswer++;
                }
                if (txtAnswer5.Text == "ILOV ECYB ERSE CURI TY" || txtAnswer5.Text == "I LOVE CYBER SECURITY" || txtAnswer5.Text == "I LOVE CYBERSECURITY" || txtAnswer5.Text == "ILOVECYBERSECURITY")
                {
                    dblRightAnswer++;
                }
                if (dblRightAnswer >= 7)
                {
                    DialogResult dialogResultPass = MessageBox.Show("Congratulations! You passed the final with a score of " + dblRightAnswer + " out of 10. You may continue on to Sophtmore Year!", "", MessageBoxButtons.OK);
                    if (dialogResultPass == DialogResult.OK)
                    {
                        lblArrowLeft9.Visible = false;
                        lblSubmit.Visible = false;
                        lblQuestion5.Visible = false;
                        lnkEnigma.Visible = false;
                        txtAnswer5.Visible = false;
                        lblSubmit.Visible = false;
                        lblQuestionNumber.Visible = false;
                        webFreshmanVideo.Visible = true;
                        btnContinue.Visible = true;
                        webFreshmanVideo.Navigate($"https://www.youtube.com/watch?v=zZuqLLdx2YQ");
                    }
                }
                else
                {
                    DialogResult dialogResultFail = MessageBox.Show("Oh no! You didn't pass the final. Your score was a " + dblRightAnswer + " out of 10. You will have to retake it.", "", MessageBoxButtons.OK);
                    if (dialogResultFail == DialogResult.OK)
                    {
                        Form frmMain = new frmFreshmanCryptoMain();
                        frmMain.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void lblArrowLeft1_Click(object sender, EventArgs e)
        {
            lblRightArrow1.Visible = true;
            lblArrowLeft1.Visible = false;
            lblRightArrow2.Visible = false;
            grpMultipleChoice1.Visible = true;
            grpMultipleChoice2.Visible = false;
            rad1A.Visible = true;
            rad1B.Visible = true;
            rad1C.Visible = true;
            rad1D.Visible = true;
            rad2A.Visible = false;
            rad2B.Visible = false;
            rad2C.Visible = false;
            rad2D.Visible = false;

            lblQuestionNumber.Text = "Question 1";
        }

        private void lblArrowLeft2_Click(object sender, EventArgs e)
        {
            lblRightArrow2.Visible = true;
            lblArrowLeft1.Visible = true;
            lblArrowLeft2.Visible = false;
            lblRightArrow3.Visible = false;
            lblQuestion1.Visible = false;
            txtAnswer3.Visible = false;
            grpMultipleChoice2.Visible = true;
            rad2A.Visible = true;
            rad2B.Visible = true;
            rad2C.Visible = true;
            rad2D.Visible = true;
            
            lblQuestionNumber.Text = "Question 2";
        }

        private void lblArrowLeft3_Click(object sender, EventArgs e)
        {
            lblRightArrow4.Visible = false;
            lblArrowLeft2.Visible = true;
            lblRightArrow3.Visible = true;
            lblArrowLeft3.Visible = false;
            grpMultipleChoice3.Visible = false;
            lblQuestion1.Visible = true;
            txtAnswer3.Visible = true;
            rad4A.Visible = false;
            rad4B.Visible = false;
            rad4C.Visible = false;
            rad4D.Visible = false;
            lblQuestionNumber.Text = "Question 3";
            lblQuestion1.Text = "The answer to this question is a two-digit number; other characters are invalid.  Solve by using brute-force attacks.  Hint - begin from 0, then advance up (00, 01, 02…)";
        }

        private void lblArrowLeft4_Click(object sender, EventArgs e)
        {
            lblRightArrow5.Visible = false;
            lblArrowLeft3.Visible = true;
            lblRightArrow4.Visible = true;
            lblArrowLeft4.Visible = false;
            grpMultipleChoice3.Visible = true;
            grpMultipleChoice4.Visible = false;
            rad3A.Visible = true;
            rad3B.Visible = true;
            rad3C.Visible = true;
            rad3D.Visible = true;
            rad4A.Visible = false;
            rad4B.Visible = false;
            rad4C.Visible = false;
            rad4D.Visible = false;
            lblQuestionNumber.Text = "Question 4";
        }

        private void lblArrowLeft5_Click(object sender, EventArgs e)
        {
            lblRightArrow6.Visible = false;
            lblArrowLeft4.Visible = true;
            lblRightArrow5.Visible = true;
            lblArrowLeft5.Visible = false;
            grpMultipleChoice4.Visible = true;
            rad4A.Visible = true;
            rad4B.Visible = true;
            rad4C.Visible = true;
            rad4D.Visible = true;
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            lblQuestion4.Visible = false;
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            lblQuestionNumber.Text = "Question 5";
        }

        private void lblArrowLeft6_Click(object sender, EventArgs e)
        {
            lblRightArrow7.Visible = false;
            lblArrowLeft5.Visible = true;
            lblRightArrow6.Visible = true;
            lblArrowLeft6.Visible = false;
            lblQuestion1.Visible = true;
            lblQuestion2.Visible = true;
            lblQuestion3.Visible = true;
            lblQuestion4.Visible = true;
            txtAnswer1.Visible = true;
            txtAnswer2.Visible = true;
            txtAnswer4.Visible = false;
            lblQuestionNumber.Text = "Question 6";
            lblQuestion1.Text = "Ciphertext security is determined by the";
            lblQuestion2.Text = "of the cryptographic algorithm";
            lblQuestion3.Text = "and the";
            lblQuestion4.Text = "of the key.";
        }

        private void lblArrowLeft7_Click(object sender, EventArgs e)
        {
            lblRightArrow8.Visible = false;
            lblArrowLeft6.Visible = true;
            lblRightArrow7.Visible = true;
            lblArrowLeft7.Visible = false;
            lblQuestion1.Visible = true;
            txtAnswer4.Visible = true;
            grpMultipleChoice5.Visible = false;
            rad5A.Visible = false;
            rad5B.Visible = false;
            rad5C.Visible = false;
            rad5D.Visible = false;
            lblQuestionNumber.Text = "Question 7";
            lblQuestion1.Text = "True or False: The Caesar Cipher is a random replacement cipher that replaces one letter with a random other letter in the alphabet.";
        }

        private void lblArrowLeft8_Click(object sender, EventArgs e)
        {
            lblRightArrow9.Visible = false;
            lblArrowLeft7.Visible = true;
            lblRightArrow8.Visible = true;
            lblArrowLeft8.Visible = false;
            grpMultipleChoice6.Visible = false;
            rad6A.Visible = false;
            rad6B.Visible = false;
            rad6C.Visible = false;
            rad6D.Visible = false;
            grpMultipleChoice5.Visible = true;
            rad5A.Visible = true;
            rad5B.Visible = true;
            rad5C.Visible = true;
            rad5D.Visible = true;
            lblQuestionNumber.Text = "Question 8";
        }

        private void lblArrowLeft9_Click(object sender, EventArgs e)
        {
            lblSubmit.Visible = false;
            lblArrowLeft8.Visible = true;
            lblRightArrow9.Visible = true;
            lblArrowLeft9.Visible = false;
            lblQuestion5.Visible = false;
            txtAnswer5.Visible = false;
            lnkEnigma.Visible = false;
            grpMultipleChoice6.Visible = true;
            rad6A.Visible = true;
            rad6B.Visible = true;
            rad6C.Visible = true;
            rad6D.Visible = true;
            lblQuestionNumber.Text = "Question 9";
        }

        private void lnkEnigma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://enigma.louisedade.co.uk/enigma.html");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void lblRightArrow9_Click(object sender, EventArgs e)
        {
            lblSubmit.Visible = true;
            lblArrowLeft9.Visible = true;
            lblRightArrow9.Visible = false;
            lblArrowLeft8.Visible = false;
            lblQuestion5.Visible = true;
            txtAnswer5.Visible = true;
            lnkEnigma.Visible = true;
            grpMultipleChoice6.Visible = false;
            rad6A.Visible = false;
            rad6B.Visible = false;
            rad6C.Visible = false;
            rad6D.Visible = false;
            lblQuestion5.Text = "Use the Enigma Machine to decode this message:\n" +
                "(answer should be in all caps)\n" +
                "Geheimnis: DHCQ MDPQ CCXA IIPY IR\n" +
                "Umkehrwalze: B\n" +
                "Grundstellung: OCC\n" +
                "Ringstellung: LIN\n" +
                "Steckerbrett: A=I, U=S\n";
            lblQuestionNumber.Text = "Question 10";
        }
    }
}
