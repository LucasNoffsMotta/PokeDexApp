using System.Data;

namespace PokeDexApp
{
    public partial class Form1 : Form
    {
        public DataTable pokeTable = new DataTable();
        public DataTable typeTable = new DataTable();
        public DBConnect conn = new DBConnect();
        public ListNode dexList = new ListNode();
        public ListNode dexStart = new ListNode();


        public Form1()
        {
            InitializeComponent();
        }

        public void ConstructPages()
        {
            try
            {
                string selectAllQuery = "Select id_poke, Name, id_type_one, id_type_two from Pokemon;";
                pokeTable = conn.SQLCommand(selectAllQuery);
                int pokedexSize = pokeTable.Rows.Count;
                dexList = new ListNode();
                dexStart = new ListNode();

                for (int i = 0; i <= pokedexSize - 1; i++)
                {
                    string[] dexData = new string[4];
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
    }
}
