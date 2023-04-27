using System;
using System.Collections.Generic;
using System.Text;
using Manage.BL;
using Manage.UI;
namespace Manage.DL
{
    class PRODUCTDL
    {
        public static List<PRODUCTBL> PRODUCTS_LIST = new List<PRODUCTBL>();

// THIS FUNCTION IS FOR VALIDATION IF USER ENTER ANOTHER THAN FLOAT
     //   public static bool PRODUCT_NO_VALIDATION(string PRODUCT_NUMBER)
        //{
        //    bool a = true;
        //    for (int i = 0; PRODUCT_NUMBER.Length != '\0'; i++)
        //    {
        //        int y = Convert.ToInt32(PRODUCT_NUMBER[i]);
        //        if (y >= 48 && y <= 57|| y==46)
        //        {
        //            a = false;
        //            break;
        //        }
        //    }
        //    if (a)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        public static bool NAME_VALIDATION(string PROD_NAME)
        {
            if (PRODUCTS_LIST.Count != 0)
            {
                foreach (PRODUCTBL S in PRODUCTS_LIST)
                {
                    if (S.PRODUCT_NAME == PROD_NAME)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //___________________________Function for Username VALIDATION________________
        public static bool SERIAL_VALIDATION(float product_number)
        {
            if (PRODUCTS_LIST.Count != 0)
            {
                foreach(PRODUCTBL S in PRODUCTS_LIST)
                {
                    if (S.PRODUCT_NUMBER == product_number)
                    {
                        return false;
                    }
                }
            }
                return true;
           
        }
        public static int ADD_INTO_BOUGHT_LIST(PRODUCTBL MARZII)
        {
            Console.WriteLine("ENTER THE QUANTITY YOU WANT TO BUY");
            int A;
            A=int.Parse(Console.ReadLine());
            if (A > 0 && A < MARZII.PRODUCT_QUANTITY)
            {
                MARZII.PRODUCT_QUANTITY += A;
                PRODUCTBL.BOUGHT_PRODUCTS.Add(MARZII);
            return A;
            }
            return 0;
        }
        public static PRODUCTDL INITIALIZE_QUANTITY(PRODUCTBL MARZII,  int quant) 
        {
            foreach (PRODUCTBL S in PRODUCTS_LIST)
            {
                if (S.PRODUCT_NAME == MARZII.PRODUCT_NAME)
                { 
                     S.PRODUCT_QUANTITY -=quant ;
                }
            }
            return null;
        
        }
        public static PRODUCTDL INITIALIZE_QUANTITY_RETURN(PRODUCTBL MARZII, int quant)
        {
            foreach (PRODUCTBL S in PRODUCTS_LIST)
            {
                if (S.PRODUCT_NAME == MARZII.PRODUCT_NAME)
                {
                    S.PRODUCT_QUANTITY += quant;
                }
            }
            return null;

        }

        public static void TAKE_INPUT_TO_MODIFY_BOUGHT_PRODUCTS(PRODUCTBL s)

        {
            Console.WriteLine("YOU CAN ONLY CHANGE THE QUANTITY OF THE PRODUCT");
            int temp = s.PRODUCT_QUANTITY;
            s.PRODUCT_QUANTITY = int.Parse(Console.ReadLine());
            if (s.PRODUCT_QUANTITY > temp)
            {
                Console.WriteLine("PLEASE ENTER VALUE LESS THAN QUANTITY.  VALUE");

            }
            else
            {


                   temp -= s.PRODUCT_QUANTITY;

                   foreach(PRODUCTBL KIKI in PRODUCTS_LIST)
                       {
                            if (KIKI.PRODUCT_NAME == s.PRODUCT_NAME)
                              {
                                    KIKI.PRODUCT_QUANTITY = temp;
                              }
                       }

            }
      
        }
        //valiadtion adda karni hai
        //public static bool SEARCH_FOR_OBJECT_EXISTENCE(PRODUCTBL CHECK)
        //{
        //    //if (PRODUCTS_LIST.Count != 0)
        //    //{
        //    //    foreach (PRODUCTBL s in PRODUCTS_LIST)
        //    //    {
        //    //        if (s.PRODUCT_NAME == CHECK.PRODUCT_NAME)
        //    //        {
        //    //           // return true;
        //    //        }                     
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    //return false;
        //    //}

        //}
        public static void ADD_PRODUCT_TO_LIST(PRODUCTBL s)
        {
            PRODUCTS_LIST.Add(s);
        }
       
        public static void DELETE_PRODUCT(string NAME)
        {
            for (int i = 0; i < PRODUCTS_LIST.Count; i++)
            {
                if (PRODUCTS_LIST[i].PRODUCT_NAME == NAME)
                {

                    PRODUCTS_LIST.RemoveAt(i);

                }
            }

        }
        
        public static void SEARCH_MODIFY_PRODUCT(string naam)
        {

            if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                foreach (PRODUCTBL s in PRODUCTDL.PRODUCTS_LIST)
                {
                    if (s.PRODUCT_NAME == naam)
                    {
                        PRODUCTUI.TAKE_INPUT_FOR_MODIFY_PRODUCTS(s);
                    }
                }

        }
        
    }
}
