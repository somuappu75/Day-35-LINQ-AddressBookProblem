﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LINQ_AddressBookProblem
{
    class AddressBookManagement
    {
        public DataTable UpdatedContactDetails(DataTable dataTable)
        {
            var recordData = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals("chetan")).FirstOrDefault();
            recordData["state"] = "Karnataka.";
            Console.WriteLine("-------------UpdatedData--------------");
            Console.WriteLine("FirstName:- " + recordData.Field<string>("firstName"));
            Console.WriteLine("lastName:- " + recordData.Field<string>("lastName"));
            Console.WriteLine("Address:- " + recordData.Field<string>("address"));
            Console.WriteLine("City:- " + recordData.Field<string>("city"));
            Console.WriteLine("State:- " + recordData.Field<string>("state"));
            Console.WriteLine("zip:- " + Convert.ToInt32(recordData.Field<int>("zip")));
            Console.WriteLine("phoneNumber:- " + Convert.ToDouble(recordData.Field<Double>("phoneNumber")));
            Console.WriteLine("eMail:- " + recordData.Field<string>("eMail"));
            Console.WriteLine("----------------------------------");

            return dataTable;
        }
        
        public DataTable DeletingContactFromTable(DataTable datatable)
        {
            //Uc-5 Delete from table
            //returning the new data table
            //saving them in new data table by copytodatatable method
            DataTable dataTableupdated = datatable.AsEnumerable().Except(datatable.AsEnumerable().Where(r => r.Field<string>("firstName") == "Gouri" && r.Field<string>("lastName") == "Shete")).CopyToDataTable();
            foreach (var data in dataTableupdated.AsEnumerable())
            {
                Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
                Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
                Console.WriteLine("Address:- " + data.Field<string>("address"));
                Console.WriteLine("City:- " + data.Field<string>("city"));
                Console.WriteLine("State:- " + data.Field<string>("state"));
                Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
                Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
                Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
                Console.WriteLine("---------------------------");
            }
            return dataTableupdated;
        }
        /// <summary>
        /// UC-6  Retrievings the contact details by state or city.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public void RetrievingContactDetailsByStateOrCity(DataTable dataTable)
        {
            //lambda syntax for getting data for particular city
            var recordData = dataTable.AsEnumerable().Where(r => r.Field<string>("city") == "Karnataka");
            //lambda syntax for getting data for particular state
            var recordDataState = dataTable.AsEnumerable().Where(r => r.Field<string>("state") == "Maharashtra");
            foreach (var data in recordDataState)
            {
                Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
                Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
                Console.WriteLine("Address:- " + data.Field<string>("address"));
                Console.WriteLine("City:- " + data.Field<string>("city"));
                Console.WriteLine("State:- " + data.Field<string>("state"));
                Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
                Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
                Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
                Console.WriteLine("---------------------------");
            }

        }

        }
      
       
 }



      
    
