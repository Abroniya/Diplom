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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
 




            peremen.nick = textBox1.Text.Trim();
            peremen.pass = textBox2.Text;
            string myConnectionString = @"Data Source=localhost;Initial Catalog=hpn;Integrated Security=True";
            string mySelectQuery = "SELECT Name_User FROM Users WHERE Name_User = '" + peremen.nick + "'and Password='" + peremen.pass + "'";
           
            
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 0) //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    
                    MessageBox.Show("Логин/Пароль не верны!");
                    
                }
                else
                {
                                     
                    this.Close();
                }
            }




        
        }

        private void Авторизация_Activated(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
          
        }
    }
}
