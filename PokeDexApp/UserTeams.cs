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
        public static DataTable pokes = new DataTable();
        public static ListNode currentPoke = new ListNode();
        public static bool loaded = false;
        public static int poke_key_id = 0;
        public static int teamLimit = 10;

        public UserTeams()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.Hide();            
            LogIn.dex.Show();
        }

        private void btnTeamOne_Click(object sender, EventArgs e)
        {

        }

        private void btnPoke1_Click(object sender, EventArgs e)
        {


        }

        private void UserTeams_Load(object sender, EventArgs e)
        {
            try
            {
                if (!loaded)
                {
                    string query = $"Select * from User_Pokemons where user_id = {LogIn.userId};";
                    pokes = conn.SQLCommand(query);
                }

                Label[] pokeNames = new Label[] { lblName1, lblName2, lblName3, 
                    lblName4, lblName5, lblName6, lblName7,
                        lblName8, lblName9, lblName10};
                PictureBox[] pictures = new PictureBox[] { pictureBox1, pictureBox2, 
                    pictureBox3, pictureBox4, pictureBox5,
                        pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10};

                if (pokes.Rows.Count > 0)
                {
                    int teamSize = pokes.Rows.Count;

                    for (int i = 0; i < teamSize; i++)
                    {
                        pokeNames[i].Text = pokes.Rows[i]["name"].ToString();
                        ListNode currentPoke = Constructor.BinarySearch(PokeDex.linkedArray, Convert.ToInt32(pokes.Rows[i]["id_poke"]));
                        pictures[i].Image = currentPoke.pokemon.image;
                    }
                }

                else
                {
                    MessageBox.Show("Voce ainda nao adicionou nenhum pokemon");
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePage(int slotNumber)
        {
            try
            {
                poke_key_id = Convert.ToInt32(pokes.Rows[slotNumber - 1]["id_key"]);
                currentPoke = Constructor.BinarySearch(PokeDex.linkedArray, Convert.ToInt32(pokes.Rows[slotNumber - 1]["id_poke"]));
                this.Hide();
                PokeEditor editPage = new PokeEditor();
                editPage.Show();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnpokeOne_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void btnpokeTwo_Click(object sender, EventArgs e)
        {
            ChangePage(2);
        }

        private void btnpokeThree_Click(object sender, EventArgs e)
        {
            ChangePage(3);
        }

        private void btnpokeFour_Click(object sender, EventArgs e)
        {
            ChangePage(4);
        }

        private void btnpokeFive_Click(object sender, EventArgs e)
        {
            ChangePage(5);
        }

        private void btnpokeSix_Click(object sender, EventArgs e)
        {
            ChangePage(6);
        }

        private void btnpokeSeven_Click(object sender, EventArgs e)
        {
            ChangePage(7);
        }

        private void btnpokeEight_Click(object sender, EventArgs e)
        {
            ChangePage(8);
        }

        private void btnpokeNine_Click(object sender, EventArgs e)
        {
            ChangePage(9);
        }

        private void btnpokeTen_Click(object sender, EventArgs e)
        {
            ChangePage(10);
        }

        private void lblSlot_Click(object sender, EventArgs e)
        {

        }
    }
}
