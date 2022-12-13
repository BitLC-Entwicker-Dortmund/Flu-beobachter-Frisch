using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flußbeobachter_Frisch {
    class Klaerwerk {
        public string Name { get; set; }

        public void OnWasserstandsAenderung ( object sender , EventArgs e ) {
            Console.WriteLine ( "hallo vom Klärwerk" );
        }
    }
}
