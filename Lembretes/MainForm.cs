using Lembretes.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lembretes
{
    public partial class MainForm : Form
    {
        private LembreteContext? dbContext;
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new LembreteContext();

            this.dbContext.Database.EnsureCreated();

            this.dbContext.Lembretes.Load();
            this.lembreteBindingSource.DataSource = dbContext.Lembretes.Local.ToBindingList();
            dtData.Value = DateTime.Now.AddDays(1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.lembreteBindingSource.RemoveCurrent();
            this.dbContext!.SaveChanges();
        }
    }
}