using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDexApp
{
    public partial class UserTeams : Form
    {
        public DBConnect conn = new DBConnect();
        public static DataTable pokeOne = new DataTable();
        public UserTeams()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {


        }

        private void btnTeamOne_Click(object sender, EventArgs e)
        {

        }

        private void btnPoke1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"Select * from User_Pokemons where user_id = {LogIn.userId};";
                pokeOne = conn.SQLCommand(query);

                if (pokeOne.Rows.Count > 0)
                {
                    this.Hide();
                    PokeEditor pokeEditor = new PokeEditor();
                    pokeEditor.Show();
                }

                else
                {
                    MessageBox.Show("Empy");
                }
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }
    }
}
