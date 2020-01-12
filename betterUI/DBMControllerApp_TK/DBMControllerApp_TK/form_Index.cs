using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMControllerApp_TK
{
    public partial class form_Index : Form
    {
        public form_Index()
        {
            InitializeComponent();
            initControls();
        }
        
        private void initControls()
        {
            initSubMenus();
        }
        #region Sidepanel
        private void initSubMenus()
        {
            panelHomeSubmenu.Visible = false;
            panelSettingsSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelHomeSubmenu.Visible == true) panelHomeSubmenu.Visible = false;
            if (panelSettingsSubmenu.Visible == true) panelSettingsSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHomeSubmenu);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSettingsSubmenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void form_Index_Load(object sender, EventArgs e)
        {

        }

        
    }
}
