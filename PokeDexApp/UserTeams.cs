using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDexApp
{
    public partial class UserTeams : Form
    {
        public DBConnect conn = new DBConnect();
        public static DataTable pokes = new DataTable();
        public static ListNode currentNode = new ListNode();
        public static Pokemon currentPoke;
        public static bool loaded = false;
        public static int poke_key_id = 0;
        public static int teamLimit = 10;
        public static Pokemon[] teamPokes = new Pokemon[teamLimit]; 

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

        private Pokemon LoadEditedData(ListNode currentNode, DataTable dt, int i)
        {


            Pokemon poke = new Pokemon(currentNode.pokemon.name, currentNode.pokemon.id,
                currentNode.pokemon.typeOne, currentNode.pokemon.typeTwo, currentNode.pokemon.image,
                currentNode.pokemon.baseStats);

            try
            {
                poke.HPEV = (int)dt.Rows[i]["HP_EV"];
                poke.ATKEV = (int)dt.Rows[i]["ATK_EV"];
                poke.SPATKEV = (int)dt.Rows[i]["SPATK_EV"];
                poke.DEFEV = (int)dt.Rows[i]["DEF_EV"];
                poke.SPDEFEV = (int)dt.Rows[i]["SPDEF_EV"];
                poke.SPDEV = (int)dt.Rows[i]["SPD_EV"];

                poke.HPIV = (int)dt.Rows[i]["HP_IV"];
                poke.ATKIV = (int)dt.Rows[i]["ATK_IV"];
                poke.SPATKIV = (int)dt.Rows[i]["SPATK_IV"];
                poke.DEFIV = (int)dt.Rows[i]["DEF_IV"];
                poke.SPDEFIV = (int)dt.Rows[i]["SPDEF_IV"];
                poke.SPDIV = (int)dt.Rows[i]["SPD_IV"];

                poke.idMoveOne = (int)dt.Rows[i]["id_move_one"];
                poke.idMoveTwo = (int)dt.Rows[i]["id_move_two"];
                poke.idMoveThree = (int)dt.Rows[i]["id_move_three"];
                poke.idMoveFour = (int)dt.Rows[i]["id_move_four"];
            }
  
            catch
            {
                poke.HPEV = 0;
                poke.ATKEV = 0;
                poke.SPATKEV = 0;
                poke.DEFEV = 0;
                poke.SPDEFEV = 0;
                poke.SPDEV = 0;

                poke.HPIV = 0;
                poke.ATKIV = 0;
                poke.SPATKIV = 0;
                poke.DEFIV = 0;
                poke.SPDEFIV = 0;
                poke.SPDIV = 0;
            }

            return poke;
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
                        ListNode currentNode = Constructor.BinarySearch(PokeDex.linkedArray, Convert.ToInt32(pokes.Rows[i]["id_poke"]));
                        currentPoke = LoadEditedData(currentNode, pokes, i);
                        pictures[i].Image = currentPoke.image;
                        teamPokes[i] = currentPoke;
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
                //currentPoke = Constructor.BinarySearch(PokeDex.linkedArray, Convert.ToInt32(pokes.Rows[slotNumber - 1]["id_poke"]));
                currentPoke = teamPokes[slotNumber - 1];
                this.Hide();
                PokeEditor editPage = new PokeEditor();
                editPage.Show();
            }

            catch 
            {
                MessageBox.Show("Adicione um Pokemon a este slot para editar.");
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
