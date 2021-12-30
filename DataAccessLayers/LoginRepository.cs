using Common.Interface.Repository;
using Common.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class LoginRepository : ILogInRepository
    {
        public bool Dodaj(Login login)
        {
            string query = $"INSERT INTO Logovanje(korisnicko_ime,lozinka) VALUES (" +
                $"'{login.KorisnickoIme}','{login.Lozinka}')";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool Obrisi(Login login)
        {
            string query = $"DELETE FROM Logovanje WHERE korisnicko_ime='{login.KorisnickoIme}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool LoginUser(Login login, out string ime)
        {

            string query = $"SELECT korisnicko_ime FROM Logovanje WHERE korisnicko_ime='{login.KorisnickoIme}' AND lozinka='{login.Lozinka}'";
            ime = (string)BaseConnection.ExecuteScalarSqlCommand(query);
            return ime == login.KorisnickoIme ? true : false;
        }

        public List<Login> SviRadnici()
        {
            List<Login> returnUser = new List<Login>();
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand("SELECT * FROM Logovanje"))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Login login = new Login();
                        login.Id = reader.GetInt32(0);
                        login.KorisnickoIme = reader.GetString(1);
                        returnUser.Add(login);
                    }
                }
            }
            return returnUser;
        }
    }
}
