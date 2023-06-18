using Lembretes.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lembretes
{
    public partial class MainForm : Form
    {
        private LembreteContext? dbContext;
        private const string removeColumnName = "remove_column";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dtData.Value < DateTime.Now)
            {
                MessageBox.Show("Você deve preencher a data com um dia no futuro.");
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Você deve preencher o nome do lembrete.");
                return;
            }

            Lembrete lembrete = new Lembrete();
            lembrete.Name = txtName.Text;
            lembrete.Data = dtData.Value;
            this.lembreteBindingSource.Add(lembrete);
            this.dbContext!.SaveChanges();
            var dataColumn = dgvLembretes.Columns[0];
            dgvLembretes.Sort(dataColumn, ListSortDirection.Ascending);
            if (cbFiltrarData.Checked)
            {
                FilterRows();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new LembreteContext();

            this.dbContext.Database.EnsureCreated();

            this.dbContext.Lembretes.Load();
            this.lembreteBindingSource.DataSource = dbContext.Lembretes.Local.ToBindingList();
            dtData.Value = DateTime.Now.AddDays(1);

            DataGridViewImageColumn dgvDeleteColumn = new DataGridViewImageColumn();
            dgvDeleteColumn.Name = removeColumnName;
            dgvDeleteColumn.HeaderText = "Remover";
            dgvDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            Image iconDelete = Image.FromFile("deletar.ico");
            dgvDeleteColumn.Image = iconDelete;

            int columnIndex = 2;
            if (dgvLembretes.Columns[removeColumnName] == null)
            {
                dgvLembretes.Columns.Insert(columnIndex, dgvDeleteColumn);
            }

            var dataColumn = dgvLembretes.Columns[0];
            dgvLembretes.Sort(dataColumn, ListSortDirection.Ascending);
            dtFilterDate.Enabled = cbFiltrarData.Checked;
            dtFilterDate.Value = DateTime.Now;
        }

        private void dgvLembretes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLembretes.Columns[removeColumnName].Index)
            {
                this.lembreteBindingSource.RemoveCurrent();
                this.dbContext!.SaveChanges();
                if (cbFiltrarData.Checked)
                {
                    FilterRows();
                }
            }
        }

        private void cbFiltrarData_Click(object sender, EventArgs e)
        {
            dtFilterDate.Enabled = cbFiltrarData.Checked;
            FilterRows(!cbFiltrarData.Checked);
        }

        private void dtFilterDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbFiltrarData.Checked)
            {
                FilterRows();
            }
        }

        private void FilterRows(bool forceAllTrue = false)
        {
            DateTime selectedDate = dtFilterDate.Value.Date;

            foreach (DataGridViewRow row in dgvLembretes.Rows)
            {
                dgvLembretes.CurrentCell = null;
                if (forceAllTrue)
                {
                    row.Visible = true;
                }
                else
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value is DateTime)
                    {
                        DateTime.TryParse(row.Cells[0].Value.ToString(), out DateTime cellDateValue);
                        row.Visible = cellDateValue.Date == selectedDate.Date;
                    }
                }
            }
        }
    }
}