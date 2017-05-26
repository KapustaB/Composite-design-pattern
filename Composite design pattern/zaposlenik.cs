using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    public class Zaposlenik : ApstraktnaKlasa
    {
        

        public Zaposlenik(String ime,String funkcija, int placa){
            this.ime = ime;
            this.funkcija = funkcija;
            this.placa = placa;
        }
        
        public void raditi(){
            Console.WriteLine("Radim dan i noc"); 
        }

        public override string ispis(){
            return ("Zaposlenik, "+"Ime : " + ime + ", funkcija : " + funkcija + ", placa : " + placa + ", ima podredenih : " + podredeni.Count);
        }
    }
}
