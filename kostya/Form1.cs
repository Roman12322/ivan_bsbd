using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.NetworkInformation;

namespace kostya
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                connection.Open();
                var phone = phone_box.Text;
                var passport = passport_box.Text;
                var status = status_box.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                if(status == "admin")
                {
                    string query = $"select id from admin where phone_number = '{phone}' and passport = '{passport}'";

                    SqlCommand command = new SqlCommand(query, connection);

                    adapter.SelectCommand = command;
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        var user = new user(id: Convert.ToInt32(dt.Rows[0].ItemArray[0]), status: "admin");
                        MessageBox.Show($"Вход произведен успешно от роли {user.status}");
                        this.Hide();
                        customer_form customer_form = new customer_form(user);
                        customer_form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Некорректно введен логин или пароль");
                    }
                }
                else if(status == "customer")
                {
                    string query = $"select id from customers where phone_number = '{phone}' and passport = '{passport}'";

                    SqlCommand command = new SqlCommand(query, connection);

                    adapter.SelectCommand = command;
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        var user = new user(id: Convert.ToInt32(dt.Rows[0].ItemArray[0]), status: "customer");
                        MessageBox.Show($"Вход произведен успешно от роли {user.status}");
                        this.Hide();
                        customer_form customer_form = new customer_form(user);
                        customer_form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Некорректно введен логин или пароль");
                    }
                }
                else
                {
                    MessageBox.Show("выберите статус входа");
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введен логин или пароль");
            }
        }
    }
}
