using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendingForm : Form
    {
        public FrmSpendingForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendingForm_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.Select(x=> new {x.SpendingTitle, x.SpendingAmount, x.SpendingDate}).ToList();
            dataGridView1.DataSource = values;

            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "₺";

            var totalSpending = db.Spendings.Sum(y => y.SpendingAmount);
            lblTotalSpending.Text = totalSpending.ToString() + "₺";            

            var topCategory = db.Spendings.GroupBy(x => x.CategoryId).Select(y => new
            {
                CategoryId = y.Key,
                TotalSpending = y.Sum(s => s.SpendingAmount)
            }).OrderByDescending(z => z.TotalSpending).FirstOrDefault();

            if (topCategory != null)
            {
                var categoryName = db.Categories.Where(c => c.CategoryId == topCategory.CategoryId).Select(c => c.CategoryName).FirstOrDefault();

                lblTopSpendingCategory.Text = categoryName.ToString();
                lblTopSpending.Text = topCategory.TotalSpending.ToString();
            }

            //Chart1
            var spendingData = db.Spendings.GroupBy(s => s.CategoryId).Select(g => new
                {
                    CategoryId = g.Key,
                    TotalSpending = g.Sum(s => s.SpendingAmount)
                }).ToList();

            var chartData = spendingData.Select(data => new
            {
                CategoryName = db.Categories.Where(c => c.CategoryId == data.CategoryId).Select(c => c.CategoryName).FirstOrDefault(),
                TotalSpending = data.TotalSpending
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Harcamalar");
            foreach (var data in chartData)
            {
                series.Points.AddXY(data.CategoryName, data.TotalSpending);
            }                        
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

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBanksMovements_Click(object sender, EventArgs e)
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

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettingsForm frm = new FrmSettingsForm();
            frm.Show();
            this.Hide();
        }

        private void btnLogOutForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
