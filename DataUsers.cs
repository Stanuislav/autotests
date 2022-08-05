using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdressbokTests
{
    internal class DataUsers
    {

        private string fistname;
        private string middlename;
        private string lastname;

        public DataUsers(string fistname, string middlename)
        {
            this.fistname = fistname;
            this.middlename = middlename;
        }
        public string Fistname
        {
            get { return fistname; }
            set { fistname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set {lastname = value; }
        }

    }
}
