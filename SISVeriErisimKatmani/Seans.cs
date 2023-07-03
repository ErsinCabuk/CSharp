using SIN = SISSiniflar;
using System.Data.SqlClient;
using System.Data;

namespace SISVeriErisimKatmani
{
    public class Seans
    {
        public static SIN.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            List<SIN.Seans> seanslar = new List<SIN.Seans>();

            Komut komut = new Komut("prSeansUzmanSeanslariniListele");
            komut.ParametreEkle("@uzmanNo", uzmanNo);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read())
            {
                SIN.Seans seans = SeansBilgileriYukle(sqlVeriOkuyucu);
                seanslar.Add(seans);
            }
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return seanslar.ToArray();
        }

        private static SIN.Seans SeansBilgileriYukle(SqlDataReader sqlVeriOkuyucu)
        {
            SIN.Seans seans = new SIN.Seans();

            seans.BaslangicSaati = Komut.StringGetir(sqlVeriOkuyucu, "BaslangicSaati");
            seans.BitisSaati = Komut.StringGetir(sqlVeriOkuyucu, "BitisSaati");
            seans.HastaNo = Komut.Int32Getir(sqlVeriOkuyucu, "HastaNo");
            seans.IptalEdenNo = Komut.Int32Getir(sqlVeriOkuyucu, "IptalEdenNo");
            seans.IptalNotu = Komut.StringGetir(sqlVeriOkuyucu, "IptalNotu");
            seans.No = Komut.Int32Getir(sqlVeriOkuyucu, "SeansNo");
            seans.SeansNotu = Komut.StringGetir(sqlVeriOkuyucu, "SeansNotu");
            seans.Tarih = Komut.TarihGetir(sqlVeriOkuyucu, "Tarih");
            seans.UzmanNo = Komut.Int32Getir(sqlVeriOkuyucu, "UzmanNo");
            seans.UzmanBilgisi = Komut.StringGetir(sqlVeriOkuyucu, "UzmanBilgisi");
            seans.HastaBilgisi = Komut.StringGetir(sqlVeriOkuyucu, "HastaBilgisi");
            seans.HastaIptalEtti = Komut.BoolGetir(sqlVeriOkuyucu, "HastaIptalEtti");

            return seans;
        }

        public static bool CakismaVarMi(int uzmanNo, DateTime tarih, string baslangicSaati, string bitisSaati)
        {
            int cakisan = 0;

            Komut komut = new Komut("prSeansCakisanSeansSayisi");
            komut.ParametreEkle("@uzmanNo", uzmanNo);
            komut.ParametreEkle("@tarih", tarih);
            komut.ParametreEkle("@baslangicSaati", baslangicSaati);
            komut.ParametreEkle("@bitisSaati", bitisSaati);

            cakisan = komut.IsletInt32();
            komut.Temizle();

            return cakisan > 0;
        }

        public static bool Kaydet(SIN.Seans seans)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prSeansYeniKaydet");
            komut.ParametreEkle("@uzmanNo", seans.UzmanNo);
            komut.ParametreEkle("@tarih", seans.Tarih);
            komut.ParametreEkle("@baslangicSaati", seans.BaslangicSaati);
            komut.ParametreEkle("@bitisSaati", seans.BitisSaati);
            komut.ParametreEkleOut("@seansNo", SqlDbType.Int, 0);

            etkilenen = komut.Islet();
            if (etkilenen > 0) seans.No = komut.OutParametreDegeriGetir("@seansNo");

            komut.Temizle();

            return etkilenen > 0;
        }

        public static bool IptalEt(SIN.Seans seans)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prSeansIptalEt");
            komut.ParametreEkle("@seansNo", seans.No);
            komut.ParametreEkle("@iptalEdenNo", seans.IptalEdenNo);
            komut.ParametreEkle("@iptalNotu", seans.IptalNotu);
            komut.ParametreEkle("@hastaIptalEtti", seans.HastaIptalEtti);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }

        public static SIN.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            SIN.Seans seans = null;

            Komut komut = new Komut("prSeansHastaSonRandevuBilgisiGetir");
            komut.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read()) seans = SeansBilgileriYukle(sqlVeriOkuyucu);
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return seans;
        }

        public static SIN.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            SIN.Seans seans = null;

            Komut komut = new Komut("prSeansHastaSonSeansBilgisiGetir");
            komut.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read()) seans = SeansBilgileriYukle(sqlVeriOkuyucu);
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return seans;
        }

        public static bool RandevuIptalEt(int seansNo)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prSeansRandevuIptalEt");
            komut.ParametreEkle("@seansNo", seansNo);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }

        public static bool RandevuKaydet(int seansNo, int hastaNo)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prSeansRandevuKaydet");
            komut.ParametreEkle("@seansNo", seansNo);
            komut.ParametreEkle("@hastaNo", hastaNo);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }

        public static SIN.Seans[] HastaSeanslariniListele(int hastaNo)
        {
            List<SIN.Seans> seanslar = new List<SIN.Seans>();

            Komut komut = new Komut("prSeansHastaSeanslariniListele");
            komut.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read())
            {
                SIN.Seans seans = SeansBilgileriYukle(sqlVeriOkuyucu);
                seanslar.Add(seans);
            }
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return seanslar.ToArray();
        }

        public static bool NotGuncelle(int seansNo, string seansNotu)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prSeansNotuGuncelle");
            komut.ParametreEkle("@seansNo", seansNo);
            komut.ParametreEkle("@seansNotu", seansNotu);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }
    }
}
