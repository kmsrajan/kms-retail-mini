using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Common
{
    public static class Constants
    {
        #region messages

        public static string CONST_MSG_0011 = "நீங்கள் இந்த பொருளை நிரந்தரமாக நீக்க வேண்டுமா?";
        public static string CONST_MSG_0021 = "இந்த பொருள் திருத்தப்பட்டுள்ளது இதனை சேமிக்க விரும்புகிறீர்களா?";
        public static string CONST_MSG_0031 = "இந்த பொருளை சேமிக்க விரும்புகிறீர்களா?";
        public static string CONST_MSG_0041 = "இந்த பொருள் திருத்தம் செய்ய விரும்புகிறீர்களா?";

        public static string CONST_MSG_001 = "Do you want to delete?";
        public static string CONST_MSG_002 = "It is updated, do you want to save";
        public static string CONST_MSG_003 = "Do you want to save?";
        public static string CONST_MSG_004 = "Do you want to update?";

        #endregion Messages

        #region datatypes
        public static string CON_DT_INT ="INT";
        public static string CON_DT_DEC = "DEC";
        #endregion datatypes

        #region Connection string

        //public static string DB_CONN_STRING = "server=127.0.0.0:3306;user id=root;database=kms-mini-db;password=MySQL@1312;persistsecurityinfo=True";
        public static string DB_CONN_STRING = "Server=localhost;Port=3306;Database=kms-mini-db;Uid=root;Pwd=MySQL@1312;persistsecurityinfo=True;SslMode=none";

        #endregion Connection string

        #region Stored procedures

        public static string CON_SP_GET_ITEM_BY_NAME = "sp_GetItemByName";
        public static string CON_SP_GET_ITEM_BY_SHORTNAME = "sp_GetItemByShortName";
        public static string CON_SP_GET_ITEM_BY_DISPNAME = "sp_GetItemByDisplayName";
        public static string CON_SP_GET_ITEM_BY_CODE = "sp_GetItemByCode";

        #endregion Stored procedures

        #region Item Database objects

        //Stored procedures
        public static string CON_SP_GET_ALL_ITEMS = "sp_GetAllItems";
        public static string CON_SP_INSERT_NEW_ITEM = "sp_Insert_NewItem";
        public static string CON_SP_UPDATE_ITEM = "sp_UpdateItem";
        public static string CON_SP_UPDATE_ITEM_STATUS = "sp_UpdateItemStatus";

        //Inpute parameters
        public static string CON_PARAM_ITEM_ID = "@pId";
        public static string CON_PARAM_ITEM_CODE = "@pCode";
        public static string CON_PARAM_ITEM_NAME = "@pName";
        public static string CON_PARAM_ITEM_CATEGORY_ID = "@pICID";
        public static string CON_PARAM_ITEM_DISP_NAME = "@pDispName";
        public static string CON_PARAM_ITEM_SHORT_NAME = "@pShortName";
        public static string CON_PARAM_ITEM_PUR_PRICE = "@pPurPrice";
        public static string CON_PARAM_ITEM_QTY = "@pQty";
        public static string CON_PARAM_ITEM_MRP = "@pMRP";
        public static string CON_PARAM_ITEM_SELLING_PRICE = "@pSellingPrice";
        public static string CON_PARAM_ITEM_WS_PRICE = "@pWSPrice";
        public static string CON_PARAM_ITEM_SPL_PRICE = "@pSplPrice";
        public static string CON_PARAM_ITEM_PICTURE = "@pItemPicture";
        public static string CON_PARAM_ITEM_STATUS_ID = "@pSID";
        public static string CON_PARAM_ITEM_GST = "@pGST";
        public static string CON_PARAM_ITEM_TAX = "@pTax";

        public static string CON_PARAM_ITEM_COMMON = "@pCommon";
        //data table
        public static string CON_DT_ITEMS = "tblItems";

        //data table columns
        public static string CON_COL_ITEM_ID = "ID";
        public static string CON_COL_ITEM_CODE = "ItemCode";
        public static string CON_COL_ITEM_NAME = "ItemName";
        public static string CON_COL_ITEM_CATEGORY_ID = "Category";
        public static string CON_COL_ITEM_DISP_NAME = "DisplayName";
        public static string CON_COL_ITEM_SHORT_NAME = "ShortName";
        public static string CON_COL_ITEM_PUR_PRICE = "PurchasePrice";
        public static string CON_COL_ITEM_QTY = "Qty";
        public static string CON_COL_ITEM_MRP = "MRP";
        public static string CON_COL_ITEM_SELLING_PRICE = "SellingPrice";
        public static string CON_COL_ITEM_WS_PRICE = "WSPrice";
        public static string CON_COL_ITEM_SPL_PRICE = "SplPrice";
        public static string CON_COL_ITEM_PICTURE = "ItemPicture";
        public static string CON_COL_ITEM_STATUS_ID = "Status";
        public static string CON_COL_ITEM_GST = "GST";
        public static string CON_COL_ITEM_TAX = "Tax";
        public static string CON_COL_ITEM_CREATED_DATE = "CreatedDate";

        #endregion

        #region Master Database objects

        public static string CON_DT_CATEGORY = "tblCategory";
        public static string CON_DT_STATUS = "tblStatus";


        //stored procedures
        public static string CON_SP_GET_ALL_CATEGORIES = "sp_GetAllCategories";
        public static string CON_SP_GET_ALL_STATUS = "sp_GetAllStatus";


        #endregion Item Database objects
    }
}
