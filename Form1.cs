using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace FileHashChecker
{
    public partial class Form1 : Form
    {
        //cryptographic service provider.
        private MD5 md5 = MD5.Create();
        private SHA1 Sha1 = SHA1.Create();
        private SHA256 Sha256 = SHA256.Create();
        private SHA384 Sha385 = SHA384.Create();
        private SHA512 Sha512 = SHA512.Create();


        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // create a list of hashtypes to put into the dropdown box.
            List<string> HashTypes = new List<string>();

            HashTypes.Add("MD5");
            HashTypes.Add("SHA1");
            HashTypes.Add("SHA256");
            HashTypes.Add("SHA385");
            HashTypes.Add("SHA512");

            foreach (string hash in HashTypes)
            {
                cboHashType.Items.Add(hash);
            }

            cboHashType.SelectedIndex = 0;
           
        }

        // Return a byte array as a sequence of hex values.
        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        // Compute the file's hash based on the hashtype selected.

        private byte[] GetHashMD5(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return md5.ComputeHash(stream);
            }
        }

        private byte[] GetHashSha1(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }
     

        private byte[] GetHashSha256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }

        private byte[] GetHashSha385(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha385.ComputeHash(stream);
            }
        }

        private byte[] GetHashSha512(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha512.ComputeHash(stream);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileToCheck.Text = openFileDialog1.FileName;
            }
        }

        private void btnHashIt_Click(object sender, EventArgs e)
        {
            txtFileHash.Text = "";

            string HashType = cboHashType.SelectedItem.ToString();

            // get the file hash based on the hash type selected.

            
            switch (HashType)
            {
                case "MD5":
                    txtFileHash.Text = BytesToString(GetHashMD5(txtFileToCheck.Text));
                    break;

                case "SHA1":
                    txtFileHash.Text = BytesToString(GetHashSha1(txtFileToCheck.Text));
                    break;

                case "SHA256":
                    txtFileHash.Text = BytesToString(GetHashSha256(txtFileToCheck.Text));
                    break;

                case "SHA385":
                    txtFileHash.Text = BytesToString(GetHashSha385(txtFileToCheck.Text));
                    break;

                case "SHA512":
                    txtFileHash.Text = BytesToString(GetHashSha512(txtFileToCheck.Text));
                    break;
            }

            // Check to see if the file hash matches after downloading.
            // Set the background to red if they don't match, and green if they do match.

            if (txtFileHash.Text  == txtExpectedHash.Text)
            {
                txtFileHash.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                txtFileHash.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
