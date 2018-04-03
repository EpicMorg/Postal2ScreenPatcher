namespace postal2_screen_patcher
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_brws = new System.Windows.Forms.Button();
            this.txt_inipath = new System.Windows.Forms.TextBox();
            this.chk_backup = new System.Windows.Forms.CheckBox();
            this.btn_patch = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_high = new System.Windows.Forms.Label();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.num_high = new System.Windows.Forms.NumericUpDown();
            this.gbx_screen = new System.Windows.Forms.GroupBox();
            this.btn_default_resolution = new System.Windows.Forms.Button();
            this.rd_custom = new System.Windows.Forms.RadioButton();
            this.rd_res = new System.Windows.Forms.RadioButton();
            this.lbl_height_new = new System.Windows.Forms.Label();
            this.lbl_width_new = new System.Windows.Forms.Label();
            this.open_ini_dialog = new System.Windows.Forms.OpenFileDialog();
            this.combo_lang = new System.Windows.Forms.ComboBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.num_high)).BeginInit();
            this.gbx_screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_brws
            // 
            this.btn_brws.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brws.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btn_brws.Location = new System.Drawing.Point(330, 51);
            this.btn_brws.Name = "btn_brws";
            this.btn_brws.Size = new System.Drawing.Size(75, 20);
            this.btn_brws.TabIndex = 0;
            this.btn_brws.UseVisualStyleBackColor = true;
            this.btn_brws.Click += new System.EventHandler(this.btn_brws_Click);
            // 
            // txt_inipath
            // 
            this.txt_inipath.Location = new System.Drawing.Point(25, 51);
            this.txt_inipath.Name = "txt_inipath";
            this.txt_inipath.ReadOnly = true;
            this.txt_inipath.Size = new System.Drawing.Size(299, 20);
            this.txt_inipath.TabIndex = 1;
            this.txt_inipath.TextChanged += new System.EventHandler(this.txt_inipath_TextChanged);
            // 
            // chk_backup
            // 
            this.chk_backup.BackColor = System.Drawing.Color.Transparent;
            this.chk_backup.Checked = true;
            this.chk_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_backup.Location = new System.Drawing.Point(245, 237);
            this.chk_backup.Name = "chk_backup";
            this.chk_backup.Size = new System.Drawing.Size(70, 19);
            this.chk_backup.TabIndex = 3;
            this.chk_backup.UseVisualStyleBackColor = false;
            // 
            // btn_patch
            // 
            this.btn_patch.Enabled = false;
            this.btn_patch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patch.Location = new System.Drawing.Point(321, 233);
            this.btn_patch.Name = "btn_patch";
            this.btn_patch.Size = new System.Drawing.Size(84, 23);
            this.btn_patch.TabIndex = 4;
            this.btn_patch.UseVisualStyleBackColor = true;
            this.btn_patch.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_about
            // 
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btn_about.Location = new System.Drawing.Point(25, 235);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(88, 21);
            this.btn_about.TabIndex = 5;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(11, 28);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(0, 13);
            this.lbl_width.TabIndex = 6;
            // 
            // lbl_high
            // 
            this.lbl_high.AutoSize = true;
            this.lbl_high.Location = new System.Drawing.Point(11, 57);
            this.lbl_high.Name = "lbl_high";
            this.lbl_high.Size = new System.Drawing.Size(0, 13);
            this.lbl_high.TabIndex = 7;
            // 
            // num_width
            // 
            this.num_width.Enabled = false;
            this.num_width.Location = new System.Drawing.Point(98, 25);
            this.num_width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(120, 20);
            this.num_width.TabIndex = 8;
            // 
            // num_high
            // 
            this.num_high.Enabled = false;
            this.num_high.Location = new System.Drawing.Point(98, 54);
            this.num_high.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_high.Name = "num_high";
            this.num_high.Size = new System.Drawing.Size(120, 20);
            this.num_high.TabIndex = 9;
            // 
            // gbx_screen
            // 
            this.gbx_screen.BackColor = System.Drawing.Color.Transparent;
            this.gbx_screen.Controls.Add(this.btn_default_resolution);
            this.gbx_screen.Controls.Add(this.rd_custom);
            this.gbx_screen.Controls.Add(this.rd_res);
            this.gbx_screen.Controls.Add(this.lbl_height_new);
            this.gbx_screen.Controls.Add(this.lbl_width_new);
            this.gbx_screen.Controls.Add(this.lbl_width);
            this.gbx_screen.Controls.Add(this.num_high);
            this.gbx_screen.Controls.Add(this.lbl_high);
            this.gbx_screen.Controls.Add(this.num_width);
            this.gbx_screen.Location = new System.Drawing.Point(25, 78);
            this.gbx_screen.Name = "gbx_screen";
            this.gbx_screen.Size = new System.Drawing.Size(380, 149);
            this.gbx_screen.TabIndex = 10;
            this.gbx_screen.TabStop = false;
            this.gbx_screen.Enter += new System.EventHandler(this.gbx_screen_Enter);
            // 
            // btn_default_resolution
            // 
            this.btn_default_resolution.Enabled = false;
            this.btn_default_resolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_default_resolution.Location = new System.Drawing.Point(253, 111);
            this.btn_default_resolution.Name = "btn_default_resolution";
            this.btn_default_resolution.Size = new System.Drawing.Size(109, 23);
            this.btn_default_resolution.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_default_resolution, "Задает стандартное разрешение экрана в игре, \r\nпо умолчанию равное 800х600. Испол" +
                    "ьзуется\r\nпри необходимости сбросить настройки.");
            this.btn_default_resolution.UseVisualStyleBackColor = true;
            this.btn_default_resolution.Visible = false;
            this.btn_default_resolution.Click += new System.EventHandler(this.btn_default_resolution_Click);
            // 
            // rd_custom
            // 
            this.rd_custom.AutoSize = true;
            this.rd_custom.Location = new System.Drawing.Point(13, 114);
            this.rd_custom.Name = "rd_custom";
            this.rd_custom.Size = new System.Drawing.Size(14, 13);
            this.rd_custom.TabIndex = 13;
            this.toolTip1.SetToolTip(this.rd_custom, "Включить возможность использования \r\nсобственного разрешения экрана в игре.");
            this.rd_custom.UseVisualStyleBackColor = true;
            this.rd_custom.CheckedChanged += new System.EventHandler(this.rd_custom_CheckedChanged);
            // 
            // rd_res
            // 
            this.rd_res.AutoSize = true;
            this.rd_res.Checked = true;
            this.rd_res.Location = new System.Drawing.Point(13, 91);
            this.rd_res.Name = "rd_res";
            this.rd_res.Size = new System.Drawing.Size(14, 13);
            this.rd_res.TabIndex = 12;
            this.rd_res.TabStop = true;
            this.toolTip1.SetToolTip(this.rd_res, "Сделать разрешение в игре, \r\nтакое же как на экране.");
            this.rd_res.UseVisualStyleBackColor = true;
            this.rd_res.CheckedChanged += new System.EventHandler(this.rd_custom_CheckedChanged);
            // 
            // lbl_height_new
            // 
            this.lbl_height_new.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_height_new.Location = new System.Drawing.Point(253, 54);
            this.lbl_height_new.Name = "lbl_height_new";
            this.lbl_height_new.Size = new System.Drawing.Size(109, 18);
            this.lbl_height_new.TabIndex = 11;
            this.lbl_height_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbl_height_new, "Текущая высота вашего экрана в пикселях.");
            // 
            // lbl_width_new
            // 
            this.lbl_width_new.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_width_new.Location = new System.Drawing.Point(253, 25);
            this.lbl_width_new.Name = "lbl_width_new";
            this.lbl_width_new.Size = new System.Drawing.Size(109, 18);
            this.lbl_width_new.TabIndex = 10;
            this.lbl_width_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbl_width_new, "Текущая ширина вашего экрана в пикселях.");
            // 
            // open_ini_dialog
            // 
            this.open_ini_dialog.Filter = resources.GetString("open_ini_dialog.Filter");
            this.open_ini_dialog.Title = "Open INI file of Postal 2";
            // 
            // combo_lang
            // 
            this.combo_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lang.Enabled = false;
            this.combo_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_lang.FormattingEnabled = true;
            this.combo_lang.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.combo_lang.Location = new System.Drawing.Point(119, 235);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(120, 21);
            this.combo_lang.TabIndex = 11;
            this.toolTip1.SetToolTip(this.combo_lang, "Выбрать язык интерфейса");
            // 
            // pic_close
            // 
            this.pic_close.Image = global::postal2_screen_patcher.Properties.Resources.x1;
            this.pic_close.Location = new System.Drawing.Point(392, 23);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(13, 13);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_close.TabIndex = 12;
            this.pic_close.TabStop = false;
            this.pic_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_close_MouseClick);
            this.pic_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_close_MouseDown);
            this.pic_close.MouseLeave += new System.EventHandler(this.pic_close_MouseLeave);
            this.pic_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_close_MouseMove);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 287);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.combo_lang);
            this.Controls.Add(this.gbx_screen);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_patch);
            this.Controls.Add(this.chk_backup);
            this.Controls.Add(this.txt_inipath);
            this.Controls.Add(this.btn_brws);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSTAL2 Custom Screen Resolution";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_main_MouseDown);
            ((System.ComponentModel.ISupportInitialize) (this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.num_high)).EndInit();
            this.gbx_screen.ResumeLayout(false);
            this.gbx_screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_brws;
        private System.Windows.Forms.TextBox txt_inipath;
        private System.Windows.Forms.CheckBox chk_backup;
        private System.Windows.Forms.Button btn_patch;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.NumericUpDown num_high;
        private System.Windows.Forms.GroupBox gbx_screen;
        private System.Windows.Forms.OpenFileDialog open_ini_dialog;
        private System.Windows.Forms.Label lbl_height_new;
        private System.Windows.Forms.Label lbl_width_new;
        private System.Windows.Forms.RadioButton rd_custom;
        private System.Windows.Forms.RadioButton rd_res;
        private System.Windows.Forms.Button btn_default_resolution;
        private System.Windows.Forms.ComboBox combo_lang;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

