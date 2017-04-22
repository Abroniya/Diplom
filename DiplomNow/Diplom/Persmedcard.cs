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
    public partial class Persmedcard : Form
    {
        public Persmedcard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);
            //----------------------------------id последнего пациента----------------------------------------//
             string mySelectQuery1 = "select max(n.id) from agent n";
            SqlDataAdapter ad1 = new SqlDataAdapter(mySelectQuery1, conn);
            DataSet ds1 = new DataSet();
            conn.Open();
            ad1.Fill(ds1);
            conn.Close();
            dataGridView_agent.DataSource = ds1.Tables[0];
            textBox9.Text = dataGridView_agent.Rows[0].Cells[0].Value.ToString();
            //---------------------------------Заполненность обязательных полей-------------------------------//
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.SelectedIndex < 0) || (maskedTextBox1.Text == ""))
            {
               
                MessageBox.Show("Заполните все обязательные поля");
            }
            else
            {
            //---------------------------------Вставка--------------------------------------------------------//
                SqlCommand cmd, cmd1, cmd2, cmd3, cmd4;
                int m1;
                DateTime m2;
                conn.Open();
                m1 = Convert.ToInt32(textBox9.Text)+1;
              
                 //   m2 = Convert.ToDateTime(maskedTextBox1.ToString());
                if (comboBox1.Text == "Женский")
                {
                    if (maskedTextBox2.Text == "")
                    {
                        cmd = new SqlCommand("insert into agent(id,surname,firstname,lastname,birthdate,sex,deathdate,deathdocdate,deathdocname) VALUES('" + m1 + "','" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','ж',NULL,NULL,NULL)", conn);
                    }
                    else
                        cmd = new SqlCommand("insert into agent(id,surname,firstname,lastname,birthdate,sex,deathdate,deathdocdate,deathdocname) VALUES('" + m1 + "','" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','ж','" + dateTimePicker2.Value.Date + "','" + dateTimePicker3.Value.Date + "','" + textBox8.Text + "')", conn);

                }
                else
                {
                    if (maskedTextBox2.Text == "")
                    {
                        cmd = new SqlCommand("insert into agent(id,surname,firstname,lastname,birthdate,sex,deathdate,deathdocdate,deathdocname) VALUES('" + m1 + "','" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','м',NULL,NULL,NULL)", conn);
                    }
                    else
                    cmd = new SqlCommand("insert into agent(id,surname,firstname,lastname,birthdate,sex,deathdate,deathdocdate,deathdocname) VALUES('" + m1 + "','" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','м','" + dateTimePicker2.Value.Date + "','" + dateTimePicker3.Value.Date + "','" + textBox8.Text + "')", conn);
                }
                    cmd.ExecuteNonQuery();

                if(textBox4.Text !="")
                {
                    cmd1 = new SqlCommand("insert into agent_const(Agent, Date,Zamer, Value) VALUES('" + m1 + "','" + DateTime.Now.ToShortDateString() + "', '" + textBox4.Text + "' , 1)", conn);
                    cmd1.ExecuteNonQuery();
                }
                if (textBox5.Text != "")
                {
                    cmd2 = new SqlCommand("insert into agent_const(Agent, Date,Zamer, Value) VALUES('" + m1 + "','" + DateTime.Now.ToShortDateString() + "', '" + textBox5.Text + "' , 2)", conn);
                    cmd2.ExecuteNonQuery();
                }
                if (textBox6.Text != "")
                {
                    cmd3 = new SqlCommand("insert into agent_const(Agent, Date,Zamer, Value) VALUES('" + m1 + "','" + DateTime.Now.ToShortDateString() + "', '" + textBox6.Text + "' , 3)", conn);
                    cmd3.ExecuteNonQuery();
                }
                if (textBox7.Text != "")
                {
                    cmd4 = new SqlCommand("insert into agent_const(Agent, Date,Zamer, Value) VALUES('" + m1 + "','" + DateTime.Now.ToShortDateString() + "', '" + textBox7.Text + "' , 4)", conn);
                    cmd4.ExecuteNonQuery();
                }



                conn.Close();


            }
            

            //-----------------------------возврат к списку пацентов-------------------------------------------//
            Agents f10 = new Agents();
            f10.Show();

            string q;

            q = "SELECT id, surname as 'Фамилия', firstname as 'Имя',lastname as 'Отчество', sex as 'Пол', birthdate as 'Дата рождения' from agent where surname like '%" + f10.w + " %' and firstname like '%" + f10.w1 + " %' and lastname like '%" + f10.w2 + " %' ";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            f10.dataGridView_agg.DataSource = ds.Tables[0];
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agents f10 = new Agents();
            f10.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        private void Persmedcard_Activated(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
            maskedTextBox1.BackColor = Color.Yellow;
            comboBox1.BackColor = Color.Yellow;
            comboBox1.Items.Add("Мужской");
            comboBox1.Items.Add("Женский");
           // comboBox1.SelectedIndex = 0;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox4.Text != "")
            {
                int res;
                if (Int32.TryParse(textBox4.Text, out res))
                    textBox4.BackColor = Color.White;
                else textBox4.BackColor = Color.Yellow;

            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox5.Text != "")
            {
                int res;
                if (Int32.TryParse(textBox5.Text, out res))
                    textBox5.BackColor = Color.White;
                else textBox5.BackColor = Color.Yellow;

            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox6.Text != "")
            {
                int res;
                if (Int32.TryParse(textBox6.Text, out res))
                    textBox6.BackColor = Color.White;
                else textBox6.BackColor = Color.Yellow;

            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox7.Text != "")
            {
                int res;
                if (Int32.TryParse(textBox7.Text, out res))
                    textBox7.BackColor = Color.White;
                else textBox7.BackColor = Color.Yellow;

            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (maskedTextBox1.Text != "")
                maskedTextBox1.BackColor = Color.White;
            else
                maskedTextBox1.BackColor = Color.Yellow;

            }

        private void Persmedcard_Load(object sender, EventArgs e)
        {
          
                 textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Yellow;
                maskedTextBox1.BackColor = Color.Yellow;
                comboBox1.SelectedIndex = 0;
            

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
           if (textBox1.Text != "")
                textBox1.BackColor = Color.White; 
            else
               textBox1.BackColor = Color.Yellow; 
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.BackColor = Color.White;
            else
                textBox2.BackColor = Color.Yellow;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if (textBox3.Text != "")
                textBox3.BackColor = Color.White;
            else
                textBox3.BackColor = Color.Yellow;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)

                comboBox1.BackColor = Color.Yellow;
            else comboBox1.BackColor = Color.White;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker1.Value;
            maskedTextBox1.Text = peremen.Times.ToString("dd.MM.yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker2.Value;
            maskedTextBox2.Text = peremen.Times.ToString("dd.MM.yyyy");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker3.Value;
            maskedTextBox3.Text = peremen.Times.ToString("dd.MM.yyyy");
        }
        }
    }

