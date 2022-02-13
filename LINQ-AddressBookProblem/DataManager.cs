using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_AddressBookProblem
{
    public class DataManager
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Int64 phoneNumber { get; set; }
        public Int64 zip { get; set; }
        public string email { get; set; }
        //ER
        public string AddressBookName { get; set; }
        public string Type { get; set; }
    }
}
