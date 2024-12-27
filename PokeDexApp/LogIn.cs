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

namespace PokeDexApp
{
    public partial class LogIn : Form
    {
        public DBConnect conn = new DBConnect();
        public static int userId;
        public static PokeDex dex;

        public LogIn()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable userTable = new DataTable();
            string query = $"Select * from Users where user_name = '{txtExistentUserName.Text}'";

            if (txtExistentUserName.Text != "")
            {
                try
                {
                    userTable = conn.SQLCommand(query);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }

            if (userTable.Rows.Count > 0)
            {
                if (userTable.Rows[0]["user_name"].ToString() == txtExistentUserName.Text)
                {
                    MessageBox.Show($"Bem vindo, {txtExistentUserName.Text}");
                    userId = (int)userTable.Rows[0]["user_id"];
                    this.Hide();
                    UserPage userPage = new UserPage();   
                    dex = new PokeDex();
                    dex.ConstructPages();
                    userPage.Show();
                }

                else
                {
                    MessageBox.Show("Nenhum usuario encontrado com este nome.");
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            DataTable userTable = new DataTable();
            if (txtNewUserName.Text != "")
            {
                try
                {
                    string query = $"Select user_name from Users where user_name = '{txtNewUserName.Text}'";
                    userTable = conn.SQLCommand(query);
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }

            if (userTable.Rows.Count > 0)
            {
                MessageBox.Show("Este nome ja existe. Crie um novo.");
            }

            else if (userTable.Rows.Count == 0)
            {
                try
                {
                    int affectedRows;
                    string insertQuery = $"Insert into Users(user_name) values(@txtNewUserName);";
                    SqlCommand command = new SqlCommand(insertQuery, conn.conn);
                    command.Parameters.AddWithValue("@txtNewUserName", txtNewUserName.Text);
                    affectedRows = conn.executeQuery(command);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Novo usario criado. Faca login com seu nome.");
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
