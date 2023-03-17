using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkCreateTable
{
    internal class Program
    {
        static EMPEntities db = new EMPEntities();
        static void Main(string[] args)
        {
            String cmdText = "CREATE TABLE COMPANY" +
                    "(ID INT PRIMARY KEY    NOT NULL," +
                    "NAME       VARCHAR(50)  NOT NULL," +
                    "AGE        INT         NOT NULL," +
                    "ADDRESS    CHAR(100)," +
                    "SALARY     DECIMAL(9,2))";
            try
            {
                db.Database.ExecuteSqlCommand(cmdText, new object[0]);
                Console.WriteLine("Tables successfully created");
            }
            catch (Exception)
            {
                Console.WriteLine("Table not created");
            }
            Console.ReadKey();
        }        
    }
}