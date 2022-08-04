using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAdressbokTests
{
    internal class GroupDate
    {
        private string name;
        private string header;
        private string footer;


        public GroupDate(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Header
        {
            get { return this.header; }
            set { this.header = value; }
        }
        public string Footer
        {
            get { return this.footer; }
            set { this.footer = value; }
        }

    }
}
