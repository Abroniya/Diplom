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
    public partial class New_patient : Form
    {
       public int i1, j1, i2,j2, i3, j3, i4, j4, i5, j5, x, y, yl, xl, x1, y1, yf;

        public New_patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peremen.type_u = 1;
            Agents f2 = new Agents();
            f2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }
 
        private void New_patient_Load(object sender, EventArgs e)
        {

           
            string query2, query3, query4, query5, query6;
            this.StartPosition = FormStartPosition.CenterScreen;
        
            textBox1.Text = peremen.f.Trim() + ' ' + peremen.i.Trim() + ' ' + peremen.o.Trim() + ' ';
            textBox11.Text = peremen.mkb;
            textBox13.Text = peremen.mkb1;
            textBox12.Text = peremen.mkb_text;
            textBox14.Text = peremen.mkb1_text1; 
       //     i1 = 55; j1 = 25; i2 = 55; j2 = 155; i3 = 55; j3 = 285; i4 = 55;j4 = 415; i5 = 55; j5 = 545; x = 619; y = 39; yl = 124; xl = 639; x1 = 728;y1 = 344; yf = 512;

            
            //-----------------преобразовали дату и взяли текущую, проставил как дата заполнения--------------------//
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            peremen.Times = dateTimePicker1.Value;
            textBox5.Text = peremen.Times.ToString("dd.MM.yyyy");
           
            //---------------------------Открытие соединения---------------------------------------------------------//
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);

            //-------------вытягиваем сотрудника, заполнившего форму для заполнения нижних данных(ФИО)----------------//
           
            string mySelectQuery = " select  rtrim(surname)+' '+rtrim(firsname)+' '+rtrim(Lastname) from employers e join Users u on e.Users=u.id where u.Name_User= '" + peremen.nick + "'";
            SqlDataAdapter ad = new SqlDataAdapter(mySelectQuery, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            //------------------------Вытягиваем контактный номер сотрудника---------------------------------------//
            string mySelectQuery1 = " select rtrim(contact) from employers e join Users u on e.Users=u.id where u.Name_User= '" + peremen.nick + "'";
            SqlDataAdapter ad1 = new SqlDataAdapter(mySelectQuery1, conn);
            conn.Open();
            ad1.Fill(ds);
            conn.Close();
            //----------------------запоминаем id сотрудника-------------------------------------------------------//
            string mySelectQuery6 = " select  e.id from employers e join Users u on e.Users=u.id where u.Name_User= '" + peremen.nick + "'";
            SqlDataAdapter ad14 = new SqlDataAdapter(mySelectQuery6, conn);
            conn.Open();
            ad14.Fill(ds);
            conn.Close();
            //---------------------в dataGridView1. данные нижнего грида
            dataGridView1.DataSource = ds.Tables[0];
            textBox3.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            //---получаем номер последней в регистре заявки и в в R-main
            //--------------------------------Нахождения номера последней записи nr_request------------------------//
            string mySelectQuery5 = "select max(n.id) from nr_request n";
            SqlDataAdapter ad13 = new SqlDataAdapter(mySelectQuery5, conn);
            DataSet ds13 = new DataSet();
            conn.Open();
            ad13.Fill(ds13);
            conn.Close();
            dataGridView2.DataSource = ds13.Tables[0];
            textBox15.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            //--------------------------------Нахождения номера последней записи r_hpn_main------------------------//
            string mySelectQuery7 = "select max(n.id) from r_hpn_main n";
            SqlDataAdapter ad7 = new SqlDataAdapter(mySelectQuery5, conn);
            DataSet ds14 = new DataSet();
            conn.Open();
            ad7.Fill(ds14);
            conn.Close();
            dataGridView3.DataSource = ds14.Tables[0];
            textBox20.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
            //--------------------------------Нахождения номера последней записи r_hpn_terapy------------------------//
            string mySelectQuery10 = "select max(n.id) from r_hpn_terapy n";
            SqlDataAdapter ad15 = new SqlDataAdapter(mySelectQuery10, conn);
            DataSet ds15 = new DataSet();
            conn.Open();
            ad15.Fill(ds15);
            conn.Close();
            dataGridView4.DataSource = ds15.Tables[0];
            textBox21.Text = dataGridView4.Rows[0].Cells[0].Value.ToString();
            //--------------------------------Нахождения номера последней записи r_hpn_diagn------------------------//
            string mySelectQuery11 = "select max(n.id) from r_hpn_diagn n";
            SqlDataAdapter ad16 = new SqlDataAdapter(mySelectQuery11, conn);
            DataSet ds16 = new DataSet();
            conn.Open();
            ad16.Fill(ds16);
            conn.Close();
            dataGridView5.DataSource = ds16.Tables[0];
            textBox23.Text = dataGridView5.Rows[0].Cells[0].Value.ToString();

            //------------------------------Подгрузка места диализа-------------------------------------------------//
            query3 = "Select Kod, Place from Plase_dial";
            SqlDataAdapter dial = new SqlDataAdapter(query3, conn);
            DataSet ds_dial = new DataSet();
            conn.Open();
            dial.Fill(ds_dial);
            conn.Close();
            comboBox2.DataSource = ds_dial.Tables[0];
            comboBox2.DisplayMember = "Place";
            comboBox2.ValueMember = "Kod";
            //------------------------------Подгрузка вида диализа-------------------------------------------------//
         
            query2 = "Select kod, name from Vid_dial";
            SqlDataAdapter v_dial = new SqlDataAdapter(query2, conn);
            DataSet ds_v_dial = new DataSet();
            conn.Open();
            v_dial.Fill(ds_v_dial);
            conn.Close();
            comboBox1.DataSource = ds_v_dial.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "kod";
         

            //------------------------------Подгрузка результата диализа-------------------------------------------------//
         
            query4 = "Select kod, Result from Result_dial";
            SqlDataAdapter res_dia = new SqlDataAdapter(query4, conn);
            DataSet ds_res_dia = new DataSet();
            conn.Open();
            res_dia.Fill(ds_res_dia);
            conn.Close();
            comboBox3.DataSource = ds_res_dia.Tables[0];
            comboBox3.DisplayMember = "Result";
            comboBox3.ValueMember = "kod";
            //------------------------------Подгрузка стадии ХБП-------------------------------------------------//
            query5 = "Select Stady from Hpn_hbp";
            conn.Open();
            SqlCommand cmd5 = conn.CreateCommand();
            cmd5.CommandText = query5;
            SqlDataReader rdr5 = cmd5.ExecuteReader();
            while (rdr5.Read())
            {
                comboBox4.Items.Add(rdr5["Stady"]);
            }
            rdr5.Close();
            conn.Close();
            //------------------------------Подгрузка причин исключения-------------------------------------------------//
         /*   query6 = "Select Reason from HPN_REASON";
            conn.Open();
            SqlCommand cmd6  = conn.CreateCommand();
            cmd6.CommandText = query6;
            SqlDataReader rdr6 = cmd6.ExecuteReader();
             while (rdr6.Read())
            {
                comboBox5.Items.Add(rdr6["Reason"]);
            }
             rdr6.Close();
             conn.Close();*/
        }

        private void New_patient_Activated(object sender, EventArgs e)
        {
          
            textBox11.Text = peremen.mkb; 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
           // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker1.Value;
            textBox5.Text = peremen.Times.ToString("dd.MM.yyyy");
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           /* var maskedTextBox = new MaskedTextBox();
            maskedTextBox.Top = i1;
            maskedTextBox.Left = j1;
            i1 = i1 + 30;
            tabPage2.Controls.Add(maskedTextBox);
            maskedTextBox.BringToFront();
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker1.Value;
            maskedTextBox.Text = peremen.Times.ToString("dd.MM.yyyy");

            var textBox16 = new TextBox();
            textBox16.Top = i2 ;
            textBox16.Left = j2;
            i2 = i2 + 30;
            tabPage2.Controls.Add(textBox16);
            textBox16.BringToFront();

            var textBox17 = new TextBox();
            textBox17.Top = i3;
            textBox17.Left = j3;
            i3 = i3 + 30;
            tabPage2.Controls.Add(textBox17);
            textBox17.BringToFront();

            var textBox18 = new TextBox();
            textBox18.Top = i4;
            textBox18.Left = j4;
            i4 = i4 + 30;
            tabPage2.Controls.Add(textBox18);
           textBox18.BringToFront();
            //вот тут надо подтянуть возраст

            var textBox19 = new TextBox();
            textBox19.Top = i5;
            textBox19.Left = j5;
            i5 = i5 + 30;
            tabPage2.Controls.Add(textBox19);
            textBox19.BringToFront();
            button5.BringToFront();
            button5.Top = y + 30;
            y = y + 30;
          
            groupBox3.Height = yl;
            yl = yl + 30;

            tabControl1.Height = y1;
            y1 = y1 + 30;
            this.Height = yf;
            yf = yf + 30;
            */
          
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            МКБ f2 = new МКБ();
            f2.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mkb_sop f2 = new mkb_sop();
            f2.Show();
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  if (comboBox4.SelectedIndex < 0)
       //     {
            //    button3.Enabled = false;
          //      MessageBox.Show("Укажите стадию ХБП");
               
         //   }
         //   else button3.Enabled = true;

            if ((textBox11.Text == "") || (comboBox4.SelectedIndex < 0))
            {
             //  button3.Enabled = false;
               MessageBox.Show("Заполните все поля");
            }
            else
            {
                Главная f1 = new Главная();
                SqlConnection sc = new SqlConnection(f1.connect);
                SqlCommand cmd, cmd1, cmd2, cmd3, cmd5, cmd6;
                sc.Open();

                int id_hpn_main = Convert.ToInt32(textBox20.Text);
                int qqq = Convert.ToInt32(textBox15.Text);
                int id_terap = Convert.ToInt32(textBox21.Text);
                qqq = qqq + 1;
                id_terap = id_terap + 1;
                //int pp = Convert.ToInt32(textBox8.Text);
                //  int m =  Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
                string m = dataGridView1.Rows[2].Cells[1].Value.ToString();// здесь взяла id врача
                int r = Convert.ToInt32(textBox23.Text) + 1;
                
                
                //   string qwerty = comboBox2.SelectedValue();
                cmd = new SqlCommand("insert into nr_request(ID, TYPE_REG, NUMB, TYPE, DATE_CREATE, CREATE_EMP, STATUS, WORK_EMP,AGENT,MKB,UPDATE_DATE) VALUES('" + qqq + "', 1 ,'" + Convert.ToInt32(textBox15.Text) + "', 1, '" + peremen.Times + "' , '" + m + "', 1, NULL,'" + peremen.id + "', '" + textBox11.Text + "', NULL)", sc);
                // cmd1 = new SqlCommand("insert into nr_patient (Agent,Nos_registr,Registr_date,MKB,Update_date) VALUES('" + peremen.id + "', '" + 1 + "', '" + DateTime.Now.ToShortDateString() + "','" + textBox11.Text + "', NULL)", sc);
                cmd1 = new SqlCommand("insert into r_hpn_main(ID, PID, EMPLOYER, PHONE, ANAMNEZ_LIFE,  ANAMNEZ_ILL) VALUES('" + id_hpn_main  + "' , '" + qqq + "', '" + m.Trim() + "', '" + maskedTextBox1.Text.Trim() + "', '" + textBox6.Text.Trim() + "', '" + textBox4.Text.Trim() + "')", sc);
                cmd2 = new SqlCommand("insert into r_hpn_diagn(ID, PID,IS_MAIN,MKB,NOTE,hbp) VALUES('" + r + "','" + id_hpn_main + "', 1 ,'" + textBox11.Text + "', '" + textBox12.Text + "' , '" + comboBox4.SelectedValue + "')", sc);
                cmd5 = new SqlCommand("insert into r_hpn_terapy(ID,PID,GEM,HPN_ISD,HPN_ISH,HPN_MD,BEGIN_DATE,HPN_DIAL_KIND,HEMOGL, FOSF, KALZ) VALUES('" + id_terap + "','" + id_hpn_main + "', '" + textBox7.Text + "' ,'" + dateTimePicker3.Value.Date + "','" + comboBox3.SelectedValue + "', '" + comboBox2.SelectedValue + "' , '" + dateTimePicker2.Value.Date + "','" + comboBox1.SelectedValue + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox9.Text + "')", sc);
                cmd6 = new SqlCommand("insert into r_hpn_skf(PID,SKF,WEIGHT,KRE,ANALYSE_DATE) VALUES('" + id_terap + "','" + textBox19.Text + "', '" + textBox16.Text + "' , '" + textBox17.Text + "','" + dateTimePicker5.Value.Date + "')", sc);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();

                if (textBox13.Text != "")
                {
                    r = r + 1;
                    cmd3 = new SqlCommand("insert into r_hpn_diagn(ID, PID,IS_MAIN,MKB,NOTE,hbp) VALUES('" + r + "','" + id_hpn_main + "', 0 ,'" + textBox13.Text + "', '" + textBox14.Text + "' , '" + comboBox4.Text + "')", sc);
                    cmd3.ExecuteNonQuery();

                }

                sc.Close();
                //MessageBox.Show("Создано новое извещение на добавление");




                //Синхронизация с базой -------------------------------------------------

                LocalDataCache1SyncAgent syncAgent = new LocalDataCache1SyncAgent();
                //   Microsoft.Synchronization.Data.SyncStatistics syncStats = syncAgent.Synchronize();
                //-----------------t------------------------------------------------------

                this.Close();




           }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
          //  if (textBox7.Text == "")

              //  textBox7.BackColor = Color.Red;

       //     else
            //    textBox7.BackColor = Color.White;

            if (textBox7.Text != "")
            {
            int res;
              if (Int32.TryParse(textBox7.Text, out res))
                    textBox7.BackColor = Color.White;
              else textBox7.BackColor = Color.Yellow;
            
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            int res;
            if (Int32.TryParse(textBox7.Text, out res))
                textBox7.BackColor = Color.White;
            else textBox7.BackColor = Color.Red;
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            int res;
            if (Int32.TryParse(textBox7.Text, out res))
                textBox7.BackColor = Color.White;
            else textBox7.BackColor = Color.Red;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            int res;
            if (Int32.TryParse(textBox7.Text, out res))
                textBox7.BackColor = Color.White;
            else textBox7.BackColor = Color.Red;
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker5.CustomFormat = "dd.MM.yyyy";
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            peremen.Times = dateTimePicker5.Value;
            maskedTextBox5.Text = peremen.Times.ToString("dd.MM.yyyy");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
        }
    }
}
