using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblisBankasiBalance.Text = isBankasiBalance.ToString() + " ₺";

            //Banka Hareketleri
            for (int i = 0; i < 5; i++)
            {
                var bankProcess = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(i).FirstOrDefault();
                if (bankProcess != null)
                {
                    var bankTitle = db.Banks.Where(y => y.BankId == bankProcess.BankId).Select(z => z.BankTitle).FirstOrDefault();
                    var label = this.Controls.Find($"lblBankProcess{i + 1}", true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = $"Açıklama: {bankProcess.Description}  Tutar: {bankProcess.Amount}  Tarih: {bankProcess.ProcessDate}  Banka: {bankTitle}";
                    }
                }
            }

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBanksMovements_Click(object sender, EventArgs e)
        {
            FrmBanksMovements frm = new FrmBanksMovements();
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
