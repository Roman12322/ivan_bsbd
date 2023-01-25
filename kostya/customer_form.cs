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
    public partial class customer_form : Form
    {

        readonly user _user;
        private SqlConnection sql_connection = null;
        public customer_form(user user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void customer_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.FillBycustid(this.database1DataSet.customers, _user.id);

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Мархель Константин Валерьевич, 720-2, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void контрактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            contract_form contract_form = new contract_form(_user);
            contract_form.Show();
        }

        private void симкартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sim_form sim_form = new sim_form(_user);
            sim_form.Show();
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tarif_form tarif_form = new tarif_form(_user);
            tarif_form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
