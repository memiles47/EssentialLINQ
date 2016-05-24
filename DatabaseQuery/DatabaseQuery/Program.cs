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
            #region SurfaceBook Version
            //var db = new DataContext(@"f:\SQL_DataBaseFiles\myDbase.mdf");
            #endregion

            #region SurfacePro3 Version
            var db = new DataContext(@"d:\SQL_DataBaseFiles\myDbase.mdf");
            //var db = new DataContext(@"c:\Program Files\MicrosoftSQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\myNewDbase.mdf");
            #endregion

            var query = from c in db.GetTable<EmployeesTable>()
                where c.Name == "Mike"
                select c;

            foreach(var item in query)
                Console.WriteLine($"ID: {item.Id}\nName: {item.Name}\nTitle: {item.Title}");
        }
    }
}
