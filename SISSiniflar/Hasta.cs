using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISSiniflar
{
    public class Hasta:Kisi
    {
        private DateTime dogumTarihi = DateTime.MinValue;
        private string cinsiyet = String.Empty;
        private string adres = String.Empty;

        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Adres { get => adres; set => adres = value; }

        public string GoruntuMetni { get => string.Format("{0} {1}", base.adSoyad, base.telefonNo); }
    }
}
