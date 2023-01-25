using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostya
{
    public partial class contract_form : Form
    {
        readonly user _user;
        private SqlConnection sql_connection = null;
        public contract_form(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void contract_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.FillBycustid(this.database1DataSet.contract, _user.id);

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Мархель Константин Валерьевич, 720-2, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void симкартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sim_form sim_form = new sim_form(_user);
            sim_form.Show();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_form customer_form = new customer_form(_user);
            customer_form.Show();
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tarif_form tarif_form = new tarif_form(_user);
            tarif_form.Show();
        }
    }
}
