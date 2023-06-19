using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISSiniflar
{
    public class Calisan:Kisi
    {
        private string unvan = String.Empty;
        private string sifre = String.Empty;
        private CalisanTipleri calisanTipi;

        public string Unvan { get => unvan; set => unvan = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public CalisanTipleri CalisanTipi { get => calisanTipi; set => calisanTipi = value; }

        public string GoruntuMetni
        {
            get => string.Format("{0} {1}", base.adSoyad, unvan);
        }
    }

    public enum CalisanTipleri
    {
        SistemYoneticisi,
        Sekreter,
        Uzman
    }
}
