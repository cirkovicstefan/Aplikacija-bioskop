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
                $"kapacitet='{sala.Kapacitet}' WHERE id_sale='{sala.IdSale}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(int idSale)
        {
            string query = $"DELETE FROM sala WHERE id_sale={idSale}";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        private List<Sala>SveSaleInternal(string query)
        {
            List<Sala> retunSale = new List<Sala>();
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
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

        public List<Sala> SveSale()
        => SveSaleInternal("SELECT * FROM sala");

        public List<Sala>Pretraga(string by,Sala sala)
        {
            string query = string.Empty;
            switch (by)
            {
                case "NAZIV":
                    query = $"SELECT * FROM sala WHERE naziv_sale LIKE '%{sala.NazivSale}%'";
                    return SveSaleInternal(query);
                case "KAPACITET":
                    query = $"SELECT * FROM sala WHERE kapacitet ='{sala.Kapacitet}'";
                    return SveSaleInternal(query);
                default:
                    return new List<Sala>();

            }
        }
    }
}
