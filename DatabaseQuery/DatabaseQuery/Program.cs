using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;


namespace DatabaseQuery
{
    [Table(Name = "Table_1")]
    class Tbl
    {
        [Column] public int Id;
        [Column] public string Name;
        [Column] public string Title;
    }

    class Program
    {
        static void Main()
        {
            //Split into two lines, one for SurfacePro 3 and one for SurfaceBook
            var db = new DataContext(@"f:\SQL_DataBaseFiles\myDbase.mdf");        //Book
            //var db = new DataContext(@"d:\SQL_DataBaseFiles\myDbase.mdf");       //Pro3

            var query = from c in db.GetTable<Tbl>()
                where c.Name == "Mike"
                select c;

            foreach(var item in query)
                Console.WriteLine($"Record: {item.Name}");
        }
    }
}
