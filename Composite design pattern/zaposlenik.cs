using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    public class Zaposlenik : ApstraktnaKlasa
    {
        protected String ime;
        protected String funkcija;
        protected int placa;
        protected List<Zaposlenik> podredeni;

        public Zaposlenik(String ime,String funkcija, int placa){
            this.ime = ime;
            this.funkcija = funkcija;
            this.placa = placa;
            podredeni = new List<Zaposlenik>();
        }
        
        public void raditi(){
            Console.WriteLine("Radim dan i noc"); 
        }

        public override string ispis(){
            return ("Ne znam ja niš, ja samo delam.  "+"Ime : " + ime + ", funkcija : " + funkcija + ", placa : " + placa + ", ima podredenih : " + podredeni.Count);
        }
    }
}
