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
    public partial class PokeEditor : Form
    {
        public int totalEv = 510;
        private string nature;
        private DBConnect conn = new DBConnect();
        private Atribute hp, atk, spatk, def, spdef, spd;
        private Dictionary<string, string> natureDict =  new Dictionary<string, string>();


        public PokeEditor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTeams userTeams = new UserTeams();
            userTeams.Show();
        }

        private void PokeEditor_Load(object sender, EventArgs e)
        {
            lblName.Text = UserTeams.currentPoke.pokemon.name.ToString();
            lblNumber.Text = UserTeams.currentPoke.pokemon.id.ToString();
            lblTypeOne.Text = UserTeams.currentPoke.pokemon.typeOne.ToString();
            lblTypeTwo.Text = UserTeams.currentPoke.pokemon.typeTwo.ToString();
            pictureBox1.Image = UserTeams.currentPoke.pokemon.image;
            GetBaseStats();
            InitializeLabels();
            InitializeNatures();
            nature = "Bashful";
            txtNature.Text = nature;
            lblTotalEv.Text = totalEv.ToString();
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.pokemon.baseStats).ToString();
        }

        private void InitializeLabels()
        {
            lblHP.Text = hp.baseStat.ToString();
            lblATK.Text = atk.baseStat.ToString();
            lblSPATK.Text = spatk.baseStat.ToString();
            lblDEF.Text = def.baseStat.ToString();
            lblSPDEF.Text = spdef.baseStat.ToString();
            lblSPD.Text = spd.baseStat.ToString();
        }


        private void GetBaseStats()
        {
            hp = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[0]), "hp");
            atk = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[1]), "atk");
            spatk = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[2]), "spatk");
            def = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[3]), "def");
            spdef = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[4]), "spdef");
            spd = new Atribute(int.Parse(UserTeams.currentPoke.pokemon.baseStats[5]), "spd");
        }

        private void InitializeNatures()
        {
            natureDict["hp"] = "";
            natureDict["atk"] = "";
            natureDict["spatk"] = "";
            natureDict["def"] = "";
            natureDict["spdef"] = "";
            natureDict["spd"] = "";
        }

        private void CalculateTotalEv(int[] nums)
        {
            totalEv -= nums[0];
            totalEv += nums[1];
            lblTotalEv.Text = totalEv.ToString();
        }

        private void txtHPEV_TextChanged(object sender, EventArgs e)
        {
            hp.ev = hp.ValidateEVEntry(txtHPEV, totalEv);
            hp.ChangeEV();
            hp.InputQueue(hp.ev, "ev");
            CalculateTotalEv(hp.evTotalDecrease);
            lblHP.Text = hp.CalculateStat();
        }


        private void txtATKEV_TextChanged(object sender, EventArgs e)
        {
            atk.ev = atk.ValidateEVEntry(txtATKEV, totalEv);
            atk.ChangeEV();
            atk.InputQueue(atk.ev, "ev");
            CalculateTotalEv(atk.evTotalDecrease);
            lblATK.Text = atk.CalculateStat();
        }

        private void txtSPATKEV_TextChanged(object sender, EventArgs e)
        {
            spatk.ev = spatk.ValidateEVEntry(txtSPATKEV, totalEv);
            spatk.ChangeEV();
            spatk.InputQueue(spatk.ev, "ev");
            CalculateTotalEv(spatk.evTotalDecrease);
            lblSPATK.Text = spatk.CalculateStat();
        }

        private void txtDEFEV_TextChanged(object sender, EventArgs e)
        {
            def.ev = def.ValidateEVEntry(txtDEFEV, totalEv);
            def.ChangeEV();
            def.InputQueue(def.ev, "ev");
            CalculateTotalEv(def.evTotalDecrease);
            lblDEF.Text = def.CalculateStat();
        }

        private void txtSPDEFEV_TextChanged(object sender, EventArgs e)
        {
            spdef.ev = def.ValidateEVEntry(txtSPDEFEV, totalEv);
            spdef.ChangeEV();
            spdef.InputQueue(spdef.ev, "ev");
            CalculateTotalEv(spdef.evTotalDecrease);
            lblSPDEF.Text = spdef.CalculateStat();


        }

        private void txtSPDEV_TextChanged(object sender, EventArgs e)
        {
            spd.ev = spd.ValidateEVEntry(txtSPDEV, totalEv);
            spd.ChangeEV();
            spd.InputQueue(spd.ev, "ev");
            CalculateTotalEv(spd.evTotalDecrease);
            lblSPD.Text = spd.CalculateStat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int poke_id = UserTeams.poke_key_id;
                string query = $"Delete from User_Pokemons where id_key = {poke_id}";
                SqlCommand deleteQuery = new SqlCommand(query);
                int deletedRows = conn.executeQuery(deleteQuery);
                UserTeams userTeams = new UserTeams();
                this.Close();
                userTeams.Show();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtNature_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nature = txtNature.Text;
            InitializeNatures();
            Constructor.EnumerateNature(nature, natureDict);
            hp.ChangeNature(natureDict["hp"]);
            atk.ChangeNature(natureDict["atk"]);
            spatk.ChangeNature(natureDict["spatk"]);
            def.ChangeNature(natureDict["def"]);
            spdef.ChangeNature(natureDict["spdef"]);
            spd.ChangeNature(natureDict["spd"]);
            lblHP.Text = hp.CalculateStat();
            lblATK.Text = atk.CalculateStat();
            lblSPATK.Text = spatk.CalculateStat();
            lblDEF.Text = def.CalculateStat();
            lblSPDEF.Text = spdef.CalculateStat();
            lblSPD.Text = spd.CalculateStat();
        }
    }
}
