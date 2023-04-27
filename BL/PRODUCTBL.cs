using System;
using System.Collections.Generic;
using System.Text;

namespace Manage.BL
{
    class PRODUCTBL
    {
        public float PRODUCT_NUMBER;
        public string PRODUCT_NAME;
        public string PRODUCT_CATEGORY;
        public int PRODUCT_QUANTITY;
        public double PRODUCT_PRICE;
        public double bill;
        public static List<PRODUCTBL> BOUGHT_PRODUCTS = new List<PRODUCTBL>();



       












        public PRODUCTBL(float PROD_NUM, string PROD_NAME, string CATEGORY, int PROD_QUANTITY, double PROD_PRICE)
        {
            this.PRODUCT_NUMBER = PROD_NUM;
            this.PRODUCT_NAME = PROD_NAME;
            this.PRODUCT_CATEGORY = CATEGORY;
            this.PRODUCT_QUANTITY = PROD_QUANTITY;
            this.PRODUCT_PRICE = PROD_PRICE;

        }
        public PRODUCTBL(){}
        public PRODUCTBL(string PROD_NAME, int PROD_QUANTITY)
        {
            this.PRODUCT_NAME = PROD_NAME;
            this.PRODUCT_QUANTITY = PROD_QUANTITY;
        }
        public float GET_PROD_NO()
        {
            return PRODUCT_NUMBER;
        }

        public string GET_PROD_NAME()
        {
            return PRODUCT_NAME;
        }

        public string GET_PROD_CATEGORY()
        {
            return PRODUCT_CATEGORY;
        }

        public int GET_PROD_QUANTITY()
        {
            return PRODUCT_QUANTITY;
        }

        public double GET_PROD_PRICE()
        {
            return PRODUCT_PRICE;
        }
    }
}
