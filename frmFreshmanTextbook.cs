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
    public partial class frmFreshmanTextbook : Form
    {
        public frmFreshmanTextbook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMain = new frmFreshmanCryptoMain();
            frmMain.Show();
            this.Hide();
        }

        private void frmTextbook_Load(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = true;
            lblArrowRight2.Visible = false;
            lblArrowRight3.Visible = false;

            lblTitle.Text = "Intro To Cryptology";
            lblNotes.Text = "What is Cryptology:\n" +
            "-  Cryptography: The use of mathematics to encrypt and decrypt data\n" +
            "-  Cryptography enables the user to send important information across insecure networks so that only the person meant to get the information can understand it\n" +
            "-  Plaintext/cleartext: Text that can be understood without having to decrypt it\n" +
            "-  Encryption: A method used to disguise plaintext and hide whatever information it contains\n" +
            "-  Decryption: The method of reverting ciphertext back into plaintext\n" +
            "-  Ciphertext: Encrypted plaintext\n" +
            "Cryptography vs Cryptanalysis:\n" +
            "-  Cryptography is the science of securing data\n" +
            "-  Cryptanalysis: The science of analysing encryptions so that they can be broken without knowing the key\n" +
            "-  Cryptology: both cryptography and cryptanalysis fall under this category\n" +
            "Strong vs Weak Cryptography:\n" +
            "-  The strength of a method of cryptography is determined by the amount of time and resources it would take to revert the plaintext\n" +
            "-  Strong cryptography refers to ciphertext that isn’t easy to recover without having the proper key\n" +
            "   -  “Given all of today's computing power and available time — even a billion computers doing a billion checks a second — it is not possible to decipher the result of strong cryptography before the end of the universe” - gpgtools\n" +
            "-  However, with the continuing advancements of technology, even the strongest cryptography today may be able to be broken with tomorrow’s computers\n" +
            "How Cryptography Works:\n" +
            "-  Cipher: also known as a cryptographic algorithm, is a mathematical function used in the process of encrypting and decrypting data\n" +
            "-  Ciphers work with keys to encrypt the plaintext\n" +
            "   -  Key: a word, number, or phrase used to encrypt and decrypt plaintext that only the sender and receiver of a message should know\n" +
            "-  Using different keys with the same cipher allows a person to encrypt the same plaintext to different ciphertext\n" +
            "-  How secure the ciphertext is, is determined by the strength of the cryptographic algorithm and the secrecy of the key\n" +
            "-  Cryptosystem- a system comprised of a cipher plus all possible keys and other protocols that make it work\n";
        }

        private void lblArrowRight1_Click(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = true;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = false;
            lblArrowRight2.Visible = true;
            lblArrowRight3.Visible = false;

            lblTitle.Text = "Brute Force Attacks";
            lblNotes.Text = "-  Brute-force attack: An attack consisting of the hacker guessing the password multiple times with the hopes of guessing correctly.\n" +
            "-  This method is very fast when used to check all short passwords, but for longer passwords other methods such as the dictionary attack are used because a brute-force search takes too long.\n" +
            "-  Exhaustive key search: When the attacker attempts to guess the key (which is often derived from the password using a key derivation function, or KDF) rather than the password itself.\n";
        }

        private void lblArrowLeft1_Click(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = true;
            lblArrowRight2.Visible = false;
            lblArrowRight3.Visible = false;

            lblTitle.Text = "Intro To Cryptology";
            lblNotes.Text = "What is Cryptology:\n" +
            "-  Cryptography: The use of mathematics to encrypt and decrypt data\n" +
            "-  Cryptography enables the user to send important information across insecure networks so that only the person meant to get the information can understand it\n" +
            "-  Plaintext/cleartext: Text that can be understood without having to decrypt it\n" +
            "-  Encryption: A method used to disguise plaintext and hide whatever information it contains\n" +
            "-  Decryption: The method of reverting ciphertext back into plaintext\n" +
            "-  Ciphertext: Encrypted plaintext\n" +
            "Cryptography vs Cryptanalysis:\n" +
            "-  Cryptography is the science of securing data\n" +
            "-  Cryptanalysis: The science of analysing encryptions so that they can be broken without knowing the key\n" +
            "-  Cryptology: both cryptography and cryptanalysis fall under this category\n" +
            "Strong vs Weak Cryptography:\n" +
            "-  The strength of a method of cryptography is determined by the amount of time and resources it would take to revert the plaintext\n" +
            "-  Strong cryptography refers to ciphertext that isn’t easy to recover without having the proper key\n" +
            "   -  “Given all of today's computing power and available time — even a billion computers doing a billion checks a second — it is not possible to decipher the result of strong cryptography before the end of the universe” - gpgtools\n" +
            "-  However, with the continuing advancements of technology, even the strongest cryptography today may be able to be broken with tomorrow’s computers\n" +
            "How Cryptography Works:\n" +
            "-  Cipher: also known as a cryptographic algorithm, is a mathematical function used in the process of encrypting and decrypting data\n" +
            "-  Ciphers work with keys to encrypt the plaintext\n" +
            "   -  Key: a word, number, or phrase used to encrypt and decrypt plaintext that only the sender and receiver of a message should know\n" +
            "-  Using different keys with the same cipher allows a person to encrypt the same plaintext to different ciphertext\n" +
            "-  How secure the ciphertext is, is determined by the strength of the cryptographic algorithm and the secrecy of the key\n" +
            "-  Cryptosystem- a system comprised of a cipher plus all possible keys and other protocols that make it work\n";
        }

        private void lblArrowRight2_Click_1(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = true;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = false;
            lblArrowRight2.Visible = false;
            lblArrowRight3.Visible = true;

            lblTitle.Text = "History of Cryptology";
            lblNotes.Text = "-  During ancient times, writing was safe because very few people knew how to read.\n" +
            "-  However, the use of cryptography increased for military purposes- keeping enemies and potential spies from knowing one’s battle plans.\n" +
            "-  700 BC Scytale: Spartan military used “scytales to send sensitive information during times of battle-- a piece of leather was wrapped around a wooden rod and a message was written, the unwound letters would have no meaning, but when wrapped around another rod of the same length the message would be revealed.\n" +
            "Caesar Cipher:\n" +
            "-  “If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out. If anyone wishes to decipher these, and get at their meaning, he must substitute the fourth letter of the alphabet, namely D, for A, and so with the others.” — Suetonius, Life of Julius Caesar 56\n" +
            "-  Caesar Cipher: A type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions further down the alphabet.\n" +
            "-  Caesar created this cipher to prevent his messengers from knowing the secret plans he sent to his generals during war.\n" +
            "-  After Caesar, there wasn’t much important use of cryptographic systems until the Renaissance era where polyalphabetic substitutions were introduced.\n" +
            "-  Alan Turing and the Enigma Machine:\n" +
            "-  During WW2 The Enigma machine was a German encryption machine that the German military used to encrypt radio communications.\n" +
            "-  Alan Turing, an American mathematician designed the Bombe machine, named after the Polish Bomba machine, that decrypted the Enigma code.\n" +
            "-  In 1942, just two years after the machine was developed, the Allied powers were using Bombes to decode 84,000 messages a month, equivalent to 2 messages every minute, day and night.\n" +
            "-  Some historians argue that without Turing’s technology, the war may have lasted another 2 years, and cost 2 million more lifes.\n" +
            "DES and AES:\n" +
            "-  In 1977, National Bureau of Standards decided to publish a cryptosystem which could be used by governmental agencies or banks (DES)\n" +
            "-  DES: Symmetric shared secret key cipher used to ensure government systems all used the same, secure standard to facilitate interconnectivity. 56 Bit system.\n" +
            "-  AES: More advanced encryption key than DES, but the significance is that AES has key sizes of 128, 192, and 256 bits. AES is the current encryption standard and has withstood all attacks.\n";
        }

        private void lblArrowRight3_Click_1(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = true;
            lblArrowRight1.Visible = false;
            lblArrowRight2.Visible = false;
            lblArrowRight3.Visible = false;

            lblTitle.Text = "Vocabulary";
            lblNotes.Text = "-  AES: More advanced encryption key than DES, but the significance is that it is at least 128 bit. AES is the current encryption standard and has withstood all attacks.\n" +
            "-  Alan Turing: An American mathematician who designed the Bombe machine that decrypted the Enigma code.\n" +
            "-  Brute-force attack: An attack consisting of the hacker guessing the password multiple times with the hopes of guessing correctly.\n" +
            "-  Cipher: Also known as a cryptographic algorithm, is a mathematical function used in the process of encrypting and decrypting data\n" +
            "-  Ciphertext: Encrypted plaintext\n" +
            "-  Cryptanalysis: The science of analysing encryptions so that they can be broken without knowing the key\n" +
            "-  Cryptography: The use of mathematics to encrypt and decrypt data\n" +
            "-  Cryptology: Both cryptography and cryptanalysis fall under this category\n" +
            "-  Cryptosystem: A system comprised of a cipher plus all possible keys and other protocols that make it work\n" +
            "-  Decryption: The method of reverting ciphertext back into plaintext\n" +
            "-  DES: Symmetric shared secret key cipher used to ensure government systems all used the same, secure standard to facilitate interconnectivity. 56 Bit system.\n" +
            "-  Encryption: A method used to disguise plaintext and hide whatever information it contains\n" +
            "-  The Enigma Machine: A German encryption machine that the German military used to encrypt radio communications.\n" +
            "-  Exhaustive key search: When the attacker attempts to guess the key (which is often derived from the password using a key derivation function, or KDF) rather than the password itself.\n" +
            "-  Key: A word, number, or phrase used to encrypt and decrypt plaintext that only the sender and receiver of a message should know\n" +
            "-  Plaintext: Text that can be understood without having to decrypt it\n";
        }

        private void lblArrowLeft2_Click_1(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = true;
            lblArrowLeft2.Visible = false;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = false;
            lblArrowRight2.Visible = true;
            lblArrowRight3.Visible = false;

            lblTitle.Text = "Brute Force Attacks";
            lblNotes.Text = "-  Brute-force attack: An attack consisting of the hacker guessing the password multiple times with the hopes of guessing correctly.\n" +
            "-  This method is very fast when used to check all short passwords, but for longer passwords other methods such as the dictionary attack are used because a brute-force search takes too long.\n" +
            "-  Exhaustive key search: When the attacker attempts to guess the key (which is often derived from the password using a key derivation function, or KDF) rather than the password itself.\n";
        }

        private void lblArrowLeft3_Click_1(object sender, EventArgs e)
        {
            lblArrowLeft1.Visible = false;
            lblArrowLeft2.Visible = true;
            lblArrowLeft3.Visible = false;
            lblArrowRight1.Visible = false;
            lblArrowRight2.Visible = false;
            lblArrowRight3.Visible = true;

            lblTitle.Text = "History of Cryptology";
            lblNotes.Text = "-  During ancient times, writing was safe because very few people knew how to read.\n" +
            "-  However, the use of cryptography increased for military purposes- keeping enemies and potential spies from knowing one’s battle plans.\n" +
            "-  700 BC Scytale: Spartan military used “scytales to send sensitive information during times of battle-- a piece of leather was wrapped around a wooden rod and a message was written, the unwound letters would have no meaning, but when wrapped around another rod of the same length the message would be revealed.\n" +
            "Caesar Cipher:\n" +
            "-  “If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out. If anyone wishes to decipher these, and get at their meaning, he must substitute the fourth letter of the alphabet, namely D, for A, and so with the others.” — Suetonius, Life of Julius Caesar 56\n" +
            "-  Caesar Cipher: A type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions further down the alphabet.\n" +
            "-  Caesar created this cipher to prevent his messengers from knowing the secret plans he sent to his generals during war.\n" +
            "-  After Caesar, there wasn’t much important use of cryptographic systems until the Renaissance era where polyalphabetic substitutions were introduced.\n" +
            "-  Alan Turing and the Enigma Machine:\n" +
            "-  During WW2 The Enigma machine was a German encryption machine that the German military used to encrypt radio communications.\n" +
            "-  Alan Turing, an American mathematician designed the Bombe machine, named after the Polish Bomba machine, that decrypted the Enigma code.\n" +
            "-  In 1942, just two years after the machine was developed, the Allied powers were using Bombes to decode 84,000 messages a month, equivalent to 2 messages every minute, day and night.\n" +
            "-  Some historians argue that without Turing’s technology, the war may have lasted another 2 years, and cost 2 million more lifes.\n" +
            "DES and AES:\n" +
            "-  In 1977, National Bureau of Standards decided to publish a cryptosystem which could be used by governmental agencies or banks (DES)\n" +
            "-  DES: Symmetric shared secret key cipher used to ensure government systems all used the same, secure standard to facilitate interconnectivity. 56 Bit system.\n" +
            "-  AES: More advanced encryption key than DES, but the significance is that AES has key sizes of 128, 192, and 256 bits. AES is the current encryption standard and has withstood all attacks.\n";
        }
    }
}
