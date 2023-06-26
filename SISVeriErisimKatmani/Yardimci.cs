using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVeriErisimKatmani
{
    internal class Yardimci
    {
        public static void HataKaydet(Exception exception)
        {
            string dosyaAdi = Environment.CurrentDirectory + "\\SISVeriErisimKatmani_Hata_"+ Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, exception.ToString());
        }
    }
}
