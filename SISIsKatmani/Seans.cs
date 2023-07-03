using SIN = SISSiniflar;
using VEK = SISVeriErisimKatmani;

namespace SISIsKatmani
{
    public class Seans
    {
        public static SIN.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            return VEK.Seans.UzmanSeanslariniListele(uzmanNo); 
        }

        public static int Kaydet(SIN.Seans seans)
        {
            bool sonuc = false, 
                 cakismaVarMi = true;

            cakismaVarMi = VEK.Seans.CakismaVarMi(seans.UzmanNo, seans.Tarih, seans.BaslangicSaati, seans.BitisSaati);

            if (cakismaVarMi) return -1;

            sonuc = VEK.Seans.Kaydet(seans);

            if (sonuc) return seans.No;
            else return 0;
        }


        public static bool IptalEt(SIN.Seans seans)
        {
            return VEK.Seans.IptalEt(seans);
        }

        public static SIN.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            return VEK.Seans.SonSeansBilgisiGetir(hastaNo);
        }

        public static SIN.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            return VEK.Seans.SonSeansBilgisiGetir(hastaNo);
        }

        public static bool RandevuIptalEt(int seansNo)
        {
            return VEK.Seans.RandevuIptalEt(seansNo);
        }

        public static bool RandevuKaydet(int seansNo, int hastaNo)
        {
            return VEK.Seans.RandevuKaydet(seansNo, hastaNo);
        }

        public static SIN.Seans[] HastaSeanslariniListele(int hastaNo) 
        {
            return VEK.Seans.HastaSeanslariniListele(hastaNo);
        }

        public static bool NotGuncelle(int seansNo, string seansNotu)
        {
            return VEK.Seans.NotGuncelle(seansNo, seansNotu);
        }
    }
}
