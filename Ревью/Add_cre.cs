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
    public partial class Add_cre : Form
    {

        public Add_cre()
        {
            InitializeComponent();
            getBoxes("select type from type_creation;", type_Cb);
            getBoxes("select distinct name_auth from author;", auth_Cb);
            getList("select name_genre from genre;", genre_List);
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
                case "Добавьте!":
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
        
        private void add_btn_Click(object sender, EventArgs e)
        {
            foreach (var item in genre_List.CheckedItems)
            {
                genre_lb.Text += item.ToString() + " ";
                
            }
            if (auth_lb.Text == "Назад")
            {
                doAction("insert into author (name_auth) values ('"+auth_Tb.Text+"');");
                doAction("insert into creation (name_cre, id_type, id_author, genre, desc_cre) values ('"+fio_Tb.Text+"', (select id_type from type_creation where type = '"+type_Cb.Text+ "'), (select id_author from author where name_auth = '" + auth_Tb.Text + "'), '"+genre_lb.Text+"', '"+desc_Tb.Text+"');");
                MessageBox.Show("Произведение добавлено!");
                fio_Tb.Text = "";
                type_Cb.SelectedIndex = -1;
                auth_Tb.Text = "";
                genre_List.ClearSelected();
                desc_Tb.Text = "";
            }
            else
            {
                doAction("insert into creation (name_cre, id_type, id_author, genre, desc_cre) values ('" + fio_Tb.Text + "', (select id_type from type_creation where type = '" + type_Cb.Text + "'), (select id_author from author where name_auth = '" + auth_Cb.Text + "'), '" + genre_lb.Text + "', '" + desc_Tb.Text + "');");
                MessageBox.Show("Изменения сохранены!");//исправить
                fio_Tb.Text = "";
                type_Cb.SelectedIndex = -1;
                auth_Tb.Text = "";
                genre_List.ClearSelected();
                desc_Tb.Text = "";
            }
        }

        
    }
}
