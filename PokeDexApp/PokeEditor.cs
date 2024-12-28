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
    public partial class PokeEditor : Form
    {
        public int totalEv = 510;
        public int maxEvPerAtribute = 255;
        public int increaseStatRate = 4;
        public int HPEV, ATKEV, SPATKEV, DEFEV, SPDEFEV, SPDEV;
        private int[] inputedHPValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedATKValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedSPATKValues = new int[4] { 0, 0, 0 ,0 };
        private int[] inpputedDEFValues = new int[4] {0, 0, 0, 0 };
        private int[] inpputedSPDEFValues = new int[4] {0, 0, 0, 0 };
        private int[] inpputedSPDValues = new int[4] {0, 0, 0, 0 };




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
            lblHP.Text = UserTeams.currentPoke.pokemon.baseStats[0];
            lblATK.Text = UserTeams.currentPoke.pokemon.baseStats[1];
            lblSPATK.Text = UserTeams.currentPoke.pokemon.baseStats[2];
            lblDEF.Text = UserTeams.currentPoke.pokemon.baseStats[3];
            lblSPDEF.Text = UserTeams.currentPoke.pokemon.baseStats[4];
            lblSPD.Text = UserTeams.currentPoke.pokemon.baseStats[5];
            txtTotalEv.Text = totalEv.ToString();
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.pokemon.baseStats).ToString();
        }

        private int ValidateEntry(TextBox textChanged, int atributeEV)
        {
            try
            {
                atributeEV = int.Parse(textChanged.Text);
            }

            catch (Exception ex)
            {
                atributeEV = 0;
            }
          
            if (atributeEV > maxEvPerAtribute)
            {
                MessageBox.Show("Max EV per atribute: 255");
                atributeEV = 0;
            }

            else if (atributeEV < 0)
            {
                MessageBox.Show("Type a number greater than 0");
                atributeEV = 0;
            }

            else
            {
                if ((totalEv - atributeEV) > 0)
                {
                    return atributeEV;
                }
            }
            return atributeEV;
        }

        private string CalculateStat(string statText, int ev, int[] inputedValues)
        {
            int current = int.Parse(statText);
            int evToAdd = (int)ev / 4;
            InputQueue(inputedValues, evToAdd);
            int newTotal = current + inputedValues[2];
            newTotal -= inputedValues[3];
            return newTotal.ToString();
        }

        private void InputQueue(int[] inputArray, int newValue, string type="")
        {
            if (type == "ev")
            {
                inputArray[1] = inputArray[0];
                inputArray[0] = newValue;
            }

            else
            {
                inputArray[3] = inputArray[2];
                inputArray[2] = newValue;
            }       
        }

        private void UpdateTextChangedEntry(int atributeEV, TextBox inputText, Label statText, int[] inputedValues)
        {
            atributeEV = ValidateEntry(inputText, atributeEV);
            InputQueue(inputedValues, atributeEV, "ev");
            totalEv -= inputedValues[0];
            totalEv += inputedValues[1];
            txtTotalEv.Text = totalEv.ToString();
            statText.Text = CalculateStat(statText.Text, atributeEV, inputedValues);
        }

        private void txtHPEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(HPEV, txtHPEV, lblHP, inputedHPValues);
        }

        private void txtATKEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(ATKEV, txtATKEV, lblATK, inpputedATKValues);
        }

        private void txtSPATKEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(SPATKEV, txtSPATKEV, lblSPATK, inpputedSPATKValues);
        }

        private void txtDEFEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(DEFEV, txtDEFEV, lblDEF, inpputedDEFValues);
        }

        private void txtSPDEFEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(SPDEV, txtSPDEFEV, lblSPDEF, inpputedSPDEFValues);
        }

        private void txtSPDEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEntry(SPDEV, txtSPDEV, lblSPD, inpputedSPDValues);
        }
    }
}
