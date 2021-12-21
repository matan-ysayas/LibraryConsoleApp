using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    internal class Book
    {
      public  string name;
       public string autothor;
       public int numOfPages;

        public Book(string name,string autothor,int numOfPages)
        {
            this.name = name;
            this.autothor = autothor;
            this.numOfPages = numOfPages;

        }

    }
}
