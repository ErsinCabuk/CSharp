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

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public string TCKimlikNo
        {
            get { return tcKimlikNo; }
            set { tcKimlikNo = value; }
        }

        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        public String Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }

        public string TelefonNo
        { 
            get { return telefonNo; } 
            set {  telefonNo = value; } 
        }
    }
}
