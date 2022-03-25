using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stdt0 = new Student();
            Student stdt = new Student("Luboš");
            stdt.OznamkujCJL(3);
            stdt.OznamkujMAT(2);
            stdt.OznamkuPRG(1);
            double p = stdt.Prumer();
            if (p != -1) MessageBox.Show(stdt.GetJmeno() + " má průměr známek: " + p);
            else MessageBox.Show(stdt.GetJmeno() + " není klasifikován");        
        }
    }
}
