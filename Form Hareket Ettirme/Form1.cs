using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Hareket_Ettirme
{
    public partial class Form1 : Form
    {
        FormTaşı FT = new FormTaşı();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Point İlkkonum;

        bool Durum = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //FT.MouseDown(Durum, this, İlkkonum, e);

            Durum = true;
            this.Cursor = Cursors.SizeAll;
            İlkkonum = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //FT.MouseMove(Durum, this, İlkkonum, e);

            if (Durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //FT.MouseUp(Durum, this);
            Durum = false;
            this.Cursor = Cursors.Default;
        }
    }
}
