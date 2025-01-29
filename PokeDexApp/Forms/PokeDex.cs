using PokeDexApp.Connection;
using PokeDexApp.FrondEnd;
using PokeDexApp.Utilities;
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
        public static ListNode[] linkedArray;
        // Cache font instead of recreating font objects each time we paint.
        private Font fnt = new Font("Arial", 10);
        private string[] atributes = new string[] {"HP", "Attack", "Defense", "Special Attack",
            "Special Defense", "Speed"};
        private int atributesIndex = 0;
        private Pokemon[] topHp = new Pokemon[5];
        private Pokemon[] topAtk = new Pokemon[5];
        private Pokemon[] topSpAtk = new Pokemon[5];
        private Pokemon[] topDef = new Pokemon[5];
        private Pokemon[] topSpDef = new Pokemon[5];
        private Pokemon[] topSpd = new Pokemon[5];

        public PokeDex()
        {
            InitializeComponent();
        }



        public void ConstructPages()
        {
            try
            {
                if (!loaded)
                {
                    MovesDataBase.FillDict();
                    string selectAllQuery = "Select id_poke, Name, id_type_one, id_type_two," +
                    " HP, ATK, SPATK, DEF, SPDEF, SPD  from Pokemon;";
                    pokeTable = conn.SQLCommand(selectAllQuery);
                    int pokedexSize = pokeTable.Rows.Count;
                    dexList = new ListNode();
                    dexStart = new ListNode();
                    linkedArray = new ListNode[pokedexSize];
                    atributesIndex = 0;


                    for (int i = 0; i < pokedexSize; i++)
                    {
                        string[] dexData = new string[10];
                        dexData = Constructor.ConstructDexData(dexData, pokeTable.Rows[i]);
                        dexList = Constructor.ConstructLinkedList(dexList, dexData);
                        linkedArray[i] = dexList;
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

        public void LoadTops(string atribute, Pokemon[] topArray)
        {
            string attributeSearch = atribute;
            string query = $"SELECT TOP (10) name, HP, ATK, SPATK, DEF, SPDEF, SPD FROM Pokemon ORDER BY {attributeSearch} DESC;";

            try
            {
                DataTable topPokes = new DataTable();
                topPokes = conn.SQLCommand(query);

                if (topPokes.Rows.Count > 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        topArray[i] = Constructor.SearchOnLinkedList(topPokes.Rows[i]["name"].ToString(), dexStart).pokemon;
                    }
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
            LoadTops("HP", topHp);
            LoadTops("ATK", topAtk);
            LoadTops("SPATK", topSpAtk);
            LoadTops("DEF", topDef);
            LoadTops("SPDEF", topSpDef);
            LoadTops("SPD", topSpd);
            lblCurrentTop.Text = atributes[atributesIndex];
            ConstructTopTable(FindRightArray(lblCurrentTop.Text));
            BackColor = ColorScheme.BackGroundColor(lblTypeOne.Text);
        }

        public void UpdateColors()
        {
            BackColor = ColorScheme.BackGroundColor(lblTypeOne.Text);
            ColorScheme.UpdateBtnColors(btnFirstTop, BackColor);
            ColorScheme.UpdateBtnColors(btnSecondTop, BackColor);
            ColorScheme.UpdateBtnColors(btnThirdTop, BackColor);
            ColorScheme.UpdateBtnColors(btnFourthTop, BackColor);

            ColorScheme.UpdateBtnColors(btnFifithTop, BackColor);
            ColorScheme.UpdateBtnColors(btnNext, BackColor);
            ColorScheme.UpdateBtnColors(btnPrev, BackColor);
            ColorScheme.UpdateBtnColors(btnAdd, BackColor);

            ColorScheme.UpdateBtnColors(btnMyPokes, BackColor);
            ColorScheme.UpdateBtnColors(btnLogOut, BackColor);
            ColorScheme.UpdateBtnColors(btnPrevTop, BackColor);
            ColorScheme.UpdateBtnColors(btnNextTop, BackColor);
            ColorScheme.UpdateTextColor(lblName, BackColor);


            ColorScheme.UpdateTextColor(lblTypeOne, ColorScheme.BackGroundColor(lblTypeOne.Text));

            if (lblTypeTwo.Text != "")
            {
                ColorScheme.UpdateTextColor(lblTypeTwo, ColorScheme.BackGroundColor(lblTypeTwo.Text));
            }
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
            UpdateColors();


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

        private bool CheckFullTeam()
        {
            DataTable userPokes = new DataTable();
            string query = $"Select * from User_Pokemons Where user_id = {userId};";
            userPokes = conn.SQLCommand(query);
            if (userPokes.Rows.Count > 9)
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckFullTeam())
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

            else
            {
                MessageBox.Show("Numero maximo de Pokemons no Time, libere algum slot");
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

        private void ConstructTopTable(Pokemon[] topArray)
        {
            btnFirstTop.Text = topArray[0].name.ToString();
            btnSecondTop.Text = topArray[1].name.ToString();
            btnThirdTop.Text = topArray[2].name.ToString();
            btnFourthTop.Text = topArray[3].name.ToString();
            btnFifithTop.Text = topArray[4].name.ToString();
        }

        private Pokemon[] FindRightArray(string atribute)
        {
            Pokemon[] current;

            switch (atribute)
            {
                case "HP":
                    current = topHp;
                    break;
                case "Attack":
                    current = topAtk;
                    break;
                case "Special Attack":
                    current = topSpAtk;
                    break;
                case "Defense":
                    current = topDef;
                    break;
                case "Special Defense":
                    current = topSpDef;
                    break;
                case "Speed":
                    current = topSpd;
                    break;
                default:
                    current = topHp;
                    break;
            }
            return current;
        }


        private void btnNextTop_Click(object sender, EventArgs e)
        {
            if (atributesIndex + 1 <= atributes.Length - 1)
            {
                atributesIndex++;
                lblCurrentTop.Text = atributes[atributesIndex];
                ConstructTopTable(FindRightArray(lblCurrentTop.Text));
            }
        }

        private void btnPrevTop_Click(object sender, EventArgs e)
        {
            if (atributesIndex - 1 >= 0)
            {
                atributesIndex--;
                lblCurrentTop.Text = atributes[atributesIndex];
                ConstructTopTable(FindRightArray(lblCurrentTop.Text));
            }
        }

        private void btnFirstTop_Click(object sender, EventArgs e)
        {
            dexStart = Constructor.SearchOnLinkedList(btnFirstTop.Text, dexStart);
            UpdatePage();
        }

        private void btnSecondTop_Click(object sender, EventArgs e)
        {
            dexStart = Constructor.SearchOnLinkedList(btnSecondTop.Text, dexStart);
            UpdatePage();
        }

        private void btnThirdTop_Click(object sender, EventArgs e)
        {
            dexStart = Constructor.SearchOnLinkedList(btnThirdTop.Text, dexStart);
            UpdatePage();
        }

        private void btnFourthTop_Click(object sender, EventArgs e)
        {
            dexStart = Constructor.SearchOnLinkedList(btnFourthTop.Text, dexStart);
            UpdatePage();
        }

        private void btnFifithTop_Click(object sender, EventArgs e)
        {
            dexStart = Constructor.SearchOnLinkedList(btnFifithTop.Text, dexStart);
            UpdatePage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PokeDex_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
