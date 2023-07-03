using SIN = SISSiniflar;
using VEK = SISVeriErisimKatmani;

namespace SISIsKatmani
{
    public class Hasta
    {
        public static int Kaydet(SIN.Hasta hasta)
        {
            bool sonuc = false;

            if (hasta.No > 0) sonuc = VEK.Hasta.Guncelle(hasta);
            else sonuc = VEK.Hasta.Kaydet(hasta);

            if (sonuc) return hasta.No;
            else return 0;
        }

        public static SIN.Hasta[] HastalariListele(string ad, string soyad)
        {
            return VEK.Hasta.HastalariListele(ad, soyad);
        }

        public static SIN.Hasta HastaGetir(int hastaNo)
        {
            return VEK.Hasta.HastaGetir(hastaNo);
        }
    }
}
