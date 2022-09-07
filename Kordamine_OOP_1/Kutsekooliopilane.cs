using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Kutsekooliopilane:Isik
    {
        public string? oppeasutus;
        public string? eriala;
        public int kursus;
        public double toetus;
        public List<string> nadalatunnid;
       



        public Kutsekooliopilane()
        {
            this.nadalatunnid = new List<string>();
        }


        public Kutsekooliopilane(string oppeasutus, string eriala, int kursus, double toetus, List<string> nadalatunnid)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.nadalatunnid = nadalatunnid;
            
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = (toetus * (tulumaks / 100));
            return netopalk;
        }


        public void lisaTund(string tund)
        {
            nadalatunnid.Add(tund);
        }

        public void eemaldaTund(string tund)
        {
            nadalatunnid.Remove(tund);
        }

        public void kursused(int kursustearv)
        {
            this.kursus = kursustearv;
        }

        

    }
}
