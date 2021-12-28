using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class FilmRepository : IFilmRepository
    {
        public bool Dodaj(Film film)
        {
            string query = string.Format($"INSERT INTO film(naziv_filma,trajanje,zanr) values" +
                $"('{film.Naziv}','{film.Trajanje}','{film.Zanr}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Izmeni(Film film)
        {
            string query = string.Format($"UPDATE film SET naziv_filma='{film.Naziv}'," +
                $"trajanje='{film.Trajanje}', zanr='{film.Zanr}' WHERE id_filma='{film.IdFilma}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(int idFilma)

        => BaseConnection.ExecuteNonQuerySqlCommand($"DELETE FROM film WHERE id_filma={idFilma}");

        public List<Film> PretragaFilmova(string by, Film film)
        {
            throw new System.NotImplementedException();
        }

        public List<Film> SviFilmovi()
        {
            List<Film> returnList = new List<Film>();
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand("SELECT * FROM film"))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Film film = new Film();
                        film.IdFilma = reader.GetInt32(0);
                        film.Naziv = reader.GetString(1);
                        film.Trajanje = reader.GetString(2);
                        film.Zanr = reader.GetString(3);
                        returnList.Add(film);
                    }
                }
            }
            return returnList;
        }
    }
}
