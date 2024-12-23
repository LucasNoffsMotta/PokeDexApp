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
        public PokeEditor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPage userPage = new UserPage();
            userPage.Show();
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
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.pokemon.baseStats).ToString();

        }
    }
}
