using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtUserPassword.Text;
           
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                 this.Hide();
                 var mainForm = new FrmBanks();
                 mainForm.Show();
            }
            else
            {
                 MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }               
        }
    }
    
}
