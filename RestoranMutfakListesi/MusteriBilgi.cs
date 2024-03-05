using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMutfakListesi
{
    class MusteriBilgi
    {
        string tarif, musteri;
        int masaNo, porsiyon;

        public string Tarif
        {
            get
            {
                return tarif;
            }

            set
            {
                tarif = value;
            }
        }

        public string Musteri
        {
            get
            {
                return musteri;
            }

            set
            {
                musteri = value;
            }
        }

        public int MasaNo
        {
            get
            {
                return masaNo;
            }

            set
            {
                masaNo = value;
            }
        }

        public int Porsiyon
        {
            get
            {
                return porsiyon;
            }

            set
            {
                porsiyon = value;
            }
        }








    }
}
