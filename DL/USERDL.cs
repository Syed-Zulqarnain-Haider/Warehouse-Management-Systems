using System;
using System.Collections.Generic;
using System.Text;
using Manage.BL;
using Manage.UI;
namespace Manage.DL
{
    class USERDL
    {
        public static List<USERBL> COMPLAINTS_LIST = new List<USERBL>();
        public static List<USERBL> USER_DETAILS = new List<USERBL>();
        public static double ADD_INTO_BILL()
        {
            //THIS FUNCTION WIL ADD ALL THE PRODUCTS IN LIST THAT CERTAIN USER HAS BOUGHT AND STORE THEM IN S.BILL AND AFTER THAT TO RETURN THAT VALU BY STORING IN A//

            double a = 0;
            if (PRODUCTBL.BOUGHT_PRODUCTS.Count != 0){
               foreach (PRODUCTBL S in PRODUCTBL.BOUGHT_PRODUCTS)
                {
                    S.bill = a + S.PRODUCT_PRICE;
                    a = S.bill;
                }                
                return a;
            }
            return 0;
        }   

        public static bool USER_SEARCH(USERBL K)
        {
            if (USER_DETAILS.Count != 0)
            {
                foreach (USERBL S in USER_DETAILS)
                {
                    if (S.username == K.username && S.pass == K.pass)
                    {
                        return true;
                    }
                }
            }
               return false;
        }
       

            public static void ADD_USER_INTO_LIST(USERBL Z)
        {
            USER_DETAILS.Add(Z);
        }
        //___________________________Function for Username VALIDATION________________
        public static bool  username_validation(string name)
        {
            bool a = true;
            for (int i = 0; name.Length != '\0'; i++)
            {
                int y = Convert.ToInt32(name[i]);
                if (y >= 48 && y <= 57)
                {
                    a = false;
                    break;
                }
            }
            if (a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void ADD_INTO_LIST_OF_COMPLAINTS(USERBL N)
        {
            COMPLAINTS_LIST.Add(N);
        }
        public static void DELETE_COMPLAINTS(int IDX)
        {
            if (COMPLAINTS_LIST.Count != 0)
            {
                int A = COMPLAINTS_LIST.Count;

                for (int i = 0; i < A; i++)
                {
                    if (COMPLAINTS_LIST[i].NUMBER == IDX)
                    {

                    COMPLAINTS_LIST.RemoveAt(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no Complains or Suggestions yet");
            }
        }
        public static PRODUCTBL SEARCH_PRODUCT(string PROD_NAAM)
        {

            if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
            {
                foreach (PRODUCTBL s in PRODUCTDL.PRODUCTS_LIST)
                {
                    if (s.PRODUCT_NAME == PROD_NAAM)
                    {
                        return s;
                    }
                }
            }
            return null;
        }
        public static PRODUCTBL SEARCH_MODIFY_BOUGHT_PRODUCT(string BOUGHT)
        {

            if (PRODUCTBL.BOUGHT_PRODUCTS.Count != 0)
                foreach (PRODUCTBL s in PRODUCTBL.BOUGHT_PRODUCTS)
                {
                    if (s.PRODUCT_NAME == BOUGHT)
                    {
                        return s;
                    }
                }
            return null;

        }
    }
}
