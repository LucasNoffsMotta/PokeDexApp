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
            ListNode pokeDex = PokeDex.dexStart;
            pokeDex = Constructor.SearchOnLinkedList(UserTeams.pokeOne.Rows[0]["name"].ToString(), pokeDex);
            lblName.Text = pokeDex.pokemon.name.ToString();
            lblNumber.Text = pokeDex.pokemon.id.ToString();
            lblTypeOne.Text = pokeDex.pokemon.typeOne.ToString();
            lblTypeTwo.Text = pokeDex.pokemon.typeTwo.ToString();
            pictureBox1.Image = pokeDex.pokemon.image;
            lblHP.Text = pokeDex.pokemon.baseStats[0];
            lblATK.Text = pokeDex.pokemon.baseStats[1];
            lblSPATK.Text = pokeDex.pokemon.baseStats[2];
            lblDEF.Text = pokeDex.pokemon.baseStats[3];
            lblSPDEF.Text = pokeDex.pokemon.baseStats[4];
            lblSPD.Text = pokeDex.pokemon.baseStats[5];
            lblTotal.Text = Constructor.GetTotalBaseStats(pokeDex.pokemon.baseStats).ToString();

        }
    }
}
