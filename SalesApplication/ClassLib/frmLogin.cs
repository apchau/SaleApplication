using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLib
{
    public partial class frmLogin : Form
    {
        private FinConnectionDataSetTableAdapters.LoginsTableAdapter loginAdapter = new FinConnectionDataSetTableAdapters.LoginsTableAdapter();
        public bool goNext = false;
        public string username;
        public int password;

        public frmLogin()
        {
            InitializeComponent();
        }

        public string usrName()
        {
            return username = txtusername.Text;
        }

        public int passwd()
        {
            return password = int.Parse(txtPassword.Text);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtusername.Text;
            password = int.Parse(txtPassword.Text);
            try
            {
                if (loginAdapter.Search(loginAdapter.GetData(), username, password) > 0)
                {
                    goNext =  true;
                    Close();
                }
                else if (loginAdapter.SearchUsername(loginAdapter.GetData(), username) > 0)
                {
                    lblStatus.Text = "Invalid Password";
                    goNext =  false;
                }
                else
                {
                    lblStatus.Text = "Invalid Credentials";
                    goNext =  false;
                }
            }
            catch
            {
                lblStatus.Text = "Invalid credentials";
                goNext = false;
            }
        }

        public bool isTrue()
        {
            return goNext;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
