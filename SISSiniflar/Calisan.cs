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

        public string Unvan
        {
            get { return unvan; }
            set { unvan = value; }
        }

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        /// <summary>
        /// 0: sekreter, 1 uzman
        /// </summary>
        public CalisanTipleri CalisanTipi
        {
            get { return calisanTipi; }
            set { calisanTipi = value; }
        }

        public string GoruntuMetni
        {
            get
            {
                if (calisanTipi == CalisanTipleri.Uzman) return string.Format("{0} {1}", base.adSoyad, unvan);
                else return base.adSoyad;
            }
        }
    }

    public enum CalisanTipleri
    {
        SistemYoneticisi,
        Sekreter,
        Uzman
    }
}
