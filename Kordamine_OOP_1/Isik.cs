using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    abstract class Isik
    {
        public string? nimi;
        public int synniAasta;
        public enum Sugu { mees, naine };
        public Sugu sugu;
       


        public Isik(Sugu sugu, string nimi="---", int  synniAasta=0)
        { this.nimi = nimi; this.synniAasta = synniAasta;this.sugu = sugu; }
        public Isik()
        { 
        }
        public Isik(string nimi, int synniAasta ,Sugu inimesesugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = inimesesugu;
            
        }


        public void printinfo()
        {
            Console.WriteLine("{0,-10} {1} {2,4}", nimi, synniAasta, sugu);
        }

        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniAasta;
            return vanus;
        }
        public void muudaNimi(string uusNimi)
        {
            this.nimi=uusNimi;
        }

        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks); 



    }
}
