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
            Direktor CEO = new Direktor("Šribar", "Direktor", 200000,"Vodenje firme"," HDZ");
            Voditelj voditeljProjektaFontane = new Voditelj("Lolek", "Vodenje projekta", 12000,"Izgradnja fontane");
            Voditelj voditeljProjektaRotor   = new Voditelj("Bolek", "Vodenje projekta", 12000,"Izgradnja rotora");
            Zaposlenik šljaker1 = new Zaposlenik("Borna",    "Šljaker", 2800);
            Zaposlenik šljaker2 = new Zaposlenik("Tomislav", "Šljaker", 2800);
            Zaposlenik šljaker3 = new Zaposlenik("Marijo",   "Šljaker", 2800);
            Zaposlenik šljaker4 = new Zaposlenik("Borna",    "Šljaker", 2800);

            CEO.add(voditeljProjektaFontane);
            CEO.add(voditeljProjektaRotor);

            voditeljProjektaFontane.add(šljaker1);
            voditeljProjektaFontane.add(šljaker2);

            voditeljProjektaRotor.add(šljaker3);
            voditeljProjektaRotor.add(šljaker4);

           

            Console.WriteLine(CEO.ispis());
            Console.WriteLine(voditeljProjektaFontane.ispis());
            Console.WriteLine(voditeljProjektaRotor.ispis());
            Console.WriteLine(šljaker1.ispis());
            Console.WriteLine(šljaker2.ispis());
            Console.WriteLine(šljaker3.ispis());
            Console.WriteLine(šljaker4.ispis());

        }
    }
}
