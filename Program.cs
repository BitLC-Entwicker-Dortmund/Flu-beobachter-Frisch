using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flußbeobachter_Frisch {
    class Program {
        static void Main ( string [ ] args ) {
            // Objekte erzeugen
            Fluß rhein = new Fluß ( ) { Name = "Rhein" };
            Fluß donau = new Fluß ( ) { Name = "Donau" };

            Schiff rheingold = new Schiff ( ) { Name = "Rheingold" };
            Schiff lorelei = new Schiff ( ) { Name = "Lorelei" };
            Schiff xaver = new Schiff ( ) { Name = "Xaver" };
            Schiff unserFranz = new Schiff ( ) { Name = "Unser Franz" };
            
            Stadt duesseldorf = new Stadt ( ) { Name = "Düsseldorf" };
            Stadt koeln = new Stadt ( ) { Name = "Köln" };
            Stadt ulm = new Stadt ( ) { Name = "Ulm" };
            
            Klaerwerk soeder1 = new Klaerwerk ( ) { Name = "Söder 1" };

            // Event mit Methoden versehen

            //WasserstandsAenderungsEvent

            rhein.WasserstandsAenderungsEvent += rheingold.OnWasserstandsAenderung;
            rhein.WasserstandsAenderungsEvent += lorelei.OnWasserstandsAenderung;
            rhein.WasserstandsAenderungsEvent += duesseldorf.OnWasserstandsAenderung;
            rhein.WasserstandsAenderungsEvent += koeln.OnWasserstandsAenderung;
            donau.WasserstandsAenderungsEvent += xaver.OnWasserstandsAenderung;
            donau.WasserstandsAenderungsEvent += unserFranz.OnWasserstandsAenderung;
            donau.WasserstandsAenderungsEvent += ulm.OnWasserstandsAenderung;

            donau.WasserstandsAenderungsEvent += soeder1.OnWasserstandsAenderung;




            // Eigentlicher Aufruf - evtl. Zeit-Schleife
            rhein.Wasserstandsaenderung ( );
            donau.Wasserstandsaenderung ( );

            Console.Read ( );
        }
    }
}
