using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flußbeobachter_Frisch {
    class Stadt {
        public string Name { get; set; }

        public void OnWasserstandsAenderung ( object sender , EventArgs e ) {
            Console.WriteLine ( "hallo aus der Stadt !!!" );
            Console.WriteLine ( this.Name);
            Console.WriteLine ( "Rückruf: Fluß {0} Wasserstand {1}", 
                ((Fluß) sender).Name, ( ( Fluß ) sender ).WasserStand );
        }
    }
}
