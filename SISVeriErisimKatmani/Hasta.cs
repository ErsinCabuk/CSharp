using SISSiniflar;
using System.Data;
using System.Data.SqlClient;
using SIN = SISSiniflar;

namespace SISVeriErisimKatmani
{
    public class Hasta
    {
        public static bool Kaydet(SIN.Hasta hasta)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prHastaYeniKaydet");
            komut.ParametreEkle("@tcKimlikNo", hasta.TCKimlikNo);
            komut.ParametreEkle("@ad", hasta.Ad);
            komut.ParametreEkle("@soyad", hasta.Soyad);
            komut.ParametreEkle("@dogumTarihi", hasta.DogumTarihi);
            komut.ParametreEkle("@cinsiyet", hasta.Cinsiyet);
            komut.ParametreEkle("@adres", hasta.Adres);
            komut.ParametreEkle("@telefonNo", hasta.TelefonNo);
            komut.ParametreEkle("@eposta", hasta.EPosta);
            komut.ParametreEkleOut("@hastaNo", SqlDbType.Int, 0);

            etkilenen = komut.Islet();

            if (etkilenen > 0) hasta.No = komut.OutParametreDegeriGetir("@hastaNo");

            komut.Temizle();

            return etkilenen > 0;
        }

        public static bool Guncelle(SIN.Hasta hasta)
        {
            int etkilenen = 0;

            Komut komut = new Komut("prHastaGuncelle");
            komut.ParametreEkle("@tcKimlikNo", hasta.TCKimlikNo);
            komut.ParametreEkle("@ad", hasta.Ad);
            komut.ParametreEkle("@soyad", hasta.Soyad);
            komut.ParametreEkle("@dogumTarihi", hasta.DogumTarihi);
            komut.ParametreEkle("@cinsiyet", hasta.Cinsiyet);
            komut.ParametreEkle("@adres", hasta.Adres);
            komut.ParametreEkle("@telefonNo", hasta.TelefonNo);
            komut.ParametreEkle("@eposta", hasta.EPosta);
            komut.ParametreEkle("@hastaNo", hasta.No);

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }

        private static SIN.Hasta HastaBilgileriYukle(SqlDataReader sqlVeriOkuyucu)
        {
            SIN.Hasta hasta = new SIN.Hasta();

            hasta.No = Komut.Int32Getir(sqlVeriOkuyucu, "HastaNo");
            hasta.Ad = Komut.StringGetir(sqlVeriOkuyucu, "Ad");
            hasta.TelefonNo = Komut.StringGetir(sqlVeriOkuyucu, "TelefonNo");
            hasta.EPosta = Komut.StringGetir(sqlVeriOkuyucu, "EPosta");
            hasta.Soyad = Komut.StringGetir(sqlVeriOkuyucu, "Soyad");
            hasta.TCKimlikNo = Komut.StringGetir(sqlVeriOkuyucu, "TCKimlikNo");
            hasta.DogumTarihi = Komut.TarihGetir(sqlVeriOkuyucu, "DogumTarihi");
            hasta.Cinsiyet = Komut.StringGetir(sqlVeriOkuyucu, "Cinsiyet");
            hasta.Adres = Komut.StringGetir(sqlVeriOkuyucu, "Adres");

            return hasta;
        }

        public static SIN.Hasta[] HastalariListele(string ad, string soyad)
        {
            List<SIN.Hasta> hastalar = new List<SIN.Hasta>();

            Komut komut = new Komut("prHastalariListele");
            komut.ParametreEkle("@ad", ad);
            komut.ParametreEkle("@soyad", soyad);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();
            while (sqlVeriOkuyucu.Read())
            {
                SIN.Hasta hasta = HastaBilgileriYukle(sqlVeriOkuyucu);
                hastalar.Add(hasta);
            }
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return hastalar.ToArray();
        }

        public static SIN.Hasta HastaGetir(int hastaNo)
        {
            SIN.Hasta hasta = null;

            Komut komut = new Komut("prHastaGetir");
            komut.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sqlVeriOkuyucu = komut.IsletReader();

            while (sqlVeriOkuyucu.Read()) hasta = HastaBilgileriYukle(sqlVeriOkuyucu);
            sqlVeriOkuyucu.Close();
            komut.Temizle();

            return hasta;
        }
    }
}
