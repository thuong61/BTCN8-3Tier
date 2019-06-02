using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
   public class CatogeryBUS
    {
        CatogeryDAO catogeryDAO = new CatogeryDAO();
            public DataTable LoadList()
            {
                return catogeryDAO.LoadList();
            }

    }
}

