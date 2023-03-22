using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteTable
{
    internal class Program
    {
        static EMPEntities db = new EMPEntities();
        static void Main(string[] args)
        {
            try
            {
                db.Database.ExecuteSqlCommand("DROP TABLE COMPANY", new object[0]);
                Console.WriteLine("Table Successfully deleted!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Tables not deleted");
            }
            Console.ReadKey();    
        }
    }
}
