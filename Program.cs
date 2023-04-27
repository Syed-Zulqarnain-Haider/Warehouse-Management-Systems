using System;
using static System.Console;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Manage.UI;
using Manage.DL;
using Manage.BL;
namespace Management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            MISCUI.Loading();
            while (true)
            {
                MISCUI.HEADER();
                string OPT = MISCUI.IDENTITY_MODE();
                if (OPT == "1")
                {
                    while (true)
                    {
                        MISCUI.HEADER();

                        string USE = ADMINUI.ADMIN_MODE();
                        if (USE == "1")
                        {
                            MISCUI.HEADER();

                            ADMINBL S = ADMINUI.ADMIN_REGISTER();
                            ADMINDL.ADD_INTO_LIST(S);

                        }
                        else if (USE == "2")
                        {
                            MISCUI.HEADER();

                            ADMINBL C = ADMINUI.ADMIN_LOGIN();
                            bool SELECT = ADMINDL.ADMIN_SEARCH(C);
                            if (SELECT == true)
                            {
                                 //OPTIONS FOR ADMIN 
                                while (true)
                                {
                                    MISCUI.HEADER();

                                    string OPTION = ADMINUI.ADMIN_MENU();

                                    if (OPTION == "1")
                                    {
                                        MISCUI.HEADER();

                                        //  ______PRODUCTUI.ADD_PRODUCT();______ WILL RETURN THE OBJECT AFTER INITIALIZATION 
                                        PRODUCTBL IN = PRODUCTUI.ADD_PRODUCT();
                                        bool chk = PRODUCTUI.SEARCH_FOR_PRODUCT_EXIST(IN);
                                        if (chk == true)
                                        {
                                            Console.WriteLine("PRODUCT ALREADY EXIST YOU CAN MODIFY PRODUCT IN OPTION 5 THANK YOU");

                                        }
                                        //  _______PRODUCTDL.ADD_PRODUCT_TO_LIST(IN);_______ADD THAT OBJECT INTO LIST 
                                        // bool a= PRODUCTDL.SEARCH_FOR_OBJECT_EXISTENCE(IN);
                                        else
                                        {
                                            PRODUCTDL.ADD_PRODUCT_TO_LIST(IN);
                                        }
                                        MISCUI.clearscreen();

                                    }
                                    else if (OPTION == "2")
                                    {
                                        MISCUI.HEADER();

                                        PRODUCTUI.VIEW_PRODUCT();

                                        // _______PRODUCTUI.PROD_DEL();________WIIL TAKE THE NAME OF THE PRODUCT WHICH DO YOU WANT TO DELETE
                                        string NAAM = PRODUCTUI.PROD_DEL();
                                        //  ____PRODUCTDL.DELETE_PRODUCT(NAAM);_____THIS FUNCTION WILL DELETE THE PRODUCT IN VARIABLE NAME  __(NAAM)__
                                        PRODUCTDL.DELETE_PRODUCT(NAAM);
                                        Console.WriteLine("YOU HAVE SUCCESSFULLY DELETED PRODUCT " + NAAM);
                                        MISCUI.clearscreen();

                                    }
                                    else if (OPTION == "3")
                                    {
                                        MISCUI.HEADER();

                                        PRODUCTUI.VIEW_PRODUCT();
                                        MISCUI.clearscreen();
                                    }
                                    else if (OPTION == "4")
                                    {
                                        MISCUI.HEADER();

                                        //___PRODUCTUI.VIEW_PRODUCT();____FIRST SHOW PRODUCTS
                                        PRODUCTUI.VIEW_PRODUCT();
                                        //_____SORT_BY _____ WILL BE INITIALIZED BY THE VALUE RETURNED BY____PRODUCTUI.TAKE_ORDER();____WHICH WILL TELLS THAT HOW TO SORT PRODUCT LIKE 
                                        //_____________________________________BY PRODUCT NAME, PRODUCT NUMBER , PRODUCT QUANTITY , PRODUCT PRICE
                                        string SORT_BY = PRODUCTUI.TAKE_ORDER();
                                        string sort_order = PRODUCTUI.ORDER_OF_SORTING();
                                        if (sort_order == "1")
                                        {
                                            //_______ref SORT_BY______THIS VALUE WILL BE PASSED BY REFERENCE______JUST TO BE FAMILIAR WITH PASS BY REFERENCE 

                                            PRODUCTUI.VIEW_PRODUCT_IN_ASCENDING_ORDER(SORT_BY);
                                            PRODUCTUI.VIEW_PRODUCT();

                                        }
                                        else if (sort_order == "2")
                                        {
                                            PRODUCTUI.VIEW_PRODUCT_IN_DESCENDING_ORDER(SORT_BY);
                                            PRODUCTUI.VIEW_PRODUCT();
                                        }
                                        else
                                        {
                                            Console.WriteLine("INVALID INPUT");
                                        }

                                        MISCUI.clearscreen();

                                    }
                                    else if (OPTION == "5")
                                    {
                                        MISCUI.HEADER();

                                        PRODUCTUI.VIEW_PRODUCT();
                                        Console.WriteLine("******************************************************************");
                                        Console.WriteLine("__________________________________________________________________");

                                        string MOD_NAME = PRODUCTUI.PROD_MODIFY_NAME();
                                        PRODUCTDL.SEARCH_MODIFY_PRODUCT(MOD_NAME);
                                        Console.WriteLine("YOU HAVE SUCCESSFULLY MODIFY PRODUCT " + MOD_NAME);

                                        MISCUI.clearscreen();
                                    }
                                    else if (OPTION == "6")
                                    {
                                        USERUI.VIEW_USER_DETAILS();
                                    }
                                    else if (OPTION == "7")
                                    {
                                        MISCUI.HEADER();


                                        MISCUI.VIEW_FAQ();
                                        bool check = MISCUI.CHOICE_FOR_FAQ();
                                        if (check == true)
                                        {

                                            ADMINBL ad = MISCUI.ADD_FAQS();
                                            ADMINDL.ADD_FAQ_TO_LIST(ad);
                                        }
                                        bool FAQ_DEL_CHECK;
                                        FAQ_DEL_CHECK = MISCUI.CHOICE_FOR_DELETING_FAQ();
                                        if (FAQ_DEL_CHECK == true)
                                        {
                                            string ques = MISCUI.DEL_FAQ();
                                            ADMINDL.DELETE_FAQS(ques);
                                            Console.WriteLine("YOU HAVE SUCCESSFULLY DELETED FAQ " + ques);
                                        }


                                        MISCUI.VIEW_FAQ();
                                        // MISCUI.clearscreen();

                                        MISCUI.clearscreen();


                                    }
                                    else if (OPTION == "8")
                                    {// I HAVE TOO ADD FUNCTION TO DELETE COMPLAINTS....

                                        MISCUI.HEADER();

                                        ADMINUI.VIEW_COMPLAINT();
                                        if (USERDL.COMPLAINTS_LIST.Count != 0)
                                        {
                                            bool CHOICE = ADMINUI.CHOICE_FOR_DELETING_COMPLAINT();
                                            if (CHOICE == true)
                                            {
                                                int IDX = ADMINUI.DELETE_COMPLAINT_INDEX();
                                                USERDL.DELETE_COMPLAINTS(IDX);
                                            }
                                        }
                                        MISCUI.clearscreen();
                                    }
                                    //HAVE TO ADD OPTION 9          
                                    else if (OPTION == "10")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("INVALID INPUT PLEASE TRY AGAIN");
                                    }

                                }

                            }
                            else if (SELECT == false)
                            {
                                Console.WriteLine("INVALID ADMIN NAME OR PASSWORD");
                            }


                        }
                        else if (USE == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("INVALID ADMIN INPUT PLEASE TRY AGAIN ");
                        }
                    }

                }
                else if (OPT == "2")
                {
                    while (true)
                    {
                        MISCUI.HEADER();

                        string USE_OPTION = USERUI.USER_MODE();
                        if (USE_OPTION == "1")
                        {
                            MISCUI.HEADER();

                            USERBL Z = USERUI.USER_REGISTER();
                            USERDL.ADD_USER_INTO_LIST(Z);
                        }
                        else if (USE_OPTION == "2")
                        {
                            MISCUI.HEADER();

                            USERBL K = USERUI.USER_LOGIN();
                            bool SEE = USERDL.USER_SEARCH(K);
                            if (SEE == true)
                            {
                                while (true)
                                {
                                    MISCUI.HEADER();

                                    string USER_OPTION = USERUI.USER_MENU();

                                    if (USER_OPTION == "1")
                                    {
                                        MISCUI.HEADER();
                                        PRODUCTUI.VIEW_PRODUCT();
                                        MISCUI.clearscreen();

                                    }
                                    else if (USER_OPTION == "2")
                                    {//CHECK_______$$$$$$$$$_________
                                        MISCUI.HEADER();

                                        PRODUCTUI.VIEW_PRODUCT();

                                        string PRODUCT_NAAM = USERUI.USER_BUY_PRODUCT();
                                        PRODUCTBL MARZII = USERDL.SEARCH_PRODUCT(PRODUCT_NAAM);
                                        int A;
                                        A = PRODUCTDL.ADD_INTO_BOUGHT_LIST(MARZII);

                                        if (A > 0 && A < MARZII.PRODUCT_QUANTITY)
                                        {

                                            PRODUCTDL.INITIALIZE_QUANTITY(MARZII, A);
                                        }
                                        MISCUI.clearscreen();
                                    }
                                    else if (USER_OPTION == "3")
                                    {
                                        MISCUI.HEADER();
                                        USERUI.VIEW_BOUGHT_PRODUCT();
                                        if (PRODUCTBL.BOUGHT_PRODUCTS.Count != 0)
                                        {
                                            Console.WriteLine("******************************************************************");
                                            Console.WriteLine("__________________________________________________________________");


                                            string BOUGHT_P_NAME = USERUI.MODIFY_BOUGHT_PRODUCT();
                                            PRODUCTBL b = USERDL.SEARCH_MODIFY_BOUGHT_PRODUCT(BOUGHT_P_NAME);
                                            int quantity_minus_from_bought_product = PRODUCTUI.MODIFY_QUANTITY(b);
                                            PRODUCTDL.INITIALIZE_QUANTITY_RETURN(b, quantity_minus_from_bought_product);
                                            OpenStandardInput();

                                            USERUI.VIEW_BOUGHT_PRODUCT();
                                            Console.WriteLine("YOU HAVE SUCCESSFULLY MODIFY PRODUCT " + BOUGHT_P_NAME);
                                            MISCUI.clearscreen();
                                        }
                                    }
                                    else if (USER_OPTION == "4")
                                    {
                                        MISCUI.HEADER();
                                        USERUI.VIEW_BOUGHT_PRODUCT();
                                        double bill = USERDL.ADD_INTO_BILL();
                                        USERUI.SHOW_BILL(bill);
                                    }
                                    else if (USER_OPTION == "5")
                                    {
                                        MISCUI.HEADER();
                                        USERUI.VIEW_BOUGHT_PRODUCT();
                                        if (USERUI.RETURN_CHOICE())
                                        {


                                            String PRODUCT_DEL_NAME = USERUI.USER_CANCEL_PRODUCT();

                                        }
                                    }
                                    else if (USER_OPTION == "6")
                                    {
                                        MISCUI.HEADER();
                                        //THESE FUNCTIONS ARE FOR USER TO ADD COMPLAINTS
                                        USERBL N = USERUI.ADD_COMPLAINT();
                                        USERDL.ADD_INTO_LIST_OF_COMPLAINTS(N);
                                        MISCUI.clearscreen();


                                    }
                                    else if (USER_OPTION == "7")
                                    {
                                        MISCUI.HEADER();

                                    }
                                    else if (USER_OPTION == "8")
                                    {
                                        MISCUI.HEADER();
                                        MISCUI.VIEW_FAQ();
                                        MISCUI.clearscreen();
                                    }
                                    else if (USER_OPTION == "9")
                                    {

                                        break;

                                    }
                                    else
                                    {
                                        MISCUI.HEADER();

                                        Console.WriteLine("INVALID INPUT TRY AGAIN");
                                        MISCUI.clearscreen();
                                    }

                                }
                            }
                        }
                        else if (USE_OPTION == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("INVALID USER INPUT PLEASE TRY AGAIN ");
                        }
                    }
                }
                
                else if (OPT == "3")
                {
                    MISCUI.HEADER();

                    MISCUI.ABOUT_DEVELOPER();
                    Console.ReadLine();
                }
                else if (OPT == "4")
                {
                    MISCUI.BYE_BYE();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    MISCUI.HEADER();

                    Console.WriteLine("INVALID INPUT PLEASE TRY AGAIN");
                }
            }
        }

    } 
}             
                   
