using System.Data;
using System.Data.SqlClient;

namespace SISVeriErisimKatmani
{
    public class Baglanti
    {
        static string baglantiMetni = "Server=.\\SQLEXPRESS;Database=SIS; Integrated Security=SSPI";

        ///<summary>
        ///Yeni bir bağlantı oluşturularak yollanıyor.
        ///</summary>
        ///<returns>Yeni bağlantı.</returns>
        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            return baglanti;
        }

        ///<summary>
        ///Yeni bir bağlantı oluşturularak yollanıyor.
        ///</summary>
        ///<param name="baglanti">Sonlandırılacak bağlantı.</param>
        public static void BaglantiSonlandir(SqlConnection baglanti)
        {
            if (baglanti == null) return;
            if (baglanti.State != ConnectionState.Closed && baglanti.State != ConnectionState.Broken) baglanti.Close();
            baglanti.Dispose();
        }
    }
}
