using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ревью
{
    public partial class Add_rew : Form
    {
        public int ID = 0;
        public int IDU = 0;
        public Add_rew(int ID_log, int id_user)
        {
            InitializeComponent();
            getInfo(ID_log);
            ID = ID_log;
            IDU = id_user;
            idcre_lb.Text = ID_log.ToString();
            getInfoU(id_user);
            getInfos(ID_log);
        }
        public void getInfo(int ID)
        {
            string query = "select name_cre from creation where id_creation=" + ID + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        name_lb.Text = rd.GetString(0);
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void getInfoU(int ID)
        {
            string query = "select id_prof from profile where id_prof=" + ID + ";"; //Заменить с роли на юзера, поправить на предыдущем окне говнокодер сраный
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        id_lb.Text = rd.GetString(0);
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void getInfos(int ID)
        {
            string query = "select id_creation from creation where id_creation=" + ID + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        label2.Text = rd.GetString(0);
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void label(string query, Label label)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        label.Text = rd.GetString(0);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузкb!" + Environment.NewLine + ex.Message);
            }
        }
        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошли технические накладки!" + Environment.NewLine + ex.Message);
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            doAction("insert into review (id_creation, txt_review, rate) values ("+label2.Text+", '"+desc_Tb.Text+"', "+rate_Num.Value+");");
            doAction("insert into list_review values ("+id_lb.Text+", (select max(id_review) from review));");
            label("select sum(rate) from review where id_creation = " + idcre_lb.Text + ";", sum_lb);
            label("select count(*) from review where id_creation = " + idcre_lb.Text + ";", count_lb);
            int sum = Int32.Parse(sum_lb.Text);
            int count = Int32.Parse(count_lb.Text);
            double rate = sum / count;
            doAction("update creation set total_rate = " + rate + " where id_creation = " + idcre_lb.Text + ";");
            MessageBox.Show("Рецензия сохранена!");
            this.Close();
        }
    }
}
