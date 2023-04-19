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
    public partial class Auth1 : Form
    {
        public Auth1()
        {
            InitializeComponent();
            pswrd_tBox.UseSystemPasswordChar = true;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select id_prof from profile where id_log =(select id_log from login where login ='" + log_tBox.Text + "') and id_pswrd = (select id_pswrd from pswrd where pswrd ='" + pswrd_tBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    int result = 0;
                    result = Convert.ToInt32(cmDB.ExecuteScalar());
                    if (result >= 1)
                    {
                        Main Win = new Main(result);
                        this.Hide();
                        Auth0 auth_m = Application.OpenForms.OfType<Auth0>().SingleOrDefault();
                        if (auth_m != null)
                        {
                            auth_m.Hide();
                        }
                        Win.Show();

                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации! Попробуйте ещё раз!");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Не оставляйте пустые поля!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string result = psrd_lb.Text;
            switch (result)
            {
                case "1":
                    psrd_lb.Text = "2";
                    pictureBox1.Image = Properties.Resources.open_eye;
                    pswrd_tBox.UseSystemPasswordChar = false;
                    break;
                case "2":
                    psrd_lb.Text = "1";
                    pictureBox1.Image = Properties.Resources.close_eye;
                    pswrd_tBox.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
