using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
   public class Button_View:Button
    {
       public Button_View()
        {
            this.MouseEnter += new EventHandler(Button_View_MouseEnter);
            this.MouseLeave += new EventHandler(Button_View_MouseLeave);
        }
       void Button_View_MouseLeave(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.res2;
        }

       void Button_View_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.res2;
        }
    }
}
