using MySql.Data.MySqlClient;
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
using System.Xml;

namespace lesson02
{
    public partial class Bumonkensaku : Form
    {
        FRM_Bumon f1;
        public Bumonkensaku(FRM_Bumon ff)
        {
            InitializeComponent();
            f1 = ff;
        }
        #region BT_Kensaku_Click
        private void BT_Kensaku_Click(object sender, EventArgs e)      //Added by phoo
        {
            
            String bumoncode = TXT_Bumoncode.Text;
            String bumonname = TXT_Bumonname.Text;
            String query= "select cBUMON,sBUMON from m_bumon where 1=1";
            MySqlDataReader reader;
            try
                {
                    f1.connection.Open();
                    MySqlCommand command = f1.connection.CreateCommand();
                    if (bumoncode == "" && bumonname == "")

                    {
                        DialogResult result = MessageBox.Show("全てのデータを検索すると、時間が掛かる場合があります。", "確認", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            query += " and cBUMON is not null and cBUMON!='' order by cBUMON asc";
                            command.CommandText = query;
                            reader = command.ExecuteReader();
                            DGV_Bumonlist.Rows.Clear();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DGV_Bumonlist.Rows.Add(reader["cBUMON"].ToString(), reader["sBUMON"].ToString());
                                }
                                BT_Yomi.Enabled = true;
                                BT_Clear.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);
                                BT_Yomi.Enabled = false;
                                BT_Clear.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        if (bumoncode != "")
                        {
                            query += " and cBUMON='" + bumoncode+"'";

                        }
                        if (bumonname != "")
                        {
                            if (RD_FirstMatch.Checked == true)
                            {
                                query += " and sBUMON collate utf8_unicode_ci LIKE '" + bumonname + "%'";
                            }
                            else
                            {
                                query += " and sBUMON collate utf8_unicode_ci LIKE '%" + bumonname + "%'";
                            }
                        }
                    query += " order by cBUMON asc";
                        command.CommandText = query;
                        reader = command.ExecuteReader();
                        DGV_Bumonlist.Rows.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DGV_Bumonlist.Rows.Add(reader["cBUMON"].ToString(), reader["sBUMON"].ToString());
                            }
                            BT_Yomi.Enabled = true;
                            BT_Clear.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("データがありません。", "", MessageBoxButtons.OK);
                            BT_Yomi.Enabled = false;
                            BT_Clear.Enabled = true;
                        }

                    }

                    
                }
                catch(Exception erg)
                {
                MessageBox.Show(erg.Message);

                }

            f1.connection.Close();
            BT_Kensaku.Select();
        }
        #endregion    // Added by phoo 
        #region BTN_Close_Click and BT_Clear_Click
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TXT_Bumoncode.ResetText();
            TXT_Bumonname.ResetText();
            DGV_Bumonlist.Rows.Clear();
            RD_PartialMatch.Checked = true;
            BT_Clear.Enabled = false;
            BT_Yomi.Enabled = false;
        }
        #endregion //
        #region TXT_Bumoncode_KeyPress and TXT_Bumoncode_Leave
        private void TXT_Bumoncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TXT_Bumoncode_Leave(object sender, EventArgs e)
        {
            if (TXT_Bumoncode.Text.Length == 1)
            {
                TXT_Bumoncode.Text = "0" + TXT_Bumoncode.Text;
            }
        }
        #endregion
        #region DGV_Bumonlist_CellDoubleClick and BT_Yomi_Click and Yomi()
        private void DGV_Bumonlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            Yomi();
        }

        private void BT_Yomi_Click(object sender, EventArgs e)
        {
            Yomi();
        }
        private void Yomi()
        {
            try
            {
                f1.connection.Open();
                f1.TXT_Bumonname.Text = DGV_Bumonlist.SelectedRows[0].Cells["sbumon"].Value.ToString();
                f1.TXT_Bumoncode.Text = DGV_Bumonlist.SelectedRows[0].Cells["cbumon"].Value.ToString();
                f1.TXT_Bumonname.BackColor = Color.White;
                f1.textchangeindex = 0;
                f1.TXT_Bumoncode.Enabled = false;
                f1.TXT_Bumonname.Enabled = true;
                f1.BT_Cancel.Enabled = true;
                f1.BT_Save.Enabled = true;
                f1.BT_NewInput.Enabled = false;
                f1.BT_ChangeInput.Enabled = false;
                f1.BT_Jidocode.Enabled = false;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            f1.connection.Close();
        }
        #endregion
        #region TXT_Bumoncode_KeyDown and TXT_Bumonname_KeyDown
        private void TXT_Bumoncode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TXT_Bumoncode.Text.Length == 1)
                {
                    TXT_Bumoncode.Text = "0" + TXT_Bumoncode.Text;
                }
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void TXT_Bumonname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }
        #endregion
        #region RD_FirstMatch_KeyDown and RD_PartialMatch_KeyDown
        private void RD_FirstMatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }

        private void RD_PartialMatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Kensaku_Click(this, new EventArgs());
            }
        }
        #endregion
    }
}
