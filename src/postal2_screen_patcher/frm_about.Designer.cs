namespace postal2_screen_patcher
{
    partial class frm_about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_about));
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_coolall = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_autors = new System.Windows.Forms.Label();
            this.supportlink1 = new System.Windows.Forms.LinkLabel();
            this.gamelist = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(173, 239);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "OK";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_coolall
            // 
            this.lbl_coolall.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coolall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_coolall.Location = new System.Drawing.Point(28, 62);
            this.lbl_coolall.Name = "lbl_coolall";
            this.lbl_coolall.Size = new System.Drawing.Size(375, 163);
            this.lbl_coolall.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::postal2_screen_patcher.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(351, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ver.Location = new System.Drawing.Point(44, 74);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(72, 13);
            this.lbl_ver.TabIndex = 8;
            this.lbl_ver.Text = "Версия 1.1";
            // 
            // lbl_autors
            // 
            this.lbl_autors.AutoSize = true;
            this.lbl_autors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_autors.Location = new System.Drawing.Point(44, 99);
            this.lbl_autors.Name = "lbl_autors";
            this.lbl_autors.Size = new System.Drawing.Size(157, 39);
            this.lbl_autors.TabIndex = 9;
            this.lbl_autors.Text = "Идея: STAM\r\nКод: Kasthack\r\nИнтерфейс: STAM && Kasthack";
            // 
            // supportlink1
            // 
            this.supportlink1.AutoSize = true;
            this.supportlink1.BackColor = System.Drawing.Color.Transparent;
            this.supportlink1.Location = new System.Drawing.Point(44, 142);
            this.supportlink1.Name = "supportlink1";
            this.supportlink1.Size = new System.Drawing.Size(108, 13);
            this.supportlink1.TabIndex = 10;
            this.supportlink1.TabStop = true;
            this.supportlink1.Text = "http://ww.epicm.org/";
            this.supportlink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.supportlink1_LinkClicked);
            // 
            // gamelist
            // 
            this.gamelist.BackColor = System.Drawing.Color.Gainsboro;
            this.gamelist.FormattingEnabled = true;
            this.gamelist.Items.AddRange(new object[] {
            "Supported Games:",
            "______________________",
            "*Postal 2 (Original)",
            "*Postal 2: Apocalypse Weekend",
            "*Postal 2: AWP",
            "*Postal 2: Share th Pain",
            "*Postal 2: Eternal Damnation",
            "*Postal 2: A Very Postal Christmas",
            "*Postal 2: Штопор жжот",
            "______________________",
            "Not guaranteed to work on",
            "modifications or games that",
            "are not represented in the list above!"});
            this.gamelist.Location = new System.Drawing.Point(47, 165);
            this.gamelist.Name = "gamelist";
            this.gamelist.Size = new System.Drawing.Size(336, 43);
            this.gamelist.TabIndex = 11;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 287);
            this.Controls.Add(this.gamelist);
            this.Controls.Add(this.supportlink1);
            this.Controls.Add(this.lbl_autors);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_coolall);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_about";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_coolall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_autors;
        private System.Windows.Forms.LinkLabel supportlink1;
        private System.Windows.Forms.ListBox gamelist;
    }
}