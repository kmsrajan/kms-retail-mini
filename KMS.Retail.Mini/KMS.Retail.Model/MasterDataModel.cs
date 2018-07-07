using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KMS.Retail.Common;
using System.Data;


namespace KMS.Retail.Model
{
    public class MasterDataModel
    {
        private readonly string _connectionString;

        public MasterDataModel(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MasterDataModel()
        {
            _connectionString = Constants.DB_CONN_STRING;
        }

        public DataTable GetAllCategories()
        {
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            DataTable dt = new DataTable(Constants.CON_DT_CATEGORY);
            try
            {

                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_GET_ALL_CATEGORIES;
                        adptr = new MySqlDataAdapter(cmd);
                        adptr.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

            return dt;
        }

        public DataTable GetAllStatuses()
        {
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            DataTable dt = new DataTable(Constants.CON_DT_STATUS);
            try
            {

                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_GET_ALL_STATUS;
                        adptr = new MySqlDataAdapter(cmd);
                        adptr.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

            return dt;
        }
    }
}
