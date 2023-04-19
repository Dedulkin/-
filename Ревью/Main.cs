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
    public partial class Main : Form
    {
        public int ID = 0;
        public Main(int ID_log)
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

        private void table_btn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(id_lb.Text);
            List list = new List(id) { TopLevel = false, TopMost = true };
            panel2.Controls.Add(list);
            list.BringToFront();
            list.Show();
        }

        private void review_btn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(id_lb.Text);
            Review review = new Review(id) { TopLevel = false, TopMost = true };
            panel2.Controls.Add(review);
            review.BringToFront();
            review.Show();
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(id_lb.Text);
            Review review = new Review(id) { TopLevel = false, TopMost = true };
            panel2.Controls.Add(review);
            review.BringToFront();
            review.Show();
        }
    }
}
