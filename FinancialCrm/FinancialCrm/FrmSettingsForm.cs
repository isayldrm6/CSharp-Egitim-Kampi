using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettingsForm : Form
    {
        public FrmSettingsForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var user = db.Users.FirstOrDefault(x => x.Username == userName);

            if (user != null)
            {
                user.Username = txtUserName.Text;
                user.Password = txtPassword.Text;
                db.SaveChanges();
                MessageBox.Show("Kullanıcı Adı ve Şifre başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategoryForm frm = new FrmCategoryForm();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendingForm frm = new FrmSpendingForm();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBanksMovementForm_Click(object sender, EventArgs e)
        {
            FrmBanksMovements frm = new FrmBanksMovements();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsFrom_Click(object sender, EventArgs e)
        {
            FrmSettingsForm frm = new FrmSettingsForm();
            frm.Show();
            this.Hide();
        }
    }
}
