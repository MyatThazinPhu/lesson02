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
using MySql.Data.MySqlClient;
namespace lesson02
{
    public partial class FRM_Bumon : Form
    {
        public MySqlConnection connection;
        public string server;
        public string database;
        public string uid;
        public string password;
        public int textchangeindex = 0;
        public String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public String folder = "\\demo20\\";
        Boolean savesuccess;
        
        public FRM_Bumon()
        {
            InitializeComponent();
           //Testing chaw
        }
        #region BT_Close_Click and BT_NewInput_Click
        private void BT_Close_Click(object sender, EventArgs e)
        {
          this.Close();
           
        }

        private void BT_NewInput_Click(object sender, EventArgs e)
        {
            BT_Save.Enabled = true;
            BT_Cancel.Enabled  = true;
            TXT_Bumoncode.Enabled = true;
            TXT_Bumonname.Enabled = true;
            TXT_Bumoncode.BackColor = Color .White ;
            TXT_Bumonname.BackColor = Color.White;
            BT_Jidocode.Enabled = true;
            BT_ChangeInput.Enabled = false;
            BT_NewInput.Enabled = false;
            TXT_Bumoncode.Focus();
           

            // change button and textboxes enable
        }
        #endregion
        #region BT_Save_Click
        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DialogResult result = MessageBox.Show("登録してもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Boolean blankBumonC = RequiredFieldIsBlank(TXT_Bumoncode);
                    Boolean blankBumonN = RequiredFieldIsBlank(TXT_Bumonname);
                    if (!blankBumonC || !blankBumonN)
                    {
                        MessageBox.Show("入力して下さい。", "", MessageBoxButtons.OK);
                    }
                    else if (TXT_Bumoncode.Text == "00")
                    {
                        TXT_Bumoncode.ResetText();
                        MessageBox.Show("コードが０に設定できません。", "", MessageBoxButtons.OK);
                        TXT_Bumoncode.Focus();
                    }
                    else
                    {
                        SaveData();
                        if (savesuccess)
                        {
                            TXT_Bumoncode.ResetText();
                            TXT_Bumonname.ResetText();
                            TXT_Bumoncode.BackColor = DefaultBackColor;
                            TXT_Bumonname.BackColor = DefaultBackColor;
                            TXT_Bumoncode.Enabled = false;
                            TXT_Bumonname.Enabled = false;
                            BT_Save.Enabled = false;
                            BT_Jidocode.Enabled = false;
                            BT_Cancel.Enabled = false;
                            BT_NewInput.Enabled = true;
                            BT_ChangeInput.Enabled = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        #endregion
        #region RequiredFieldIsBlank
        private bool RequiredFieldIsBlank(TextBox txt)
        {
            
            if (txt.Text==null || txt .Text =="")
            {
                txt.BackColor = Color.Yellow ;
                return false;
            }
            else
            {
                txt.BackColor = Color .White ;
                return true;
            }
        }
        #endregion
        #region BT_Cancel_Click
        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("取消してもよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                TXT_Bumoncode.ResetText();
                TXT_Bumonname.ResetText();
                TXT_Bumoncode.BackColor = DefaultBackColor;
                TXT_Bumonname.BackColor = DefaultBackColor;
                TXT_Bumoncode.Enabled = false;
                TXT_Bumonname.Enabled = false;
                BT_Save.Enabled = false;
                BT_Jidocode.Enabled =false ;
                BT_Cancel.Enabled = false;
                BT_NewInput.Enabled = true;
                BT_ChangeInput.Enabled = true;
            }
        }
        #endregion
        #region BT_Jidocode_Click
        private void BT_Jidocode_Click(object sender, EventArgs e)
        {
            int[] code = new int[100];
            String query = "select * from m_bumon where cBUMON is not null and cBUMON!='' and cBUMON!='00' order by cBUMON asc ";
             try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = query;
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        String c = reader["cBUMON"].ToString();
                        code[i] = Int32.Parse(c);
                        i += 1;
                    }
                    reader.Close();
                   
                    int j = 0;
                    int temp = 0;
                    while (code[j] - temp == 1 && code[j] != 99)
                    {
                        temp = code[j];
                        j += 1;
                    }
                    if (temp != 99)
                    {
                        temp += 1;
                    }
                    String autocode = temp.ToString();
                    if (autocode.Length == 1)
                    {
                        autocode = "0" + autocode;
                    }
                    TXT_Bumoncode.Text = autocode;
                }
                catch(Exception erg)
                {
                    MessageBox.Show(erg.Message);
                    
                }
            connection.Close();
        }
        #endregion
        #region TXT_Bumoncode_Leave and TXT_Bumoncode_KeyPress
        private void TXT_Bumoncode_Leave(object sender, EventArgs e)
        {
            if(TXT_Bumoncode.Text .Length ==1)
            {
                TXT_Bumoncode.Text = "0" + TXT_Bumoncode.Text;
            } 
        }
        private void TXT_Bumoncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
        #region SaveData
        private void SaveData()
        {
                String BumonC = TXT_Bumoncode.Text;
                String BumonN = TXT_Bumonname.Text;
                String datequery = "SELECT NOW()";
             try
                {
                    //connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = datequery;
                    DateTime dt = (DateTime)command.ExecuteScalar();
                    String datetime = dt.ToString("yyyy-M-dd hh:mm:ss");

                    try
                    {
                        String query = "INSERT INTO m_bumon (`cBUMON`, `sBUMON`,`dHENKOU`,`cHENKOUSYA`) VALUES ('" + BumonC + "', '" + BumonN + "','" + datetime + "','9999')";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        String query = "UPDATE m_bumon SET `sBUMON`='" + BumonN + "', `dHENKOU`='" + datetime + "', `cHENKOUSYA`='9999' WHERE `cBUMON`='" + BumonC + "';";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("登録しました。", "", MessageBoxButtons.OK);
                    savesuccess = true;
                }
                catch(Exception erg)
                {
                    
                    MessageBox.Show(erg.Message);
                    savesuccess = false;
                    
                }
            //connection.Close();

        }
        #endregion
        #region FRM_Bumon_Load
        private void FRM_Bumon_Load(object sender, EventArgs e)
        {
            if (Demo_test())
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch(Exception erg)
                {
                    MessageBox.Show(erg.Message);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        #endregion
        #region BT_ChangeInput_Click and TXT_Bumonname_TextChanged
        private void BT_ChangeInput_Click(object sender, EventArgs e)
        {
            try
                {
                    connection.Open();
                    connection.Close();
                    Bumonkensaku sform = new Bumonkensaku(this);
                    sform.ShowDialog();
                }
                catch(Exception erg)
                {
                    MessageBox.Show(erg.Message);
                }
        }

        private void TXT_Bumonname_TextChanged(object sender, EventArgs e)
        {
            textchangeindex = 1;
        }
        #endregion
        #region FRM_Bumon_FormClosing
        private void FRM_Bumon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (BT_NewInput.Enabled == true || (BT_NewInput.Enabled == false && textchangeindex == 0 && TXT_Bumonname.Text != ""))
                {
                    e.Cancel = false;
                }
                else
                {
                    DialogResult result = MessageBox.Show("項目が変更されています。保存しますか？", "確認", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open();
                            Boolean blankBumonC = RequiredFieldIsBlank(TXT_Bumoncode);
                            Boolean blankBumonN = RequiredFieldIsBlank(TXT_Bumonname);
                            if (!blankBumonC || !blankBumonN)           // Check textboxes blank
                            {
                                MessageBox.Show("入力して下さい。", "", MessageBoxButtons.OK);
                                e.Cancel = true;
                            }
                            else if (TXT_Bumoncode.Text == "00")
                            {
                                TXT_Bumoncode.ResetText();
                                MessageBox.Show("コードが０に設定できません。", "", MessageBoxButtons.OK);
                                TXT_Bumoncode.Focus();
                                e.Cancel = true;
                            }
                            else
                            {
                                SaveData();             // insert data into database
                                if (savesuccess)
                                {
                                    e.Cancel = false;
                                }
                                else
                                {
                                    e.Cancel = true;
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            e.Cancel = true;
                        }
                        connection.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }

            }
        }
        #endregion
        #region Demo_test
        public Boolean Demo_test()
        {
            if (System.IO.File.Exists(path + folder + "demo20.xml"))
            {
                XmlDocument doc = new XmlDocument();
                string path1 = path + folder + "demo20.xml";
                doc.Load(path1);            // load demo20 file and show sever and db values
                try
                {
                    var theserver = doc.SelectNodes("/DEMO20/DBList/DB-SERV/Values");
                    server = theserver[0].InnerText;
                    var thedbname = doc.SelectNodes("/DEMO20/DBList/DB-NAME/Values");
                    database = thedbname[0].InnerText;
                    var theusername = doc.SelectNodes("/DEMO20/DBList/DB-USER/Values");
                    uid = theusername[0].InnerText;
                    var thepassword = doc.SelectNodes("/DEMO20/DBList/DB-PASS/Values");
                    password = thepassword[0].InnerText;
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                    connection = new MySqlConnection(connectionString);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Demo20 file is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Close();
                    return false;
                }


            }
            else
            {
                MessageBox.Show("Demo20 file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
                return false;

            }

        }
        #endregion
    }
}
