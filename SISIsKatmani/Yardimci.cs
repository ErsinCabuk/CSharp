using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SISIsKatmani
{
    internal class Yardimci
    {
        public static void HataKaydet(Exception hata)
        {
            string dosyaAdi = Environment.CurrentDirectory + "\\SISIsKatmani_Hata_" + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, hata.ToString());
        }

        public static void YeniSifreEpostaYolla(string eposta, string sifre)
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = "mail.hesapadi.com";

            NetworkCredential crd = new NetworkCredential("hesap", "sifre");
            sc.Credentials = crd;

            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("gonderen@hesapadi.com");
            mesaj.To.Add(eposta);
            mesaj.Subject = "Sifre değişikliği";
            mesaj.Body = "Yeni şifre: " + sifre;

            try
            {
                sc.Send(mesaj);
            }
            catch (Exception hata) 
            {
                HataKaydet(hata);
            }
        }

        public static string ParolaOlustur()
        {
            return "123";
        }
    }
}
