using System.Data;

namespace PokeDexApp
{
    public partial class PokeDex : Form
    {
        public DataTable pokeTable = new DataTable();
        public DataTable typeTable = new DataTable();
        public DBConnect conn = new DBConnect();
        public ListNode dexList = new ListNode();
        public ListNode dexStart = new ListNode();

        public PokeDex()
        {
            InitializeComponent();
        }

        public void ConstructPages()
        {
            try
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
            ListNode searchNodeOne = dexStart;
            ListNode searchNodeTwo = dexStart;
            string search = txtSearch.Text;

            if (search != dexStart.pokemon.name)
            {
                while (searchNodeOne.pokemon != null || searchNodeTwo.pokemon != null)
                {
                    if (searchNodeOne.pokemon.name == search)
                    {
                        dexStart = searchNodeOne;
                        break;
                    }

                    if (searchNodeTwo.pokemon.name == search)
                    {
                        dexStart = searchNodeTwo;
                        break;
                    }

                    if (searchNodeOne.next.pokemon != null)
                    {
                        searchNodeOne = searchNodeOne.next;
                    }

                    if (searchNodeTwo.prev.pokemon != null)
                    {
                        searchNodeTwo = searchNodeTwo.prev;
                    }
                }

                UpdatePage();
            }



        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }
    }
}
