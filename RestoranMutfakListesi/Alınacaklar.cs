using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMutfakListesi
{
    public class Alınacaklar
    {
        string malzeme, birim;
        double miktar;

        public string Malzeme
        {
            get
            {
                return malzeme;
            }

            set
            {
                malzeme = value;
            }
        }

        public double Miktar
        {
            get
            {
                return miktar;
            }

            set
            {
                miktar = value;
            }
        }

        public string Birim
        {
            get
            {
                return birim;
            }

            set
            {
                birim = value;
            }
        }




    }
}
