using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    class Voditelj : Zaposlenik
    {
        protected String projekt; 
        public Voditelj(String ime, String funkcija, int placa, String projekt) : base(ime, funkcija, placa){
            this.projekt  = projekt;
            podredeni = new List<Zaposlenik>();
        }

        public void add(Zaposlenik z){
            podredeni.Add(z);
        }
        public void remove(Zaposlenik z){
            podredeni.Remove(z);
        }
        public List<Zaposlenik> getpodredeni(){
            return podredeni;
        }
        public override string ispis(){
            return  ("Voditelj, " + "Ime : " + ime + ", funkcija : " + funkcija + ", placa : " + placa + ", ima podredenih : " + podredeni.Count);
        }

    }
}
