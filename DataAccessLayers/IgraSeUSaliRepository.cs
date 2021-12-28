using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class IgraSeUSaliRepository : ISeIgraUSaliRepository
    {
        public bool Dodaj(SeIgraUSali seIgraUSali)
        {
            string query = string.Format($"INSERT INTO seigrausali(id_filma,id_sale,datum_odrzavanja,vreme_odrzavanja,broj_prodatih_karata) VALUES" +
                $"('{seIgraUSali.IdFilma}','{seIgraUSali.IdSale}','{seIgraUSali.DatumOdrzavanja}','{seIgraUSali.VremeOdrzavanja}','{seIgraUSali.BrojProdatihKarata}')");

            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        

        public bool Izmeni(SeIgraUSali seIgraUSali)
        {
            string query = $"UPDATE seigrausali SET vreme_odrzavanja='{seIgraUSali.VremeOdrzavanja}', " +
                $" broj_prodatih_karata='{seIgraUSali.BrojProdatihKarata}' WHERE id_filma='{seIgraUSali.IdFilma}' AND " +
                $" id_sale='{seIgraUSali.IdSale}' AND datum_odrzavanja ='{seIgraUSali.DatumOdrzavanja}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(SeIgraUSali seIgraUSali)
        {
            string query = $"DELETE FROM seigrausali WHERE id_filma='{seIgraUSali.IdFilma}' AND " +
                $" id_sale='{seIgraUSali.IdSale}' AND datum_odrzavanja ='{seIgraUSali.DatumOdrzavanja}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public List<SeIgraUSali> SviSeIgraUSali()
        {
            List<SeIgraUSali> retuSeIgraUSalis = new List<SeIgraUSali>();
            string query = $"SELECT se.*,f.*,s.* FROM seigrausali se INNER JOIN film f  ON" +
                $" se.id_filma=f.id_filma INNER JOIN sala s ON s.id_sale=se.id_sale";
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Film film = new Film();
                        Sala sala = new Sala();
                        SeIgraUSali seIgraUSali = new SeIgraUSali();
                        seIgraUSali.IdFilma = reader.GetInt32(0);
                        seIgraUSali.IdSale = reader.GetInt32(1);
                        seIgraUSali.DatumOdrzavanja = reader.GetString(2);
                        seIgraUSali.VremeOdrzavanja = reader.GetString(3);
                        seIgraUSali.BrojProdatihKarata = reader.GetInt32(4);
                        film.IdFilma = reader.GetInt32(5);
                        film.Naziv = reader.GetString(6);
                        film.Trajanje = reader.GetString(7);
                        film.Zanr = reader.GetString(8);
                        sala.IdSale = reader.GetInt32(9);
                        sala.NazivSale = reader.GetString(10);
                        sala.Kapacitet = reader.GetInt32(11);
                        seIgraUSali.ListFilmova.Add(film);
                        seIgraUSali.ListSala.Add(sala);
                        retuSeIgraUSalis.Add(seIgraUSali);

                    }
                }
            }
            return retuSeIgraUSalis;
        }

        public bool SetBrojKarti(SeIgraUSali seIgraUSali)
        {
            string query = $"UPDATE seigrausali SET broj_prodatih_karata='{seIgraUSali.BrojProdatihKarata}' "+
               $" WHERE id_filma='{seIgraUSali.IdFilma}' AND " +
               $" id_sale='{seIgraUSali.IdSale}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
    }
}
