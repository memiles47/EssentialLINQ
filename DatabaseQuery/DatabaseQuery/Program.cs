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
            var db = new DataContext(ConnectString());

            var query = from c in db.GetTable<EmployeesTable>()
                where c.Name == "Mike"
                select c;

            foreach(var item in query)
                Console.WriteLine($"ID: {item.Id}\nName: {item.Name}\nTitle: {item.Title}");
        }

        private static string ConnectString()
        {
            var connectString = Environment.MachineName == "MEM_SURFACE"
                ? @"server = MEM_SURFACE\SQLEXPRESS; integrated security = true; database = myDbase;"
                : @"server = MEM-SURFACEBOOK\SQLEXPRESS; integrated security = true; database = myDbase;";
            return connectString;
        }
    }
}
