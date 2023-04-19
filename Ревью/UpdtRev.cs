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
    public partial class UpdtRev : Form
    {
        
        public UpdtRev(int ID_log, int cre)
        {
            InitializeComponent();
            id_lb.Text = ID_log.ToString();
            idcre_lb.Text=cre.ToString();
            TB("select txt_review from review where id_review = "+id_lb.Text+";", desc_Tb);
            label("select name_cre from creation where id_creation = (select id_creation from review where id_review = " + id_lb.Text + ");", name_lb);
            num("select rate from review where id_review = " + id_lb.Text + ";", rate_Num);
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
        public void num(string query, NumericUpDown numericUpDown)
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
                        numericUpDown.Value = Int32.Parse(rd.GetString(0));
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                doAction("update review set txt_review = '" + desc_Tb.Text + "', rate =" + rate_Num.Value + " where id_review = " + id_lb.Text + ";");
                label("select sum(rate) from review where id_creation = " + idcre_lb.Text + ";", sum_lb);
                label("select count(*) from review where id_creation = " + idcre_lb.Text + ";", count_lb);
                int sum = Int32.Parse(sum_lb.Text);
                int count = Int32.Parse(count_lb.Text);
                double rate = sum / count;
                doAction("update creation set total_rate = " + rate + " where id_creation = " + idcre_lb.Text + ";");
                MessageBox.Show("Внесённые изменения сохранены.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + Environment.NewLine + ex.Message);
            }
        }
    }
}
