using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace taskEncapsulation
{
    internal class Book : Product
    {

        string Genre;

        public Book()
        {

        }

        public Book(double price, int count, int no, string name)
        {
            Price = price;
            Count = count;
            No = no;
            Name = name;
        }


        public void ShowInfo()
        {
            Console.WriteLine(No + " " + Name + " " + Price);
        }














    }
}
