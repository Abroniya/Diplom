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
    public partial class МКБ : Form
    {
        public МКБ()
        {
            InitializeComponent();
        }

        private void МКБ_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen; 
            string q;
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);

            q = "SELECT id as 'Код МКБ10', MKB10 as 'Наименование' from MKB10 ";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 200;
         
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_patient f10 = new New_patient();
            f10.Show();
            f10.textBox11.Text = peremen.mkb.Trim();
            f10.textBox12.Text = peremen.mkb_text.Trim();
                        this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            textBox1.Text = dataGridView1[0, row].Value.ToString();
            textBox2.Text = dataGridView1[1, row].Value.ToString();
            peremen.mkb = textBox1.Text;
            peremen.mkb_text = textBox2.Text;

        }
    }
}
