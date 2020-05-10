namespace osu__map_status_by_Maulenko
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VersionProgramm = new System.Windows.Forms.Label();
            this.linkVkAuthor = new System.Windows.Forms.LinkLabel();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.linkapiget = new System.Windows.Forms.LinkLabel();
            this.LabelGetAPI = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormHelp = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VersionProgramm);
            this.panel1.Controls.Add(this.linkVkAuthor);
            this.panel1.Controls.Add(this.LabelAuthor);
            this.panel1.Controls.Add(this.linkapiget);
            this.panel1.Controls.Add(this.LabelGetAPI);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 161);
            this.panel1.TabIndex = 1;
            // 
            // VersionProgramm
            // 
            this.VersionProgramm.AutoSize = true;
            this.VersionProgramm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VersionProgramm.Location = new System.Drawing.Point(216, 139);
            this.VersionProgramm.Name = "VersionProgramm";
            this.VersionProgramm.Size = new System.Drawing.Size(63, 13);
            this.VersionProgramm.TabIndex = 6;
            this.VersionProgramm.Text = "Version: 1.1";
            // 
            // linkVkAuthor
            // 
            this.linkVkAuthor.AutoSize = true;
            this.linkVkAuthor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkVkAuthor.Location = new System.Drawing.Point(71, 76);
            this.linkVkAuthor.Name = "linkVkAuthor";
            this.linkVkAuthor.Size = new System.Drawing.Size(31, 13);
            this.linkVkAuthor.TabIndex = 5;
            this.linkVkAuthor.TabStop = true;
            this.linkVkAuthor.Text = "LINK";
            this.linkVkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVkAuthor_LinkClicked);
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAuthor.Location = new System.Drawing.Point(13, 76);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(56, 13);
            this.LabelAuthor.TabIndex = 4;
            this.LabelAuthor.Text = "AUTHOR:";
            // 
            // linkapiget
            // 
            this.linkapiget.AutoSize = true;
            this.linkapiget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkapiget.Location = new System.Drawing.Point(71, 53);
            this.linkapiget.Name = "linkapiget";
            this.linkapiget.Size = new System.Drawing.Size(31, 13);
            this.linkapiget.TabIndex = 3;
            this.linkapiget.TabStop = true;
            this.linkapiget.Text = "LINK";
            this.linkapiget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkapiget_LinkClicked);
            // 
            // LabelGetAPI
            // 
            this.LabelGetAPI.AutoSize = true;
            this.LabelGetAPI.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelGetAPI.Location = new System.Drawing.Point(13, 53);
            this.LabelGetAPI.Name = "LabelGetAPI";
            this.LabelGetAPI.Size = new System.Drawing.Size(52, 13);
            this.LabelGetAPI.TabIndex = 2;
            this.LabelGetAPI.Text = "GET API:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FormHelp);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 40);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // FormHelp
            // 
            this.FormHelp.AutoSize = true;
            this.FormHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormHelp.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormHelp.Location = new System.Drawing.Point(11, 8);
            this.FormHelp.Name = "FormHelp";
            this.FormHelp.Size = new System.Drawing.Size(73, 20);
            this.FormHelp.TabIndex = 1;
            this.FormHelp.Text = "osu! help";
            this.FormHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHelp_MouseDown);
            this.FormHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHelp_MouseMove);
            this.FormHelp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHelp_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(242, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 38);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FormHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label VersionProgramm;
        private System.Windows.Forms.LinkLabel linkVkAuthor;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.LinkLabel linkapiget;
        private System.Windows.Forms.Label LabelGetAPI;
    }
}