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
    public partial class Review : Form
    {
        public int ID = 0;
        public Review(int ID_log)
        {
            InitializeComponent();
            getInfo(ID_log);
            ID = ID_log;
        }
        public void getInfo(int ID)
        {
            string query = "select id_prof from profile where id_prof=" + ID + ";";
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

        public void DGV(string query, DataGridView dgv)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dgv.DataSource = dt;
                dgv.ClearSelection();
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].ReadOnly = true;
                dgv.Columns[2].ReadOnly = true;
                dgv.Columns[3].ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Review_Load(object sender, EventArgs e)
        {
            DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where id_creation = (select id_creation from review where id_review = (select id_review from list_review where id_prof = "+id_lb.Text+"));",list_DGV);
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
        public void TB(string query, TextBox box)
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
                        box.Text = rd.GetString(0);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузкb!" + Environment.NewLine + ex.Message);
            }
        }
        private void list_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label("select rate from review where id_creation = "+ list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + " and id_review = (select id_review from list_review where id_prof = "+id_lb.Text+");",rate_lb);
            TB("select txt_review from review where id_creation = " + list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + " and id_review = (select id_review from list_review where id_prof = " + id_lb.Text + ");", desc_Tb);
            label("select review.id_review from review join list_review on review.id_review = list_review.id_review where id_creation = " + list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + " and list_review.id_prof = " + id_lb.Text + ";", help_lb);
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
        private void del_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены что хотите безвозвратно удалить рецензию на " + list_DGV[2, list_DGV.CurrentRow.Index].Value.ToString() + ": " + list_DGV[1, list_DGV.CurrentRow.Index].Value.ToString() + " (" + list_DGV[3, list_DGV.CurrentRow.Index].Value.ToString() + ")?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//допиши блэнб
                if (result == DialogResult.Yes)
                {
                    label("select id_creation from creation where id_creation = "+ list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + ";",idcre_lb);
                    doAction("delete from list_review where id_review = " + help_lb.Text + " and id_prof = "+id_lb.Text+";");
                    
                    doAction("delete from review where id_review = " + help_lb.Text + ";");

                    label("select sum(rate) from review where id_creation = " + idcre_lb.Text + ";", sum_lb);
                    label("select count(*) from review where id_creation = " + idcre_lb.Text + ";", count_lb);
                    int sum = Int32.Parse(sum_lb.Text);
                    int count = Int32.Parse(count_lb.Text);
                    double rate = sum / count;
                    doAction("update creation set total_rate = "+rate+ " where id_creation = " + idcre_lb.Text + ";");
                    DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where id_creation = (select id_creation from review where id_review = (select id_review from list_review where id_prof = " + id_lb.Text + "));", list_DGV);

                }
            }
            catch
            {
                MessageBox.Show("Чтобы что-то удалить надо что-то выделить.");
            }
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            label("select review.id_review from review join list_review on review.id_review = list_review.id_review where id_creation = " + list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + " and list_review.id_prof = " + id_lb.Text + ";", help_lb);
            label("select id_creation from creation where id_creation = " + list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + ";", idcre_lb);
            int cre = int.Parse(idcre_lb.Text);
            int rev = Int32.Parse(help_lb.Text);
            UpdtRev updtRev = new UpdtRev(rev, cre);
            updtRev.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where id_creation = (select id_creation from review where id_review = (select id_review from list_review where id_prof = " + id_lb.Text + "));", list_DGV);
            rate_lb.Text = "0";
            desc_Tb.Text = "";
        }
    }
}
