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

        public string SaveInvoice(Invoice invc)
        {
            string res = string.Empty;
            if (string.IsNullOrEmpty(invc.ID))
            {
                res=AddNewInvoice(invc);
            }
            else
            {
                UpdateInvoice(invc);
                res = string.Empty;
            }
            return res;
        }
        public string AddNewInvoice(Invoice invc)
        {
            string res = string.Empty;
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
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_AMT_RECEIVED, invc.AmountReceived.ToString());
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_DATE, DateTime.Now);
                        res = cmd.ExecuteScalar().ToString();
                    }

                }

            }
            catch (MySqlException ex)
            {
                //throw ex;
                
            }
            return res;
        }
        public void UpdateInvoice(Invoice invc)
        {
            //string res = string.Empty;
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_UPDATE_INVOICE;
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_ID, invc.ID);
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
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_AMT_RECEIVED, invc.AmountReceived.ToString());
                        cmd.Parameters.AddWithValue(Constants.CON_PARAM_INVOICE_DATE, DateTime.Now);
                        cmd.ExecuteNonQuery();                    }

                }

            }
            catch (MySqlException ex)
            {
                //throw ex;

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
            DataTable dt = new DataTable(Constants.CON_DT_INVOICES);
            try
            {

                using (var conn = new MySqlConnection(_connectionString))
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = Constants.CON_SP_GET_ALL_INVOICES;
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
