using System;
using System.Data;

namespace LINQ_AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem Using Linq");

            //UC_1 Creating data table
            DataTable addressBookTable = new DataTable();

            //UC2- Addding columns To table 
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);

            // first name and mobile no column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;

            //UC-3 INsering values to table
            addressBookTable.Rows.Add("chetan", "koparde", "Rampur", "Hosur", "Karnataka", 591317, 9980143256, "Chetan65@");
            addressBookTable.Rows.Add("Akshay", "Poojari", "Sasalatti", "Bangalore", "Karnataka", 123456, 9740049061, "akshay.a");
            addressBookTable.Rows.Add("Gouri", "Shete", "banahatti", "Mumbai", "Maharashtra", 856932, 9845623514, "gouri$3@gmail.com");
            addressBookTable.Rows.Add("Somu", "Havinal", "rabakavi", "Kalyan", "Haryana", 136119, 9591235869, "somusp75@gmail.com");
            addressBookTable.Rows.Add("Praveen", "Ainapur", "mudhol", "Delhi", "Delhi", 121435, 9876543210, "praveen.ainapur");
            addressBookTable.Rows.Add("Vidya", "Balgi", "banahatti", "Mumbai", "Maharashtra", 143256, 9731390823, "vidya.balgi");
        }
    }
}
