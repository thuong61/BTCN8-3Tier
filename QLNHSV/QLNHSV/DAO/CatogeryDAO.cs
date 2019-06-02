using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
   public class CatogeryDAO
    {
            public DataTable LoadList()
            {
                string sql = "Select * From Catogery";
                var rs = ProcessData.LoadData(sql);

                return rs;
            }

     
    }
}

