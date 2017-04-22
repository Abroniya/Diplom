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
    public partial class qwerty : Form
    {
        public qwerty()
        {
            InitializeComponent();
        }

        private void qwerty_Activated(object sender, EventArgs e)
        {
            string q;
            Регистр_ХПН f1 = new Регистр_ХПН();
            SqlConnection conn = new SqlConnection(f1.connect);
            q = "SELECT * FROM dbo.nr_patient";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
        }
    }
}
