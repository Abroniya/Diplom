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
    public partial class Karta_pat : Form
    {
        public Karta_pat()
        {
            InitializeComponent();
        }

        private void Karta_pat_Load(object sender, EventArgs e)
        {
           // New_patient f10 = new New_patient();

            string q123, q22, diag;
            Главная f123 = new Главная();
            SqlConnection conn123 = new SqlConnection(f123.connect);
       
            int m1 = peremen.nom_s;

            MessageBox.Show(m1.ToString());
            q123 = "SELECT a.id, a.surname, a.firstname, a.lastname, mn.ANAMNEZ_ILL, mn.ANAMNEZ_LIFE,  di.MKB, di.NOTE, di.hbp, di.IS_MAIN,  ter.ERITR, ter.GEM, ter.HEMOGL,ter.HPN_DIAL_KIND, ter.HPN_ISD, ter.HPN_ISH, ter.HPN_MD, ter.KETOST, sk.ANALYSE_DATE, sk.KRE,sk.SKF, sk.[WEIGHT] from agent a left join nr_request req on req.AGENT=a.id  left join r_hpn_main mn on req.ID=mn.PID left join r_hpn_diagn di on di.PID=mn.ID left join r_hpn_terapy ter on ter.PID=mn.Id left join r_hpn_skf sk on sk.PID=ter.ID where a.id='" + m1 + "' ";
          SqlDataAdapter ad = new SqlDataAdapter(q123, conn123);
          DataSet ds = new DataSet();
         
            conn123.Open();
            ad.Fill(ds);
            conn123.Close();
            dataGridView3.DataSource = ds.Tables[0];
          dataGridView3.Columns[0].Width = 50;
            dataGridView3.Columns[1].Width = 150;
           
            textBox4.Text = dataGridView3.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView3.Rows[0].Cells[11].Value.ToString();
            textBox8.Text = dataGridView3.Rows[0].Cells[12].Value.ToString();
            maskedTextBox2.Text = dataGridView3.Rows[0].Cells[13].Value.ToString();
            maskedTextBox3.Text = dataGridView3.Rows[0].Cells[14].Value.ToString();
            comboBox3.Text = dataGridView3.Rows[0].Cells[15].Value.ToString();
            comboBox2.Text = dataGridView3.Rows[0].Cells[16].Value.ToString();
            maskedTextBox5.Text = dataGridView3.Rows[0].Cells[18].Value.ToString();
            textBox17.Text = dataGridView3.Rows[0].Cells[19].Value.ToString();
            textBox19.Text = dataGridView3.Rows[0].Cells[20].Value.ToString();
            //подтягивание закончено
            //получение диагнозов

            diag = "SELECT a.id, di.MKB, di.NOTE, di.hbp, di.IS_MAIN from agent a left join nr_request req on req.AGENT=a.id  left join r_hpn_main mn on req.ID=mn.PID left join r_hpn_diagn di on di.PID=mn.ID where a.id='" + m1 + "' "; //тут раньше было 5, подозревашка,что это не верно. в where
            SqlDataAdapter addia = new SqlDataAdapter(diag, conn123);
            DataSet dsdia = new DataSet();
            conn123.Open();
            addia.Fill(dsdia);
            conn123.Close();
            dataGridView4.DataSource = dsdia.Tables[0];
            dataGridView4.Columns[0].Width = 50;
            dataGridView4.Columns[1].Width = 150;
            if (dataGridView4.Rows[0].Cells[4].Value.ToString() == "1")
            {
                textBox11.Text = dataGridView4.Rows[0].Cells[1].Value.ToString();
                textBox12.Text = dataGridView4.Rows[0].Cells[2].Value.ToString();
            }
            if (dataGridView4.Rows[1].Cells[4].Value.ToString() == "0")
            {
                textBox13.Text = dataGridView4.Rows[1].Cells[1].Value.ToString();
                textBox14.Text = dataGridView4.Rows[1].Cells[2].Value.ToString();
            }
            comboBox4.Text = dataGridView4.Rows[0].Cells[3].Value.ToString();
            //конец диагнозов
            //тянем верхний грид
    
            string f11 = dataGridView3.Rows[0].Cells[1].Value.ToString();
            string f12 = dataGridView3.Rows[0].Cells[2].Value.ToString();
            string f13 = dataGridView3.Rows[0].Cells[3].Value.ToString();
          
            textBox1.Text = f11.Trim() + ' ' + f12.Trim() + ' ' + f13.Trim() + ' ';
            //вытягивание нижнего колонтитула
            Главная f223 = new Главная();
            SqlConnection conn1 = new SqlConnection(f223.connect);
        
            string mySelectQuery = " select a.id, e.Firsname, e.Lastname, e.Surname, e.contact, DATE_CREATE from agent a join dbo.nr_request nr on nr.Agent=a.id  join employers e on e.ID=nr.CREATE_EMP  where a.id= '" + m1 + "'";
        
            SqlDataAdapter ad0 = new SqlDataAdapter(mySelectQuery, conn1);
          
            DataSet ds1 = new DataSet();

            conn123.Open();
            ad0.Fill(ds1);
          
            conn123.Close();


            dataGridView2.DataSource = ds1.Tables[0];
            textBox5.Text = dataGridView2.Rows[0].Cells[5].Value.ToString().Trim();
            maskedTextBox1.Text = dataGridView2.Rows[0].Cells[4].Value.ToString().Trim();
            textBox3.Text = dataGridView2.Rows[0].Cells[1].Value.ToString().Trim() + ' ' + dataGridView2.Rows[0].Cells[2].Value.ToString().Trim() + ' ' + dataGridView2.Rows[0].Cells[3].Value.ToString().Trim();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Otchet f2 = new Otchet();
            f2.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
