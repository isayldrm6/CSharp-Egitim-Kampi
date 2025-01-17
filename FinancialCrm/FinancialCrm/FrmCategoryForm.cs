using FinancialCrm.Models;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategoryForm : Form
    {
        public FrmCategoryForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategoryForm_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var categoryName = txtCategoryName.Text;
            var category = new Categories { CategoryName = categoryName };            
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi.","Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value =int.Parse(txtCategoryId.Text);
            var category = db.Categories.FirstOrDefault(k => k.CategoryId == value);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi.","Güncelleme", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori bulunamadı!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var categoryId = int.Parse(txtCategoryId.Text);
            var category = db.Categories.FirstOrDefault(k => k.CategoryId == categoryId);
            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori bulunamadı!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnBanksMovementsForm_Click(object sender, EventArgs e)
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
