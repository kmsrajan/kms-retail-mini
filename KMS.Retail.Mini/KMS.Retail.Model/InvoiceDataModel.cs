using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KMS.Retail.Common;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KMS.Retail.Model
{
    public class InvoiceDataModel
    {
        private readonly string _connectionString;

        public InvoiceDataModel(string connectionString)
        {
            _connectionString = connectionString;
        }

        public InvoiceDataModel()
        {
            _connectionString = Constants.DB_CONN_STRING;
        }

        public void SaveInvoice(Invoice invc)
        {
            if (string.IsNullOrEmpty(invc.ID))
            {
                AddNewInvoice(invc);
            }
            else
            {
                UpdateInvoice(invc);
            }
        }
        public void AddNewInvoice(Invoice invc)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_INSERT_NEW_INVOICE;

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_NO, invc.InvoiceNo);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_CUST_NAME, invc.CustName);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_CUST_MOBILE, invc.Mobile);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_CUST_ADS, invc.CustAddress);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_CUST_PHOTO, invc.Photo);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_STATUS, invc.InvoiceStatus);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_ITEMS, JsonConvert.SerializeObject(invc.Items));
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_TOTAL_AMT, invc.TotalAmount);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_TAX_TYPE, invc.TaxType);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_TOTAL_TAX, invc.TotalTax);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_DISCOUNT, invc.Discount);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_NET_TOTAL, invc.NetTotal);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_PAYMENET_MODE, invc.PaymentMode);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_AMT_RECEIVED, invc.AmountReceived);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_DATE, DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void UpdateInvoice(Invoice item)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        //conn.Open();
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.CommandText = Constants.CON_SP_UPDATE_ITEM;
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_ID, item.ID);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_NAME, item.Name);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CODE, item.Code);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_DISP_NAME, item.DisplayName);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_CATEGORY_ID, item.Category);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_STATUS_ID, item.Status);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SHORT_NAME, item.ShortName);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PUR_PRICE, item.PurchasePrice);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_QTY, item.Qty);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SELLING_PRICE, item.SellingPrice);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_MRP, item.MRP);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_WS_PRICE, item.WSPrice);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_SPL_PRICE, item.SplPrice);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_PICTURE, item.Picture);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_GST, item.GST);
                        //cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_TAX, item.Tax);

                        //cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public void DeleteInvoice(string itemID)
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

                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_ID, itemID);
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_ITEM_STATUS_ID, "3");
                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllInvoices()
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


    }
}
