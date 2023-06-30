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
        protected string ad = String.Empty;
        protected string soyad = String.Empty;
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

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public String EPosta
        {
            get { return eposta; }
            set { eposta = value; }
        }

        public string TelefonNo
        { 
            get { return telefonNo; } 
            set {  telefonNo = value; } 
        }

        public virtual string GoruntuMetni
        {
            get { return string.Format("{0} {1}", ad, soyad); }
        }
    }
}
