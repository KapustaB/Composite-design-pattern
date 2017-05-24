using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    class Direktor : Voditelj
    {
        protected String stranka;
        public Direktor(string ime, string funkcija, int placa, string projekt, String stranka) : base(ime, funkcija, placa, projekt){
            this.stranka = stranka;
        }
        public override string ispis(){
            return  ("Ja sam glavni  " + "Ime : " + ime + ", funkcija : " + funkcija + ", placa : " + placa + ", ima podredenih : " + podredeni.Count +", "+ ipisStranke());
        }
        public String ipisStranke(){
            return ("Moja stranka je:" + stranka);
        }
    }
}
