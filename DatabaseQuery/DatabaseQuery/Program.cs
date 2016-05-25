using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace DatabaseQuery
{
    [Table(Name = "Employees")]
    class EmployeesTable
    {
        [Column] public int Id;
        [Column] public string Name;
        [Column] public string Title;
    }

    class Program
    {
        static void Main()
        {
            //Additions making this code machine agnostic
            var connectionString = Environment.MachineName == "MEM-SURFACEBOOK"
                ? @"F:\SQL_DataBaseFiles\myDbase.mdf"
                : @"D:\SQL_DataBaseFiles\myDbase.mdf";

            var db = new DataContext(connectionString);

            var query = from c in db.GetTable<EmployeesTable>()
                where c.Name == "Mike"
                select c;

            foreach(var item in query)
                Console.WriteLine($"ID: {item.Id}\nName: {item.Name}\nTitle: {item.Title}");
        }
    }
}
