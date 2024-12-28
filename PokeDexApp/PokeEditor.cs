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
        public int HPEV, ATKEV, SPATKEV, DEFEV, SPDEFEV, SPDEV,
            baseHP, baseATK, baseSPATK, baseDEF, baseSPDEF, baseSPD;
        private int[] inputedHPValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedATKValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedSPATKValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedDEFValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedSPDEFValues = new int[4] { 0, 0, 0, 0 };
        private int[] inpputedSPDValues = new int[4] { 0, 0, 0, 0 };



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
            lblHP.Text = baseHP.ToString();
            lblATK.Text = baseATK.ToString();
            lblSPATK.Text = baseSPATK.ToString();
            lblDEF.Text = baseDEF.ToString();
            lblSPDEF.Text = baseSPDEF.ToString();
            lblSPD.Text = baseSPD.ToString();
            txtTotalEv.Text = totalEv.ToString();
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.pokemon.baseStats).ToString();
        }

        private int ValidateEVEntry(TextBox textChanged, int atributeEV)
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

        private string CalculateStatByEV(string statText, int ev=0, int[] inputedValues=null, string nature ="")
        {
            int current = int.Parse(statText);
            int evToAdd = (int)ev / 4;
            InputQueue(inputedValues, evToAdd);
            int newTotal = current + inputedValues[2];
            newTotal -= inputedValues[3];
            return newTotal.ToString();
        }

        private void InputQueue(int[] inputArray, int newValue, string type = "")
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

        private void UpdateTextChangedEV(int atributeEV, TextBox inputText, Label statText, int[] inputedValues)
        {
            atributeEV = ValidateEVEntry(inputText, atributeEV);
            InputQueue(inputedValues, atributeEV, "ev");
            totalEv -= inputedValues[0];
            totalEv += inputedValues[1];
            txtTotalEv.Text = totalEv.ToString();
            statText.Text = CalculateStatByEV(statText.Text, atributeEV, inputedValues);
        }

        private void UpdateAllStatsByEv()
        {
            UpdateTextChangedEV(HPEV, txtHPEV, lblHP, inputedHPValues);
            UpdateTextChangedEV(ATKEV, txtATKEV, lblATK, inpputedATKValues);
            UpdateTextChangedEV(SPATKEV, txtSPATKEV, lblSPATK, inpputedSPATKValues);
            UpdateTextChangedEV(DEFEV, txtDEFEV, lblDEF, inpputedDEFValues);
            UpdateTextChangedEV(SPDEFEV, txtSPDEFEV, lblSPDEF, inpputedSPDEFValues);
            UpdateTextChangedEV(SPDEV, txtSPDEV, lblSPD, inpputedSPDValues);
        }

        private void txtHPEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(HPEV, txtHPEV, lblHP, inputedHPValues);
        }
  

        private void txtATKEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(ATKEV, txtATKEV, lblATK, inpputedATKValues);
        }

        private void txtSPATKEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(SPATKEV, txtSPATKEV, lblSPATK, inpputedSPATKValues);
        }

        private void txtDEFEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(DEFEV, txtDEFEV, lblDEF, inpputedDEFValues);
        }

        private void txtSPDEFEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(SPDEFEV, txtSPDEFEV, lblSPDEF, inpputedSPDEFValues);
        }

        private void txtSPDEV_TextChanged(object sender, EventArgs e)
        {
            UpdateTextChangedEV(SPDEV, txtSPDEV, lblSPD, inpputedSPDValues);
        }

        private Label EnumerateStatsLabels(int statCode)
        {
            Label currentLabel;

            switch (statCode)
            {
                case 0:
                    currentLabel = null;
                    break;
                case 1:
                    currentLabel = lblHP;
                    break;
                case 2:
                    currentLabel = lblATK;
                    break;
                case 3:
                    currentLabel = lblSPATK;
                    break;
                case 4:
                    currentLabel = lblDEF;
                    break;
                case 5:
                    currentLabel = lblSPDEF;
                    break;
                case 6:
                    currentLabel = lblSPD;
                    break;
                default:
                    currentLabel = null;
                    break;
            }
            return currentLabel;
        }

        private int CalculateTenPercentage(int current)
        {
            return (int)(current * 0.1);
        }

        private void GetBaseStats()
        {
            baseHP= int.Parse(UserTeams.currentPoke.pokemon.baseStats[0]);
            baseATK = int.Parse(UserTeams.currentPoke.pokemon.baseStats[1]);
            baseSPATK = int.Parse(UserTeams.currentPoke.pokemon.baseStats[2]);
            baseDEF = int.Parse(UserTeams.currentPoke.pokemon.baseStats[3]);
            baseSPDEF = int.Parse(UserTeams.currentPoke.pokemon.baseStats[4]);
            baseSPD = int.Parse(UserTeams.currentPoke.pokemon.baseStats[5]);
        }

        private int EnumerateBaseStats(Label lbl)
        {
            int stat;
            string statName = lbl.Name;

            switch(statName)
            {
                case "lblHP":
                    stat = baseHP;
                    break;
                    
                case "lblATK":
                    stat = baseATK;
                    break;

                case "lblSPATK":
                    stat = baseSPATK;
                    break;

                case "lblDEF":
                    stat = baseDEF;
                    break;

                case "lblSPDEF":
                    stat = baseSPDEF;
                    break;

                case "lblSPD":
                    stat = baseSPD;
                    break;

                default:
                    stat = 0;
                    break;
            }
            return stat;
        }

        private void ChangeStatsNature(string nature)
        {
            
            Dictionary<string, int> statsToChange = Constructor.EnumerateNature(nature);
            Label strongStat = EnumerateStatsLabels(statsToChange["strong"]);
            Label weakStat = EnumerateStatsLabels(statsToChange["weak"]);
            GetBaseStats();
            if (strongStat != null && weakStat != null)
            {
                int strongStatValue = EnumerateBaseStats(strongStat);
                int weakStatValue = EnumerateBaseStats(weakStat);
                strongStat.Text = (strongStatValue + CalculateTenPercentage(strongStatValue).ToString());
                weakStat.Text = (weakStatValue + CalculateTenPercentage(weakStatValue).ToString());
            }

            else
            {
                GetBaseStats();
            }

            UpdateAllStatsByEv();
        }


        private void txtNature_SelectedIndexChanged(object sender, EventArgs e)
        {

            ChangeStatsNature(txtNature.Text);

        }
    }
}
