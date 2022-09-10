using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Opilane : Isik
    {
        public string? koolinimi;
        public int klass;
        public string? spetsialiseerumine;
        public double taskuraha;
        public List<string> haridus;
        public Dictionary<string, List<int>> hinded;
        public List<Isik> inimesed = new List<Isik>();
        //public double eritoetus;
       
       

        public Opilane()
        {
            this.inimesed = new List<Isik>();
            this.haridus = new List<string>();
            hinded = new Dictionary<string, List<int>>();
        }

        public override void printinfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", nimi, synniAasta, sugu, koolinimi, klass, spetsialiseerumine, taskuraha);
        }


        public Opilane(string koolinimi, int klass, string spetsialiseerumine, double taskuraha, List<string> haridus/*, double eritoetus*/)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.taskuraha = taskuraha;
            this.haridus = haridus;
            //this.eritoetus = eritoetus;
        }


        //public void toetus()
        //{
        //    int k = 0;
        //    int soidutoetus=30;
        //    int pohitoetus = 60;
        //    int eritoetus = 45;

        //    if()
        //    {
        //        k += soidutoetus;
        //    }
        //    else if()
        //    {
        //        k += pohitoetus;
        //    }
        //}



        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            return taskuraha;
        }

       

        public void eriala(string koolieriala)
        {
            haridus.Add(koolieriala);
        }
        

        public void lisaAine(string aine)
        {   
            // vaatame, kas Dictionary hinded ei sisalda ainet
            // kui samanimelist ainet pole, siis lisame selle, vastasel juhul ei tee midagi
            if (!hinded.ContainsKey(aine)) {
                hinded.Add(aine, new List<int>());
            }
        }

        public void eemaldaAine(string aine)
        {   // vaatame, kas Dictionarys on olemas antud nimega aine, kui on, siis eemaldame selle, vastasel juhul ei tee midagi
            if(hinded.ContainsKey(aine))
            {
                hinded.Remove(aine);
            }
        }

        public void lisaHinne(string aine, int hinne)
        {
            // vaatame, kas dictionaris on olemas antud aine
            if (hinded.ContainsKey(aine)) {
                // kui aine on olemas, siis saame väärtuse ning lisame hinde
                List<int> aineHinded = hinded[aine];
                aineHinded.Add(hinne);
            }
            // vastasel juhule ei tee midagi
        }


        public void vaataHinded()
        {
            foreach (var item in hinded)
            {
                Console.WriteLine("-----------");
                Console.WriteLine(item.Key);
                Console.WriteLine(string.Join(",",item.Value));
                Console.WriteLine("-----------");
            }
        }
        public void vaataHindedAineKohta(string aine)
        {
            if(hinded.ContainsKey(aine))
            {
                Console.WriteLine("-----------");
                Console.WriteLine(aine);
                Console.WriteLine(string.Join(",", hinded[aine]));
                Console.WriteLine("-----------");
            }
            else
            {
                Console.WriteLine("ainet ei leitud");
            }
            
        }
      
          
       

    }
}
