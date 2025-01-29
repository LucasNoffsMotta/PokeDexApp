using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                poke.nature = Constructor.EnumerateNatureToString((int)dt.Rows[i]["id_nature"]);
                poke.level = (int)dt.Rows[i]["level"];
                poke.nickName = dt.Rows[i]["nickname"].ToString();
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

                poke.level = 1;
                poke.nickName = "";
            }
            return poke;
        }

        private void ClearLabels()
        {
            lblName1.Text = "";
            lblName2.Text = "";
            lblName3.Text = "";
            lblName4.Text = "";
            lblName5.Text = "";
            lblName6.Text = "";
            lblName7.Text = "";
            lblName8.Text = "";
            lblName9.Text = "";
            lblName10.Text = "";

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
        }

        private void UpdatePage()
        {
            try
            {
                if (!loaded)
                {
                    pokes.Clear();
                    string query = $"Select * from User_Pokemons where user_id = {LogIn.userId};";
                    pokes = conn.SQLCommand(query);
                }

                Label[] pokeNames = new Label[] { lblName1, lblName2, lblName3,
                    lblName4, lblName5, lblName6, lblName7,
                        lblName8, lblName9, lblName10};

                Label[] pokeNicks = new Label []{ lblNick1, lblNick2, lblNick3, lblNick4,
                    lblNick5, lblNick6, lblNick7, lblNick8,lblNick9, lblNick10};

                PictureBox[] pictures = new PictureBox[] { pictureBox1, pictureBox2,
                    pictureBox3, pictureBox4, pictureBox5,
                        pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10};


                if (pokes.Rows.Count > 0)
                {
                    int teamSize = pokes.Rows.Count;

                    for (int i = 0; i < teamSize; i++)
                    {
                        pokeNames[i].Text = pokes.Rows[i]["name"].ToString();
                        pokeNicks[i].Text = pokes.Rows[i]["nickname"].ToString();
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

        private void UserTeams_Load(object sender, EventArgs e)
        {
            UpdatePage();

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

        private Pokemon[] UpdatePokesArray(Pokemon[] teamPokes, int deletedIndex)
        {
            if (deletedIndex < teamPokes.Length - 1)
            {
                int count = deletedIndex;
                int lastIndex = teamPokes.Length - 1;

                while (count < teamPokes.Length - 1)
                {
                    teamPokes[count] = teamPokes[count + 1];
                    count++;
                }

                teamPokes[lastIndex] = null;
            }

            return teamPokes;
        }


        private void DeleteSlot(int slotNumber)
        {
            try
            {
                poke_key_id = Convert.ToInt32(pokes.Rows[slotNumber - 1]["id_key"]);
                string deleteQuery = $"Delete from User_Pokemons Where id_key = {poke_key_id};";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery);
                int affectedRows = conn.executeQuery(deleteCmd);



                if (affectedRows > 0)
                {
                    teamPokes = UpdatePokesArray(teamPokes, slotNumber - 1);
                    loaded = false;
                    ClearLabels();
                    UpdatePage();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void CopySlot(int slotNumber)
        {
            if (pokes.Rows.Count < teamLimit)
            {
                try
                {
                    Pokemon copiedPoke = teamPokes[slotNumber - 1];

                    string inserQuery = @"
                    INSERT INTO User_Pokemons 
                    (id_poke, name, id_type_one, id_type_two, id_move_one,
                    id_move_two,id_move_three, id_move_four,
                    id_nature,
                    HP, ATK, SPATK, DEF, SPDEF, SPD,
                    HP_EV, ATK_EV, SPATK_EV, DEF_EV, SPDEF_EV, SPD_EV,
                    HP_IV, ATK_IV, SPATK_IV, DEF_IV, SPDEF_IV, SPD_IV,
                    user_id,
                    level,
                    nickname) 

                    VALUES 
                    (@id, @name, @typeOne, @typeTwo,
                    @moveOne, @moveTwo,@moveThree, @moveFour,
                    @idNature,
                    @hp, @atk, @spatk, @def, @spdef, @spd,
                    @hpEv, @atkEv, @spAtkEv, @defEv, @spDefEv, @spdEv,
                    @hpIv, @atkIv, @spAtkIv, @defIv, @spDefIv, @spdIv,
                    @userId,
                    @level,
                    @nick);
                ";

                    SqlCommand insertCMD = new SqlCommand(inserQuery, conn.conn);

                    insertCMD.Parameters.AddWithValue("@id", copiedPoke.id);
                    insertCMD.Parameters.AddWithValue("@name", copiedPoke.name);
                    insertCMD.Parameters.AddWithValue("@typeOne", Constructor.EnumerateType(copiedPoke.typeOne));
                    insertCMD.Parameters.AddWithValue("@typeTwo", Constructor.EnumerateType(copiedPoke.typeTwo));
                    insertCMD.Parameters.AddWithValue("@moveOne", copiedPoke.idMoveOne);
                    insertCMD.Parameters.AddWithValue("@moveTwo", copiedPoke.idMoveTwo);
                    insertCMD.Parameters.AddWithValue("@moveThree", copiedPoke.idMoveThree);
                    insertCMD.Parameters.AddWithValue("@moveFour", copiedPoke.idMoveFour);

                    insertCMD.Parameters.AddWithValue("@idNature", pokes.Rows[slotNumber - 1]["id_nature"]);


                    insertCMD.Parameters.AddWithValue("@hp", pokes.Rows[slotNumber - 1]["HP"]);
                    insertCMD.Parameters.AddWithValue("@atk", pokes.Rows[slotNumber - 1]["ATK"]);
                    insertCMD.Parameters.AddWithValue("@spatk", pokes.Rows[slotNumber - 1]["SPATK"]);
                    insertCMD.Parameters.AddWithValue("@def", pokes.Rows[slotNumber - 1]["DEF"]);
                    insertCMD.Parameters.AddWithValue("@spdef", pokes.Rows[slotNumber - 1]["SPDEF"]);
                    insertCMD.Parameters.AddWithValue("@spd", pokes.Rows[slotNumber - 1]["SPD"]);

                    insertCMD.Parameters.AddWithValue("@hpEv", copiedPoke.HPEV);
                    insertCMD.Parameters.AddWithValue("@atkEv", copiedPoke.ATKEV);
                    insertCMD.Parameters.AddWithValue("@spAtkEv", copiedPoke.SPATKEV);
                    insertCMD.Parameters.AddWithValue("@defEv", copiedPoke.DEFEV);
                    insertCMD.Parameters.AddWithValue("@spDefEv", copiedPoke.SPDEFEV);
                    insertCMD.Parameters.AddWithValue("@spdEv", copiedPoke.SPDEV);

                    insertCMD.Parameters.AddWithValue("@hpIv", copiedPoke.HPIV);
                    insertCMD.Parameters.AddWithValue("@atkIv", copiedPoke.ATKIV);
                    insertCMD.Parameters.AddWithValue("@spAtkIv", copiedPoke.SPATKIV);
                    insertCMD.Parameters.AddWithValue("@defIv", copiedPoke.DEFIV);
                    insertCMD.Parameters.AddWithValue("@spDefIv", copiedPoke.SPDEFIV);
                    insertCMD.Parameters.AddWithValue("@spdIv", copiedPoke.SPDIV);

                    insertCMD.Parameters.AddWithValue("@level", copiedPoke.level);
                    insertCMD.Parameters.AddWithValue("@nick", copiedPoke.nickName);
                    insertCMD.Parameters.AddWithValue("@userId", pokes.Rows[slotNumber - 1]["user_id"]);

                    int affectedRow = conn.executeQuery(insertCMD);

                    if (affectedRow > 0)
                    {
                        ClearLabels();
                        UpdatePage();
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Nao ha espaco disponivel, libere um slot.");
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopySlot(1);
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            CopySlot(2);
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DeleteSlot(2);
        }

        private void btnCopy3_Click(object sender, EventArgs e)
        {
            CopySlot(3);
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            DeleteSlot(3);
        }

        private void btnCopy4_Click(object sender, EventArgs e)
        {
            CopySlot(4);
        }

        private void btnDelete5_Click(object sender, EventArgs e)
        {
            DeleteSlot(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CopySlot(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteSlot(5);
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DeleteSlot(1);
        }

        private void btnDelete6_Click(object sender, EventArgs e)
        {
            DeleteSlot(6);
        }

        private void btnDelete7_Click(object sender, EventArgs e)
        {
            DeleteSlot(7);
        }

        private void btnDelete8_Click(object sender, EventArgs e)
        {
            DeleteSlot(8);
        }

        private void btnDelete9_Click(object sender, EventArgs e)
        {
            DeleteSlot(9);
        }

        private void btnDelete10_Click(object sender, EventArgs e)
        {
            DeleteSlot(10);
        }

        private void btnCopy6_Click(object sender, EventArgs e)
        {
            CopySlot(6);
        }

        private void btnCopy7_Click(object sender, EventArgs e)
        {
            CopySlot(7);
        }

        private void btnCopy8_Click(object sender, EventArgs e)
        {
            CopySlot(8);
        }

        private void btnCopy9_Click(object sender, EventArgs e)
        {
            CopySlot(9);
        }

        private void btnCopy10_Click(object sender, EventArgs e)
        {
            CopySlot(10);
        }

        private void lblNick1_Click(object sender, EventArgs e)
        {

        }
    }
}
