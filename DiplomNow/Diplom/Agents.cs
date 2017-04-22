using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diplom
{
    public partial class Agents : Form
    {
        public string w1, w2, w3, w4, w;
        
        public Agents()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Font = new Font(button3.Font, button3.Font.Style | FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Font = new Font(button1.Font, button1.Font.Style | FontStyle.Bold);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Font = new Font(button2.Font, button2.Font.Style | FontStyle.Bold);
         /*  textBox1.Text = "Фамилия";//подсказка
            textBox1.ForeColor = Color.Black;
            textBox2.Text = "Имя";//подсказка
            textBox2.ForeColor = Color.Black;
            textBox3.Text = "Отчество";//подсказка
            textBox3.ForeColor = Color.Black;
            textBox4.Text = "Дата рождения";//подсказка
            textBox4.ForeColor = Color.Black;*/

            this.dataGridView_agg.Visible = false;



           



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           // textBox1.Text = "Фамилия";//подсказка
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           //textBox2.Text = "Имя";//подсказка
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
         //  textBox3.Text = "Отчество";//подсказка
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
         //   textBox4.Text = "Дата рождения";//подсказка
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView_agg.Visible = true;

            w = textBox1.Text.ToLower();
            w1 = textBox2.Text.ToLower();
            w2 = textBox3.Text.ToLower();
        //    dataGridView1.Columns[0].Visible = false;

            

            string q;
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);
  
            q = "SELECT id, surname as 'Фамилия', firstname as 'Имя',lastname as 'Отчество', sex as 'Пол', birthdate as 'Дата рождения' from agent where surname like '%" + w + " %' and firstname like '%" + w1 + " %' and lastname like '%" + w2 + " %' ";
                SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            dataGridView_agg.DataSource = ds.Tables[0];

            dataGridView_agg.Columns[0].Width = 50;
            dataGridView_agg.Columns[1].Width = 150;
            dataGridView_agg.Columns[2].Width = 150;
            dataGridView_agg.Columns[3].Width = 100;
            dataGridView_agg.Columns[4].Width = 100;
            dataGridView_agg.Columns[5].Width = 100;




        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
       /*     int row = e.RowIndex;
         //   MessageBox.Show(Convert.ToString(column));
           // MessageBox.Show(Convert.ToString(row));
            textBox1.Text = dataGridView_agg[1, row].Value.ToString();
            textBox2.Text = dataGridView_agg[2, row].Value.ToString();
            textBox3.Text = dataGridView_agg[3, row].Value.ToString();
            textBox4.Text = dataGridView_agg[0, row].Value.ToString();

            peremen.id = Convert.ToInt32(textBox4.Text); //айдиха найденного пациента
            peremen.f = textBox1.Text;
            peremen.i = textBox2.Text;
            peremen.o = textBox3.Text;*/
    
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (peremen.type_u == 1)
            {
                New_patient f10 = new New_patient();
                f10.Show();
                f10.textBox1.Text = peremen.f.Trim() + ' ' + peremen.i.Trim() + ' ' + peremen.o.Trim() + ' ';


                this.Close();
            }
            if (peremen.type_u == 2)
            {
                Notice_update f10 = new Notice_update();
                f10.Show();
                f10.textBox1.Text = peremen.f.Trim() + ' ' + peremen.i.Trim() + ' ' + peremen.o.Trim() + ' ';
                this.Close();
            }
            if (peremen.type_u == 3)
            {
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Image = null;
            //this.button3 = Resources.res1;
            this.dataGridView_agg.Visible = true;

            w = textBox1.Text.ToLower();
            w1 = textBox2.Text.ToLower();
            w2 = textBox3.Text.ToLower();
            //    dataGridView1.Columns[0].Visible = false;



            string q;
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);

            q = "SELECT id, surname as 'Фамилия', firstname as 'Имя',lastname as 'Отчество', sex as 'Пол', birthdate as 'Дата рождения' from agent where surname like '%" + w + " %' and firstname like '%" + w1 + " %' and lastname like '%" + w2 + " %' ";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            dataGridView_agg.DataSource = ds.Tables[0];

            dataGridView_agg.Columns[0].Width = 50;
            dataGridView_agg.Columns[1].Width = 150;
            dataGridView_agg.Columns[2].Width = 150;
            dataGridView_agg.Columns[3].Width = 100;
            dataGridView_agg.Columns[4].Width = 100;
            dataGridView_agg.Columns[5].Width = 100;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Persmedcard f10 = new Persmedcard();
            f10.Show();
            this.Close();
        }

        private void dataGridView_agg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                int row = e.RowIndex;
         //   MessageBox.Show(Convert.ToString(column));
           // MessageBox.Show(Convert.ToString(row));
            textBox1.Text = dataGridView_agg[1, row].Value.ToString();
            textBox2.Text = dataGridView_agg[2, row].Value.ToString();
            textBox3.Text = dataGridView_agg[3, row].Value.ToString();
            textBox4.Text = dataGridView_agg[0, row].Value.ToString();

            peremen.id = Convert.ToInt32(textBox4.Text); //айдиха найденного пациента
            peremen.f = textBox1.Text;
            peremen.i = textBox2.Text;
            peremen.o = textBox3.Text;
        }

        
    }
}
