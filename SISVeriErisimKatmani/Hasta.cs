using SISSiniflar;
using System.Data;
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
            komut.ParametreEkle("@dogumTarihi", hasta.DogumTarihi.ToString());
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
            komut.ParametreEkle("@dogumTarihi", hasta.DogumTarihi.ToString());
            komut.ParametreEkle("@cinsiyet", hasta.Cinsiyet);
            komut.ParametreEkle("@adres", hasta.Adres);
            komut.ParametreEkle("@telefonNo", hasta.TelefonNo);
            komut.ParametreEkle("@eposta", hasta.EPosta);
            komut.ParametreEkle("@hastaNo", hasta.No.ToString());

            etkilenen = komut.Islet();
            komut.Temizle();

            return etkilenen > 0;
        }
    }
}
