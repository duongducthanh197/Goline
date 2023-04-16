using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets_System.Common.Const;
using Timesheets_System.Common.Util;
using Timesheets_System.Controllers;
using Timesheets_System.Models.DAO;
using Timesheets_System.Models.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Timesheets_System.Views
{
    public partial class frmLogin : Form
    {
        UserController _userController = new UserController();
        ScreenAuthController _screenAuthController = new ScreenAuthController();
        public static UserDTO loggedUser; 

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                //Check username, password textbox
                if (!ElementCheck()) return;

                //Get user by username
                UserDTO _userDTO = _userController.getUserByID(txt_Username.Text);

                //Check username is exist
                if (_userDTO == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Check password is correct
                if (StringUtil.Encrytion(txt_Password.Text) != _userDTO.Password)
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Get authentication of user with menu screen
                ScreenAuthDTO _screenAuthDTO = new ScreenAuthDTO();
                _screenAuthDTO.Auth_Group_ID = _userDTO.Auth_Group_ID;
                _screenAuthDTO.Screen_ID = "frmMenu";
                _screenAuthDTO.Allowed_To_Open = PERMISSION_TO_OPEN_SCREEN.ALLOWED;

                _screenAuthDTO = _screenAuthController.GetScreenAuthByAuthGrID(_screenAuthDTO);

                if (_screenAuthDTO == null)
                {
                    //User not permission to access menu
                    MessageBox.Show("Bạn chưa có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //User can access menu
                    frmMenu frmMenu = new frmMenu();
                    loggedUser = _userDTO;
                    Thread.Sleep(500);
                    frmMenu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
       

        private Boolean ElementCheck()
        {
            //Check username is empty
            if (txt_Username.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check username is empty
            if (txt_Password.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Processing login event when press Enter 
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Processing login event when press Enter 
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }
    }
}
