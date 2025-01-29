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
        private DataTable moves = new DataTable();
        private DBConnect conn = new DBConnect();
        private Atribute hp, atk, spatk, def, spdef, spd;
        private Dictionary<string, string> natureDict = new Dictionary<string, string>();
        private DataRow currentMoveOne, currentMoveTwo, currentMoveThree, currentMoveFour;

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
            lblName.Text = UserTeams.currentPoke.name.ToString();
            lblNumber.Text = UserTeams.currentPoke.id.ToString();
            lblTypeOne.Text = UserTeams.currentPoke.typeOne.ToString();
            lblTypeTwo.Text = UserTeams.currentPoke.typeTwo.ToString();
            pictureBox1.Image = UserTeams.currentPoke.image;
        
            GetMovesData();
            InitializeMoveslist();
            GetBaseStats();
            InitializeEmptyFields();
            InitializeLabels();
            InitializeNatures();
            txtNature.Text = UserTeams.currentPoke.nature.ToString();
            lblTotalEv.Text = totalEv.ToString();
            lblTotal.Text = Constructor.GetTotalBaseStats(UserTeams.currentPoke.baseStats).ToString();
            UpdateColors();
        }

        private void UpdateColors()
        {
            BackColor = ColorScheme.BackGroundColor(UserTeams.currentPoke.typeOne.ToString());
            ColorScheme.UpdateBtnColors(btnBack, BackColor);
            ColorScheme.UpdateBtnColors(btnDelete, BackColor);
            ColorScheme.UpdateBtnColors(btnSave, BackColor);
            ColorScheme.UpdateTextColor(lblName, BackColor);

            try
            {
                ColorScheme.UpdateTextColor(lblType1, ColorScheme.BackGroundColor(lblType1.Text));
                ColorScheme.UpdateTextColor(lblType2, ColorScheme.BackGroundColor(lblType2.Text));
                ColorScheme.UpdateTextColor(lblType3, ColorScheme.BackGroundColor(lblType1.Text));
                ColorScheme.UpdateTextColor(lblType4, ColorScheme.BackGroundColor(lblType2.Text));
                ColorScheme.UpdateTextColor(lblTypeOne, ColorScheme.BackGroundColor(lblTypeOne.Text));
                ColorScheme.UpdateTextColor(lblTypeTwo, ColorScheme.BackGroundColor(lblTypeTwo.Text));
            }

            catch
            {
                ColorScheme.UpdateTextColor(lblTypeOne, ColorScheme.BackGroundColor(lblTypeOne.Text));
                ColorScheme.UpdateTextColor(lblTypeTwo, ColorScheme.BackGroundColor(lblTypeTwo.Text));
            }
            
         
        }

        private void GetMovesData()
        {
            moves = conn.SQLCommand("Select * from Moves where id_move = 1");
            moves.Clear();

            try
            {
                for (int i = 0; i < UserTeams.currentPoke.moveSet.Length; i++)
                {
                    string selectQuery = $"Select * from Moves where id_move = {UserTeams.currentPoke.moveSet[i]};";
                    DataTable temp = conn.SQLCommand(selectQuery);
                    DataRow tempRow = temp.Rows[0];
                    moves.ImportRow(tempRow);
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int GetMovesId(string name)
        {
            int id = 1;

            for (int i = 0; i < moves.Rows.Count; i++)
            {
                if (moves.Rows[i]["name_move"].Equals(name))
                {
                    id = (int)moves.Rows[i]["id_move"];
                }
            }

            return id;
        }


        private void InitializeMoveslist()
        {
            for (int i = 0; i < moves.Rows.Count; i++)
            {
                txtMoveOne.Items.Add(moves.Rows[i]["name_move"].ToString());
                txtMoveTwo.Items.Add(moves.Rows[i]["name_move"].ToString());
                txtMoveThree.Items.Add(moves.Rows[i]["name_move"].ToString());
                txtMoveFour.Items.Add(moves.Rows[i]["name_move"].ToString());
            }
        }


        private void RebuildMoveslist()
        {
            for (int i = 0; i < moves.Rows.Count; i++)
            {
                txtMoveOne.Items[i] = (moves.Rows[i]["name_move"].ToString());
                txtMoveTwo.Items[i] = (moves.Rows[i]["name_move"].ToString());
                txtMoveThree.Items[i] = (moves.Rows[i]["name_move"].ToString());
                txtMoveFour.Items[i] = (moves.Rows[i]["name_move"].ToString());
            }
        }

        //private void IterateOnList(ComboBox list, ComboBox selectedMove)
        //{
        //    for (int i = 0; i < list.Items.Count; i++)
        //    {
        //        if (list.Items[i].Equals(selectedMove.Text))
        //        {
        //            list.Items[i] = " - ";
        //        }
        //    }
        //}

        //private void UpdateMovesList(ComboBox one, ComboBox two, ComboBox three, ComboBox selected)
        //{
        //    RebuildMoveslist();
        //    IterateOnList(one, selected);
        //    IterateOnList(two, selected);
        //    IterateOnList(three, selected);
        //}


        private int CorrectDuplicatedMoves(string currentMove, ComboBox otherMoveOne, ComboBox otherMoveTwo,
            ComboBox otherMoveThree)

        {
            ComboBox[] otherMoves = new ComboBox[] { otherMoveOne, otherMoveTwo, otherMoveThree };

            for (int i = 0; i < otherMoves.Length; i++)
            {
                if (otherMoves[i].Text.Equals(currentMove))
                {
                    otherMoves[i].Text = "";
                    return i;
                }
            }

            return -1;
        }


        private void UpdateMoveLabels(Label type, Label category, Label power, Label acc, Label pp)
        {
            type.Visible = false;
            category.Visible = false;
            power.Visible = false;
            acc.Visible = false;
            pp.Visible = false;    
        }


        private void InitializeEmptyFields()
        {
            //Load ev and iv saved on the database
            txtHPEV.Text = UserTeams.currentPoke.HPEV.ToString();
            txtATKEV.Text = UserTeams.currentPoke.ATKEV.ToString();
            txtSPATKEV.Text = UserTeams.currentPoke.SPATKEV.ToString();
            txtDEFEV.Text = UserTeams.currentPoke.DEFEV.ToString();
            txtSPDEFEV.Text = UserTeams.currentPoke.SPDEFEV.ToString();
            txtSPDEV.Text = UserTeams.currentPoke.DEFEV.ToString();

            txtHPIV.Text = UserTeams.currentPoke.HPIV.ToString();
            txtATKIV.Text = UserTeams.currentPoke.ATKIV.ToString();
            txtSPATKIV.Text = UserTeams.currentPoke.SPATKIV.ToString();
            txtDEFIV.Text = UserTeams.currentPoke.DEFIV.ToString();
            txtSPDEFIV.Text = UserTeams.currentPoke.SPDEFIV.ToString();
            txtSPDIV.Text = UserTeams.currentPoke.SPDIV.ToString();

            txtLevel.Text = UserTeams.currentPoke.level.ToString();

            currentMoveOne = GetCurrentMoveByid(UserTeams.currentPoke.idMoveOne, txtMoveOne);
            currentMoveTwo = GetCurrentMoveByid(UserTeams.currentPoke.idMoveTwo, txtMoveTwo);
            currentMoveThree = GetCurrentMoveByid(UserTeams.currentPoke.idMoveThree, txtMoveThree);
            currentMoveFour = GetCurrentMoveByid(UserTeams.currentPoke.idMoveFour, txtMoveFour);
         
            GetMoveLabels(currentMoveOne, lblType1, lblCat1, lblPower1, lblAcc1, lblPP1);
            GetMoveLabels(currentMoveTwo, lblType2, lblCat2, lblPower2, lblAcc2, lblPP2);
            GetMoveLabels(currentMoveThree, lblType3, lblCat3, lblPower3, lblAcc3, lblPP3);
            GetMoveLabels(currentMoveFour, lblType4, lblCat4, lblPower4, lblAcc4, lblPP4);

            txtNickName.Text = UserTeams.currentPoke.nickName;
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
            hp = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[0]), "hp");
            atk = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[1]), "atk");
            spatk = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[2]), "spatk");
            def = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[3]), "def");
            spdef = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[4]), "spdef");
            spd = new Atribute(int.Parse(UserTeams.currentPoke.baseStats[5]), "spd");
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

            hp.ChangeNatureSymbol(lblHPnature);
            atk.ChangeNatureSymbol(lblATKnature);
            spatk.ChangeNatureSymbol(lblSPATKnature);
            def.ChangeNatureSymbol(lblDEFnature);
            spdef.ChangeNatureSymbol(lblSPDEFnature);
            spd.ChangeNatureSymbol(lblSPDnature);

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
                    "SPATK_IV = @txtSPATKIV, DEF_IV = @txtDEFIV, SPDEF_IV = @txtSPDEFIV, SPD_IV= @txtSPDIV," +
                    "id_move_one = @idMoveOne, id_move_two = @idMoveTwo, id_move_three = @idMoveThree, id_move_four = @idMoveFour, " +
                    "id_nature = @idNature, " + "level = @level," + "nickname = @nickname" +
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

                updateComand.Parameters.AddWithValue("idMoveOne", GetMovesId(txtMoveOne.Text));
                updateComand.Parameters.AddWithValue("idMoveTwo", GetMovesId(txtMoveTwo.Text));
                updateComand.Parameters.AddWithValue("idMoveThree", GetMovesId(txtMoveThree.Text));
                updateComand.Parameters.AddWithValue("idMoveFour", GetMovesId(txtMoveFour.Text));

                updateComand.Parameters.AddWithValue("@idNature", Constructor.EnumerateNatureToInt(txtNature.Text));
                updateComand.Parameters.AddWithValue("@level", hp.level);
                updateComand.Parameters.AddWithValue("@nickname", txtNickName.Text);


                int affectedRow = conn.executeQuery(updateComand);


                if (affectedRow > 0)
                {
                    MessageBox.Show("Saved on database");
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private DataRow GetCurrentMoveByName(string name)
        {
            DataRow currentRow = moves.Rows[0];


            for (int i = 0; i < moves.Rows.Count; i++)
            {
                if (moves.Rows[i]["name_move"].Equals(name))
                {
                    currentRow = moves.Rows[i];
                }
            }

            return currentRow;
        }

        private DataRow GetCurrentMoveByid(int id, ComboBox moveBox)
        {
            if (id >= 0)
            {
                DataRow currentRow = moves.Rows[0];

                for (int i = 0; i < moves.Rows.Count; i++)
                {
                    if ((int)moves.Rows[i]["id_move"] == id)
                    {
                        currentRow = moves.Rows[i];
                        moveBox.Text = currentRow["name_move"].ToString();
                        return currentRow;
                    }
                }               
            }
            return null;      
        }


        private void GetMoveLabels(DataRow dr, Label type, Label cat, Label power, Label acc, Label pp)
        {
            if (dr != null)
            {
                type.Text = Constructor.EnumerateTypes((int)dr["id_type"]);
                cat.Text = dr["move_category"].ToString();
                power.Text = dr["power"].ToString();
                acc.Text = dr["accuracy"].ToString();
                pp.Text = dr["pp"].ToString();

                type.Visible = true;
                cat.Visible = true;
                power.Visible = true;
                acc.Visible = true;
                pp.Visible = true;
            }
        }



        private void txtMoveOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedMove;
            selectedMove = GetCurrentMoveByName(txtMoveOne.Text);
            int repeated = CorrectDuplicatedMoves(selectedMove["name_move"].ToString(), txtMoveTwo, txtMoveThree, txtMoveFour);

            if (repeated == 0)
            {
                UpdateMoveLabels(lblType2, lblCat2, lblPower2, lblAcc2, lblPP2);
            }

            else if (repeated == 1)
            {
                UpdateMoveLabels(lblType3, lblCat3, lblPower3, lblAcc3, lblPP3);
            }

            else if (repeated == 2)
            {
                UpdateMoveLabels(lblType4, lblCat4, lblPower4, lblAcc4, lblPP4);
            }


            GetMoveLabels(selectedMove, lblType1, lblCat1, lblPower1, lblAcc1, lblPP1);
            ColorScheme.UpdateTextColor(lblType1, ColorScheme.BackGroundColor(lblType1.Text));

            
        }

        private void txtMoveTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedMove;
            selectedMove = GetCurrentMoveByName(txtMoveTwo.Text);
            int repeated = CorrectDuplicatedMoves(selectedMove["name_move"].ToString(), txtMoveOne, txtMoveThree, txtMoveFour);
            if (repeated == 0)
            {
                UpdateMoveLabels(lblType1, lblCat1, lblPower1, lblAcc1, lblPP1);
            }

            else if (repeated == 1)
            {
                UpdateMoveLabels(lblType3, lblCat3, lblPower3, lblAcc3, lblPP3);
            }

            else if (repeated == 2)
            {
                UpdateMoveLabels(lblType4, lblCat4, lblPower4, lblAcc4, lblPP4);
            }
            GetMoveLabels(selectedMove, lblType2, lblCat2, lblPower2, lblAcc2, lblPP2);         
            ColorScheme.UpdateTextColor(lblType2, ColorScheme.BackGroundColor(lblType2.Text));
        }

        private void txtMoveThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedMove;
            selectedMove = GetCurrentMoveByName(txtMoveThree.Text);
            int repeated = CorrectDuplicatedMoves(selectedMove["name_move"].ToString(), txtMoveOne, txtMoveTwo, txtMoveFour);
            if (repeated == 0)
            {
                UpdateMoveLabels(lblType1, lblCat1, lblPower1, lblAcc1, lblPP1);
            }

            else if (repeated == 1)
            {
                UpdateMoveLabels(lblType2, lblCat2, lblPower2, lblAcc2, lblPP2);
            }

            else if (repeated == 2)
            {
                UpdateMoveLabels(lblType4, lblCat4, lblPower4, lblAcc4, lblPP4);
            }
            GetMoveLabels(selectedMove, lblType3, lblCat3, lblPower3, lblAcc3, lblPP3);
            ColorScheme.UpdateTextColor(lblType3, ColorScheme.BackGroundColor(lblType3.Text));
        }

        private void txtMoveFour_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedMove;
            selectedMove = GetCurrentMoveByName(txtMoveFour.Text);
            int repeated = CorrectDuplicatedMoves(selectedMove["name_move"].ToString(), txtMoveOne, txtMoveThree, txtMoveTwo);
            if (repeated == 0)
            {
                UpdateMoveLabels(lblType1, lblCat1, lblPower1, lblAcc1, lblPP1);
            }

            else if (repeated == 1)
            {
                UpdateMoveLabels(lblType3, lblCat3, lblPower3, lblAcc3, lblPP3);
            }

            else if (repeated == 2)
            {
                UpdateMoveLabels(lblType2, lblCat2, lblPower2, lblAcc2, lblPP2);
            }
            GetMoveLabels(selectedMove, lblType4, lblCat4, lblPower4, lblAcc4, lblPP4);
            ColorScheme.UpdateTextColor(lblType4, ColorScheme.BackGroundColor(lblType4.Text));
        }
    }
}
