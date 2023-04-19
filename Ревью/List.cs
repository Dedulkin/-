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
    public partial class List : Form
    {
        public int ID = 0;
        public List(int ID_log)
        {
            InitializeComponent();
            getInfo(ID_log);
            getInfoU(ID_log);
            ID = ID_log;
            cat_Cb.Items.Add("...типу");
            cat_Cb.Items.Add("...жанру");
            cat_Cb.Items.Add("__");
        }
        public void getInfoU(int ID)
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
                        id_user_lb.Text = rd.GetString(0);
                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void getInfo(int ID)
        {
            string query = "select id_role from profile where id_prof=" + ID + ";";
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
                dgv.Columns[4].ReadOnly = true;
                dgv.Columns[5].ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        private void List_Load(object sender, EventArgs e)
        {
            if (id_lb.Text=="2")
            {
                add_btn.Visible = true;
                del_btn.Visible = true;
                updt_btn.Visible = true;
            }
            DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author;", list_DGV);
        }

        public void getBoxes(string query, ComboBox box)
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
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибочка!" + Environment.NewLine + ex.Message);
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
                        box.Text=rd.GetString(0);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибочка!" + Environment.NewLine + ex.Message);
            }
        }
        private void cat_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cat_Cb.Text){
                case "...типу":
                    filtr_Cb.Visible = true;
                    filtr_Cb.Items.Clear();
                    getBoxes("select type from type_creation;",filtr_Cb);
                    break;
                case "...жанру":
                    filtr_Cb.Visible = true;
                    filtr_Cb.Items.Clear();
                    getBoxes("select name_genre from genre;", filtr_Cb);
                    break;
                case "__":
                    filtr_Cb.Visible = false;
                    filtr_Cb.Items.Clear();
                    DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author;", list_DGV);
                    break;
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where name_cre like '%"+search_tb.Text+ "%' or name_auth like '%" + search_tb.Text + "%';", list_DGV);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_cre add_Cre = new Add_cre();
            add_Cre.Show();
        }

        private void list_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB("select desc_cre from creation where id_creation = "+ list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + ";",desc_Tb);
            
        }
        
        private void review_btn_Click(object sender, EventArgs e)
        {
            int id_user = Int32.Parse(id_user_lb.Text);
            int id = Int32.Parse(list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString());
            Add_rew review = new Add_rew(id, id_user);
            review.Show();
        }

        private void filtr_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cat_Cb.Text)
            {
                case "...типу":
                    DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where creation.id_type = (select id_type from type_creation where type = '" + filtr_Cb.Text+"');", list_DGV);
                    break;
                case "...жанру":
                    DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author where genre like '%"+filtr_Cb.Text+"%';", list_DGV);
                    break;
                
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
       
        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены что хотите безвозвратно удалить "+ list_DGV[2, list_DGV.CurrentRow.Index].Value.ToString() + ": "+ list_DGV[1, list_DGV.CurrentRow.Index].Value.ToString() +" ("+ list_DGV[3, list_DGV.CurrentRow.Index].Value.ToString()+ ")?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//допиши блэнб
                if (result == DialogResult.Yes)
                {
                    doAction("delete from creation where id_creation = "+ list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString() + ";");
                }
            }
            catch
            {
                MessageBox.Show("Чтобы что-то удалить надо что-то выделить.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGV("select creation.id_creation, creation.name_cre as 'Название', type_creation.type as 'Тип произведения', author.name_auth as 'ФИО автора', creation.genre as 'Жанр/ы', creation.total_rate 'Средняя оценка' from creation join type_creation on creation.id_type=type_creation.id_type join author on creation.id_author = author.id_author;", list_DGV);
            desc_Tb.Text = "";
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            int id_cre = Int32.Parse(list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString());
            Show show = new Show(id_cre);
            show.Show();
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            int id_cre = Int32.Parse(list_DGV[0, list_DGV.CurrentRow.Index].Value.ToString());
            UpdtCre updtCre = new UpdtCre(id_cre);
            updtCre.Show();
        }
    }
}
