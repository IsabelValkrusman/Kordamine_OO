using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
     class Tootaja : Isik
    {

        public string? asutus;
        public string? amet;
        public double tootasu;
        public double tunnitasu;



        public Tootaja(string nimi, Sugu sugu)
        {
            this.nimi = nimi;
            this.sugu = sugu;

        }

        public Tootaja(string nimi, int synniAasta, Isik.Sugu sugu, string asutus, string amet, int tootasu, double tunnitasu)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
            this.tunnitasu = tunnitasu;
        }
        

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = ((tootasu - maksuvaba) * (tulumaks / 100));
            return netopalk;
        }

        public double arvutaTootunnid()
        {
            return tootasu / tunnitasu;
        }

        public void muudaAmet(string uusAmet)
        {
            this.amet = uusAmet;
        }

        public void tostaTootasu(double protsent)
        {
            protsent = protsent / 100;
            double uusPalk = tootasu * (1 + protsent);
            this.tootasu = uusPalk;
        }

       
    }

}
