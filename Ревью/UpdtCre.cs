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
    public partial class UpdtCre : Form
    {
        public int ID = 0;
        public UpdtCre(int ID_log)
        {
            InitializeComponent();
            getBoxes("select type from type_creation;", type_Cb);
            getBoxes("select distinct name_auth from author;", auth_Cb);
            getList("select name_genre from genre;", genre_List);
            id_lb.Text = ID_log.ToString();
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
        public void getList(string query, CheckedListBox listbox)
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
                        listbox.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибочка!" + Environment.NewLine + ex.Message);
            }
        }

        private void auth_lb_Click(object sender, EventArgs e)
        {
            switch (auth_lb.Text)
            {
                case "Исправьте!":
                    auth_lb.Text = "Назад";
                    lb.Visible = false;
                    auth_Cb.Visible = false;
                    auth_Tb.Visible = true;
                    break;
                case "Назад":
                    auth_lb.Text = "Добавьте!";
                    lb.Visible = true;
                    auth_Cb.Visible = true;
                    auth_Tb.Visible = false;
                    break;
            }
        }
        public void getB(string query, ComboBox box)
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
                MessageBox.Show("Произошла непредвиденная ошибочка!" + Environment.NewLine + ex.Message);
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
        private void UpdtCre_Load(object sender, EventArgs e)
        {
            getB("select name_auth from author where id_author = (select id_author from creation where id_creation = " + id_lb.Text+");",auth_Cb);
            getB("select type from type_creation where id_type= (select id_type from creation where id_creation = " + id_lb.Text + ");", type_Cb);
            TB("select name_cre from creation where id_creation = " + id_lb.Text + ";", fio_Tb);
            TB("select name_auth from author where id_author = (select id_author from creation where id_creation = " + id_lb.Text + ");", auth_Tb);
            TB("select desc_cre from creation where id_creation = " + id_lb.Text + ";", desc_Tb);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            foreach (var item in genre_List.CheckedItems)
            {
                genre_lb.Text += item.ToString() + " ";

            }
            if (auth_lb.Text == "Назад")
            {
                doAction("update author set name_auth = '" + auth_Tb.Text + "' where id_auth = (select id_auth from creation where id_creation = " + id_lb.Text + ");");
                doAction("update creation set name_cre ='" + fio_Tb.Text + "', id_type = (select id_type from type_creation where type = '" + type_Cb.Text + "'), genre = '" + genre_lb.Text + "', desc_cre = '" + desc_Tb.Text + "' where id_creation = " + id_lb.Text + ";");
                MessageBox.Show("Изменения сохранены!");
                this.Close();
            }
            else
            {
                
                doAction("update creation set name_cre ='" + fio_Tb.Text + "', id_type = (select id_type from type_creation where type = '" + type_Cb.Text + "'), genre = '" + genre_lb.Text + "', desc_cre = '" + desc_Tb.Text + "', id_author = (select id_author from author where name_auth = '" + auth_Cb.Text + "') where id_creation = " + id_lb.Text + ";");
                MessageBox.Show("Изменения сохранены!");//исправить
                this.Close();
            }
        }
    }
}
