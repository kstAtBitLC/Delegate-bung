using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateÜbung {

    delegate int MeinDelegateTyp (int para1, int para2);

    class Program {
        static void Main ( string [] args ) {
            // direkter Aufruf
            //Console.WriteLine ( Demo.Addition (3,4) );
            MeinDelegateTyp mdt;

            // Delegate-Objekt-Erzeugung
            // und Methodenzuweisung
            //mdt = new MeinDelegateTyp (Demo.Subtraktion);

            mdt = Demo.Division;
            // Ausgabe des eigentlichen Methodenaufrufs
            Console.WriteLine ( mdt ( 7, 8 ) );

            // Auszug Main()
            // Delegate-Objekt + Methoden-Zeiger definieren
            int [] array = { 1, 3, 5, 7 };
            Umwandeln ( array, mdt );

            Console.WriteLine ( "Delegate me!" );
            Console.ReadKey ();
        }


    static void Umwandeln ( int [] werte, MeinDelegateTyp dieMethode ) {
        for ( int i = 0 ; i < werte.Length ; i++ ) {
            werte [ i ] = dieMethode ( werte [ i ], 1 );
        }
        foreach ( var item in werte ) {
            Console.WriteLine ( item );
        }
    }



}  // Ende Programm

class Demo {
        public static int Addition ( int x, int y ) {
            return x + y;
        }
        public static int Subtraktion ( int x, int y ) {
            return x - y;
        }

        public static int Multiplikation ( int x, int y ) {
            return x * y;
        }

        public static int Division ( int x, int y ) {
            int ergebnis = -1;

            if ( y != 0 ) {
                ergebnis = x / y;
            }
            return ergebnis;
        }
    }  // Ende Demo
}
