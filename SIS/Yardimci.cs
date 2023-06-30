using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class Yardimci
    {
        public static int KullaniciNo = 0;

        public static void HataKaydet(Exception hata)
        {
            string dosyaAdi = Environment.CurrentDirectory + "\\SIS_Hata_" + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, hata.ToString());
        }
    }
}
