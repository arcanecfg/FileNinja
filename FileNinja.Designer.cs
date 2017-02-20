namespace FileNinja
{
    partial class FileNinja
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
            this.components = new System.ComponentModel.Container();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCryptAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCryptSelected = new System.Windows.Forms.Button();
            this.btnDecryptSelected = new System.Windows.Forms.Button();
            this.btnDecryptAll = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPassword = new System.Windows.Forms.Button();
            this.notifyInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtKey.Location = new System.Drawing.Point(44, 320);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(497, 23);
            this.txtKey.TabIndex = 1;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // btnCryptAll
            // 
            this.btnCryptAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCryptAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCryptAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCryptAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCryptAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCryptAll.Location = new System.Drawing.Point(153, 352);
            this.btnCryptAll.Name = "btnCryptAll";
            this.btnCryptAll.Size = new System.Drawing.Size(135, 25);
            this.btnCryptAll.TabIndex = 3;
            this.btnCryptAll.Text = "Encrypt All";
            this.btnCryptAll.UseVisualStyleBackColor = true;
            this.btnCryptAll.Click += new System.EventHandler(this.btnCryptAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "DROP FILES/FOLDERS HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Ninja 1.0";
            // 
            // btnCryptSelected
            // 
            this.btnCryptSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCryptSelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCryptSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCryptSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCryptSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCryptSelected.Location = new System.Drawing.Point(12, 352);
            this.btnCryptSelected.Name = "btnCryptSelected";
            this.btnCryptSelected.Size = new System.Drawing.Size(135, 25);
            this.btnCryptSelected.TabIndex = 6;
            this.btnCryptSelected.Text = "Encrypt Selected";
            this.btnCryptSelected.UseVisualStyleBackColor = true;
            this.btnCryptSelected.Click += new System.EventHandler(this.btnCryptSelected_Click);
            // 
            // btnDecryptSelected
            // 
            this.btnDecryptSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDecryptSelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDecryptSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDecryptSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDecryptSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptSelected.Location = new System.Drawing.Point(296, 352);
            this.btnDecryptSelected.Name = "btnDecryptSelected";
            this.btnDecryptSelected.Size = new System.Drawing.Size(135, 25);
            this.btnDecryptSelected.TabIndex = 8;
            this.btnDecryptSelected.Text = "Decrypt Selected";
            this.btnDecryptSelected.UseVisualStyleBackColor = true;
            this.btnDecryptSelected.Click += new System.EventHandler(this.btnDecryptSelected_Click);
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDecryptAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDecryptAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDecryptAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDecryptAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptAll.Location = new System.Drawing.Point(437, 352);
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Size = new System.Drawing.Size(135, 25);
            this.btnDecryptAll.TabIndex = 9;
            this.btnDecryptAll.Text = "Decrypt All";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 303);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 11);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMain.ContextMenuStrip = this.menuMain;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMain.FormattingEnabled = true;
            this.lbMain.ItemHeight = 20;
            this.lbMain.Location = new System.Drawing.Point(12, 95);
            this.lbMain.Name = "lbMain";
            this.lbMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMain.Size = new System.Drawing.Size(560, 202);
            this.lbMain.TabIndex = 11;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(118, 70);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem2,
            this.allToolStripMenuItem2});
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeItemToolStripMenuItem.Text = "Remove";
            // 
            // selectedToolStripMenuItem2
            // 
            this.selectedToolStripMenuItem2.Name = "selectedToolStripMenuItem2";
            this.selectedToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem2.Text = "Selected";
            this.selectedToolStripMenuItem2.Click += new System.EventHandler(this.selectedToolStripMenuItem2_Click);
            // 
            // allToolStripMenuItem2
            // 
            this.allToolStripMenuItem2.Name = "allToolStripMenuItem2";
            this.allToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem2.Text = "All";
            this.allToolStripMenuItem2.Click += new System.EventHandler(this.allToolStripMenuItem2_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.allToolStripMenuItem});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem1,
            this.allToolStripMenuItem1});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // selectedToolStripMenuItem1
            // 
            this.selectedToolStripMenuItem1.Name = "selectedToolStripMenuItem1";
            this.selectedToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem1.Text = "Selected";
            this.selectedToolStripMenuItem1.Click += new System.EventHandler(this.selectedToolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem1.Text = "All";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(547, 320);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(25, 23);
            this.btnPassword.TabIndex = 12;
            this.btnPassword.Text = "*";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // notifyInfo
            // 
            this.notifyInfo.Text = "notifyIcon1";
            this.notifyInfo.Visible = true;
            // 
            // FileNinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(584, 389);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDecryptAll);
            this.Controls.Add(this.btnDecryptSelected);
            this.Controls.Add(this.btnCryptSelected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCryptAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FileNinja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileNinja";
            this.Load += new System.EventHandler(this.FileNinja_Load);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCryptAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCryptSelected;
        private System.Windows.Forms.Button btnDecryptSelected;
        private System.Windows.Forms.Button btnDecryptAll;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyInfo;
    }
}

