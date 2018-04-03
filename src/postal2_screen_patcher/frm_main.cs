using System;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace postal2_screen_patcher
{
    public partial class frm_main : Form
    {
        Rectangle scr = Screen.PrimaryScreen.Bounds;
        Regex r = new Regex("FullscreenViewportX=([0-9]+)");
        Regex r2 = new Regex("FullscreenViewportY=([0-9]+)");
        public string _(string key)
        {
            try { return Translation.Texts[key]; }
            catch { return ""; }
        }
        public void translatemenus(ToolStripMenuItem pr)
        {
            pr.Text = _(pr.Name);
            foreach (ToolStripItem dr in pr.DropDownItems)
            {
                try { translatemenus((ToolStripMenuItem) dr); }
                catch { }
            }
        }
        public void translate_controls(Control parent,ToolTip t)
        {
            parent.Text = _(parent.Name);
            try {
                if (t != null)
                    t.SetToolTip(parent, _("ttip_" + parent.Name)); 
            }
            catch { }
            foreach (Control ctr in parent.Controls) translate_controls(ctr,t);
        }
        public void translate(ToolTip t=null)
        {
            foreach (Control parentctr in this.Controls) translate_controls(parentctr,t);
            try { foreach (ToolStripMenuItem ts in this.MainMenuStrip.Items) translatemenus(ts); }
            catch { }
        }
        public frm_main()
        {
            InitializeComponent();
            Translation.Language = "ru";
            translate(this.toolTip1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combo_lang.SelectedIndex = 0;
            MessageBox.Show((Convert.ToInt32(DateTime.Now.Subtract(new DateTime(2012, 09, 03)).TotalDays) / 7  % 2 == 0) ? "Четная" : "Нечетная");
        }
        void replace(string path_to_ini,bool custom)
        {
            try
            {
                var s =File.ReadAllText(path_to_ini);
                s= r.Replace( s, "FullscreenViewportX=" + (custom ? num_width.Value.ToString() : scr.Width.ToString()));
                s = r2.Replace(s, "FullscreenViewportY=" + (custom ? num_high.Value.ToString() : scr.Height.ToString()));
                File.WriteAllText( path_to_ini,s);
            }
            catch
            {
                MessageBox.Show("Не удалось изменить конфигурацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                btn_patch.Enabled = true;
                string file = txt_inipath.Text;
                if (File.Exists(file))
                {
                    if (!chk_backup.Checked)
                        chk_backup.Checked = (
                                                MessageBox.Show("Вы не выбрали опцию создания резервной копии. Сделать резервную копию?",
                                                                "Внимание",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation )
                                                == DialogResult.Yes);
                    if (chk_backup.Checked)
                        try
                        {
                            if (File.Exists(file + ".bak"))
                                try
                                {
                                    File.Delete(file + ".bak");
                                }
                                catch { }
                            File.Copy(file, file + ".bak");
                        }
                        catch
                        {
                            if (MessageBox.Show("Не удалось создать резервную копию. Продолжить без него?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                                return;
                        }
                    replace(file, rd_custom.Checked);
                    SoundPlayer btns = new SoundPlayer(Properties.Resources.btn);
                    btns.Play();
                    MessageBox.Show("Выполнено успешно!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Необходимо указать ini-файл настроек игры!", "ЕГГОГ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void btn_brws_Click(object sender, EventArgs e)
        {
            if (open_ini_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_inipath.Text = open_ini_dialog.FileName;
                    string s = File.ReadAllText(txt_inipath.Text);
                    decimal d = 0, d1 = 0;
                    if (decimal.TryParse(r.Match(s).Groups[1].Value, out d)&&decimal.TryParse(r2.Match(s).Groups[1].Value, out d1))
                    {
                        num_width.Value = d;
                        num_high.Value=d1;
                    }
                    else
                    {
                        MessageBox.Show("INI файл не валиден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_inipath.Text = "";
                        return;
                    }
                }
                catch { }
            }
        }

        private void rd_custom_CheckedChanged(object sender, EventArgs e)
        {
         /*   if (txt_inipath.Text == "" || rd_res.Checked)
            {
               
                num_high.Enabled = false;
                num_width.Enabled = false;
            }
            else
            {
                num_high.Enabled = true;
                num_width.Enabled = true;
            }
*/

  num_high.Enabled = rd_custom.Checked && txt_inipath.Text != "" ;
  num_width.Enabled = rd_custom.Checked && txt_inipath.Text != "";
            btn_default_resolution.Visible = rd_custom.Checked;
        }

        private void txt_inipath_TextChanged(object sender, EventArgs e)
        {
            if (txt_inipath.Text == "")
            {
          
                btn_default_resolution.Enabled  = false;
                btn_patch.Enabled = false;
            }
            else
            {
         
                btn_default_resolution.Enabled  = true;
                btn_patch.Enabled = true;
            }
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
#if !DEBUG
            try
            {
                System.Diagnostics.Process.Start("http://ww.epicm.org");
            }
            catch { }
#endif
        }

        private void gbx_screen_Enter(object sender, EventArgs e)
        {

        }

        #region колдовство с крестиком
        private void pic_close_MouseLeave(object sender, EventArgs e)
        {
            pic_close.Image = Properties.Resources.x1;

        }


        private void pic_close_MouseMove(object sender, MouseEventArgs e)
        {
            pic_close.Image = Properties.Resources.x2;

        }

        private void pic_close_MouseDown(object sender, MouseEventArgs e)
        {

            pic_close.Image = Properties.Resources.x3;


        }



        private void pic_close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        private void btn_default_resolution_Click(object sender, EventArgs e)
        {
            num_width.Value = 800;
            num_high.Value = 600;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            frm_about frmabout = new frm_about();
            frmabout.ShowDialog();
        }

         
         
         
    }
}
