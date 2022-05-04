using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _20_AdoNet_Adres_Defteri
{
    internal class AdresDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; Initial catalog=AdresDefteri; integrated security=true;");
        public List<Adres> Getir()
        {
            if(_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Adresler", _conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Adres> list = new List<Adres>();

            while(reader.Read())
            {
                Adres adres = new Adres {
                Id = Convert.ToInt32(reader["ID"]),
                KisiAdi = reader["KisiAdi"].ToString(),
                Adress = reader["Adress"].ToString(),
                Telefon = reader["Telefon"].ToString()
                };
                list.Add(adres);
            }
            _conn.Close();
            return list;
        }

        public void Ekle(Adres adres)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into Adresler(KisiAdi,Adress,Telefon) values(@KisiAdi,@Adress,@Telefon)",_conn);
            cmd.Parameters.AddWithValue("@KisiAdi", adres.KisiAdi);
            cmd.Parameters.AddWithValue("@Adress", adres.Adress);
            cmd.Parameters.AddWithValue("@Telefon", adres.Telefon);

            cmd.ExecuteNonQuery();
        }
        
        public void Duzenle(Adres adres)
        {
            if(_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            SqlCommand cmd = new SqlCommand("update Adresler set KisiAdi=@KisiAdi , Adress=@Adress , Telefon=@Telefon where Id=@Id", _conn);

            cmd.Parameters.AddWithValue("@Id", adres.Id);
            cmd.Parameters.AddWithValue("@KisiAdi", adres.KisiAdi);
            cmd.Parameters.AddWithValue("@Adress", adres.Adress);
            cmd.Parameters.AddWithValue("@Telefon", adres.Telefon);

            cmd.ExecuteNonQuery();
        }

        public void Sil(int urunId)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            SqlCommand cmd = new SqlCommand("delete from Adresler where id=@id" , _conn);

            cmd.Parameters.AddWithValue("@id", urunId);
            cmd.ExecuteNonQuery();
        }
    }
}
