using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    class Direktor : Voditelj
    {
        protected int brojTel;
        public Direktor(string ime, string funkcija, int placa, string projekt, int brojTel) : base(ime, funkcija, placa, projekt){
            this.brojTel = brojTel;
        }
        public override string ispis(){
            return  ("Direktor, " + "Ime : " + ime + ", funkcija : " + funkcija + ", placa : " + placa + ", ima podredenih : " + podredeni.Count +", "+ ispisBrTel());
        }
        public int ispisBrTel(){
            return brojTel;
        }
    }
}
