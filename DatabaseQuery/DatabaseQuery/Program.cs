﻿using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DatabaseQuery
{
    [Table(Name = "Employees")]
    internal class EmployeesTable
    {
        [Column] public int Id;
        [Column] public string Name;
        [Column] public string Title;
    }

    internal class Program
    {
        private static void Main()
        {
            var db = new DataContext(ConnectString());

            var query = from c in db.GetTable<EmployeesTable>()
                orderby c.Name
                select c;

            foreach (var item in query)
                Console.WriteLine($"Name: {item.Name},\tTitle: {item.Title}");

            Console.ReadLine();
        }
        //Method for creating the connect string depending on what computer I am using
        //Create database in surface book and check the logic
        private static string ConnectString()
        {
            return Environment.MachineName == "MEM-SURFACEBOOK"
                ? @"server = MEM-SURFACEBOOK\SQLEXPRESS; integrated security = true; database = myDatabase;"
                : @"server = MEM-SURFACEPRO3\SQLEXPRESS; integrated security = true; database = myDatabase;";
        }
    }
}