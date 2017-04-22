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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest,
            int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        public Bitmap memoryImage;
        public void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
      /*  private System.Drawing.Printing.PrintDocument docToPrint = 
	new System.Drawing.Printing.PrintDocument();*/
        private void Otchet_Load(object sender, EventArgs e)
        {
            int m1 = peremen.nom_s;
            string q;
            Главная f1 = new Главная();
            SqlConnection conn = new SqlConnection(f1.connect);

            q = " SELECT a.id, a.surname, a.firstname, a.lastname, a.birthdate ,di.MKB, di.NOTE,  e.Surname, e.Firsname, e.Lastname, req.DATE_CREATE , sk.SKF from agent a left join nr_request req on req.AGENT=a.id  left join r_hpn_main mn on req.ID=mn.PID left join r_hpn_diagn di on di.PID=mn.ID join employers e on req.CREATE_EMP=e.ID left join r_hpn_terapy ter on ter.PID=mn.ID left join r_hpn_skf sk on sk.PID=ter.ID where  di.IS_MAIN = 1 and a.id='" + m1 + "' ";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            conn.Open();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            conn.Close();
            string Fam = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string Im = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string Ot = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string Fe = dataGridView1.Rows[0].Cells[7].Value.ToString();
            string Ie = dataGridView1.Rows[0].Cells[8].Value.ToString();
            string Oe = dataGridView1.Rows[0].Cells[9].Value.ToString();

            label9.Text = Fam.Trim() + ' ' + Im.Trim() + ' ' + Ot.Trim();
            label10.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            label12.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            label13.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
            label14.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
            label15.Text = Fe.Trim() + ' ' + Ie.Trim() + ' ' + Oe.Trim();
            label16.Text = DateTime.Now.ToString();
        }
      /*  public void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
           /* // Allow the user to choose the page range he or she would
            // like to print.
            PrintDialog1.AllowSomePages = true;

            // Show the help button.
            PrintDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            PrintDialog1.Document = docToPrint;

            DialogResult result = PrintDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
            */
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

     /*   private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            DateTime date = DateTime.Now;

            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            var Report = ObjWorkSheet.get_Range("A1", "A1");
            Report.Font.Size = "22";
            var Report2 = ObjWorkSheet.get_Range("A1", "A1");
            Report2.Font.Size = "22";
            ObjWorkSheet.Cells[1, 1] = "Отчет по предприятиям";
            if (comboBox1.Text == "") ObjWorkSheet.Cells[2, 1] = "Выпускники работающие на всех предприятиях";
            else ObjWorkSheet.Cells[2, 1] = "Выпускники работающие на " + comboBox1.Text;
            ObjWorkSheet.Cells[3, 1] = "Выпускник";
            ((Excel.Range)ObjWorkSheet.Columns[1, Type.Missing]).EntireColumn.ColumnWidth = "40";
            ObjWorkSheet.Cells[3, 2] = "Email";
            ((Excel.Range)ObjWorkSheet.Columns[2, Type.Missing]).EntireColumn.ColumnWidth = "40";
            ObjWorkSheet.Cells[3, 3] = "Телефон";
            ((Excel.Range)ObjWorkSheet.Columns[3, Type.Missing]).EntireColumn.ColumnWidth = "25";
            ObjWorkSheet.Cells[3, 4] = "Рабочий телефон";
            ((Excel.Range)ObjWorkSheet.Columns[4, Type.Missing]).EntireColumn.ColumnWidth = "25";


            var cells = ObjWorkSheet.get_Range("A3", "D" + (dataGridView1.RowCount + 3).ToString());

            cells.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous; // внутренние вертикальные
            cells.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous; // внутренние горизонтальные 
            cells.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble; // верхняя внешняя
            cells.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble; // правая внешняя
            cells.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble; // левая внешняя
            cells.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble; // нижняя внешняя

            DateTime date1 = DateTime.Now; ObjWorkSheet.Cells[1, 4] = date1.ToString();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {

                    ObjWorkSheet.Cells[i + 4, 1] = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                    ObjWorkSheet.Cells[i + 4, 2] = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                    ObjWorkSheet.Cells[i + 4, 3] = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                    ObjWorkSheet.Cells[i + 4, 4] = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();


                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Ошибка!");
                    return;

                }
                ObjExcel.Visible = true;
                ObjExcel.UserControl = true;

            }
            
        }*/
       /* private void document_PrintPage(object sender,
    System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }*/


    }


}
