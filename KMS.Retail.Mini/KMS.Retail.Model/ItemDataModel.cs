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
    public class ItemDataModel
    {
        private readonly string _connectionString;

        public ItemDataModel(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ItemDataModel()
        {
            _connectionString = Constants.DB_CONN_STRING;
        }

        public void AddNewItem(Item item)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_INSERT_NEW_ITEM;

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_NAME, item.Name);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CODE, item.Code);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_DISP_NAME, item.DisplayName);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CATEGORY_ID, item.Category);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_STATUS_ID, item.Status);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SHORT_NAME, item.ShortName);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PUR_PRICE, item.PurchasePrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_QTY, item.Qty);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SELLING_PRICE, item.SellingPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_MRP, item.MRP);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_WS_PRICE, item.WSPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SPL_PRICE, item.SplPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PICTURE, item.Picture);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_GST, item.GST);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_TAX, item.Tax);

                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void UpdateItem(Item item)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_UPDATE_ITEM;

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_NAME, item.Name);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CODE, item.Code);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_DISP_NAME, item.DisplayName);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CATEGORY_ID, item.Category);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_STATUS_ID, item.Status);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SHORT_NAME, item.ShortName);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PUR_PRICE, item.PurchasePrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_QTY, item.Qty);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SELLING_PRICE, item.SellingPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_MRP, item.MRP);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_WS_PRICE, item.WSPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SPL_PRICE, item.SplPrice);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PICTURE, item.Picture);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_GST, item.GST);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_TAX, item.Tax);

                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void DeleteItem(string itemCode)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_UPDATE_ITEM_STATUS;

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CODE, itemCode);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_STATUS_ID, "0");
                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllItems()
        {
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            DataTable dt = new DataTable(Constants.CON_DT_ITEMS);
            try
            {

                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_GET_ALL_ITEMS;
                        adptr = new MySqlDataAdapter(cmd);
                        adptr.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }

            return dt;
        }
        public bool IsValidItem(string paramName, string itemID,string paramValue)
        {
            Item itm = new Item();
            try
            {               
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = paramName;

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_ID, itemID);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_COMMON, paramValue);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }

        }

    }
}
