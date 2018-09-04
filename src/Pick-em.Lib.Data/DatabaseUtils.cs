using Npgsql;

namespace Pick_em.Lib.Data
{
    public class DatabaseUtils
    {
        private NpgsqlConnection dbConnection { get; set; }

        public DatabaseUtils (
            NpgsqlConnection givenConn
        )
        {
            this.dbConnection = givenConn;
        }

        public bool Startup()
        {
            bool successful = true;
            try
            {
                this.connect();
            }
            catch
            {
                successful = false;
            }
            return successful;
        }

        private void connect()
        {
            this.dbConnection.Open();
        }

        public string HealthCheck()
        {
            string result = "";
            using (var cmd = new NpgsqlCommand("SELECT 1", this.dbConnection))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        result = reader.GetInt32(0).ToString();
            return result;   
        }
    }
}