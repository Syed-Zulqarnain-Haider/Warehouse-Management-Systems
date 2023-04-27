using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Manage.UI;
using Manage.BL;
namespace Manage.DL
{
    class ADMINDL
    {
        public static List<ADMINBL> FAQ = new List<ADMINBL>();
        public static List<ADMINBL> ADMIN_DETAILS = new List<ADMINBL>();

        public static bool ADMIN_SEARCH(ADMINBL C)
        {
            if (ADMIN_DETAILS.Count != 0)
            {
            foreach(ADMINBL A in ADMIN_DETAILS)
            {
                if (A.USERNAME == C.USERNAME && A.PASSWORD == C.PASSWORD && A.EMAIL == C.EMAIL)
                {
                    return true;
                }
            }
            }
            return false;
        }
        public static void ADD_INTO_LIST(ADMINBL S)
        {

            ADMIN_DETAILS.Add(S);
        }

        
        public static void ADD_FAQ_TO_LIST(ADMINBL s)
        {
            FAQ.Add(s);
        }
            //THE USER ENTERED QUESTION IS IN FUNCTION PARAMETER WHICH IS BEING USED TO DELETE THAT SPECIFIC FAQ.
        public static void DELETE_FAQS(string QUES)
        {
            for (int i = 0; i < FAQ.Count; i++)
            {
                if (FAQ[i].QUESTIONS == QUES)
                {

                    FAQ.RemoveAt(i);

                }
            }

        }

    }
}
