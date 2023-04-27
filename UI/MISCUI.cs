using System;
using static System.Console;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Manage.BL;
using Manage.DL;
namespace Manage.UI
{
    class MISCUI
	{
	
		public static void ABOUT_DEVELOPER()
        {
			Console.WriteLine("IDENTIFICATION MODE > DEVELOR MODE > ABOUT DEVELOPER");
			Console.WriteLine("_____________________________________________________");
			string ABOUT = "A COMPUTER SCIENCE STUDENT OF UET LAHORE SESSION 2021. INTERESTED IN SELF DRIVING CARS, AI, CHAT BOTS, ETHICAL HACKING AND MANY MORE. ";
			string INFO = "I AM A DEDICATED, COMMITTED AND ORGANIZED PERSON WHO WORKS WITH A PROFESSIONAL APPROACH IN THE FIELD OF COMPUTER SCIENCE.";
			for(int i=0; i < ABOUT.Length; i++)
            {
				Console.Write(ABOUT[i]);

				Thread.Sleep(50);
            }
			Console.WriteLine("\n");
			for (int i = 0; i < INFO.Length; i++)
			{
				Console.Write(INFO[i]);
				Thread.Sleep(50);
			}
			Console.WriteLine("\n");

		}
		//_______________Function for IDENTITY
		//MODE_______________________
		public static string IDENTITY_MODE()
		{
			Console.WriteLine("IDENTIFICATION MODE");
			Console.WriteLine("___________________");
			Console.WriteLine("CHOOSE YOUR MODE ");
			Console.WriteLine("   1.  ADMIN MODE");
			Console.WriteLine("   2.  USER MODE");
			Console.WriteLine("   3.  ABOUT DEVELOPER");
			Console.WriteLine("   4.  Exit ");
			Console.WriteLine("Your Option:.. ");
			string selecter;
			selecter = Console.ReadLine();
			return selecter;
		}

		public static string DEL_FAQ()
		{
			Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW FAQ");
			Console.WriteLine("_____________________________________________________");
			Console.WriteLine("ENTER THE QUESTION YOU WANT TO DELETE. ");
			string name;
			name = Console.ReadLine();
			return name;
		}
		public static bool CHOICE_FOR_DELETING_FAQ()
		{
			Console.WriteLine("DO YOU WANT TO DELETE FAQ (Y/y) OR (N/n)");
			char a = char.Parse(Console.ReadLine());
			if (a == 'y' || a == 'Y')
			{
				return true;

			}

			return false;

		}
		public static bool CHOICE_FOR_FAQ()
		{
			Console.WriteLine("DO YOU WANT TO ADD QUESTIONS AND ANSWER (Y/y) OR (N/n)");
			char a = char.Parse(Console.ReadLine());
			if (a == 'y' || a == 'Y')
			{
				return true;

			}
           
				return false;
           
		}
	
		public static ADMINBL ADD_FAQS()
        {
			Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > ADD FAQS ");
			string QUEST="Q";
			string ANS ="A";
			Console.WriteLine( "ENTER THE QUESTION YOU WANT TO ADD: ");
			QUEST= Console.ReadLine();
			Console.WriteLine("ENTER THE ANSWER YOU WANT TO ADD: ");
			ANS=Console.ReadLine();
			ADMINBL IN = new ADMINBL(QUEST, ANS);
			return IN;					
		}
		public static void VIEW_FAQ()
		{
			Console.WriteLine("IDENTIFICATION MODE > ADMIN MODE > ADMIN > VIEW FAQ");
			Console.WriteLine("_____________________________________________________");
				if (ADMINDL.FAQ.Count != 0)
				foreach (ADMINBL s in ADMINDL.FAQ)
				{
					{
						Console.WriteLine(s.QUESTIONS + " ? \n"+ s.ANSWERS);
					}
				}

		}

		//____________________LOADING_________________
		public static void Loading()
		{
			Console.Clear();
			SetCursorPosition(72, 23);
			Console.Write("LOADING ");
			const char block = '■';
			for (int i = 0; i <= 30; i++)
			{
				Console.Write(block);

				SetCursorPosition(80 + i, 23);
				Thread.Sleep(100);
			}
			Console.Clear();
		}
		//_____________THANK YOU Header of the Program_____________
		static public void BYE_BYE()
		{
			Console.Clear();
			Console.WriteLine("\n");
			Console.WriteLine("\n");
			Console.WriteLine("  8888888 8888888888 8 8888        8          .8.          b.             8 8 8888     ,88'           `8.`8888.      ,8'     ,o888888o.     8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8         .888.         888o.          8 8 8888    ,88'             `8.`8888.    ,8'   . 8888     `88.   8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8        :88888.        Y88888o.       8 8 8888   ,88'               `8.`8888.  ,8'   ,8 8888       `8b  8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8       . `88888.       .`Y888888o.    8 8 8888  ,88'                 `8.`8888.,8'    88 8888        `8b 8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8      .8. `88888.      8o. `Y888888o. 8 8 8888 ,88'                   `8.`88888'     88 8888         88 8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8     .8`8. `88888.     8`Y8o. `Y88888o8 8 8888 88'                     `8. 8888      88 8888         88 8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888888888888    .8' `8. `88888.    8   `Y8o. `Y8888 8 888888<                       `8 8888      88 8888        ,8P 8 8888      88 ");
			Console.WriteLine("        8 8888       8 8888        8   .8'   `8. `88888.   8      `Y8o. `Y8 8 8888 `Y8.                      8 8888      `8 8888       ,8P  ` 8888     ,8P ");
			Console.WriteLine("        8 8888       8 8888        8  .888888888. `88888.  8         `Y8o.` 8 8888   `Y8.                    8 8888       ` 8888     ,88'     8888   ,d8P  ");
			Console.WriteLine("        8 8888       8 8888        8 .8'       `8. `88888. 8            `Yo 8 8888     `Y8.                  8 8888          `8888888P'        `Y88888P'   ");
			Console.WriteLine("______________________________________________________________________________________________________________________________________________________________");
			Console.WriteLine("**************************************************************************************************************************************************************  ");
			Console.WriteLine("\n");
			Console.WriteLine("                                                             ______________Zulqarnain Haider_______________  ");
			Console.WriteLine("                                                             __________________2021-CS-48__________________  ");
			Console.WriteLine("\n");
			Console.WriteLine("\n");
		}
		//_______________Function for a HEADER
		public static void HEADER()
		{

			Console.Clear();
			Console.Write("\n");
			Console.Write("\n");

			Console.Write("                                          dP                        " + "                                                                    " + "                                         dP   ");
			Console.Write("\n");
			Console.Write("                                          88                        " + "                                                                    " + "                                         88   ");
			Console.Write("\n");
			Console.Write("    dP  dP  dP .d8888b. 88d888b. .d8888b. 88d888b. .d8888b. dP    " + "dP .d8888b. .d8888b.    88d8b.d8b. .d8888b. 88d888b. .d8888b. " + ".d8888b. .d8888b. 88d8b.d8b. .d8888b. 88d888b. d8888P ");
			Console.Write("\n");
			Console.Write("    88  88  88 88'  `88 88'  `88 88ooood8 88'  `88 88'  `88 88    " + "88 Y8ooooo. 88ooood8    88'`88'`88 88'  `88 88'  `88 88'  `88 88'  " + "`88 88ooood8 88'`88'`88 88ooood8 88'  `88   88   ");
			Console.Write("\n");
			Console.Write("    88.88b.88' 88.  .88 88       88.  ... 88    88 88.  .88 88.  " + ".88       88 88.  ...    88  88  88 88.  .88 88    88 88.  .88 88.  " + ".88 88.  ... 88  88  88 88.  ... 88    88   88   ");
			Console.Write("\n");
			Console.Write("    8888P Y8P  `88888P8 dP       `88888P' dP    dP `88888P' " + "`88888P' `88888P' `88888P'    dP  dP  dP `88888P8 dP    dP `88888P8 " + "`8888P88 `88888P' dP  dP  dP `88888P' dP    dP   dP   ");
			Console.Write("\n");
			Console.Write("                                                                    " + "                                                                 " + ".88                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "                                                             d8888P " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "                               dP                                   " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "                               88                                   " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "  .d8888b. dP    dP .d8888b. d8888P .d8888b. 88d8b.d8b.             " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "  Y8ooooo. 88    88 Y8ooooo.   88   88ooood8 88'`88'`88             " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "        88 88.  .88       88   88   88.  ... 88  88  88             " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "  `88888P' `8888P88 `88888P'   dP   `88888P' dP  dP  dP             " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "                .88                                                 " + "                                              ");
			Console.Write("\n");
			Console.Write("                                                                    " + "            d8888P                                                  " + "                                              ");
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("____________________________________________________________________" + "____________________________________________________________________" + "_____________________________________________________");
			Console.Write("\n");
		}
		//public static void loadFromProductFile(string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price)
		//{
		//	fstream file = new fstream();

		//	file.open("product.txt", ios.@in);
		//	string product = "";
		//	while (!file.eof())
		//	{
		//		getline(file, product);
		//		if (product[0] != ',' && product[0] != '\0')
		//		{
		//			productName[count_product] = parse_data(product, 1);
		//			productNo[count_product] = parse_data(product, 2);
		//			product_time[count_product] = parse_data(product, 3);
		//			string time = parse_data(product, 4);
		//			dayNight[count_product] = time[0];
		//			product_ind[count_product] = str_to_i(parse_data(product, 5));
		//			industrial_price[count_product] = str_to_i(parse_data(product, 6));
		//			product_house[count_product] = str_to_i(parse_data(product, 7));
		//			household_price[count_product] = str_to_i(parse_data(product, 8));
		//			count_product++;
		//		}
		//		else
		//		{
		//			continue;
		//		}
		//	}
		//	file.close();
		//	Console.Write(count_product);
		//	Console.ReadKey(true);
		//}
		//______________________FUNCTION FOR CLEAR SCREEN__________________________

		public static void clearscreen()
		{
			Console.Write("Press Any key to continue ");
			Console.ReadKey(true);
			Console.Clear();
		}
		//_______FUNCTION For PARSING DATA

		public static string parse_data(string word, int field)
		{
			int comma = 1;
			string item = "";
			for (int i = 0; word[i] != '\0'; i++)
			{
				if (word[i] == ',')
				{
					comma++;
				}
				else if (comma == field)
				{
					item = item + word[i];
				}
			}
			return item;
		}

		//___________________________Function for Password VALIDATION________________

		public static bool password_validation(string pass)
		{

			bool t = true;
			int passer = 0;
			for (int i = 0; i < pass.Length; i++)
			{
				passer++;
				int y = Convert.ToInt32(pass[i]);
				if (y >= 48 && y <= 57)
				{
					t = false;
				}
			}
			if (t == false && passer >= 8)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		//___________________________Function for Username VALIDATION________________

		public static bool username_validation(string name)
		{
			bool a = true;
			for (int i = 0; i< name.Length; i++)
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

		public static bool email_validation(string email)
		{
			for (int i = 0; i< email.Length; i++)
			{
				if (email[i] == '@')
				{
					return true;
				
				}
			}
			return false;
		}

		////--------------------File Handling Functions---------------------------
		//public static void store_data(int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN, string[] complainer, string[] suggest, string[] admin_name, string[] admin_pass, string[] admin_email)
		//{
		//	fstream file = new fstream();
		//	file.open("admin.txt", ios.@out);
		//	for (int i = 0; i < admin_count; i++)
		//	{
		//		if (i != 0)
		//		{
		//			file << "\n";
		//		}
		//		file << admin_name[i];
		//		file << ',';
		//		file << admin_pass[i];
		//		file << ',';
		//		file << admin_email[i];
		//		if (i != admin_count - 2)
		//		{
		//			file << "\n";
		//		}
		//	}

		//	file.close();

		//	file.open("approve.txt", ios.@out);
		//	for (int i = 0; i < app; i++)
		//	{
		//		file << approved_N[i];
		//		file << "\n";
		//	}
		//	file.close();

		//	file.open("faqs.txt", ios.@out);
		//	for (int i = 0; i < faq_counter; i++)
		//	{
		//		file << questions[i];
		//		file << "\n";
		//		file << answers[i];
		//		file << "\n";
		//	}
		//	file.close();

		//	file.open("suggestion.txt", ios.@out);
		//	for (int i = 0; i < suggest_counter; i++)
		//	{
		//		file << complainer[i];
		//		file << "\n";
		//		file << suggest[i];
		//		if (i != suggest_counter - 1)
		//		{
		//			file << "\n";
		//		}
		//	}
		//	file.close();

		//	file.open("storage.txt", ios.@out);
		//	for (int i = 0; i < store; i++)
		//	{
		//		if (i != 0)
		//		{
		//			file << "\n";
		//		}
		//		file << UserN[i];
		//		file << ',';
		//		file << pnaam[i];
		//		file << ',';
		//		file << buy_product[i];
		//		file << ',';
		//		file << date[i];
		//		file << ',';
		//		file << month[i];
		//		file << ',';
		//		file << no_industrial[i];
		//		file << ',';
		//		file << no_household[i];
		//		if (i != store - 1)
		//		{
		//			file << "\n";
		//		}
		//	}
		//	file.close();
		//}

		//public static void load_data(int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN, string[] complainer, string[] suggest, string[] admin_name, string[] admin_pass, string[] admin_email)
		//{
		//	fstream file = new fstream();
		//	string word = "";
		//	file.open("admin.txt", ios.@in);
		//	while (!file.eof())
		//	{
		//		getline(file, word);
		//		if (word[0] != ',' && word[0] == '\0')
		//		{
		//			admin_name[admin_count] = parse_data(word, 1);
		//			admin_pass[admin_count] = parse_data(word, 2);
		//			admin_email[admin_count] = parse_data(word, 3);
		//			admin_count++;
		//		}
		//		else
		//		{
		//			continue;
		//		}
		//	}
		//	admin_count--;
		//	Console.Write(admin_count);
		//	Console.ReadKey(true);
		//	file.close();

		//	file.open("approve.txt", ios.@in);
		//	string letter = "";
		//	while (!file.eof())
		//	{
		//		getline(file, letter);
		//		approved_N[app] = letter;
		//		app++;
		//	}

		//	file.open("suggestion.txt", ios.@in);
		//	string suggesty = "";
		//	while (!file.eof())
		//	{
		//		getline(file, suggesty);
		//		complainer[suggest_counter] = suggesty;
		//		getline(file, suggesty);
		//		suggest[suggest_counter] = suggesty;
		//		suggest_counter++;
		//	}
		//	file.close();

		//	file.open("storage.txt", ios.@in);
		//	string place = "";
		//	while (!file.eof())
		//	{
		//		getline(file, place);
		//		if (place[0] != ',' && place[0] != '0')
		//		{
		//			UserN[store] = parse_data(place, 1);
		//			pnaam[store] = parse_data(place, 2);
		//			buy_product[store] = parse_data(place, 3);
		//			date[store] = str_to_i(parse_data(place, 4));
		//			month[store] = parse_data(place, 5);
		//			no_industrial[store] = str_to_i(parse_data(place, 6));
		//			no_household[store] = str_to_i(parse_data(place, 7));
		//			store++;
		//		}
		//	}
		//	file.close();
		//	store--;
		//	Console.Write(store);
		//	Console.ReadKey(true);
		//}

		//// FUNCTION TO STORE DATA IN FILE
		//public static void storeNewUserRecordIntoFile(string usernameNew, string passwordNew, string firstnameNew, string lastnameNew, string emailNew, long cnicNew, int ageNew, string genderNew, string cityNew, string contactNew)
		//{
		//	fstream file = new fstream();
		//	int i = 0;
		//	file.open("user.txt", ios.@out);
		//	for (i = 0; i < usercount; i++)
		//	{
		//		if (i != 0)
		//		{
		//			file << "\n";
		//		}
		//		file << usernameNew[i];
		//		file << ',';
		//		file << firstnameNew[i];
		//		file << ',';
		//		file << lastnameNew[i];
		//		file << ',';
		//		file << emailNew[i];
		//		file << ',';
		//		file << (int)cnicNew["i"];
		//		file << ',';
		//		file << passwordNew[i];
		//		file << ',';
		//		file << contactNew[i];
		//		if (i != usercount - 2)
		//		{
		//			file << "\n";
		//		}
		//	}
		//	file.close();
		//}

		//// FUNCTION TO LOAD DATA FROM FILE
		//public static void loadUserRecordFromFile(string[] username, string[] firstname, string[] lastname, string[] email, long[] CNIC, string[] password, string[] contact)
		//{
		//	fstream file = new fstream();
		//	string alphabet = "";
		//	file.open("user.txt", ios.@in);
		//	while (!file.eof())
		//	{
		//		getline(file, alphabet);
		//		if (alphabet[0] != ',' && alphabet[0] != ' ')
		//		{
		//			username[usercount] = parse_data(alphabet, 1);
		//			firstname[usercount] = parse_data(alphabet, 2);
		//			lastname[usercount] = parse_data(alphabet, 3);
		//			email[usercount] = parse_data(alphabet, 4);
		//			CNIC[usercount] = str_to_l(parse_data(alphabet, 5));
		//			password[usercount] = parse_data(alphabet, 6);
		//			contact[usercount] = parse_data(alphabet, 7);
		//			usercount = usercount + 1;
		//		}
		//		else
		//		{
		//			continue;
		//		}
		//	}
		//	file.close();
		//	Console.Write(usercount);
		//	Console.ReadKey(true);
		//}

		//public static void storeProductRecordIntoFile(string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price)
		//{
		//	fstream file = new fstream();
		//	file.open("product.txt", ios.@out);
		//	for (int i = 0; i < count_product; i++)
		//	{
		//		if (i != 0)
		//		{
		//			file << "\n";
		//		}
		//		file << productName[i];
		//		file << ',';
		//		file << productNo[i];
		//		file << ',';
		//		file << product_time[i];
		//		file << ',';
		//		file << dayNight[i];
		//		file << ',';
		//		file << product_ind[i];
		//		file << ',';
		//		file << industrial_price[i];
		//		file << ',';
		//		file << product_house[i];
		//		file << ',';
		//		file << household_price[i];
		//		if (i != count_product - 1)
		//		{
		//			file << "\n";
		//		}
		//	}
		//	file.close();
		//}

	}
}
