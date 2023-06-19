using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISSiniflar
{
    public class Kisi
    {
        protected int no;
        protected string tcKimlikNo = String.Empty;
        protected string adSoyad = String.Empty;
        protected string eposta = String.Empty;
        protected string telefonNo = String.Empty;

        public int No { get => no; set => no = value; }
        public string TcKimlikNo { get => tcKimlikNo; set => tcKimlikNo = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string TelefonNo { get => telefonNo; set => telefonNo = value; }
    }
}
