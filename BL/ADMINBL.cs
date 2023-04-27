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
using Manage.UI;
namespace Manage.BL
{
    class ADMINBL
    {
        public string QUESTIONS;
        public string ANSWERS;
        public string USERNAME;
        public string PASSWORD;
        public string EMAIL;
        public ADMINBL(string USERNAME,string PASSWORD,string EMAIL)
        {
            this.USERNAME = USERNAME;
            this.PASSWORD = PASSWORD;
            this.EMAIL = EMAIL;
        }

        public ADMINBL(string QUEST,string ANS)
        {
            this.QUESTIONS = QUEST;
            this.ANSWERS = ANS;
        }
       
        public string GET_USERNAME()
        {
            return USERNAME;
        }
        public string GET_PASSWORD()
        {
            return PASSWORD;
        }
        public string GET_EMAIL()
        {
            return EMAIL;
        }
        public String GET_QUESTION()
        {
            return QUESTIONS;
        }
        public String GET_ANSWER()
        {
            return ANSWERS;
        }
    }
}
