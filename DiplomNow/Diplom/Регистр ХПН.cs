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
    public partial class Регистр_ХПН : Form
    {
        public string connect = "Data Source=localhost;Initial Catalog=hpn;Integrated Security=True";
      
        public Регистр_ХПН()
        {
            InitializeComponent();
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Регистр_ХПН_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy51ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Регистр_ХПН_Activated(object sender, EventArgs e)
        {
            string q, q1, q2, q3;
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);
            q = "SELECT nr.ID as 'Номер в регистре', ag.surname as 'Фамилия', ag.firstname as 'Имя', ag.lastname as 'Отчество', ag.birthdate as 'Дата рождения', nr.MKB  as 'МКБ заболевания', nr.Registr_date as 'Дата включения', ou.visit_date  as 'Дата исключения' , ou.Remove_reason as 'Причина исключения' FROM nr_patient nr join nos_registr nos on nr.Nos_registr =nos.ID join agent ag on nr.Agent=ag.id left join hpn_out ou on nr.ID=ou.PID  where nos.nr_code='HPN'";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
           // dataGridView1.Columns[9].Width = 100;
            //второй грид//

            q1 = "select * from Nr_reqv_pat where type=1"; //не забудь сделать ограничение что это только на добавление
            SqlDataAdapter ad1 = new SqlDataAdapter(q1, conn);
            DataSet ds1 = new DataSet();
            conn.Open();
            ad1.Fill(ds1);
            conn.Close();
            dataGridView2.DataSource = ds1.Tables[0];

            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[5].Width = 100;
            dataGridView2.Columns[6].Width = 100;
            dataGridView2.Columns[7].Width = 100;
        //    dataGridView2.Columns[13].Visible = false;
           
            //третий грид//

            q2 = "select r.ID as 'Номер извещения', stre.Status as 'Статус', (rtrim(ag.surname) + ' ' + rtrim(ag.firstname)  +  ' ' +  rtrim(ag.lastname)) as 'ФИО', ag.birthdate as 'Дата рождения', em.fio as 'Сотрудник сформировавший', r.DATE_CREATE as 'Дата формирования', r.update_date as 'Дата изменения статуса', ee.fio 'Изменил статус' from nr_request r join agent ag on r.AGENT=ag.id join employers em on r.CREATE_EMP=em.ID join Status_request stre on stre.ID=r.STATUS join employers ee on ee.ID=r.WORK_EMP where TYPE_REG=2";
            SqlDataAdapter ad2 = new SqlDataAdapter(q2, conn);
            DataSet ds2 = new DataSet();
            conn.Open();
            ad2.Fill(ds2);
            conn.Close();
            dataGridView3.DataSource = ds2.Tables[0];

            dataGridView3.Columns[0].Width = 100;
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Width = 100;
            dataGridView3.Columns[4].Width = 100;
            dataGridView3.Columns[5].Width = 100;
            dataGridView3.Columns[6].Width = 100;
            dataGridView3.Columns[7].Width = 100;
         //   dataGridView3.Columns[8].Width = 100;
            //четвертый грид//

            q3 = "select r.ID as 'Номер извещения', stre.Status as 'Статус', (rtrim(ag.surname) + ' ' + rtrim(ag.firstname)  +  ' ' +  rtrim(ag.lastname)) as 'ФИО', ag.birthdate as 'Дата рождения', em.fio as 'Сотрудник сформировавший', r.DATE_CREATE as 'Дата формирования', r.update_date as 'Дата изменения статуса', ee.fio 'Изменил статус' from nr_request r join agent ag on r.AGENT=ag.id join employers em on r.CREATE_EMP=em.ID join Status_request stre on stre.ID=r.STATUS join employers ee on ee.ID=r.WORK_EMP where TYPE_REG=3";
            SqlDataAdapter ad3 = new SqlDataAdapter(q3, conn);
            DataSet ds3 = new DataSet();
            conn.Open();
            ad2.Fill(ds3);
            conn.Close();
            dataGridView4.DataSource = ds3.Tables[0];

            dataGridView4.Columns[0].Width = 100;
            dataGridView4.Columns[1].Width = 100;
            dataGridView4.Columns[2].Width = 100;
            dataGridView4.Columns[3].Width = 100;
            dataGridView4.Columns[4].Width = 100;
            dataGridView4.Columns[5].Width = 100;
            dataGridView4.Columns[6].Width = 100;
            dataGridView4.Columns[7].Width = 100;
      //      dataGridView4.Columns[8].Width = 100;

            ToolStripMenuItem SeeMenuItem = new ToolStripMenuItem("Просмотр");
            ToolStripMenuItem GoMenuItem = new ToolStripMenuItem("Отправить на утверждение");
            ToolStripMenuItem YesMenuItem = new ToolStripMenuItem("Утвердить");
            ToolStripMenuItem NoMenuItem = new ToolStripMenuItem("Отклонить");
            ToolStripMenuItem ExMenuItem = new ToolStripMenuItem("Вeрнуть с утверждения");
            contextMenuStrip1.Items.AddRange(new[] { SeeMenuItem, GoMenuItem, ExMenuItem, YesMenuItem, NoMenuItem });
            // ассоциируем контекстное меню с текстовым полем
            dataGridView2.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            dataGridView3.ContextMenuStrip = contextMenuStrip1;
            dataGridView4.ContextMenuStrip = contextMenuStrip1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void регистрХПНToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Регистр_ХПН f2 = new Регистр_ХПН();
            f2.Show();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void утвердитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            New_patient f2 = new New_patient();
            f2.Show();
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {

            
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int ss = dataGridView2.CurrentRow.Index; //узнали индекс строки. по которой пкм
            string ss1 = Convert.ToString(ss);
            if (dataGridView2.Rows[ss].Cells[5].Value.ToString().Trim() == "Отклонена")
            {
                MessageBox.Show("Нельзя утвердить отклоненную заявку");
            }
            else
            {
                Главная f20 = new Главная();
                SqlConnection sc = new SqlConnection(f20.connect);
                //-----------------------------Определение строки datagrid и id заявки--------------------------------------------------//
                int s = dataGridView2.CurrentRow.Index;
                string s1 = Convert.ToString(s);
                p1 = dataGridView2.Rows[s].Cells[0].Value.ToString();
                int p2 = Convert.ToInt32(p1);

                SqlCommand cmd, cmd1, cmd2, cmd2_2, cmd3, cmd5, cmd6; // создали штуку для запроса
                String cmd_r, cmd1_r, cmd2_r, cmd2_r_2, cmd3_r, cmd5_r, cmd6_r;
                string t1, t2, t3, t4, t5, t6, t7;
                int w1, w2, w3, w4, w5, w6, w7;
                //    sc.Open();//открыли
                //----------------------------------Последний номер в регистре пацентов-----------------------------------------//
                string mySelectQuery5 = "select max(nr.id) from dbo.nr_patient nr";
                SqlDataAdapter ad13 = new SqlDataAdapter(mySelectQuery5, sc);
                DataSet ds13 = new DataSet();
                sc.Open();
                ad13.Fill(ds13);
                sc.Close();
                dataGridView1.DataSource = ds13.Tables[0]; // в 0 строке 0 столбца хранится последний номер заявок(существующих)
                textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                int qqq = Convert.ToInt32(textBox1.Text);
                qqq = qqq + 1; // сделали седующую по счету
                //------------------------------------Вставка данных при утверждении-------------------------------------------//

                //------------------------------------Обновление статуса заявки-----------------------------------------------//
                sc.Open();
                cmd = new SqlCommand("UPDATE nr_request SET STATUS=" + "'" + 3 + "', Update_date=" + "'" + DateTime.Now.ToShortDateString() + "' WHERE ID = " + p2, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                //---------------------------------------Вставка в nr_patients------------------------------------------------//
                sc.Open();
                cmd1 = new SqlCommand("insert into nr_patient (ID, Agent,Nos_registr,Registr_date,MKB,Update_date) VALUES('" + qqq + "' , '" + +peremen.id + "' , '" + 1 + "', '" + DateTime.Now.ToShortDateString() + "','" + dataGridView2.Rows[s].Cells[4].Value.ToString() + "', NULL)", sc);
                cmd1.ExecuteNonQuery();
                sc.Close();
                //---------------------------------------Вставка в hpn_main ------------------------------------------------//

                cmd3_r = "select r.ID, m.ANAMNEZ_ILL, m.ANAMNEZ_LIFE, m.EMPLOYER, m.PHONE, m.ID from nr_request r left join r_hpn_main m on r.ID=m.PID where r.ID='" + p2 + "'";

                SqlDataAdapter ad3_r = new SqlDataAdapter(cmd3_r, sc);
                DataSet ds3_r = new DataSet();
                sc.Open();
                ad3_r.Fill(ds3_r);
                sc.Close();
                dataGridView_main.DataSource = ds3_r.Tables[0];//тут
                textBox_main.Text = dataGridView_main.Rows[0].Cells[5].Value.ToString();

                //  MessageBox.Show(t6);

                w6 = Convert.ToInt32(textBox_main.Text) + 1;
                sc.Open();
                cmd3 = new SqlCommand("insert into hpn_main(ID, PID, EMPLOYER, PHONE, ANAMNEZ_LIFE,  ANAMNEZ_ILL) VALUES('" + w6 + "' , '" + qqq + "', '" + dataGridView_main.Rows[0].Cells[3].Value.ToString() + "', '" + dataGridView_main.Rows[0].Cells[4].Value.ToString() + "', '" + dataGridView_main.Rows[0].Cells[2].Value.ToString() + "', '" + dataGridView_main.Rows[0].Cells[1].Value.ToString() + "')", sc);
                cmd3.ExecuteNonQuery();
                sc.Close();
                //---------------------------------------Вставка в hpn_diagn основного диагноза------------------------------------------------//

                cmd2_r = "select req.ID, d.IS_MAIN, d.MKB, d.NOTE, d.hbp, d.ID  from nr_request r join r_hpn_main req on r.ID=req.PID left join r_hpn_diagn d on d.PID=req.ID  where r.ID='" + p2 + "' and d.is_main = 1";
                SqlDataAdapter ad2_r = new SqlDataAdapter(cmd2_r, sc);
                DataSet ds2_r = new DataSet();
                sc.Open();
                ad2_r.Fill(ds2_r);
                sc.Close();
                dataGridView_diagn.DataSource = ds2_r.Tables[0];
                //    textBox_diagn.Text = dataGridView_diagn.Rows[0].Cells[0].Value.ToString();
                //     w5 = Convert.ToInt32(textBox_diagn.Text);
                d1.Text = dataGridView_diagn.Rows[0].Cells[2].Value.ToString();
                d2.Text = dataGridView_diagn.Rows[0].Cells[3].Value.ToString();
                d3.Text = dataGridView_diagn.Rows[0].Cells[4].Value.ToString();
                d7.Text = dataGridView_diagn.Rows[0].Cells[5].Value.ToString();
                int a1, a2;
                a1 = Convert.ToInt32(dataGridView_diagn.Rows[0].Cells[0].Value.ToString());
                a2 = Convert.ToInt32(d7.Text);
                MessageBox.Show(dataGridView_diagn.Rows[0].Cells[0].Value.ToString());
                MessageBox.Show(d7.Text);
                sc.Open();
                cmd2 = new SqlCommand("insert into hpn_diagn(ID,PID,IS_MAIN,MKB,NOTE,hbp) VALUES('" + a2 + "','" + a1 + "', 1 ,'" + d1.Text + "', '" + d2.Text + "' , '" + d3.Text + "')", sc);
                cmd2.ExecuteNonQuery();
                sc.Close();
                //---------------------------------------Вставка в hpn_diagn сопутствующего диагноза------------------------------------------------//
                cmd2_r_2 = "select req.ID, d.IS_MAIN, d.MKB, d.NOTE, d.hbp, d.ID  from nr_request r join r_hpn_main req on r.ID=req.PID left join r_hpn_diagn d on d.PID=req.ID  where r.ID='" + p2 + "' and d.is_main  = 0";
                SqlDataAdapter ad2_r_2 = new SqlDataAdapter(cmd2_r_2, sc);
                DataSet ds2_r_2 = new DataSet();
                sc.Open();
                ad2_r_2.Fill(ds2_r_2);
                sc.Close();
                dataGridView_diag_0.DataSource = ds2_r_2.Tables[0];


                // textBox_diagn_0.Text = dataGridView_diag_0.Rows[0].Cells[5].Value.ToString();
                //      w4 = Convert.ToInt32(textBox_diagn.Text);
                if (dataGridView_diagn.Rows[0].Cells[2].Value.ToString() != "")
                {
                    d4.Text = dataGridView_diag_0.Rows[0].Cells[2].Value.ToString();
                    d5.Text = dataGridView_diag_0.Rows[0].Cells[3].Value.ToString();
                    d6.Text = dataGridView_diag_0.Rows[0].Cells[4].Value.ToString();
                    d8.Text = dataGridView_diagn.Rows[0].Cells[5].Value.ToString();
                    int a3, a4;
                    a3 = Convert.ToInt32(dataGridView_diag_0.Rows[0].Cells[0].Value.ToString());
                    a4 = Convert.ToInt32(d8.Text) + 1;
                    sc.Open();
                    cmd2_2 = new SqlCommand("insert into hpn_diagn(ID,PID,IS_MAIN,MKB,NOTE,hbp) VALUES('" + a4 + "','" + a3 + "', 0 ,'" + d4.Text + "', '" + d5.Text + "' , '" + d6.Text + "')", sc);
                    cmd2_2.ExecuteNonQuery();
                    sc.Close();
                }
                //---------------------------------------Вставка в hpn_terap------------------------------------------------//
                cmd5_r = "select m.ID , t.ID, t.GEM,t.HPN_ISD, t.HPN_ISH,  t.HPN_MD, t.BEGIN_DATE, t.HPN_DIAL_KIND, t.HEMOGL,t.FOSF, t.KALZ from nr_request r join r_hpn_main m  on r.ID=m.PID left join r_hpn_terapy t on t.PID=m.ID   where r.ID='" + p2 + "'";
                SqlDataAdapter ad5_r = new SqlDataAdapter(cmd5_r, sc);
                DataSet ds5_r = new DataSet();
                sc.Open();
                ad5_r.Fill(ds5_r);
                sc.Close();
                dataGridView_terap.DataSource = ds5_r.Tables[0];//тут
                //textBox_main.Text = dataGridView_terap.Rows[0].Cells[1].Value.ToString();

                w7 = Convert.ToInt32(dataGridView_terap.Rows[0].Cells[1].Value.ToString()) + 1;
                int w8 = Convert.ToInt32(dataGridView_terap.Rows[0].Cells[0].Value.ToString());
                int w9 = Convert.ToInt32(dataGridView_terap.Rows[0].Cells[4].Value.ToString());
                int w10 = Convert.ToInt32(dataGridView_terap.Rows[0].Cells[5].Value.ToString());
                int w11 = Convert.ToInt32(dataGridView_terap.Rows[0].Cells[7].Value.ToString());

                sc.Open();
                cmd5 = new SqlCommand("insert into hpn_terapy(ID,PID,GEM,HPN_ISD,HPN_ISH,HPN_MD,BEGIN_DATE,HPN_DIAL_KIND,HEMOGL,FOSF,KALZ) VALUES('" + w7 + "','" + w8 + "', '" + dataGridView_terap.Rows[0].Cells[2].Value.ToString() + "' ,'" + Convert.ToDateTime(dataGridView_terap.Rows[0].Cells[3].Value.ToString()) + "','" + w9 + "', '" + w10 + "' , '" + Convert.ToDateTime(dataGridView_terap.Rows[0].Cells[6].Value.ToString()) + "','" + w11 + "','" + dataGridView_terap.Rows[0].Cells[8].Value.ToString() + "','" + dataGridView_terap.Rows[0].Cells[9].Value.ToString() + "','" + dataGridView_terap.Rows[0].Cells[10].Value.ToString() + "')", sc);
                cmd5.ExecuteNonQuery();
                sc.Close();
                //---------------------------------------Вставка в hpn_skf------------------------------------------------//
                cmd6_r = "Select m.ID , t.ID, s.ID, s.ANALYSE_DATE, s.KRE, s.SKF, s.[WEIGHT] from nr_request r join r_hpn_main m  on r.ID=m.PID left join r_hpn_terapy t on t.PID=m.ID left join r_hpn_skf s on s.PID=t.ID where r.ID='" + p2 + "'";
                SqlDataAdapter ad6_r = new SqlDataAdapter(cmd6_r, sc);
                DataSet ds6_r = new DataSet();
                sc.Open();
                ad6_r.Fill(ds6_r);
                sc.Close();
                dataGridView_skf.DataSource = ds6_r.Tables[0];
                int w12, w13, w16;
                decimal w14, w15;
                w12 = Convert.ToInt32(dataGridView_skf.Rows[0].Cells[2].Value.ToString()) + 1;
                w13 = Convert.ToInt32(dataGridView_skf.Rows[0].Cells[1].Value.ToString()) + 1;
                w14 = Convert.ToDecimal(dataGridView_skf.Rows[0].Cells[4].Value.ToString());
                w15 = Convert.ToDecimal(dataGridView_skf.Rows[0].Cells[5].Value.ToString());
                MessageBox.Show(dataGridView_skf.Rows[0].Cells[6].Value.ToString());

                w16 = Convert.ToInt32(dataGridView_skf.Rows[0].Cells[6].Value.ToString());
                sc.Open();
                cmd6 = new SqlCommand("insert into hpn_skf(ID,PID,SKF,WEIGHT,KRE,ANALYSE_DATE) VALUES('" + w12 + "','" + w13 + "', '" + w15 + "' , '" + w16 + "','" + w14 + "','" + Convert.ToDateTime(dataGridView_skf.Rows[0].Cells[3].Value.ToString()) + "')", sc);
                cmd6.ExecuteNonQuery();
                sc.Close();



                //---------------------------------------обновление датагрида с заявками на изменение-----------------------//
                string q1 = "select * from Nr_reqv_pat  where type=1";
                SqlDataAdapter ad1 = new SqlDataAdapter(q1, sc);
                DataSet ds1 = new DataSet();
                sc.Open();
                ad1.Fill(ds1);
                sc.Close();
                dataGridView2.DataSource = ds1.Tables[0];

                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[1].Width = 100;
                dataGridView2.Columns[2].Width = 100;
                dataGridView2.Columns[3].Width = 100;
                dataGridView2.Columns[4].Width = 100;
                dataGridView2.Columns[5].Width = 100;
                dataGridView2.Columns[6].Width = 100;
                dataGridView2.Columns[7].Width = 100;
                //---------------------------------------обновление датагрида с пацентами регистра-----------------------//
                string q;

                q = "SELECT nr.ID as 'Номер в регистре', ag.surname as 'Фамилия', ag.firstname as 'Имя', ag.lastname as 'Отчество', ag.birthdate as 'Дата рождения', nr.MKB  as 'МКБ заболевания', nr.Registr_date as 'Дата включения', ou.visit_date  as 'Дата исключения' , ou.Remove_reason as 'Причина исключения' FROM nr_patient nr join nos_registr nos on nr.Nos_registr =nos.ID join agent ag on nr.Agent=ag.id left join hpn_out ou on nr.ID=ou.PID  where nos.nr_code='HPN'";
                SqlDataAdapter ad = new SqlDataAdapter(q, sc);
                DataSet ds = new DataSet();
                sc.Open();
                ad.Fill(ds);
                sc.Close();
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[8].Width = 100;
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int s = dataGridView2.CurrentRow.Index; //узнали индекс строки. по которой пкм
            string s1 = Convert.ToString(s);
            if (dataGridView2.Rows[s].Cells[5].Value.ToString().Trim() == "Утверждена")
            {
                MessageBox.Show("Нельзя отклонить утвержденную заявку");
            }
           else{    
            
            p1 = dataGridView2.Rows[s].Cells[0].Value.ToString(); //айдиха с БД (номер с таблички по заявкам)
            int p2 = Convert.ToInt32(p1);
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);
            SqlCommand cmd;
            conn.Open();
            cmd = new SqlCommand("UPDATE nr_request SET STATUS=" + "'" + 4 + "', Update_date=" + "'" + DateTime.Now.ToShortDateString() + "' WHERE ID = " + p2, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
         //   MessageBox.Show("Пользователь успешно удален");
            //обновили
            Главная f20 = new Главная(); // открыли строку соединения, она на форме главная
            SqlConnection sc = new SqlConnection(f20.connect); // соединяемся
         //   SqlCommand cmd; // создали штуку для запроса
            string q1 = "select * from Nr_reqv_pat  where type=1"; //не забудь сделать ограничение что это только на добавление
            SqlDataAdapter ad1 = new SqlDataAdapter(q1, sc);
            DataSet ds1 = new DataSet();
            sc.Open();
            ad1.Fill(ds1);
            sc.Close();
            dataGridView2.DataSource = ds1.Tables[0];

            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[5].Width = 100;
            dataGridView2.Columns[6].Width = 100;
            dataGridView2.Columns[7].Width = 100;

           }


        }

        private void просмотрToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int s = dataGridView2.CurrentCell.RowIndex; //узнали индекс строки. по которой пкм
            string s1 = Convert.ToString(s);
            string t = dataGridView2.Rows[s].Cells[13].Value.ToString();
         //   MessageBox.Show("Чо передаем?");
         //   MessageBox.Show(t);
            peremen.nom_s = Convert.ToInt32(t);
            Karta_pat f2 = new Karta_pat();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notice_update f2 = new Notice_update();
            f2.Show();
        }
       
    }
}

      