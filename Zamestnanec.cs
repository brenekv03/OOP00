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
        public Zamestnanec(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public Zamestnanec(string jmeno,string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
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
        public override string ToString()
        {
            string s = "\nJméno: " + jmeno
                + "\nPříjmení: " + prijmeni;
            return base.ToString() + s;//base je předek
        }
    }
}
