using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Prototype1_SimpleWinform
{
    class DBHandler
    {
        internal DBHandler()
        {
            
        }

        internal DataTable GetDt()
        {
            DBFaker dummyDB = new DBFaker();

            return dummyDB.GetDB();
        }



    }
}
