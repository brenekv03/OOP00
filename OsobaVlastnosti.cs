using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00
{
    class OsobaVlastnosti
    {
        /*private string jmeno;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            private set
            {
                jmeno = value;
            }
        }*/
        public string Jmeno { get; private set; } //zkrácená verze;

        /*private string prijmeni;
        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                prijmeni = value;
            }
        }*/
        public string Prijmeni { get; private set; } //Zkrácená verze

        private int vyska;
        public int Vyska
        {
            get //selektor
            {
                return vyska;
            }
            set //modifikátor
            {
                if (value >= 20 && value <= 300) vyska = value;
            }
        }
        private double hmotnost;
        public double Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if (value >= 1 && value <= 500) hmotnost = value;
            }
        }



        public OsobaVlastnosti(string jmeno)
        {
            Jmeno = jmeno;
        }
        public OsobaVlastnosti(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public OsobaVlastnosti(string jmeno, string prijmeni, int vyska, double hmotnost)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vyska = vyska;
            Hmotnost = hmotnost;
        }
        public override string ToString()
        {
            string s = "\nJméno: " + Jmeno +
                "Příjmení: " + Prijmeni +
                //"\n" + celeVelkymi + 
                "\nHmotnost je: " + Hmotnost +
                "\nVýška je: " + Vyska //+
                //"\n BMI je: " + bodyMassIndex;
                ;
            return base.ToString() + "\n" + s;//base je předek
        }
    }
}
