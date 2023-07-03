using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using SIN = SISSiniflar;

namespace SISVeriErisimKatmani
{
    public class Calisan
    {
        public static int KullaniciGirisiniDogrula(string eposta, string sifre)
        {
            Komut komut = new Komut("prCalisanGirisiniDogrula");
            komut.ParametreEkle("@eposta", eposta);
            komut.ParametreEkle("@sifre", sifre);

            int sonuc = komut.IsletInt32();

            komut.Temizle();

            return sonuc;
        }

        private static SIN.Calisan CalisanBilgileriYukle(SqlDataReader sqlVeriOkuyucu)
        {
            SIN.Calisan calisan = new SIN.Calisan();

            try
            {
                calisan.No = Komut.Int32Getir(sqlVeriOkuyucu, "CalisanNo");
                calisan.Ad = Komut.StringGetir(sqlVeriOkuyucu, "Ad");
                calisan.TelefonNo = Komut.StringGetir(sqlVeriOkuyucu, "TelefonNo");
                calisan.EPosta = Komut.StringGetir(sqlVeriOkuyucu, "EPosta");
                calisan.Soyad = Komut.StringGetir(sqlVeriOkuyucu, "Soyad");
                calisan.TCKimlikNo = Komut.StringGetir(sqlVeriOkuyucu, "TCKimlikNo");
                calisan.Unvan = Komut.StringGetir(sqlVeriOkuyucu, "Unvan");
                calisan.CalisanTipi = (SIN.Calisan.CalisanTipleri) Komut.Int16Getir(sqlVeriOkuyucu, "CalisanTipi");
                calisan.Sifre = Komut.StringGetir(sqlVeriOkuyucu, "Sifre");
            }
            catch (Exception hata)
            {
                Yardimci.HataKaydet(hata);
                calisan = null;
            }

            return calisan;
        }

        public static SIN.Calisan CalisanGetir(int calisanNo)
        {
            SIN.Calisan calisan = null;

            Komut komut = new Komut("prCalisanGetir");
            komut.ParametreEkle("@calisanNo", calisanNo);
            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read()) calisan = CalisanBilgileriYukle(sqlVeriOkuyucu);

            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return calisan;
        }

        public static bool Kaydet(SIN.Calisan calisan)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prCalisanYeniKaydet");
            komut.ParametreEkle("@tcKimlikNo", calisan.TCKimlikNo);
            komut.ParametreEkle("@ad", calisan.Ad);
            komut.ParametreEkle("@soyad", calisan.Soyad);
            komut.ParametreEkle("@unvan", calisan.Unvan);
            komut.ParametreEkle("@telefonNo", calisan.TelefonNo);
            komut.ParametreEkle("@eposta", calisan.EPosta);
            komut.ParametreEkle("@sifre", calisan.Sifre);
            komut.ParametreEkle("@calisanTipi", calisan.CalisanTipi);
            komut.ParametreEkleOut("@calisanNo", SqlDbType.Int, 0);

            etkilenen = komut.Islet();

            if (etkilenen > 0) calisan.No = komut.OutParametreDegeriGetir("@calisanNo");

            komut.Temizle();

            return etkilenen > 0;
        }

        public static bool Guncelle(SIN.Calisan calisan)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prCalisanGuncelle");
            komut.ParametreEkle("@tcKimlikNo", calisan.TCKimlikNo);
            komut.ParametreEkle("@ad", calisan.Ad);
            komut.ParametreEkle("@soyad", calisan.Soyad);
            komut.ParametreEkle("@unvan", calisan.Unvan);
            komut.ParametreEkle("@telefonNo", calisan.TelefonNo);
            komut.ParametreEkle("@eposta", calisan.EPosta);
            komut.ParametreEkle("@sifre", calisan.Sifre);
            komut.ParametreEkle("@calisanTipi", calisan.CalisanTipi);
            komut.ParametreEkle("@calisanNo", calisan.No);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }

        public static SIN.Calisan[] CalisanlariListele(string ad, string soyad)
        {
            List<SIN.Calisan> calisanlar = new List<SIN.Calisan>();

            Komut komut = new Komut("prCalisanlariListele");
            komut.ParametreEkle("@ad", ad);
            komut.ParametreEkle("@soyad", soyad);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while(sqlVeriOkuyucu.Read())
            {
                SIN.Calisan calisan = CalisanBilgileriYukle(sqlVeriOkuyucu);
                calisanlar.Add(calisan);
            }
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return calisanlar.ToArray();
        }

        public static SIN.Calisan[] UzmanlariListele()
        {
            List<SIN.Calisan> uzmanlar = new List<SIN.Calisan>();

            Komut komut = new Komut("prCalisanUzmanlariListele");

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read())
            {
                SIN.Calisan uzman = CalisanBilgileriYukle(sqlVeriOkuyucu);
                uzmanlar.Add(uzman);
            }
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return uzmanlar.ToArray();
        }

        public static bool SifreDegistir(int calisanNo, string yeniSifre)
        {
            bool sonuc = false;

            Komut komut = new Komut("prCalisanSifreDegistir");
            komut.ParametreEkle("@calisanNo", calisanNo);
            komut.ParametreEkle("@sifre", yeniSifre);

            sonuc = komut.IsletBool();

            komut.Temizle();

            return sonuc;
        }

        public static bool SifreSifirla(string eposta, string sifre)
        {
            bool sonuc = false;

            Komut komut = new Komut("prCalisanSifreSifirla");
            komut.ParametreEkle("@eposta", eposta);
            komut.ParametreEkle("@sifre", sifre);

            sonuc = komut.IsletBool();
            komut.Temizle();

            return sonuc;
        }
    }
}