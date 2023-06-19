using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISSiniflar
{
    public class Seans
    {
        private int no;
        private int uzmanNo;
        private int hastaNo;
        private DateTime tarih;
        private string baslangicSaati = string.Empty;
        private string bitisSaati = string.Empty;
        private string seansNotu= string.Empty;
        private int iptalEdenNo;
        private string iptalNotu = string.Empty;
        private string goruntuMetni = string.Empty;
        private string hastaBilgisi = string.Empty;
        private string uzmanBilgisi = string.Empty;
        private bool seansYapildi = false;
        private bool hastaIptalEtti = true;

        public int No { get => no; set => no = value; }
        public int UzmanNo { get => uzmanNo; set => uzmanNo = value; }
        public int HastaNo { get => hastaNo; set => hastaNo = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string BaslangicSaati { get => baslangicSaati; set => baslangicSaati = value; }
        public string BitisSaati { get => bitisSaati; set => bitisSaati = value; }
        public string SeansNotu { get => seansNotu; set => seansNotu = value; }
        public int IptalEdenNo { get => iptalEdenNo; set => iptalEdenNo = value; }
        public string IptalNotu { get => iptalNotu; set => iptalNotu = value; }
        public string HastaBilgisi { get => hastaBilgisi; set => hastaBilgisi = value; }
        public string UzmanBilgisi { get => uzmanBilgisi; set => uzmanBilgisi = value; }
        public bool SeansYapildi { get => seansYapildi; set => seansYapildi = value; }
        public bool HastaIptalEtti { get => hastaIptalEtti; set => hastaIptalEtti = value; }

        public string GoruntuMetni
        {
            get
            {
                string metin = string.Format("{0} / {1} - {2}", tarih.ToShortDateString(), baslangicSaati, bitisSaati);
                if(!string.IsNullOrEmpty(hastaBilgisi))
                {
                    metin += " (" + hastaBilgisi + ")";
                }
                if(iptalEdenNo > 0)
                {
                    metin += " [iptal]";
                }
                return metin;
            }
        }
    }
}
