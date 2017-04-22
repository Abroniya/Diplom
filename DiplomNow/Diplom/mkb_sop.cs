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
    public partial class mkb_sop : Form
    {
        public mkb_sop()
        {
            InitializeComponent();
        }

        private void mkb_sop_Load(object sender, EventArgs e)
        {
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
            f10.textBox13.Text = peremen.mkb1.Trim();
            f10.textBox14.Text = peremen.mkb1_text1.Trim();
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            textBox1.Text = dataGridView1[0, row].Value.ToString();
            peremen.mkb1 = textBox1.Text;
            textBox2.Text = dataGridView1[1, row].Value.ToString();
            peremen.mkb1_text1 = textBox2.Text;

        }
    }
}
