using SIN = SISSiniflar;
using VEK = SISVeriErisimKatmani;

namespace SISIsKatmani
{
    public class Calisan
    {
        public static int KullaniciGirisiniDogrula(string eposta, string sifre)
        {
            return VEK.Calisan.KullaniciGirisiniDogrula(eposta, sifre);
        }

        public static SIN.Calisan CalisanGetir(int calisanNo)
        {
            return VEK.Calisan.CalisanGetir(calisanNo);
        }

        public static int Kaydet(SIN.Calisan calisan)
        {
            bool sonuc = false;

            if (calisan.No > 0) sonuc = VEK.Calisan.Guncelle(calisan);
            else
            {
                calisan.Sifre = Yardimci.SifreOlustur();
                sonuc = VEK.Calisan.Kaydet(calisan);
            }

            if (sonuc)
            {
                Yardimci.YeniSifreEpostaYolla(calisan.EPosta, calisan.Sifre);
                return calisan.No;
            }

            return 0;
        }

        public static SIN.Calisan[] CalisanlariListele(string ad, string soyad)
        {
            return VEK.Calisan.CalisanlariListele(ad, soyad);
        }

        public static bool SifreDegistir(int calisanNo, string yeniSifre)
        {
            return VEK.Calisan.SifreDegistir(calisanNo, yeniSifre);
        }

        public static bool SifreSifirla(string eposta, string sifre)
        {
            return VEK.Calisan.SifreSifirla(eposta, sifre);
        }
    }
}