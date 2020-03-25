using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Hareket_Ettirme
{
    class FormTaşı
    {
        public void MouseDown(bool Durum, Form Form,Point İlkkonum, MouseEventArgs e)
        {
            Durum = true;
            Form.Cursor = Cursors.SizeAll;
            İlkkonum = e.Location;
        }

        public void MouseMove(bool Durum, Form Form, Point İlkkonum, MouseEventArgs e)
        {
            if (Durum)
            {
                Form.Left = e.X + Form.Left - (İlkkonum.X);
                Form.Top = e.Y + Form.Top - (İlkkonum.Y);
            }
        }

        public void MouseUp(bool Durum, Form Form)
        {
            Durum = false;
            Form.Cursor = Cursors.Default;
        }
    }
}
