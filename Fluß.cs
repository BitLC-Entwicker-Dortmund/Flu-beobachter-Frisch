using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flußbeobachter_Frisch {
    class Fluß {
        public string Name { get; set; }
        public int WasserStand { get; set; } = 100;
        // Zufallsgenerator
        private Random zfg = new Random ( );
        public event EventHandler<EventArgs> WasserstandsAenderungsEvent;

        public void Wasserstandsaenderung ( ) {
            for ( int i = 0 ; i < 1000 ; i++ ) {
                Thread.Sleep ( 20 );
                WasserStand = zfg.Next ( 100 , 10001 );
                
                if ( WasserStand < 250 || WasserStand > 8000 ) {
                    WasserstandsAenderungsEvent ( this, EventArgs.Empty);
                   // Console.WriteLine ( "es ist soweit ...");
                } //else Console.WriteLine (  "Eigentlich alles in Ordnung");
            }
        }
    }
}
