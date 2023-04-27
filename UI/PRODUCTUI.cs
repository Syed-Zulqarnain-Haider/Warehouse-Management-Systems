using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Manage.BL;
using Manage.DL;
namespace Manage.UI
{
    class PRODUCTUI
    {
        public static int MODIFY_QUANTITY(PRODUCTBL A)
            {
                    Console.WriteLine("ENTER THE QUANTITY YOU WANT TO EDIT OR RETURN IN PRODUCT ");
                    int check= int.Parse(Console.ReadLine());
                    int TEMP;

                    if (check > 0 && check < A.PRODUCT_QUANTITY)
                    {
                       TEMP = check;
                       A.PRODUCT_QUANTITY = check;
                     return TEMP;
                    }
            return 0;

            }
        ////                                                    OPTION 01
              //                              _______________FUNCTION TO ADD PRODUCT__________________
        public static PRODUCTBL ADD_PRODUCT()
        {
            float PROD_NUM = 0.0F;
            string PROD_NAME = "a";
            string CATEGORY = "b";
            int PROD_QUANTITY = 0;
            double PROD_PRICE = 0;
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > ADD PRODUCT");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("[1]. Product No.");
//            string TEMP_PRODUCT_NUM = Console.ReadLine();
            //if (!PRODUCTDL.PRODUCT_NO_VALIDATION(TEMP_PRODUCT_NUM)) 
            //{ 
                
                
                PROD_NUM = float.Parse(Console.ReadLine());




                while(!PRODUCTDL.SERIAL_VALIDATION(PROD_NUM))
                {
                Console.WriteLine("PRODUCT NUMBER ALREADY REGISTERED PLEASE ENTER DIFF NUMBER");
                    // TEMP_PRODUCT_NUM = Console.ReadLine();

                    PROD_NUM = float.Parse(Console.ReadLine());
                }
            //}
            //else
            //{
            //    Console.WriteLine("WARNING ! PRODUCT NUMBER INVALID INPUT ONLY NUMBERS e.g (12.23) ");

            //}
            Console.WriteLine("[2]. Product Name");
            PROD_NAME = Console.ReadLine();
            while (!PRODUCTDL.NAME_VALIDATION(PROD_NAME))
            {
                Console.WriteLine("PRODUCT NAME ALREADY REGISTERED PLEASE ENTER DIFF NAME");
                PROD_NAME = Console.ReadLine();
            }
            Console.WriteLine("[3]. Category");
            CATEGORY = Console.ReadLine();
            Console.WriteLine("[4]. Product Quantity");
            PROD_QUANTITY = int.Parse(Console.ReadLine());
            while (PROD_QUANTITY < 0)
            {
                Console.WriteLine("PRODUCT QUANTITY LESS THAN ZERO (0) ");
                PROD_QUANTITY = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("[5]. Product Price");
            PROD_PRICE = double.Parse(Console.ReadLine());
            while (PROD_PRICE < 0)
            {
                Console.WriteLine("PRODUCT PRICE LESS THAN ZERO (0) ");
                PROD_PRICE = double.Parse(Console.ReadLine());
            }
            PRODUCTBL s = new PRODUCTBL(PROD_NUM, PROD_NAME, CATEGORY, PROD_QUANTITY, PROD_PRICE);
            return s;
        }
        //      ______________________FUNCTION TO DELETE SPECIFIC PRODUCT FROM LIST BY TAKING NAME___________________________
        public static string PROD_DEL()
        {
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > DELETE PRODUCT ");
            Console.WriteLine("_____________");
            Console.WriteLine("Enter The Product Name You Want To Remove ");
            string name;
            name = Console.ReadLine();
            return name;
        }
        public static bool SEARCH_FOR_PRODUCT_EXIST(PRODUCTBL naam)
        {

            if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
            {
                foreach (PRODUCTBL s in PRODUCTDL.PRODUCTS_LIST)
                {
                    if (s.PRODUCT_NAME == naam.PRODUCT_NAME)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //    __________________________________________view products stored in list____________________________________________
        public static void VIEW_PRODUCT()
        {
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS");
            Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       "+ "|PROD QUANTITY. " + "|PRODUCT PRICE.");

            if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
            {
                foreach (PRODUCTBL s in PRODUCTDL.PRODUCTS_LIST)
                {

                    Console.WriteLine("   |" + s.GET_PROD_NO() + "\t\t|" + s.GET_PROD_NAME() + " \t\t|" + s.GET_PROD_CATEGORY() + "  \t\t|" + s.GET_PROD_QUANTITY() + " \t\t|" + s.GET_PROD_PRICE());
                }
            }
            else
            {
                Console.WriteLine("DATA DOES NOT EXIST");
            }
        }
        //________________________how do you want to sort you data  like by name, by number, by quantity, by price ___________
        public static string TAKE_ORDER()
        {
            Console.WriteLine("HOW DO YOU LIKE TO SORT THE LIST OF PRODUCTS. ");
            Console.WriteLine("[1]. PRICE ");
            Console.WriteLine("[2]. NAME  ");
            Console.WriteLine("[3]. QUANTITY ");
            Console.WriteLine("[4]. PRODUCT NO ");
            String OPTION = Console.ReadLine();
            return OPTION;
        }
       //________________________________________sorting order ascending or descending________________________________________
        public static string ORDER_OF_SORTING()
        {
            Console.WriteLine("HOW DO YOU LIKE TO SORT THE LIST OF PRODUCTS ACCORDING TO PRICE. ");
            Console.WriteLine("[1].ASCENDING"); 
            Console.WriteLine("[2].DESCENDING");
            Console.WriteLine("YOUR OPTION");
            string OPTION = Console.ReadLine();
            return OPTION;
        }
       //   _________________________________________function for ascending order_____________________________________________
        public static void VIEW_PRODUCT_IN_ASCENDING_ORDER( String SORT_BY_PRICE_OPTION_SELECTOR_ASCENDING)
        {
            if (SORT_BY_PRICE_OPTION_SELECTOR_ASCENDING == "1")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderBy(o => o.PRODUCT_PRICE).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_ASCENDING == "2")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderBy(o => o.PRODUCT_NAME).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_ASCENDING == "3")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderBy(o => o.PRODUCT_QUANTITY).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_ASCENDING == "4")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");
                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderBy(o => o.PRODUCT_NUMBER).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else
            {
                Console.WriteLine("INVALID INPUT PLEASE TRY AGAIN ");
            }
        }
       //   ________________________________________function for descending order_____________________________________________
        public static void VIEW_PRODUCT_IN_DESCENDING_ORDER(string SORT_BY_PRICE_OPTION_SELECTOR_DESCENDING)
        {
            if (SORT_BY_PRICE_OPTION_SELECTOR_DESCENDING == "1")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderByDescending(o => o.PRODUCT_PRICE).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_DESCENDING == "2")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderByDescending(o => o.PRODUCT_NAME).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_DESCENDING == "3")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderByDescending(o => o.PRODUCT_QUANTITY).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else if (SORT_BY_PRICE_OPTION_SELECTOR_DESCENDING == "4")
            {
                Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW PRODUCTS IN SORT");
                Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

                if (PRODUCTDL.PRODUCTS_LIST.Count != 0)
                {
                    PRODUCTDL.PRODUCTS_LIST = PRODUCTDL.PRODUCTS_LIST.OrderByDescending(o => o.PRODUCT_NUMBER).ToList();
                }
                else
                {
                    Console.WriteLine("DATA DOES NOT EXIST");
                }
            }
            else
            {
                Console.WriteLine("INVALID INPUT");

            }

        }
        //__________________________________FUNCTION TO take name to modify which product______________________________________
        public static string PROD_MODIFY_NAME()
        {
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > MODIFY PRODUCT DETAILS");
            Console.WriteLine("_____________");
            Console.WriteLine("Enter The Product Name You Want To (MODIFY) Details ");
            string name;
            name = Console.ReadLine();
            return name;
        }
        //________________________overwriting or taking input in the attributes of the list at specific index__________________
        public static void TAKE_INPUT_FOR_MODIFY_PRODUCTS(PRODUCTBL si)
        {

            si.PRODUCT_NUMBER = 0.0F;
            si.PRODUCT_NAME = "";
            si.PRODUCT_CATEGORY = "";
            si.PRODUCT_QUANTITY = 0;
            si.PRODUCT_PRICE = 0;
            Console.Write("\n");
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > MODIFY PRODUCT DETAILS");
            Console.WriteLine("_____________");
            Console.WriteLine("[1]. Product No.");
            si.PRODUCT_NUMBER = float.Parse(Console.ReadLine());
            Console.WriteLine("[2]. Product Name");
            si.PRODUCT_NAME = Console.ReadLine();
            Console.WriteLine("[3]. Category");
            si.PRODUCT_CATEGORY = Console.ReadLine();
            Console.WriteLine("[4]. Product Quantity");
            si.PRODUCT_QUANTITY = int.Parse(Console.ReadLine());
            Console.WriteLine("[5]. Product Price");
            si.PRODUCT_PRICE = double.Parse(Console.ReadLine());
            Console.Write("\n");

        }
    }
}
