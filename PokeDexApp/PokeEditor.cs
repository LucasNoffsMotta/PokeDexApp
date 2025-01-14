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
        private int poke_id;
        private string nature;
        private DBConnect conn = new DBConnect();
        private Atribute hp, atk, spatk, def, spdef, spd;
        private Dictionary<string, string> natureDict = new Dictionary<string, string>();


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
            poke_id = UserTeams.poke_key_id;
            lblName.Text = UserTeams.currentPoke.pokemon.name.ToString();
            lblNumber.Text = UserTeams.currentPoke.pokemon.id.ToString();
            lblTypeOne.Text = UserTeams.currentPoke.pokemon.typeOne.ToString();
            lblTypeTwo.Text = UserTeams.currentPoke.pokemon.typeTwo.ToString();
            pictureBox1.Image = UserTeams.currentPoke.pokemon.image;
            GetBaseStats();
            InitializeEmptyFields();
            InitializeLabels();
            InitializeNatures();
            txtLevel.Text = 50.ToString();
            nature = "Bashful";
            txtNature.Text = nature;
            lblTotalEv.Text = totalEv.ToString();
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.pokemon.baseStats).ToString();
        }

        private void InitializeEmptyFields()
        {
            //Load ev and iv saved on the database
            txtHPEV.Text = UserTeams.currentPoke.pokemon.HPEV.ToString();
            txtATKEV.Text = UserTeams.currentPoke.pokemon.ATKEV.ToString();
            txtSPATKEV.Text = UserTeams.currentPoke.pokemon.SPATKEV.ToString();
            txtDEFEV.Text = UserTeams.currentPoke.pokemon.DEFEV.ToString();
            txtSPDEFEV.Text = UserTeams.currentPoke.pokemon.SPDEFEV.ToString();
            txtSPDEV.Text = UserTeams.currentPoke.pokemon.DEFEV.ToString();


            txtHPIV.Text = UserTeams.currentPoke.pokemon.HPIV.ToString();
            txtATKIV.Text = UserTeams.currentPoke.pokemon.ATKIV.ToString();
            txtSPATKIV.Text = UserTeams.currentPoke.pokemon.SPATKIV.ToString();
            txtDEFIV.Text = UserTeams.currentPoke.pokemon.DEFIV.ToString();
            txtSPDEFIV.Text = UserTeams.currentPoke.pokemon.SPDEFIV.ToString();
            txtSPDIV.Text = UserTeams.currentPoke.pokemon.SPDIV.ToString();
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

        private void txtHPIV_TextChanged(object sender, EventArgs e)
        {
            hp.iv = hp.ValidateIVEntry(txtHPIV);
            hp.ChangeIV();
            lblHP.Text = hp.CalculateStat();

        }

        private void txtATKIV_TextChanged(object sender, EventArgs e)
        {
            atk.iv = atk.ValidateIVEntry(txtATKIV);
            atk.ChangeIV();
            lblATK.Text = atk.CalculateStat();
        }

        private void txtSPATKIV_TextChanged(object sender, EventArgs e)
        {
            spatk.iv = spatk.ValidateIVEntry(txtSPATKIV);
            spatk.ChangeIV();
            lblSPATK.Text = spatk.CalculateStat();

        }

        private void txtDEFIV_TextChanged(object sender, EventArgs e)
        {
            def.iv = def.ValidateIVEntry(txtDEFIV);
            def.ChangeIV();
            lblDEF.Text = def.CalculateStat();

        }

        private void txtSPDEFIV_TextChanged(object sender, EventArgs e)
        {
            spdef.iv = spdef.ValidateIVEntry(txtSPDEFIV);
            spdef.ChangeIV();
            lblSPDEF.Text = spdef.CalculateStat();
        }

        private void txtSPDIV_TextChanged(object sender, EventArgs e)
        {
            spd.iv = spd.ValidateIVEntry(txtSPDIV);
            spd.ChangeIV();
            lblSPD.Text = spd.CalculateStat();
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            hp.ValidateLevelEntry(txtLevel);
            lblHP.Text = hp.CalculateStat();

            atk.ValidateLevelEntry(txtLevel);
            lblATK.Text = atk.CalculateStat();

            spatk.ValidateLevelEntry(txtLevel);
            lblSPATK.Text = spatk.CalculateStat();

            def.ValidateLevelEntry(txtLevel);
            lblDEF.Text = def.CalculateStat();

            spdef.ValidateLevelEntry(txtLevel);
            lblSPDEF.Text = spdef.CalculateStat();

            spd.ValidateLevelEntry(txtLevel);
            lblSPD.Text = spd.CalculateStat();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update User_Pokemons" +
                    " SET " +
                    "HP_EV = @txtHPEV, " +
                    "ATK_EV = @txtATKEV, SPATK_EV = @txtSPATKEV, DEF_EV = @txtDEFEV, " +
                    "SPDEF_EV = @txtSPDEFEV," +
                    "SPD_EV = @txtSPDEV, HP_IV = @txtHPIV, ATK_IV = @txtATKIV , " +
                    "SPATK_IV = @txtSPATKIV, DEF_IV = @txtDEFIV, SPDEF_IV = @txtSPDEFIV, SPD_IV= @txtSPDIV" +
                    $" WHERE id_key = {poke_id};";

                SqlCommand updateComand = new SqlCommand(query);
                updateComand.Parameters.AddWithValue("@txtHPEV", txtHPEV.Text);
                updateComand.Parameters.AddWithValue("@txtATKEV", txtATKEV.Text);
                updateComand.Parameters.AddWithValue("@txtSPATKEV", txtSPATKEV.Text);
                updateComand.Parameters.AddWithValue("@txtDEFEV", txtDEFEV.Text);
                updateComand.Parameters.AddWithValue("@txtSPDEFEV", txtSPDEFEV.Text);
                updateComand.Parameters.AddWithValue("@txtSPDEV", txtSPDEV.Text);

                updateComand.Parameters.AddWithValue("@txtHPIV", txtHPIV.Text);
                updateComand.Parameters.AddWithValue("@txtATKIV", txtATKIV.Text);
                updateComand.Parameters.AddWithValue("@txtSPATKIV", txtSPATKIV.Text);
                updateComand.Parameters.AddWithValue("@txtDEFIV", txtDEFIV.Text);
                updateComand.Parameters.AddWithValue("@txtSPDEFIV", txtSPDEFIV.Text);
                updateComand.Parameters.AddWithValue("@txtSPDIV", txtSPDIV.Text);
                int affectedRow = conn.executeQuery(updateComand);


                if (affectedRow > 0)
                {
                    MessageBox.Show("Saved on database");
                }
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
