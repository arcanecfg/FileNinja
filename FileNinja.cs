/* FileNinja v1.0 BETA
 * 24/02/2017
 * Written by Arcanecfg
 * www.WastedWolf.com
 * www.YouTube.com/Arcanecfg
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace FileNinja
{
    public partial class FileNinja : Form
    {
        int fileCount = 0, curCount = 0;
        bool compressFiles = Properties.Settings.Default.CompressFiles;

        public FileNinja()
        {
            InitializeComponent();
        }

        #region "Drag and drop"
        private void FileNinja_Load(object sender, EventArgs e)
        {
            //chkSingleFile.Checked = compressFiles;
  
            AllowDrop = true;
            DragEnter += new DragEventHandler(mainForm_DragEnter);
            DragDrop += new DragEventHandler(mainForm_DragDrop);
        }

        void mainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void mainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!lbMain.Items.Contains(file))
                {
                    lbMain.Items.Add(file);
                }
            }
        }
        #endregion

        #region "Button clicks"
        private void btnCryptSelected_Click(object sender, EventArgs e)
        {
            curCount = 0;
            fileCount = lbMain.SelectedItems.Count;
            ThreadPool.QueueUserWorkItem(new WaitCallback(EncryptFile), lbMain.SelectedItem.ToString());
            progressBar.Visible = true;
            
        }

        private void btnCryptAll_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            curCount = 0;
            fileCount = lbMain.Items.Count;
            foreach (var fileName in lbMain.Items)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(EncryptFile), fileName.ToString());
            }
        }

        private void btnDecryptSelected_Click(object sender, EventArgs e)
        {
            curCount = 0;
            fileCount = lbMain.SelectedItems.Count;
            ThreadPool.QueueUserWorkItem(new WaitCallback(DecryptFile), lbMain.SelectedItem.ToString());
            progressBar.Visible = true;
        }

        private void btnDecryptAll_Click(object sender, EventArgs e)
        {
                progressBar.Visible = true;
                curCount = 0;
                fileCount = lbMain.Items.Count;
                foreach (var fileName in lbMain.Items)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(DecryptFile), fileName.ToString());
                }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            if (txtKey.UseSystemPasswordChar == false)
            {
                txtKey.UseSystemPasswordChar = true;
            }
            else
            {
                txtKey.UseSystemPasswordChar = false;
            }

        }

        //private void chkSingleFile_CheckedChanged(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.CompressFiles = chkSingleFile.Checked;
        //    Properties.Settings.Default.Save();
        //}

        private void selectedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            while (lbMain.SelectedItems.Count > 0)
            {
                lbMain.Items.Remove(lbMain.SelectedItems[0]);
            }
        }

        private void allToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbMain.Items.Clear();
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCryptSelected.PerformClick();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCryptAll.PerformClick();
        }

        private void selectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDecryptSelected.PerformClick();
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDecryptAll.PerformClick();
        }
        #endregion

        #region "Encrypt/Decrypt"
        private void EncryptFile(object fileName)
        {
            try
            {
                string topDir = null;
                if(Directory.Exists(fileName.ToString()))
                {
                    topDir = fileName.ToString();
                    DirectoryInfo myDir = new DirectoryInfo(fileName.ToString());
                    fileCount--;
                    fileCount += myDir.GetFiles().Length;
                    foreach (var myFile in myDir.GetFiles())
                    {
                        EncryptFile(myFile.FullName);
                    }

                    foreach (var myNewDir in myDir.GetDirectories())
                    {
                        EncryptFile(myNewDir.FullName);
                    }
                }
                else
                {
                    FileInfo myFile = new FileInfo(fileName.ToString());
                    byte[] fileBytes = File.ReadAllBytes(myFile.FullName);
                    //byte[] encryptedBytes = AES.Encrypt(buffer, txtKey.Text);
                    byte[] fileNameBytes = ASCIIEncoding.ASCII.GetBytes(myFile.Name + "$");
                    //byte[] encryptedNameBytes = AES.Encrypt(System.Text.ASCIIEncoding.ASCII.GetBytes(myFile.Name + "$"), txtKey.Text);
                    byte[] finalBytes = new byte[fileBytes.Length + fileNameBytes.Length];
                    System.Buffer.BlockCopy(fileNameBytes, 0, finalBytes, 0, fileNameBytes.Length);
                    System.Buffer.BlockCopy(fileBytes, 0, finalBytes, fileNameBytes.Length, fileBytes.Length);
                    byte[] encryptedBytes = AES.Encrypt(finalBytes, txtKey.Text);
                    File.Delete(myFile.FullName);
                    string myEncryptedFileName = Convert.ToBase64String(AES.Encrypt(ASCIIEncoding.ASCII.GetBytes(myFile.Name),
                           txtKey.Text));
                    //File.WriteAllBytes(myFile.DirectoryName + @"\" + myEncryptedFileName + ".NINJA", encryptedBytes);
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                        {
                            if (myEncryptedFileName.Contains(c))
                            {
                                myEncryptedFileName = myEncryptedFileName.Replace(c, '_');
                            }
                        }
                        //MessageBox.Show(myEncryptedFileName);
                    File.WriteAllBytes(myFile.DirectoryName + @"\" + myEncryptedFileName + ".NINJA", encryptedBytes);
                    curCount++;
                    lbMain.Invoke(new Action(() => lbMain.Items.Remove(fileName.ToString())));
                }

               if(curCount>=fileCount)
                {
                    progressBar.Invoke(new Action(() => progressBar.Visible = false));
                    //MessageBox.Show("Done." + curCount + "/" + fileCount, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbMain.Invoke(new Action(() => lbMain.Items.Remove(topDir)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while encrypting your files. \nERROR: " + ex.Message, Text);
                progressBar.Invoke(new Action(() => progressBar.Visible = false));
            }
        }

        private void DecryptFile(object fileName)
        {
            try
            {
                string topDir = null;
                if (Directory.Exists(fileName.ToString()))
                {
                    topDir = fileName.ToString();
                    DirectoryInfo myDir = new DirectoryInfo(fileName.ToString());
                    fileCount--;
                    fileCount += myDir.GetFiles().Length;
                    foreach (var myFile in myDir.GetFiles())
                    {
                        DecryptFile(myFile.FullName);
                    }

                    foreach (var myNewDir in myDir.GetDirectories())
                    {
                        DecryptFile(myNewDir.FullName);
                    }
                }
                else
                {
                    FileInfo myFile = new FileInfo(fileName.ToString());
                    if (myFile.Name.Contains("NINJA"))
                    {
                        byte[] buffer = File.ReadAllBytes(myFile.FullName);
                        byte[] decryptedBytes = AES.Decrypt(buffer, txtKey.Text);
                        int nameLength = 0;
                        for (int i = 0; i < decryptedBytes.Length && decryptedBytes[i] != '$'; i++)
                        {
                            nameLength++;
                        }
                        byte[] nameBytes = new byte[nameLength];
                        byte[] fileBytes = new byte[decryptedBytes.Length - (nameLength + 1)];
                        System.Buffer.BlockCopy(decryptedBytes, 0, nameBytes, 0, nameLength);
                        System.Buffer.BlockCopy(decryptedBytes, nameLength + 1, fileBytes, 0, decryptedBytes.Length - (nameLength + 1));
                        string fileNameClean = ASCIIEncoding.ASCII.GetString(nameBytes);
                        File.Delete(myFile.FullName);
                        File.WriteAllBytes(myFile.FullName.Replace(myFile.Name, fileNameClean), fileBytes);
                        curCount++;
                        lbMain.Invoke(new Action(() => lbMain.Items.Remove(fileName.ToString())));
                        if (curCount >= fileCount)
                        {
                            lbMain.Invoke(new Action(() => lbMain.Items.Remove(topDir)));
                            progressBar.Invoke(new Action(() => progressBar.Visible = false));
                            //MessageBox.Show("Done.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                 MessageBox.Show("An error has occured while encrypting your files. \nERROR: " + ex.Message,Text);
            }

        }
        #endregion
    }
}

/*
 * To do:
 *      Completed notification.
 *      Compress into a single file.
 */
