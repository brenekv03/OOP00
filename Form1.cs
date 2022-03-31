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
            //Student stdt = new Student();
            Student stdt = new Student("Luboš");
            stdt.OznamkujCJL(3);
            stdt.OznamkujMAT(2);
            stdt.OznamkuPRG(1);
            double p = stdt.Prumer();
            if (p != -1) MessageBox.Show(stdt.GetJmeno() + " má průměr známek: " + p);
            else MessageBox.Show(stdt.GetJmeno() + " není klasifikován");        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student stdt2 = new Student("Kamil", 1, 2, 3);
            double p = stdt2.Prumer();
            if (p != -1) MessageBox.Show(stdt2.GetJmeno() + " má průměr známek: " + p);
            else MessageBox.Show(stdt2.GetJmeno() + " není klasifikován");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student("Bohdan", "Velmez", 5, 5, 5);
            double p = student.Prumer();
            student.SetBydliste("Velkého Meziřičí");
            if (p != -1) MessageBox.Show(student.GetJmeno() +" z " +student.GetBydliste()+ " má průměr známek: " + p);
            else MessageBox.Show(student.GetJmeno() + " z " + student.GetBydliste() + " není klasifikován");

            Student student1 = new Student("Kozel", "Velkých Popovic");
            if (p != -1) MessageBox.Show(student1.GetJmeno() + " z " + student1.GetBydliste() + " má průměr známek: " + p);
            else MessageBox.Show(student1.GetJmeno() + " z " + student1.GetBydliste() + " není klasifikován");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student student1 = new Student("Eustáč", "Praha", 1, 1, 1);
            MessageBox.Show(student1.ToString());
            MessageBox.Show(textBox1.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zamestnanec zamestnanec = new Zamestnanec();
            MessageBox.Show(zamestnanec.ToString());
        }
    }
}
