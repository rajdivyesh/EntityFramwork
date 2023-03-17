using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertRows
{
    internal class Program
    {
        static EMPEntities db = new EMPEntities();
        static void Main(string[] args)
        {
            try
            {
                db.COMPANY.Add(new COMPANY
                {
                    ID = 1,
                    NAME = "Allen",
                    AGE = 25,
                    ADDRESS = "California",
                    SALARY = 15000
                });

                db.COMPANY.Add(new COMPANY
                {
                    ID = 2,
                    NAME = "Paul",
                    AGE = 32,
                    ADDRESS = "California",
                    SALARY = 20000
                });

                db.COMPANY.Add(new COMPANY
                {
                    ID = 3,
                    NAME = "Teddy",
                    AGE = 23,
                    ADDRESS = "Norway",
                    SALARY = 20000
                });

                db.COMPANY.Add(new COMPANY
                {
                    ID = 4,
                    NAME = "Mark",
                    AGE = 25,
                    ADDRESS = "Richmond",
                    SALARY = 65000
                });
                db.SaveChanges();

                Console.WriteLine("Data successfully inserted");
            }
            catch (Exception)
            {
                Console.WriteLine("Data not inserted");
            }
            Console.ReadKey();
        }
    }
}
