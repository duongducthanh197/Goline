using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets_System.Common.Const;
using Timesheets_System.Controllers;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Views
{
    public partial class frmMenu : Form
    {
        Point mouseOffset;
        ScreenAuthController _screenAuthController = new ScreenAuthController();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmInit();
        }

        private void frmInit()
        {
            // If not login then exit application
            if (frmLogin.loggedUser == null)
            {
                return;
            }

            // Display fullname
            lbl_Username.Text += frmLogin.loggedUser.Fullname.ToUpper();

            try
            {
                // Enable/Disable menu item
                EnableMenuItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void EnableMenuItem()
        {
            // Get all screen authentication by authentication group of logged user
            UserDTO _userDTO = frmLogin.loggedUser;
            ScreenAuthDTO _screenAuthDTO = new ScreenAuthDTO();
            _screenAuthDTO.Auth_Group_ID = _userDTO.Auth_Group_ID;
            _screenAuthDTO.Allowed_To_Open = PERMISSION_TO_OPEN_SCREEN.ALLOWED;

            List<ScreenAuthDTO> screenAuthList = _screenAuthController.GetScreenAuthList(_screenAuthDTO);

            // Get all tool strip menu item in menu strip
            var allToolStripMenuItem = new List<ToolStripMenuItem>();
            GetAllToolStripMenuItems(ms_Menu.Items, allToolStripMenuItem);

            // Loop all item
            foreach (ToolStripMenuItem item in allToolStripMenuItem)
            {
                // Loop all screen authentication
                foreach (var screen in screenAuthList)
                {
                    // Tool strip menu item name = screen id and this user allowed to open this screen
                    if (item.Name == screen.Screen_ID && screen.Allowed_To_Open == PERMISSION_TO_OPEN_SCREEN.ALLOWED)
                    {
                        // If sub item is enabled then enable parent item
                        if (item.OwnerItem != null) item.OwnerItem.Enabled = true;
                        item.Enabled = true;
                        break;
                    }
                    else
                    {
                        // User cannot open this item => DISABLE
                        item.Enabled = false;
                    }
                }
            }
        }

        private void GetAllToolStripMenuItems(ToolStripItemCollection items, List<ToolStripMenuItem> result)
        {
            // Loop all items in menu
            foreach (ToolStripItem item in items)
            {
                // Get tool strip menu item and add to result
                if (item is ToolStripMenuItem menuItem)
                {
                    result.Add(menuItem);
                    // Recursive if item has DropDownItems
                    GetAllToolStripMenuItems(menuItem.DropDownItems, result);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ms_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void ms_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void tsmi_Logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin.loggedUser = null;
                frmLogin frm = new frmLogin();  
                frm.Show();
                this.Close();
            }   
        }

        private void frmTimesheets_Click(object sender, EventArgs e)
        {
            frmTimesheets form = new frmTimesheets();
            form.ShowDialog();
        }

        private void frmPersonalTimesheet_Click(object sender, EventArgs e)
        {
            frmPersonalTimesheet form = new frmPersonalTimesheet();
            form.ShowDialog();
        }
    }
}
