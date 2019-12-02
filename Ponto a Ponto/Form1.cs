using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto_a_Ponto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        distancia P1 = new distancia();
        distancia P2 = new distancia();

        private void Button1_Click(object sender, EventArgs e)
        {
            P1.X = Convert.ToDouble(x1.Text);
            P1.Y = Convert.ToDouble(y1.Text);
            P2.X = Convert.ToDouble(x2.Text);
            P2.Y = Convert.ToDouble(y2.Text);
            label4.Text = P1.Distancia(P2).ToString();
        }
    }
}
