using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flußbeobachter_Frisch {
    class Schiff {
        public string Name { get; set; }

        public void OnWasserstandsAenderung(object sender, EventArgs e ) {
            Console.WriteLine ( "hallo vom Schiff auf dat {0}", ((Fluß) sender).Name);
        }

    }
}
