using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

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
                orderby c.Name
                select c;

            foreach(var item in query)
                Console.WriteLine($"Name: {item.Name},\tTitle: {item.Title}");
        }

        private static string ConnectString()
        {
            return Environment.MachineName == "MEM-SURFACEBOOK"
                ? @"server = MEM-SURFACEBOOK\SQLEXPRESS; integrated security = true; database = myDbase;"
                : @"server = MEM_SURFACE\SQLEXPRESS; integrated security = true; database = myDbase;";
        }
    }
}
