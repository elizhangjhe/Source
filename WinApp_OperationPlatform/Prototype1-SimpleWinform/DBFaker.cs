using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Faker;

namespace Prototype1_SimpleWinform
{
    class DBFaker
    {
        
        /// <summary>
        /// Get a dummy DataTable for test
        /// </summary>
        /// <returns></returns>
        internal DataTable GetDB()
        {
            DataTable emptyDt = CreateSchema();

            FakeData(emptyDt, 10);

            return emptyDt;
        }


        /// <summary>
        /// Create DataTable scheme based on DtSchema
        /// </summary>
        /// <returns></returns>
        private DataTable CreateSchema()
        {
            DataTable dt = new DataTable();

            foreach (var colName in Enum.GetNames(typeof(DtSchema)))
            {
                dt.Columns.Add(colName);
            }

            dt.Columns[DtSchema.Id.ToString()].DataType = typeof(int);

            return dt;
        }

        /// <summary>
        /// Assign dummy data into the dt
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="rowNum"></param>
        private void FakeData(DataTable dt, int rowNum)
        {
            for (int i = 0; i < rowNum; i++)
            {
                DataRow newDr = dt.NewRow();

                newDr[DtSchema.Id.ToString()] = Faker.Generators.Numbers.Int();
                newDr[DtSchema.Item_Name.ToString()] = Faker.Generators.Names.First();

                DateTime today = DateTime.Now;
                newDr[DtSchema.Install_Date.ToString()] = Faker.Generators.DateTimes.
                    GetDateTime(today.AddDays(-100), today.AddDays(100));

                dt.Rows.Add(newDr);
            }

            
        }

        /// <summary>
        /// 
        /// </summary>
        internal enum DtSchema
        {
            Id,
            Item_Name,
            Spec_Series,
            Install_Date,
            Period_To_Maintain,
            Period_To_Replace,
            Start_Date,
            End_Date
        }


    }
}
