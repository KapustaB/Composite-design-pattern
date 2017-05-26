using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
   
    public abstract class ApstraktnaKlasa
    {
        protected String ime;
        protected String funkcija;
        protected int placa;
        public List<Zaposlenik> podredeni;
        public abstract String ispis();
    }
}
