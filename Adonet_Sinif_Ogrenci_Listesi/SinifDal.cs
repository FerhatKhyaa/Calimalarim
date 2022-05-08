using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Adonet_Sinif_Ogrenci_Listesi
{
    internal class SinifDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; Initial catalog=VeriTabani; integrated security=true;");

        public List<Sinif> Goster()
        {   
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("select * from Liste",_conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Sinif> list = new List<Sinif>();

            while(reader.Read())
            {
                Sinif s = new Sinif
                { 
                    Id= Convert.ToInt32(reader["ID"]),
                    OgrenciAdi = reader["OgrenciAdi"].ToString(),
                    OkulNumarasi = Convert.ToInt32(reader["OkulNo"]),
                    Bolum = reader["Bolumu"].ToString()
                };
                
                list.Add(s);
            }
            _conn.Close();
            return list;
        }

        public void Ekle(Sinif sinif)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into Liste (OgrenciAdi,OkulNo,Bolumu) values(@OgrenciAdi,@OkulNo,@Bolumu)",_conn);
            cmd.Parameters.AddWithValue("@OgrenciAdi", sinif.OgrenciAdi);
            cmd.Parameters.AddWithValue("@OkulNo", sinif.OkulNumarasi);
            cmd.Parameters.AddWithValue("@Bolumu", sinif.Bolum);

            cmd.ExecuteNonQuery();

        }

        public void Duzenle(Sinif sinif)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand cmd = new SqlCommand("update Liste set OgrenciAdi=@OgrenciAdi , OkulNo=@OkulNo , Bolumu=@Bolumu where id=@id", _conn);
            cmd.Parameters.AddWithValue("@id", sinif.Id);
            cmd.Parameters.AddWithValue("@OgrenciAdi", sinif.OgrenciAdi);
            cmd.Parameters.AddWithValue("@OkulNo", sinif.OkulNumarasi);
            cmd.Parameters.AddWithValue("@Bolumu", sinif.Bolum);

            cmd.ExecuteNonQuery();

        }
        public void Sil(int id)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from Liste where id=@id",_conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
