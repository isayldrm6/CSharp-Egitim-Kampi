using FinancialCrm.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanksMovements : Form
    {
        public FrmBanksMovements()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanksMovements_Load(object sender, EventArgs e)
        {           
            var values = db.BankProcesses.Select(x => new { x.Description, x.ProcessType, x.ProcessDate, x.Amount , x.BankId}).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankId.Text);
            var value = db.BankProcesses.Select(x => new { x.Description, x.ProcessType, x.ProcessDate, x.Amount, x.BankId }).Where(y => y.BankId == id).ToList();
            dataGridView1.DataSource = value;
        }

        private void btnDateGetById_Click(object sender, EventArgs e)
        {;
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            var value = db.BankProcesses.Where(x => x.ProcessDate >= startDate && x.ProcessDate <= endDate)
                .Select(x => new 
                { 
                    x.Description, 
                    x.ProcessType, 
                    x.ProcessDate, 
                    x.Amount, 
                    x.BankId 
                }).ToList();
            dataGridView1.DataSource = value;
        }
        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategoryForm frm = new FrmCategoryForm();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendingForm frm = new FrmSpendingForm();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettingsForm frm = new FrmSettingsForm();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
