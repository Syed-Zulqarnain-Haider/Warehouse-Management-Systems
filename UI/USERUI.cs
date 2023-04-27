using System;
using System.Collections.Generic;
using System.Text;
using Manage.DL;
using Manage.BL;
namespace Manage.UI
{
	class USERUI
	{
		public static void SHOW_BILL(double bill)
        {
			Console.Write("*************************************************************************************************");
			Console.Write("_________________________________________________________________________________________________");
			Console.Write("\n");
			Console.Write("YOUR TOTAL BILL IS ");
			Console.WriteLine(bill);
			Console.WriteLine("CHECKOUT FROM OPTION 7 ");

		}

		public static void VIEW_USER_DETAILS()
        {
			if (USERDL.USER_DETAILS.Count == 0)
			{
				Console.WriteLine("No User found . Therefore, No User Details");
			}
			else if (USERDL.USER_DETAILS.Count != 0)
			{
				Console.WriteLine("|UserName\t\t|Name\t\t\t|NIC\t\t|Contact\t\t|PRODUCT Name\t\t|No. of products(F/S) \t\t |Product price");

				foreach (USERBL A in USERDL.USER_DETAILS)
				{
					Console.WriteLine("|" + A.username + "\t\t" + "|" + A.firstname + "\t\t" + "|" + A.NIC + "\t\t" + "|" + A.contact);//+"\t\t"< "|" + m[j] +"\t\t"+ "|" + no_industrial[i] "|"+"\t\t" + << buy_product[i]);	
				}
			}
		}
		public static USERBL USER_LOGIN()
        {
			string username;
			string password;
			Console.WriteLine("ENTER USERNAME: ");
			username=Console.ReadLine();
			Console.WriteLine("ENTER PASSWORD: ");
			password = Console.ReadLine();
			USERBL S = new USERBL(username, password);
			return S;

		}
		public static USERBL USER_REGISTER()
        {
				string username;
				Console.WriteLine("ENTER USERNAME (ALI1): ");
				username=Console.ReadLine();
			while (!MISCUI.username_validation(username))
			{
				Console.WriteLine("Must Contain Numbers: ");
				username = Console.ReadLine();
			}
			string firstname;
				string lastname;
				string email;
				Console.WriteLine ("FIRST NAME: ");
					firstname = Console.ReadLine();
				Console.WriteLine ("LAST NAME: ");
					lastname = Console.ReadLine();
				Console.WriteLine ("E-MAIL: ");
				 email = Console.ReadLine();
			while (!MISCUI.email_validation(email))
			{
				Console.WriteLine("Email Should Contain @ character: ");
				email = Console.ReadLine();
			}
			Console.WriteLine ("ENTER CNIC (no dashes): ");
				long NIC;
				NIC =long.Parse(Console.ReadLine());
				while (true)
				{
					int counter = 0;
					for (long i = NIC; i != 0; i = i / 10)
					{
						counter++;
					}
					if (counter == 13)
					{
						break;
					}
					else
					{
						Console.WriteLine ("Invalid CNIC");
						Console.WriteLine ("ENTER CNIC (no dashes): ");
						NIC = int.Parse(Console.ReadLine());
					}
				}
				Console.WriteLine ("Password: ");
				string pass;
				pass = Console.ReadLine();
				while (!MISCUI.password_validation(pass))
				{
					Console.WriteLine ("Password at least 8 char containing numbers: ");
					pass = Console.ReadLine();
				}
				Console.WriteLine ("AGE: ");
				int age;
				age = int.Parse(Console.ReadLine());
				while (age <= 0)
				{
					Console.WriteLine ("INVALID AGE" );
					Console.WriteLine ("ENTER AGE : ");
					age = int.Parse(Console.ReadLine());				
				}

				Console.WriteLine ("ENTER GENDER: ");
				string gender;
				gender = Console.ReadLine();
				Console.WriteLine ("ENTER CITY: ");
				string city;
				city = Console.ReadLine();
				Console.WriteLine ("ENTER YOUR CONTACT: ");
				long contact;
				contact = long.Parse(Console.ReadLine());
		    	while (true)
	    		{
				int count = 0;
				for (long i = contact; i != 0; i = i / 10)
				{
					count++;
				}
				if (count == 11)
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid Contact");
					Console.WriteLine("ENTER Contact (no dashes): ");
					contact = int.Parse(Console.ReadLine());
				}
		    	}
    			USERBL S = new USERBL(username, firstname, lastname, email, NIC, pass, age, gender, city, contact);
				return S;
		}
		public static string USER_MENU()
		{
			Console.WriteLine("Choose one of the following options");
			Console.WriteLine("	[1].	View Product Details");
			Console.WriteLine("	[2].	Buy Products");
			Console.WriteLine("	[3].	Modify the Order");
			Console.WriteLine("	[4].	See Total Bill");
			Console.WriteLine("	[5].	Cancel Order");
			Console.WriteLine("	[6].	Suggestions/Complains");
			Console.WriteLine("	[7].	Checkout");
			Console.WriteLine("	[8].	FAQS");
			Console.WriteLine("	[9].	LOGOUT");
			Console.WriteLine("YOUR OPTION:..");
			string option =Console.ReadLine();
			Console.Clear();

			return option;
		}
		public static void VIEW_BOUGHT_PRODUCT()
		{
			Console.WriteLine("IDENTIFICATION MODE > USER MODE > USER > VIEW BOUGHT PRODUCTS");
			Console.WriteLine("   |PRODUCT NO. " + "|PRODUCT NAME   " + "|CATEGORY       " + "|PROD QUANTITY. " + "|PRODUCT PRICE.");

			if (PRODUCTBL.BOUGHT_PRODUCTS.Count != 0)
			{
				foreach (PRODUCTBL s in PRODUCTBL.BOUGHT_PRODUCTS)
				{

					Console.WriteLine("   |" + s.GET_PROD_NO() + "\t\t|" + s.GET_PROD_NAME() + " \t\t|" + s.GET_PROD_CATEGORY() + "  \t\t|" + s.GET_PROD_QUANTITY() + " \t\t|" + s.GET_PROD_PRICE());
				}
			}

			else
			{
				Console.WriteLine("DATA DOES NOT EXIST");
			}
		}
		//_________________________function for user mode____________________________
		public static string USER_MODE()
		{
			Console.WriteLine("IDENTITY MODE > ADMIN MODE ");
			Console.WriteLine("_____________");
			Console.WriteLine("Choose One of the Following Option Number ");
			Console.WriteLine("   1.  Register ");
			Console.WriteLine("   2.  Login");
			Console.WriteLine("   3.  Return");
			Console.WriteLine("CHOOSE OPTION:  ");
			string option;
			option = Console.ReadLine();
			return option;
		}
		public static string MODIFY_BOUGHT_PRODUCT()
		{

			Console.WriteLine("IDENTIFICATION MODE > USER MODE > USER > MODIFY BOUGHT PRODUCT ");
			Console.WriteLine("_____________");
			Console.WriteLine("Enter The Product Name You Want To (MODIFY) Details ");
			string name;
			name = Console.ReadLine();
			return name;
		}
		public static string USER_BUY_PRODUCT()
		{//add karna hai user name ______________________________$$$$$$$$$$$$$$
			Console.WriteLine("IDENTIFICATION MODE > User Mode > //___Uname > Modify Order ");
			Console.WriteLine("ENTER THE PRODUCT NAME YOU WANT TO BUY ");
			string BUY_PRODUCT = Console.ReadLine();
			return BUY_PRODUCT;
		}
		public static string USER_CANCEL_PRODUCT()
		{//add karna hai user name ______________________________$$$$$$$$$$$$$$
			Console.WriteLine("IDENTIFICATION MODE > USER MODE > //___Uname > CANCEL ORDER ");
			Console.WriteLine("ENTER THE PRODUCT NAME YOU WANT TO CANCEL ORDER ");
			string BUY_PRODUCT = Console.ReadLine();
			return BUY_PRODUCT;
		}
		public static bool RETURN_CHOICE()
        {
			Console.WriteLine("DO YOU WANT TO CANCEL ORDER (Y/y) OR (N/n)");
			char a = char.Parse(Console.ReadLine());
			if (a == 'y' || a == 'Y')
			{
				return true;

			}

			return false;
		}
		public static int QUANTITY()
		{
				Console.WriteLine("ENTER THE PRODUCT QUANTITY YOU WANT TO BUY");
				int a;
				a = int.Parse(Console.ReadLine());
			return a;
		}	
		//______________user can add complain which admin can see later on_____________
		public static USERBL ADD_COMPLAINT()
        {// __________________________________USERNAME INCLUDE KARNA HAI______________
			Console.WriteLine("IDENTIFICATION MODE > USER MODE > USER > ADD COMPLAINT ");
			Console.WriteLine("ENTER THE COMPLAINT INDEX (1,2...) ");
			int NUM = int.Parse(Console.ReadLine());
			Console.WriteLine("ENTER YOUR COMPLAINTS ");

			string COMPLAIN_S = Console.ReadLine();
			USERBL S = new USERBL(COMPLAIN_S,NUM);
			return S;
		}
		//__________________________Function for USER MENU__________________________
		//_________________________function for user mode____________________________
		
		////___________________Function to Register User_______________

		//public static void user_reg(string[] username, string[] firstname, string[] lastname, string[] email, long[] CNIC, string[] password, string[] contact, string[] gender, string[] city, int[] age)
		//{
		//	string usernameNew = "";
		//	string passwordNew = "";
		//	string firstnameNew = "";
		//	string lastnameNew = "";
		//	string emailNew = "";
		//	long cnicNew;
		//	int ageNew;
		//	string genderNew = "";
		//	string cityNew = "";
		//	string contactNew = "";

		//	Console.Write("USERNAME: ");
		//	usernameNew = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!username_validation(usernameNew))
		//	{
		//		Console.Write("Must Contain Numbers: ");
		//		usernameNew = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	Console.Write("FIRST NAME: ");
		//	firstnameNew = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("LAST NAME: ");
		//	lastnameNew = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("E-MAIL: ");
		//	emailNew = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!email_validation(emailNew))
		//	{
		//		Console.Write("Email Should Contain @ character: ");
		//		emailNew = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	Console.Write("ENTER CNIC (no dashes): ");
		//	cnicNew = long.Parse(ConsoleInput.ReadToWhiteSpace(true));
		//	while (true)
		//	{
		//		int counter = 0;
		//		for (long i = cnicNew; i != 0; i = i / 10)
		//		{
		//			counter++;
		//		}
		//		if (counter == 13)
		//		{
		//			break;
		//		}
		//		else
		//		{
		//			Console.Write("Invalid CNIC");
		//			Console.Write("\n");
		//			Console.Write("ENTERr CNIC: ");
		//			cnicNew = long.Parse(ConsoleInput.ReadToWhiteSpace(true));
		//		}
		//	}
		//	Console.Write("Password: ");
		//	passwordNew = ConsoleInput.ReadToWhiteSpace(true);
		//	while (!password_validation(passwordNew))
		//	{
		//		Console.Write("Password at least 8 char containing numbers: ");
		//		passwordNew = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//	Console.Write("Age: ");
		//	ageNew = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		//	while (ageNew <= 0)
		//	{
		//		Console.Write("Invalid Age");
		//		Console.Write("\n");
		//		Console.Write("Age: ");
		//		ageNew = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		//	}
		//	Console.Write("Gender: ");
		//	genderNew = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("City: ");
		//	cityNew = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("Contact: ");
		//	contactNew = ConsoleInput.ReadToWhiteSpace(true);
		//	// Add new user record in arrays
		//	username[usercount] = usernameNew;
		//	password[usercount] = passwordNew;
		//	firstname[usercount] = firstnameNew;
		//	lastname[usercount] = lastnameNew;
		//	email[usercount] = emailNew;
		//	CNIC[usercount] = cnicNew;
		//	contact[usercount] = contactNew;
		//	gender[usercount] = genderNew;
		//	city[usercount] = cityNew;
		//	age[usercount] = ageNew;

		//	approved_N[app] = usernameNew;
		//	usercount++;
		//	app++;
		//	// store new User record into file
		//	storeNewUserRecordIntoFile(usernameNew, passwordNew, firstnameNew, lastnameNew, emailNew, cnicNew, ageNew, genderNew, cityNew, contactNew);
		//}
	

		//__________________Function for user validation_______________________

		//									 				______________USER MODE____________
		//// OPTION 02
		//public static bool VALID_USER(string name, string pass_word, string[] username, string[] password)
		//{
		//	bool flag = false;
		//	for (int i = 0; i < usercount; i++)
		//	{
		//		if (name == username[i] && pass_word == password[i])
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


		////_____________________function for user login_______________
		//public static void USERLOGIN(string[] username, string[] password)
		//{

		//	string password1 = "";
		//	Console.Write("       ENTER USERNAME: ");
		//	Uname = ConsoleInput.ReadToWhiteSpace(true);
		//	Console.Write("       ENTER PASSWORD: ");
		//	password1 = ConsoleInput.ReadToWhiteSpace(true);

		//	while (!(valid_user(Uname, password1, username, password)))
		//	{
		//		header();
		//		Console.Write("IDENTIFICATION MODE > ADMIN MODE > LOGIN");
		//		Console.Write("\n");
		//		Console.Write("_____________");
		//		Console.Write("\n");
		//		Console.Write("Wrong Credentials TYPE AGAIN");
		//		Console.Write("\n");
		//		Console.Write("       ENTER USERNAME: ");
		//		Uname = ConsoleInput.ReadToWhiteSpace(true);
		//		Console.Write("       ENTER PASSWORD: ");
		//		password1 = ConsoleInput.ReadToWhiteSpace(true);
		//	}
		//}

		//											______________________USER
		// MENU__________________________
		// OPTION 01
		
		//____FUNCTION TO VIEW SORTED FCLASS FARE

//		public static void sort_industrial(string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price)
//		{
//			int min = 0;
//			for (int i = 0; i < count_product - 1; i++)
//			{
//				for (int j = i + 1; j < count_product; j++)
//				{
//					if (industrial_price[i] < industrial_price[j])
//					{
//						int temp = household_price[i];
//						household_price[i] = household_price[j];
//						household_price[j] = temp;

//						int temp0 = industrial_price[i];
//						industrial_price[i] = industrial_price[j];
//						industrial_price[j] = temp0;

//						string temp1 = productName[i];
//						productName[i] = productName[j];
//						productName[j] = temp1;

//						string temp2 = productNo[i];
//						productNo[i] = productNo[j];
//						productNo[j] = temp2;

//						string temp5 = product_time[i];
//						product_time[i] = product_time[j];
//						product_time[j] = temp5;

//						int temp6 = product_house[i];
//						product_house[i] = product_house[j];
//						product_house[j] = temp6;

//						int temp7 = product_ind[i];
//						product_ind[i] = product_ind[j];
//						product_ind[j] = temp7;

//						char temp8 = dayNight[i];
//						dayNight[i] = dayNight[j];
//						dayNight[j] = temp8;
//					}
//				}
//			}
//			Console.Write("|Product No.");
//			Console.Write("\t\t");
//			Console.Write("|Product Name");
//			Console.Write("\t");
//			Console.Write("|Recieving Time");
//			Console.Write("\t");
//			Console.Write("|Industrial price");
//			Console.Write("\t\t");
//			Console.Write("|Household price");
//			Console.Write("\n");
//			Console.Write("\n");
//			for (int i = 0; i < count_product; i++)
//			{
//				Console.Write("|");
//				Console.Write(productNo[i]);
//				Console.Write("\t\t");
//				Console.Write("|");
//				Console.Write(productName[i]);
//				Console.Write("\t\t");
//				Console.Write("|");
//				Console.Write(product_time[i]);
//				Console.Write("\t\t");
//				Console.Write("|");
//				Console.Write(industrial_price[i]);
//				Console.Write("\t\t");
//				Console.Write("|");
//				Console.Write(household_price[i]);
//				Console.Write("\n");
//			}
//		}

//		// OPTION 02
//		//____FUNCTION TO SEE AVAILABLE PRODUCTS
//		public static void AVAILABLE_PRODUCTS(char scene, string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price)
//		{
//			bool a = false;
//			if (count_product == 0)
//			{
//				Console.Write("There is no product to show");
//			}
//			else
//			{
//				Console.Write("|Product No.");
//				Console.Write("\t");
//				Console.Write("|Product Name");
//				Console.Write("\t");
//				Console.Write("|Storage Time");
//				Console.Write("\t");
//				Console.Write("|Industrial price");
//				Console.Write("\t");
//				Console.Write("|Household price");
//				Console.Write("\n");
//				Console.Write("\n");
//				for (int i = 0; i < count_product; i++)
//				{
//					if (dayNight[i] == scene)
//					{
//						a = true;
//						Console.Write("|");
//						Console.Write(productNo[i]);
//						Console.Write("\t\t");
//						Console.Write("|");
//						Console.Write(productName[i]);
//						Console.Write("|");
//						Console.Write(product_time[i]);
//						Console.Write("\t");
//						Console.Write("|");
//						Console.Write(industrial_price[i]);
//						Console.Write("\t");
//						Console.Write("|");
//						Console.Write(industrial_price[i]);
//						Console.Write("\n");
//					}
//				}
//			}
//			if (a == false)
//			{
//				Console.Write("There is no Product available yet to show");
//			}
//			Console.Write("\n");
//		}

//		// OPTION 03
//		public static void store_in_arrays(int date_r, string month_r, string pnaam_r, int no_industrial_r, int no_household_r, string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price, int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN)
//		{
//			date[store] = date_r;
//			month[store] = month_r;
//			pnaam[store] = pnaam_r;
//			no_industrial[store] = no_industrial_r;
//			no_household[store] = no_household_r;
//			buy_product[store] = products[store];
//			UserN[store] = Uname;
//			store++;

//			for (int i = 0; i < store; i++)
//			{
//				for (int j = 0; j < count_product; j++)
//				{
//					if (productName[j] == pnaam[i])
//					{
//						Console.Write("Total Industrial Products: ");
//						Console.Write(no_industrial[i] * industrial_price[j]);
//						Console.Write("\n");
//						Console.Write("Total Household Product: ");
//						Console.Write(no_household[i] * household_price[j]);
//						Console.Write("\n");
//						payable = (no_industrial[i] * industrial_price[j]) + (no_household[i] * household_price[j]);
//					}
//				}
//			}
//		}

//		//_____FUNCTION FOR RESERVING A TICKET


//		public static void PLACE_ORDER(string[] productName, string[] productNo, string[] product_time, string dayNight, int[] product_ind, int[] product_house, int[] industrial_price, int[] household_price, int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN)
//		{
//			bool check = false;
//			for (int i = 0; i < store; i++)
//			{
//				if (Uname == UserN[i])
//				{
//					check = true;
//				}
//			}
//			if (check == true)
//			{
//				Console.Write("You have already Stored. To Modify go to Next Option");
//				Console.Write("\n");
//			}
//			else
//			{
//				int date1;
//				string month1 = "";
//				string pnaam1 = "";
//				Console.Write("Enter Product Name: ");
//				pnaam1 = ConsoleInput.ReadToWhiteSpace(true);
//				bool t = false;
//				for (int i = 0; i < count_product; i++)
//				{
//					if (pnaam1 == productName[i])
//					{
//						t = true;
//						break;
//					}
//				}
//				while (!t)
//				{
//					Console.Write("There is no such Product availables: ");
//					pnaam1 = ConsoleInput.ReadToWhiteSpace(true);
//					for (int i = 0; i < count_product; i++)
//					{
//						if (pnaam1 == productName[i])
//						{
//							t = true;
//							break;
//						}
//					}
//				}
//				Console.Write("Enter Date of Product ordering: ");
//				date1 = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//				Console.Write("Enter Month of ordering: ");
//				month1 = ConsoleInput.ReadToWhiteSpace(true);
//				Console.Write("Enter No.of Industrial products want to buy: ");
//				int N_indus;
//				N_indus = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//				Console.Write("Enter No. of Household products want to buy: ");
//				int N_house;
//				N_house = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//				Console.Write("You Have Successfully placed your Order.");
//				Console.Write("\n");
//				Console.Write("To SEE your Order Detail Go to Next Option:");
//				Console.Write("\n");
//				store_in_arrays(date1, month1, pnaam1, N_indus, N_house, productName, productNo, product_time, dayNight, product_ind, product_house, industrial_price, household_price, date, month, pnaam, no_industrial, no_household, buy_product, products, UserN);
//			}
//		}
//		// OPTION 04
//		//__________________Function for see Reservation details_____
//		public static int INDEX_RETURNER(string[] username)
//		{
//			for (int i = 0; i < usercount; i++)
//			{
//				if (Uname == username[i])
//				{
//					return i;
//				}
//			}
//			return 0;
//		}

//		public static int payable;
//		public static void ADD_TO_CART(int idx, string[] username, string[] firstname, string[] lastname, long[] CNIC, string[] contact, string[] productName, int[] industrial_price, int[] household_price, int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN)
//		{
//			Console.Write("|UserName\t\t|Name\t\t|NIC\t\t|Contact\t\t|Product " + "Number\t\t|Industrial prod.\t\t|Household prod.");
//			Console.Write("\n");

//			for (int i = 0; i < store; i++)
//			{
//				if (UserN[i] == Uname)
//				{
//					Console.Write("|");
//					Console.Write(username[idx]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(firstname[idx]);
//					Console.Write(" ");
//					Console.Write(lastname[idx]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(CNIC[idx]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(contact[idx]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(buy_product[i]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(no_industrial[i]);
//					Console.Write("\t\t");
//					Console.Write("|");
//					Console.Write(no_household[i]);
//					Console.Write("\n");
//				}
//			}
//			for (int i = 0; i < store; i++)
//			{
//				for (int j = 0; j < count_product; j++)
//				{
//					if (productName[j] == pnaam[i])
//					{
//						Console.Write("\n");
//						Console.Write("Total Industrial product price: ");
//						Console.Write(no_industrial[i] * industrial_price[j]);
//						Console.Write("\n");
//						Console.Write("Total Household product price: ");
//						Console.Write(no_household[i] * household_price[j]);
//						Console.Write("\n");
//						Console.Write("Total price = ");
//						Console.Write(payable);
//						Console.Write("\n");
//					}
//				}
//			}
//		}
//		// OPTION 05
//		//______FUNCTION TO MODIFY RESERVATION
//		public static void MODIFY_ORDER(int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN)
//			{

//				for (int i = 0; i < store; i++)
//				{
//					if (UserN[i] == Uname)
//					{
//						Console.Write("Enter Product Name: ");
//						pnaam[i] = ConsoleInput.ReadToWhiteSpace(true);
//						Console.Write("Enter Date of Buying product: ");
//						date[i] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//						Console.Write("Enter Month of buying: ");
//						month[i] = ConsoleInput.ReadToWhiteSpace(true);
//						Console.Write("Enter No. of Industrial product want to buy: ");
//						no_industrial[i] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//						Console.Write("Enter No. of Household product want to buy: ");
//						no_household[i] = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//					}
//				}
//			}

//		// OPTION 06
//		//______FUNCTION TO CANCEL RESERVATION
//		public static void CANCEL_ORDER(int[] date, string[] month, string[] pnaam, int[] no_industrial, int[] no_household, string[] buy_product, string[] products, string[] UserN)
//		{
//			for (int i = 0; i < store; i++)
//			{
//				if (UserN[i] == Uname)
//				{
//					for (int j = 1; j < store - 1; j++)
//					{
//						pnaam[i] = pnaam[i + 1];
//						date[i] = date[i + 1];
//						month[i] = month[i + 1];
//						no_industrial[i] = no_industrial[i + 1];
//						no_household[i] = no_household[i + 1];
//						UserN[i] = UserN[i + 1];
//						buy_product[i] = buy_product[i + 1];
//					}
//					store--;
//					break;
//				}
//			}
//			payable = 0;
//			Console.Write("Cancelled");
//			Console.Write("\n");
//		}

//		// OPTION 08
//		//_______________FUNCTION FOR PAYMENT _________
//		public static void payment()
//		{
//			if (payable == 0)
//			{
//				Console.Write("You Have not yet store ");
//				Console.Write("\n");
//				Console.Write("Reserve Your Seats & then come back");
//			}
//			else
//			{
//				Console.Write("Enter Payment Method(cash/card): ");
//				string method = "";
//				method = ConsoleInput.ReadToWhiteSpace(true);

//				if (method == "card")
//				{
//					Console.Write("Successfully Paid");
//				}
//				if (method == "cash")
//				{
//					Console.Write("\n");
//					Console.Write("Amount You Paid: ");
//					int paid;
//					paid = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
//					Console.Write("\n");
//					Console.Write("Balance: ");
//					Console.Write(payable - paid);
//					Console.Write("\n");
//					Console.Write("Succesfully Done");
//					Console.Write("\n");
//				}
//			}
//		}
	}
}
