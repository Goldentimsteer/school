//Timothy Lockhart
//Program 8
//12/1/2022
//This program allows you to open and close files. insert and delete
//items in the file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    [Serializable]
    internal class Record

    {
        //creates a Record for items to have a id number
        public string ID = "";

        // a name
        public string Name = "";

        // a price
        public string Price = "";

        // a quantity
        public string Quantity = "";

        // and what store
        public string Store = "";
    }

}
