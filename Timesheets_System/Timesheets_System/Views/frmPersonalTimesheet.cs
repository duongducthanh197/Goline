using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timesheets_System.Views
{
    public partial class frmPersonalTimesheet : Form
    {
        Point mouseOffset;

        public frmPersonalTimesheet()
        {
            InitializeComponent();
        }

        private void frmPersonalTimesheet_Load(object sender, EventArgs e)
        {

        }

        private void frmInit()
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void pn_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

    }
}