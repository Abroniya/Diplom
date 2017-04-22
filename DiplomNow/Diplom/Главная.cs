using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Главная : Form
    {
        
        public string connect = "Data Source=localhost;Initial Catalog=hpn;Integrated Security=True";
      
        public Главная()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

           

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hpnDataSet.agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.hpnDataSet.agent);
            this.IsMdiContainer = true;
            if (peremen.k != 10)
            {
                Авторизация f2 = new Авторизация();
                //f2.MdiParent = this;
                f2.ShowDialog();
            }
        }

        private void данныеПоРегструОКСToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void регистрХПНToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Регистр_ХПН f2 = new Регистр_ХПН();
            f2.MdiParent = this;
            f2.Show();
        }

        private void регистрБАИХОБЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   qqq f2 = new qqq();
          //  f2.MdiParent = this;
          //  f2.Show();
        }

        private void регистрССЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
           qwerty f2 = new qwerty();
           f2.MdiParent = this;
            f2.Show();
        }

        private void Главная_Activated(object sender, EventArgs e)
        {

        }
    }
}
