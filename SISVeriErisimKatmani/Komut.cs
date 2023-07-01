using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        internal SqlParameter ParametreEkle(string ad, string deger)
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

        internal bool IsletBool()
        {
            object sonuc = IsletSkaler();
            if(sonuc == null) return false;
            bool deger = (bool)sonuc;
            return deger;
        }

        private object IsletSkaler()
        {
            object sonuc = null;
            try
            {
                baglanti.Open();
                sonuc = komut.ExecuteScalar();
                return sonuc;
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

        internal void Temizle()
        {
            Baglanti.BaglantiSonlandir(baglanti);
            komut.Dispose();
        }

        internal int IsletInt32()
        {
            object sonuc = IsletSkaler();
            if (sonuc == null) return 0;

            int deger = (int)sonuc;

            return deger;
        }

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

        internal int OutParametreDegeriGetir(string parametreAdi)
        {
            object deger = komut.Parameters[parametreAdi].Value;
            if (deger != null) return (int)deger;
            else return 0;
        }

        internal static string StringGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            string veri = string.Empty;
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            if(!sqlVeriOkuyucu.IsDBNull(indeks)) veri = sqlVeriOkuyucu.GetString(indeks);
            return veri;
        }

        internal static int Int32Getir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int veri = -1;
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            if (!sqlVeriOkuyucu.IsDBNull(indeks)) veri = sqlVeriOkuyucu.GetInt32(indeks);
            return veri;
        }

        internal static int Int16Getir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            int veri = -1;
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            if (!sqlVeriOkuyucu.IsDBNull(indeks)) veri = sqlVeriOkuyucu.GetInt16(indeks);
            return veri;
        }

        internal static DateTime TarihGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            DateTime veri = DateTime.MinValue;
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            if (!sqlVeriOkuyucu.IsDBNull(indeks)) veri = sqlVeriOkuyucu.GetDateTime(indeks);
            return veri;
        }

        internal static bool BoolGetir(SqlDataReader sqlVeriOkuyucu, string alan)
        {
            bool veri = false;
            int indeks = sqlVeriOkuyucu.GetOrdinal(alan);
            if (!sqlVeriOkuyucu.IsDBNull(indeks)) veri = sqlVeriOkuyucu.GetBoolean(indeks);
            return veri;
        }
    }
}
