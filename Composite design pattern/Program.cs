using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Direktor CEO = new Direktor("Julijan", "Direktor", 300000,"Vodenje firme",0977768955);
            Voditelj voditeljProjektaFontane = new Voditelj("Lolek", "Vodenje projekta", 15000,"Izgradnja fontane");
            Voditelj voditeljProjektaRotor   = new Voditelj("Bolek", "Vodenje projekta", 15000,"Izgradnja rotora");
            Zaposlenik šljaker1 = new Zaposlenik("Renato",    "Šljaker", 2800);
            Zaposlenik šljaker2 = new Zaposlenik("Tomislav", "Šljaker", 2800);
            Zaposlenik šljaker3 = new Zaposlenik("Marijo",   "Šljaker", 2800);
            Zaposlenik šljaker4 = new Zaposlenik("Borna",    "Šljaker", 2800);

            CEO.add(voditeljProjektaFontane);
            CEO.add(voditeljProjektaRotor);

            voditeljProjektaFontane.add(šljaker1);
            voditeljProjektaFontane.add(šljaker2);

            voditeljProjektaRotor.add(šljaker3);
            voditeljProjektaRotor.add(šljaker4);

            Program p = new Program();
            Console.WriteLine(CEO.ispis());
            p.ispisZaposlenika(CEO.podredeni);
            
        }

        void ispisZaposlenika(List<Zaposlenik> list)
        {
            if (list == null) return;
            foreach (Zaposlenik a in list)
            {
                Console.WriteLine(a.ispis());
                ispisZaposlenika(a.podredeni);
            }
            return;
        }
      
       
    }
}
