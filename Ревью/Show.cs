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
    public partial class Show : Form
    {
        public Show(int cre)
        {
            InitializeComponent();
            cre_lb.Text = cre.ToString();
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
                        label.Text = "Рецензии на " + rd.GetString(0) +": " + rd.GetString(1)+" (" + rd.GetString(2)+")";
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузкb!" + Environment.NewLine + ex.Message);
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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        private void Show_Load(object sender, EventArgs e)
        {
            label("select type_creation.type, creation.name_cre, author.name_auth from type_creation join creation on type_creation.id_type=creation.id_type join author on author.id_author=creation.id_author where id_creation = "+cre_lb.Text+";", hello_lb);
            DGV("select review.id_review, profile.name as 'Пользователь', review.rate as 'Оценка' from review join list_review on review.id_review=list_review.id_review join profile on list_review.id_prof = profile.id_prof where id_creation = " + cre_lb.Text + ";", list_DGV);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGV("select review.id_review, profile.name as 'Пользователь', review.rate as 'Оценка' from review join list_review on review.id_review=list_review.id_review join profile on list_review.id_prof = profile.id_prof where id_creation = " + cre_lb.Text + ";", list_DGV);
            desc_Tb.Text = "";
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
            TB("select txt_review from review where id_review = "+ list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + ";", desc_Tb);
        }
    }
}
