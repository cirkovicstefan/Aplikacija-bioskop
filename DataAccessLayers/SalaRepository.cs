using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class SalaRepository : ISalaRepository
    {
        public bool Dodaj(Sala sala)
        {
            string query = string.Format($"INSERT INTO sala(naziv_sale,kapacitet) " +
                $"VALUES('{sala.NazivSale}','{sala.Kapacitet}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Izmeni(Sala sala)
        {
            string query = string.Format($"UPDATE sala SET naziv_sale='{sala.NazivSale}', " +
                $"kapacitet='{sala.Kapacitet}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(int idSale)
        {
            string query = $"DELETE FROM sala WHERE id_sale={idSale}";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public List<Sala> SveSale()
        {
            List<Sala> retunSale = new List<Sala>();
            using(SqlCommand sqlCommand = BaseConnection.GetSqlCommand("SELECT * FROM sala"))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Sala sala = new Sala();
                        sala.IdSale = reader.GetInt32(0);
                        sala.NazivSale = reader.GetString(1);
                        sala.Kapacitet = reader.GetInt32(2);
                        retunSale.Add(sala);
                    }
                }
            }
            return retunSale;
        }
    }
}
