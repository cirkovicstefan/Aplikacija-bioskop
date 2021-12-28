using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class GledalacRepository : IGledalacRepository
    {
        public bool Dodaj(Gledalac gledalac)
        {
            string query = string.Format($"INSERT INTO gledalac(email,ime,prezime) " +
                $"VALUES('{gledalac.Email}','{gledalac.Ime}','{gledalac.Prezime}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Izmeni(Gledalac gledalac)
        {
            string query = string.Format($"UPDATE gledalac SET email='{gledalac.Email}', " +
                $"ime='{gledalac.Ime}', prezime='{gledalac.Prezime}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(int idGledaoca)
        {
            string query = $"DELETE FROM gledalac WHERE id_gledaoca='{idGledaoca}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        private List<Gledalac> SviGledaociInternal(string query)
        {
            List<Gledalac> retlist = new List<Gledalac>();
            using (SqlCommand sqlCommnad = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader reader = sqlCommnad.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Gledalac gledalac = new Gledalac();
                        gledalac.Email = reader.GetString(0);
                        gledalac.Ime = reader.GetString(1);
                        gledalac.Prezime = reader.GetString(2);
                        retlist.Add(gledalac);
                    }
                }
            }
            return retlist;
        }


        public List<Gledalac> SviGledaoci()
        {
            return SviGledaociInternal("SELECT * FROM gledalac");
        }
    }


}

