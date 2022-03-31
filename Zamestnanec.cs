using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00
{
    class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private string celeVelkymi;
        private int vyska;
        private double hmotnost;
        private double bodyMassIndex;
        public Zamestnanec(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public Zamestnanec(string jmeno,string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }
        public Zamestnanec(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vyska = vyska;
            this.hmotnost = hmotnost;
        }
        public string GetJmeno()
        {
            return jmeno;
        }
        public string GetPrijmeni()
        {
            return prijmeni;
        }
        public void SetPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
        }

        public int GetVyska()
        {
            return vyska;
        }
        public void SetVyska(int vyska)
        {
            if (vyska >= 20 && vyska <= 300) this.vyska = vyska;
        }

        public double GetHmotnost()
        {
            return hmotnost;
        }
        public void SetHmotnost(double hmotnost)
        {
            if(hmotnost>=1&&hmotnost<=500) this.hmotnost = hmotnost;
        }

        public string CeleVelkymi(string jmeno, string prijmeni)
        {
            celeVelkymi = jmeno.ToUpper() +" "+ prijmeni.ToUpper();
            return celeVelkymi;
        }

        public double BodyMassIndex(int vyska, double hmotnost)
        {
            bodyMassIndex = hmotnost / Math.Pow(vyska / 100,2);
            return bodyMassIndex;
        }
        public override string ToString()
        {
            string s = "\nJméno: " + jmeno + "Příjmení: " + prijmeni + "\n" + celeVelkymi + "\nHmotnost je: " + hmotnost + "\nVýška je: " + vyska + "\n BMI je: " + bodyMassIndex;
            return base.ToString() + "\n"+ s;//base je předek
        }
    }
}
