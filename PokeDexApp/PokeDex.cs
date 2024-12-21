using System.Data;
using System.Data.SqlClient;

namespace PokeDexApp
{
    public partial class PokeDex : Form
    {
        public DataTable pokeTable = new DataTable();
        public DataTable typeTable = new DataTable();
        public DBConnect conn = new DBConnect();
        public ListNode dexList = new ListNode();
        public static ListNode dexStart = new ListNode();
        public int userId = LogIn.userId;
        public static bool loaded = false;

        public PokeDex()
        {
            InitializeComponent();
        }

        public void ConstructPages()
        {
            try
            {
                if(!loaded)
                {
                    string selectAllQuery = "Select id_poke, Name, id_type_one, id_type_two," +
                    " HP, ATK, SPATK, DEF, SPDEF, SPD  from Pokemon;";
                    pokeTable = conn.SQLCommand(selectAllQuery);
                    int pokedexSize = pokeTable.Rows.Count;
                    dexList = new ListNode();
                    dexStart = new ListNode();


                    for (int i = 0; i <= pokedexSize - 1; i++)
                    {
                        string[] dexData = new string[10];
                        dexData = Constructor.ConstructDexData(dexData, pokeTable.Rows[i]);
                        dexList = Constructor.ConstructLinkedList(dexList, dexData);
                        if (i == 0)
                        {
                            dexStart = dexList;
                            dexStart.prev = new ListNode();
                        }
                        ListNode temp = dexList;
                        dexList.next = new ListNode();
                        dexList = dexList.next;
                        dexList.prev = temp;
                    }
                    UpdatePage();
                    loaded = true;
                }
                else
                {
                    UpdatePage();
                }
                
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConstructPages();
        }

        private void lblTypeOne_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        public void UpdatePage()
        {
            lblName.Text = dexStart.pokemon.name.ToString();
            lblNumber.Text = dexStart.pokemon.id.ToString();
            lblTypeOne.Text = dexStart.pokemon.typeOne.ToString();
            lblTypeTwo.Text = dexStart.pokemon.typeTwo.ToString();
            pictureBox1.Image = dexStart.pokemon.image;
            lblHP.Text = dexStart.pokemon.baseStats[0];
            lblATK.Text = dexStart.pokemon.baseStats[1];
            lblSPATK.Text = dexStart.pokemon.baseStats[2];
            lblDEF.Text = dexStart.pokemon.baseStats[3];
            lblSPDEF.Text = dexStart.pokemon.baseStats[4];
            lblSPD.Text = dexStart.pokemon.baseStats[5];
            lblTotal.Text = Constructor.GetTotalBaseStats(dexStart.pokemon.baseStats).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dexStart.next.pokemon != null)
            {
                dexStart = dexStart.next;
                UpdatePage();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dexStart.prev.pokemon != null)
            {
                dexStart = dexStart.prev;
                UpdatePage();
            }


        }

        private void pctBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             dexStart = Constructor.SearchOnLinkedList(txtSearch.Text, dexStart);
             UpdatePage();         
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int[] baseStats = Constructor.ParseArray(dexStart.pokemon.baseStats);
                int insertedPokemon;

                string query = @"
                    INSERT INTO User_Pokemons 
                    (id_poke, name, id_type_one, id_type_two, HP, ATK, SPATK, DEF, SPDEF, SPD, user_id) 
                    VALUES 
                    (@id, @name, @typeOne, @typeTwo, @hp, @atk, @spatk, @def, @spdef, @spd, @userId);
                ";

                SqlCommand insertPokemon = new SqlCommand(query, conn.conn);
                int typeOne = Constructor.EnumerateType(dexStart.pokemon.typeOne);
                int typeTwo = Constructor.EnumerateType(dexStart.pokemon.typeTwo);

                insertPokemon.Parameters.AddWithValue("@id", dexStart.pokemon.id);
                insertPokemon.Parameters.AddWithValue("@name", dexStart.pokemon.name);
                insertPokemon.Parameters.AddWithValue("@typeOne", typeOne);
                insertPokemon.Parameters.AddWithValue("@typeTwo", typeTwo);
                insertPokemon.Parameters.AddWithValue("@hp", baseStats[0]);
                insertPokemon.Parameters.AddWithValue("@atk", baseStats[1]);
                insertPokemon.Parameters.AddWithValue("@spatk", baseStats[2]);
                insertPokemon.Parameters.AddWithValue("@def", baseStats[3]);
                insertPokemon.Parameters.AddWithValue("@spdef", baseStats[4]);
                insertPokemon.Parameters.AddWithValue("@spd", baseStats[5]);
                insertPokemon.Parameters.AddWithValue("@userId", userId);


                insertedPokemon = conn.executeQuery(insertPokemon);

                if (insertedPokemon > 0)
                {
                    MessageBox.Show("Pokemon Inserido com sucesso!");
                }
            }

            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        private void lblHP_Click(object sender, EventArgs e)
        {

        }

        private void btnMyPokes_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTeams userTeams = new UserTeams();
            userTeams.Show();
        }
    }
}
