using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
            if(panelPlaylistSubmenu.Visible == true)
            {
                panelPlaylistSubmenu.Visible = false;
            }
            if(panelToolsSubmenu.Visible == true)
            {
                panelToolsSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //MessageBox.Show("button2 실행");
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button3 실행");
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button4 실행");
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button5 실행");
            hideSubMenu();
        }
        #endregion

        
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }
        #region PlaylistSubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button9 실행");
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button8 실행");
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button7 실행");
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button6 실행");
            hideSubMenu();
        }

        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //MessageBox.Show("Equalizer");
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }
        #region ToolsSubMenu
        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button15 실행");
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button14 실행");
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button13 실행");
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button12 실행");
            hideSubMenu();
        }
        #endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helps");
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
