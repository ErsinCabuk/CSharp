using System.Data;
using System.Data.SqlClient;

namespace SISVeriErisimKatmani
{
    public class Komut
    {
        private SqlConnection baglanti = null;
        private SqlCommand komut = null;


        internal Komut(string spAdi)
        {
            baglanti = Baglanti.BaglantiGetir();
            KomutOlustur(spAdi);
        }

        internal Komut(string spAdi, SqlConnection baglantiGirdi)
        {
            baglanti = baglantiGirdi;
            KomutOlustur(spAdi);
        }

        private void KomutOlustur(string spAdi)
        {
            try
            {
                komut = baglanti.CreateCommand();
                komut.CommandText = spAdi;
                komut.CommandType = CommandType.StoredProcedure;
            }
            catch (SqlException hata)
            {
                throw new Exception("Komut oluşturulamadı.", hata);
            }
        }


        ///<summary>
        ///Verilen değerlerle yeni bir parametre oluşturur.
        ///</summary>
        ///<param name="ad">Paramtere adı</param>
        ///<param name="deger">Paramtere değeri</param>
        ///<returns>Yeni oluşturulan parametreyi döndürür.</returns>
        internal SqlParameter ParametreEkle(string ad, object deger)
        {
            SqlParameter parametre = new SqlParameter(ad, deger);
            komut.Parameters.Add(parametre);
            return parametre;
        }

        ///<summary>
        ///Verilen değerlerle yeni bir OUT parametre oluşturur.
        ///</summary>
        ///<param name="ad">Paramtere adı</param>
        ///<param name="tip">Parametrenin tipi (SqlDbType)</param>
        ///<param name="uzunluk">Veri tipinin uzunluğu. Yoksa 0</param>
        ///<returns>Yeni oluşturulan parametreyi döndürür.</returns>
        internal SqlParameter ParametreEkleOut(string ad, SqlDbType tip, int uzunluk)
        {
            SqlParameter parametre = new SqlParameter();
            parametre.ParameterName = ad;
            parametre.SqlDbType = tip;
            parametre.Direction = ParameterDirection.Output;
            if (uzunluk > 0) parametre.Size = uzunluk;
            komut.Parameters.Add(parametre);
            return parametre;
        }

        private object IsletSkaler()
        {
            object sonuc = null;
            try
            {
                baglanti.Open();
                sonuc = komut.ExecuteScalar();
            }
            catch (SqlException hata)
            {
                Yardimci.HataKaydet(hata);
            }
            finally
            {
                baglanti.Close();
            }
            return sonuc;
        }

        /// <summary>
        /// Sonucu bool olarak dönderir
        /// </summary>
        /// <returns>Bool dönderir</returns>
        internal bool IsletBool()
        {
            object sonuc = IsletSkaler();
            return sonuc == null ? false : (bool)sonuc;
        }


        /// <summary>
        /// Komutu temizler ve kapatır
        /// </summary>
        internal void Temizle()
        {
            Baglanti.BaglantiSonlandir(baglanti);
            komut.Dispose();
        }

        /// <summary>
        /// Sonucu Int32 olarak dönderir
        /// </summary>
        /// <returns>int dönderir</returns>
        internal int IsletInt32()
        {
            object sonuc = IsletSkaler();
            return sonuc == null ? 0 : (int)sonuc;
        }

        /// <summary>
        /// Sonucu SqlDataReader olarak dönderir
        /// </summary>
        /// <returns>SqlDataReader dönderir</returns>
        internal SqlDataReader IsletReader()
        {
            try
            {
                SqlDataReader sqlVeriOkuyucu;
                baglanti.Open();
                sqlVeriOkuyucu = komut.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlVeriOkuyucu;
            }
            catch (SqlException hata)
            {
                throw new Exception("Veri tabani işlem hatası", hata);
            }
        }

        /// <summary>
        /// Sonucu işler
        /// </summary>
        /// <returns>int dönderir</returns>
        internal int Islet()
        {
            int etkilenen = 0;
            try
            {
                baglanti.Open();
                etkilenen = komut.ExecuteNonQuery();
                return etkilenen;
            }
            catch (SqlException hata)
            {
                throw new Exception("Veri tabani işlem hatası", hata);
            }
            finally
            {
                baglanti.Close();
            }
        }

        /// <summary>
        /// OUT parametre değerini getirir
        /// </summary>
        /// <param name="parametreAdi">Parametrenin adı</param>
        /// <returns>int dönderir</returns>
        internal int OutParametreDegeriGetir(string parametreAdi)
        {
            object deger = komut.Parameters[parametreAdi].Value;
            return deger != null ? (int)deger : 0;
        }

        /// <summary>
        /// Veri tabanında veriyi string olarak alır
        /// </summary>
        /// <param name="sqlVeriOkuyucu">SqlDataReader</param>
        /// <param name="alan">Getirilecek verinin column adı.</param>
        /// <returns>string dönderir</returns>
        internal static string StringGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            return !sqlVeriOkuyucu.IsDBNull(indeks) ? sqlVeriOkuyucu.GetString(indeks) : string.Empty;
        }

        /// <summary>
        /// Veri tabanında veriyi Int32 olarak alır
        /// </summary>
        /// <param name="sqlVeriOkuyucu">SqlDataReader</param>
        /// <param name="alan">Getirilecek verinin column adı.</param>
        /// <returns>int dönderir</returns>
        internal static int Int32Getir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            return !sqlVeriOkuyucu.IsDBNull(indeks) ? sqlVeriOkuyucu.GetInt32(indeks) : -1;
        }

        /// <summary>
        /// Veri tabanında veriyi Int16 olarak alır
        /// </summary>
        /// <param name="sqlVeriOkuyucu">SqlDataReader</param>
        /// <param name="alan">Getirilecek verinin column adı.</param>
        /// <returns>int dönderir</returns>
        internal static int Int16Getir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            return !sqlVeriOkuyucu.IsDBNull(indeks) ? sqlVeriOkuyucu.GetInt16(indeks) : -1;
        }

        /// <summary>
        /// Veri tabanında veriyi DateTime olarak alır
        /// </summary>
        /// <param name="sqlVeriOkuyucu">SqlDataReader</param>
        /// <param name="alan">Getirilecek verinin column adı.</param>
        /// <returns>DateTime dönderir</returns>
        internal static DateTime TarihGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            return !sqlVeriOkuyucu.IsDBNull(indeks) ? sqlVeriOkuyucu.GetDateTime(indeks) : DateTime.MinValue;
        }

        /// <summary>
        /// Veri tabanında veriyi bool olarak alır
        /// </summary>
        /// <param name="sqlVeriOkuyucu">SqlDataReader</param>
        /// <param name="alan">Getirilecek verinin column adı.</param>
        /// <returns>bool dönderir</returns>
        internal static bool BoolGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            return !sqlVeriOkuyucu.IsDBNull(indeks) ? sqlVeriOkuyucu.GetBoolean(indeks) : false;
        }
    }
}
