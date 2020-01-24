using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project5_thfm2
{
    public partial class frmLogin : Form
    {
        Entities db = new Entities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            var ds = (from l in db.Logins
                      where l.l_Email == txtUser.Text
                      &&
                      l.Password == txtPass.Text
                      &&
                      l.permission == 1133
                      select l).FirstOrDefault();
            if (ds != null)
            {
                var form = new frmMain();
                form._UserName = ds.l_Firstname +" "+ ds.l_Lastname;
                //form._Permission = Convert.ToInt32(ds.permission);
                form._Loginid = ds.Login_Id;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Can not access the system.", "Notifications");
                txtPass.Clear();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
    }
}
