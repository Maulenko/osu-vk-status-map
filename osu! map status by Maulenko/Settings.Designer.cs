namespace osu__map_status_by_Maulenko
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImportAPI = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.btnAddAPI = new System.Windows.Forms.Button();
            this.textBoxApiAdd = new System.Windows.Forms.TextBox();
            this.LabelAPI = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormSetting = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ImportAPI);
            this.panel1.Controls.Add(this.checkBoxSave);
            this.panel1.Controls.Add(this.btnAddAPI);
            this.panel1.Controls.Add(this.textBoxApiAdd);
            this.panel1.Controls.Add(this.LabelAPI);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 161);
            this.panel1.TabIndex = 1;
            // 
            // ImportAPI
            // 
            this.ImportAPI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportAPI.BackgroundImage")));
            this.ImportAPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportAPI.FlatAppearance.BorderSize = 0;
            this.ImportAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportAPI.Location = new System.Drawing.Point(71, 108);
            this.ImportAPI.Name = "ImportAPI";
            this.ImportAPI.Size = new System.Drawing.Size(40, 40);
            this.ImportAPI.TabIndex = 5;
            this.ImportAPI.UseVisualStyleBackColor = true;
            this.ImportAPI.Click += new System.EventHandler(this.ImportAPI_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxSave.Location = new System.Drawing.Point(220, 121);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(51, 17);
            this.checkBoxSave.TabIndex = 4;
            this.checkBoxSave.Text = "Save";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // btnAddAPI
            // 
            this.btnAddAPI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAPI.BackgroundImage")));
            this.btnAddAPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAPI.FlatAppearance.BorderSize = 0;
            this.btnAddAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAPI.Location = new System.Drawing.Point(19, 108);
            this.btnAddAPI.Name = "btnAddAPI";
            this.btnAddAPI.Size = new System.Drawing.Size(40, 40);
            this.btnAddAPI.TabIndex = 3;
            this.btnAddAPI.UseVisualStyleBackColor = true;
            this.btnAddAPI.Click += new System.EventHandler(this.btnAddAPI_Click);
            // 
            // textBoxApiAdd
            // 
            this.textBoxApiAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxApiAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxApiAdd.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxApiAdd.Location = new System.Drawing.Point(16, 73);
            this.textBoxApiAdd.Multiline = true;
            this.textBoxApiAdd.Name = "textBoxApiAdd";
            this.textBoxApiAdd.Size = new System.Drawing.Size(256, 31);
            this.textBoxApiAdd.TabIndex = 2;
            // 
            // LabelAPI
            // 
            this.LabelAPI.AutoSize = true;
            this.LabelAPI.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAPI.Location = new System.Drawing.Point(16, 57);
            this.LabelAPI.Name = "LabelAPI";
            this.LabelAPI.Size = new System.Drawing.Size(27, 13);
            this.LabelAPI.TabIndex = 1;
            this.LabelAPI.Text = "API:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FormSetting);
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
            // FormSetting
            // 
            this.FormSetting.AutoSize = true;
            this.FormSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormSetting.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormSetting.Location = new System.Drawing.Point(11, 8);
            this.FormSetting.Name = "FormSetting";
            this.FormSetting.Size = new System.Drawing.Size(99, 20);
            this.FormSetting.TabIndex = 1;
            this.FormSetting.Text = "osu! settings";
            this.FormSetting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSetting_MouseDown);
            this.FormSetting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSetting_MouseMove);
            this.FormSetting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormSetting_MouseUp);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FormSetting;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button btnAddAPI;
        private System.Windows.Forms.TextBox textBoxApiAdd;
        private System.Windows.Forms.Label LabelAPI;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.Button ImportAPI;
    }
}