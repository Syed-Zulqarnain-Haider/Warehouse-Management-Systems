using System;
using static System.Console;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Manage.DL;
using Manage.BL;
namespace Manage.UI
{
    class ADMINUI
	{	//_________________________Function for admin mode___________________________

        public static string ADMIN_MODE()
        {
            Console.WriteLine("IDENTITY MODE > ADMIN MODE ");
            Console.WriteLine("_____________");
            Console.WriteLine("Choose One of the Following Option Number ");
            Console.WriteLine("   1.  Register ");
            Console.WriteLine("   2.  Login");
            Console.WriteLine("   3.  Return");
            Console.WriteLine("CHOOSE OPTION:  ");
            string option = Console.ReadLine();
            return option;
        }
        //__________________FUNCTION to register admin
        public static ADMINBL ADMIN_REGISTER()
        {
            Console.Clear();
            MISCUI.HEADER();
            Console.WriteLine("IDENTIFICATION MODE > SIGN UP > ADMIN REGISTRATION");
            Console.WriteLine("Enter Name: ");
            string admin;
            admin=Console.ReadLine();
            while (!MISCUI.username_validation(admin))
            {
                Console.WriteLine("Must Contain Numbers: ");
                admin = Console.ReadLine();
            }
            Console.WriteLine("Enter Password: ");
            string pass = Console.ReadLine();
            while (!MISCUI.password_validation(pass))
            {
                Console.WriteLine("Password at least 8 characters containing number: ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Enter E-mail:  ");
            string email;
            email = Console.ReadLine();
            while (!MISCUI.email_validation(email))
            {
                Console.WriteLine( "Email Should Contain @ character: ");
                email = Console.ReadLine();
            }
            ADMINBL S = new ADMINBL(admin,pass, email);
            return S;
        }
        public static ADMINBL ADMIN_LOGIN()
        {
            string name;
            string password;
            string email;
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > LOGIN");
            Console.WriteLine("_____________");
            Console.WriteLine("ENTER USERNAME: ");
            name=Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD: ");
            password=Console.ReadLine();
            Console.WriteLine("ENTER EMAIL: ");
            email = Console.ReadLine();
            ADMINBL S = new ADMINBL(name,password,email);
            return S;
           
        }


        public static bool CHOICE_FOR_DELETING_COMPLAINT()
        {
            Console.WriteLine("DO YOU WANT TO DELETE COMPLAINTS (Y/N)");
            Char CHOICE = char.Parse(Console.ReadLine());
            if (CHOICE=='Y' || CHOICE=='y')
            {
                return true;
            }
            else
            {
                return false;
            }




        }
		//__________________Function for admin login______________________

		//public static void ADMIN_LOGIN(string[] admin_name, string[] admin_pass)
		//{
		//	string name1 = "";
		//	string password1 = "";
		//	Console.Write("IDENTIFICATION MODE > ADMIN MODE > LOGIN");
		//	Console.Write("\n");
		//	Console.Write("_____________");
		//	Console.Write("\n");
		//	Console.Write("       ENTER USERNAME: ");
		//	name1 = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("       ENTER PASSWORD: ");
		//	password1 = ConsoleInput.ReadToWhiteSpace(true);

		//	while (!(valid_admin(name1, password1, admin_name, admin_pass)))
		//	{
		//		header();
		//		Console.Write("IDENTITY MODE > ADMIN MODE > LOGIN");
		//		Console.Write("\n");
		//		Console.Write("_____________");
		//		Console.Write("\n");
		//		Console.Write("Wrong Credentials TYPE AGAIN");
		//		Console.Write("\n");
		//		Console.Write("       ENTER USERNAME: ");
		//		name1 = ConsoleInput.ReadToWhiteSpace(true);
		//		Console.Write("       ENTER PASSWORD: ");
		//		password1 = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//}
		////__________________Function for admin validation_______________________


		//public static bool VALID_ADMIN(string name, string password, string[] admin_name, string[] admin_pass)
		//{
		//	bool flag = false;
		//	for (int i = 0; i < 5; i++)
		//	{
		//		if (name == admin_name[i] && password == admin_pass[i])
		//		{
		//			flag = true;
		//		}
		//	}
		//	if (flag == true)
		//	{
		//		return true;
		//	}
		//	else if (flag == false)
		//	{
		//		return false;
		//	}
		//	return false;
		//}
		////__________________FUNCTION to register admin

		//public static void ADMIN_REGISTER(string[] admin_name, string[] admin_pass, string[] admin_email)
		//{
		//	system("cls");
		//	header();
		//	Console.Write("\tADMIN REGISTRATION");
		//	Console.Write("\n");
		//	Console.Write("Enter Name: ");
		//	admin = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!username_validation(admin))
		//	{
		//		Console.Write("Must Contain Numbers: ");
		//		admin = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	Console.Write("Enter Password: ");
		//	pass = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!password_validation(pass))
		//	{
		//		Console.Write("Password at least 8 characters containing number: ");
		//		pass = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	Console.Write("Enter E-mail:  ");
		//	string email = "";
		//	email = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!email_validation(email))
		//	{
		//		Console.Write("Email Should Contain @ character: ");
		//		email = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	admin_details(admin, pass, email, admin_name, admin_pass, admin_email);
		//}
		////__________________________Function for ADMIN MENU________________________

		//       ___________________________ADMIN MENU________________
        public static string ADMIN_MENU()
		{
		Console.WriteLine("_____________");
		Console.WriteLine("Choose One of the Following Options ");
		Console.WriteLine("   1.  Add Products ");
		Console.WriteLine("   2.  Delete Products");
		Console.WriteLine("   3.  View Products Details ");
        Console.WriteLine("   4.  View Products in Sorting Order ");
        Console.WriteLine("   5.  Modify Product");
		Console.WriteLine("   6.  View Buyer Details ");
		Console.WriteLine("   7.  Edit FAQS for buyers");
		Console.WriteLine("   8.  Respond To Problems ");
		Console.WriteLine("   9.  Manage User Accounts");
		Console.WriteLine("   10. Logout");
		Console.WriteLine("YOUR OPTION:..");
		string OPTION;
		OPTION = Console.ReadLine();
        Console.Clear();

            return OPTION;
		}
       // _____________________ADMIN CAN VIEW COMPLAINTS FUNCTION____________________
        public static void VIEW_COMPLAINT()
        {
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW COMPLAINTS");
            Console.WriteLine("USER COMPLAINTS");

            if (USERDL.COMPLAINTS_LIST.Count != 0)
            {
                foreach (USERBL s in USERDL.COMPLAINTS_LIST)
                {
                    Console.WriteLine(s.NUMBER);
                    Console.WriteLine(s.COMPLAINT);
                }
            }
            else
            {
                Console.WriteLine("There is no Complains or Suggestions yet");
            }
        }
        //////////public static void PAYMENT()
        //////////{//BOUGHT  PRODUCT MAIN JO OBJECT RETURN KARAYA HAI USKA AMOUNT WALA
        ////////// ////ADD KAR KAI USKO AIK VARIABLE MAIN STORE KARANA HAI ABS AUR BOUGHT PRODUCTS KO LIST SAI REMOVE KARANA HAI 
        //////////    if (payable == 0)
        //////////    {
        //////////        cout << "You Have not yet store ";
        //////////        cout << endl << "Reserve Your Seats & then come back";
        //////////    }
        //////////    else
        //////////    {


        //////////        Console.WriteLine("ENTER AMOUNT YOU WANT TO PAY: ");
        //////////            int paid;

        //////////             paid= int.Parse(Console.ReadLine());
        //////////        Console.WriteLine("BILLING AMOUNT : ";
        //////////        PRODUCTBL.BOUGHT_PRODUCTS
        //////////        Console.WriteLine("Balance: ";
        //////////        Console.ReadLine(PRODUCTBL - paid;
        //////////            cout << endl;
        //////////            cout << "Succesfully Done" << endl;
                
        //////////    }
        //////////}
      // ______________________AFTER VIEWING ADMIN CAN DELETE COMPLAINTS AFTER RESOLVING_____________________@@@@@@@@@@@@@@@@@@@@
        public static int DELETE_COMPLAINT_INDEX()
        {
            Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > DELETE COMPLAINTS");
            Console.WriteLine("ENTER COMPLAINT INDEX YOU WANT TO DELETE");
            
            int index=int.Parse(Console.ReadLine());
            return index;
           
        }
        //_________________________Function for admin mode___________________________
        


        //						             				________ADMIN MENU   _________


        // OPTION 02
        //___________________FUNCTION FOR DELETING PRODUCT__________________
        //// OPTION 03
        ////___________________FUNCTION TO VIEW PRODUCT DETAILS________________
        //public static void VIEW_PRODUCT(string[] productName, string[] productNo, string[] product_time, int[] industrial_price, int[] household_price)
        //{
        //	if (count_product == 0)
        //	{
        //		Console.Write("No Product To Show");
        //	}
        //	else
        //	{
        //		Console.Write("|Product No.");
        //		Console.Write("|Product Name");
        //		Console.Write("\t");
        //		Console.Write("|Storing Time");
        //		Console.Write("\t");
        //		Console.Write("|Industrial Prod.");
        //		Console.Write("\t");
        //		Console.Write("|Household prod.");
        //		Console.Write("\n");
        //		Console.Write("\n");
        //		for (int i = 0; i < count_product; i++)
        //		{
        //			Console.Write("|");
        //			Console.Write(productNo[i]);
        //			Console.Write("\t\t");
        //			Console.Write("|");
        //			Console.Write(productName[i]);
        //			Console.Write("\t\t");
        //			Console.Write("|");
        //			Console.Write(product_time[i]);
        //			Console.Write("\t\t");
        //			Console.Write("|");
        //			Console.Write(industrial_price[i]);
        //			Console.Write("\t\t");
        //			Console.Write("|");
        //			Console.Write(household_price[i]);
        //			Console.Write("\n");
        //		}
        //	}
        //}

        //// OPTION 04
        ////_______________FUNCTION FOR MODIFICATION__________________________
        //public static void MODIFY_PRODUCT(int idx, string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price)
        //{
        //	Console.Write("Product No.: ");
        //	productNo[idx] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("Product Name: ");
        //	productName[idx] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("Recieving Time: ");
        //	product_time[idx] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("Day or Night Time (d/n): ");
        //	dayNight[idx] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("No. of industrial products: ");
        //	product_ind[idx] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
        //	Console.Write("Price of industrial product: ");
        //	product_house[idx] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
        //	Console.Write("No. of household or other products: ");
        //	industrial_price[idx] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
        //	Console.Write("Price of household product: ");
        //	household_price[idx] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
        //}

        //// OPTION 05
        ////_______________FUNCTION View Passeenger Details___________________
        //public static void BUYER_DETAIL(string[] username, string[] firstname, string[] lastname, long[] CNIC, string[] contact, string[] UserN, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product)
        //{
        //	if (store == 0)
        //	{
        //		Console.Write("No User found . Therefore, No User Details");
        //	}
        //	else if (store != 0)
        //	{
        //		Console.Write("|UserName\t\t|Name\t\t\t|NIC\t\t|Contact\t\t|PRODUCT Name\t\t|No. " + "of products(F/S)\t\t|Ticket Number");
        //		Console.Write("\n");
        //		for (int i = 0; i < store; i++)
        //		{
        //			for (int j = 0; j < usercount; j++)
        //			{
        //				if (UserN[i] == username[j])
        //				{
        //					Console.Write("|");
        //					Console.Write(username[j]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(firstname[j]);
        //					Console.Write(" ");
        //					Console.Write(lastname[j]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(CNIC[j]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(contact[j]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(pnaam[j]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(no_industrial[i]);
        //					Console.Write("/");
        //					Console.Write(no_household[i]);
        //					Console.Write("\t\t");
        //					Console.Write("|");
        //					Console.Write(buy_product[i]);
        //					Console.Write("\n");
        //				}
        //			}
        //		}
        //	}
        //}

        //// OPTION 06	
        ////________________Function to VIEW FAQS____________
        //public static void FAQS()
        //{
        //	fstream file = new fstream();
        //	string faq = "";
        //	file.open("faqs.txt", ios.@in);
        //	while (!file.eof())
        //	{
        //		getline(file, faq);
        //		questions[faq_counter] = faq;
        //		getline(file, faq);
        //		answers[faq_counter] = faq;
        //		faq_counter++;
        //	}
        //	file.close();
        //	Console.Write("---------------  FAQS  --------------");
        //	Console.Write("\n");
        //	Console.Write("\n");
        //	if (faq_counter == 0)
        //	{
        //		Console.Write("There is no FAQs yet");
        //	}
        //	if (faq_counter != 0)
        //	{
        //		for (int i = 0; i < faq_counter; i++)
        //		{

        //			Console.Write(questions[i]);
        //			Console.Write("\n");
        //			Console.Write("\n");
        //			Console.Write(answers[i]);
        //			Console.Write("\n");
        //		}
        //	}
        //}
        ////________________Function to ADD FAQS____________

        //public static void ADD_FAQS()
        //{
        //	bool flag = true;
        //	while (flag)
        //	{
        //		Console.Write("Add Questions: \n use underscore:\n");
        //		questions[faq_counter] = ConsoleInput.ReadToWhiteSpace(true);
        //		Console.Write("Add Answer: \n");
        //		answers[faq_counter] = ConsoleInput.ReadToWhiteSpace(true);
        //		faq_counter++;
        //		Console.Write("Want to add more Press 1 if not 0: ");
        //		flag = bool.Parse(ConsoleInput.ReadToWhiteSpace(true));
        //	}
        //}

        //// OPTION 07
        ////________________ENTER YOU  Issues___________
        //public static void TAKE_SUGGESTIONS(string[] complainer, string[] suggest)
        //{

        //	Console.Write("Enter Your Name Here: ");
        //	complainer[suggest_counter] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("\n");
        //	Console.Write("Enter your suggestion here:");
        //	Console.Write("\n");
        //	Console.Write("Use Underscore_ instead of spaces");
        //	Console.Write("\n");
        //	suggest[suggest_counter] = ConsoleInput.ReadToWhiteSpace(true);
        //	Console.Write("Thanks for your cooperation");
        //	Console.Write("\n");
        //	suggest_counter++;
        //}
        ////________________VIEW to Issues___________
        //public static void SUGGESTIONS(string[] complainer, string[] suggest)
        //{
        //	if (suggest_counter == 0)
        //	{
        //		Console.Write("There is no Complains or Suggestions yet");
        //	}
        //	else
        //	{
        //		for (int i = 0; i < suggest_counter; i++)
        //		{
        //			Console.Write(complainer[i]);
        //			Console.Write("\n");
        //			Console.Write(suggest[i]);
        //			Console.Write("\n");
        //		}
        //	}
        //}

        //// OPTION 08
        ////_______________Function to Approve User Details________
        //public static void APPROVE_USER(string[] userName, string[] password, string[] email)
        //{
        //	if (app == 0 || approved_N[0] == " ")
        //	{
        //		Console.Write("There is no user to SHOW");
        //		Console.Write("\n");
        //		;
        //	}
        //	else
        //	{
        //		bool dec = true;
        //		while (dec)
        //		{
        //			header();
        //			Console.Write("IDENTITY MODE > ADMIN MODE > USER ACCOUNT");
        //			Console.Write("\n");
        //			Console.Write("_____________");
        //			Console.Write("\n");
        //			Console.Write("User IDs");
        //			Console.Write("\n");
        //			Console.Write("|USERNAME\t\t\t|E-MAIL\t\t\t\t|PASSWORD");
        //			Console.Write("\n");
        //			for (int i = 0; i < app; i++)
        //			{
        //				for (int j = 0; j < usercount; j++)
        //				{
        //					if (approved_N[i] == userName[j])
        //					{

        //						Console.Write("|");
        //						Console.Write(userName[j]);
        //						Console.Write("\t\t\t");
        //						Console.Write("|");
        //						Console.Write(email[j]);
        //						Console.Write("\t\t\t");
        //						Console.Write("|");
        //						Console.Write(password[j]);
        //						Console.Write("\n");
        //					}
        //				}
        //			}

        //			Console.Write("Enter USERNAME to approve or Type all to approve all: ");
        //			string usernaam = "";
        //			usernaam = ConsoleInput.ReadToWhiteSpace(true);
        //			if (usernaam == "all")
        //			{
        //				app = 0;
        //			}
        //			else
        //			{
        //				if (app == 1)
        //				{
        //					approved_N[0] = " ";
        //					app--;
        //				}
        //				else
        //				{
        //					for (int k = 0; k < app; k++)
        //					{
        //						if (usernaam == approved_N[k])
        //						{
        //							for (int i = k; i < usercount - 1; i++)
        //							{
        //								approved_N[i] = approved_N[i + 1];
        //							}
        //							app--;
        //							break;
        //						}
        //					}
        //					if (app != 0)
        //					{
        //						Console.Write("Want to approve more press 1 if not press 0: ");
        //					}
        //					else
        //					{
        //						dec = false;
        //					}
        //				}
        //			}
        //		}
        //	}
        //}

    }
}
