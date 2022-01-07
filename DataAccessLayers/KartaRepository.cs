using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class KartaRepository : IKartaRepository
    {
        public bool Dodaj(Karta karta)
        {

            string query = string.Format($"INSERT INTO karta(broj_sedista,id_filma,id_sale,id_gledaoca," +
                $"cena,datum_odrzavanja) VALUES('{karta.BrojSedista}','{karta.IdFilma}'," +
                $"'{karta.IdSale}','{karta.IdGledaoca}','{karta.Cena}','{karta.DatumOdrzavanja}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Izmeni(Karta karta)
        {
            string query = $"UPDATE karta SET broj_sedista='{karta.BrojSedista}'," +
                $"id_filma='{karta.IdFilma}',id_sale='{karta.IdSale}',id_gledaoca='{karta.IdGledaoca}'," +
                $"cena='{karta.Cena}',datum_odrzavanja='{karta.DatumOdrzavanja}' WHERE id_karte='{karta.IdKarte}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(Karta karta)
        {
            string query = $"DELETE FROM karta WHERE id_karte='{karta.IdKarte}' AND  " +
                $"id_filma='{karta.IdFilma}' AND id_sale='{karta.IdSale}' AND  " +
                $"id_gledaoca='{karta.IdGledaoca}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        
        public List<Karta> SveKarte()
        {
            string query = $"SELECT k.*,g.*,s.*,f.* FROM karta k INNER JOIN gledalac g  ON " +
               $"k.id_gledaoca=g.id_gledaoca INNER JOIN sala s ON s.id_sale=k.id_sale INNER JOIN seigrausali se " +
               $"ON se.datum_odrzavanja=k.datum_odrzavanja INNER JOIN film f ON k.id_filma=f.id_filma";
            return SveKarteInternal(query);
        }

        public List<Karta> SveKarteInternal(string query)
        {
            List<Karta> listaKarti = new List<Karta>();

          
            using (SqlCommand sqlCommnad = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader reader = sqlCommnad.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Karta karta = new Karta();
                        Gledalac gledalac = new Gledalac();
                        Sala sala = new Sala();
                        Film film = new Film();
                        karta.IdKarte = reader.GetInt32(0);
                        karta.BrojSedista = reader.GetInt32(1);
                        karta.IdFilma = reader.GetInt32(2);
                        karta.IdSale = reader.GetInt32(3);
                        karta.IdGledaoca = reader.GetInt32(4);
                        karta.Cena = reader.GetDecimal(5);
                        karta.DatumOdrzavanja = reader.GetString(6);
                        gledalac.IdGledaoca = reader.GetInt32(7);
                        gledalac.Email = reader.GetString(8);
                        gledalac.Ime = reader.GetString(9);
                        gledalac.Prezime = reader.GetString(10);
                        sala.IdSale = reader.GetInt32(11);
                        sala.NazivSale = reader.GetString(12);
                        sala.Kapacitet = reader.GetInt32(13);
                        film.IdFilma = reader.GetInt32(14);
                        film.Naziv = reader.GetString(15);
                        film.Trajanje = reader.GetString(16);
                        film.Zanr = reader.GetString(17);
                        karta.ListFilmova.Add(film);
                        karta.ListGledaoci.Add(gledalac);
                        karta.ListSala.Add(sala);
                        listaKarti.Add(karta);

                    }
                }
            }
            return listaKarti;
        }


        public List<string> ZaradaFilmova()
        {
            List<string> listZarada = new List<string>();
            string query = $"SELECT  'Film '+f.naziv_filma+' je zaradio od prodaje karata '+CONVERT(VARCHAR,SUM(k.cena))+' dinara' FROM " +
                $" film f INNER JOIN karta k ON f.id_filma=k.id_filma GROUP BY f.naziv_filma ORDER BY (SUM(k.cena)) DESC;";
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    listZarada.Add(reader.GetString(0));
                }
                
            }
            return listZarada;
        }
    }
}
