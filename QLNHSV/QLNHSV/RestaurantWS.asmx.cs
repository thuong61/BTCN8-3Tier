using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace QLNHSV
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        restaurantDAO restaurantDAO = new restaurantDAO();
        [WebMethod]
        public DataSet LoadListOfRes()
        {
            DataSet dataSet = new DataSet();
            var tb = restaurantDAO.LoadList();

            dataSet.Tables.Add(tb);
            return dataSet;
        }

        [WebMethod]
        public int Insert(Restaurant restaurant)
        {
            // check
            if (restaurant.Name.StartsWith("@@@"))
                return -1;
            if (String.IsNullOrEmpty(restaurant.Address))
                return -2;
            return restaurantDAO.Insert(restaurant);
        }

        [WebMethod]
        public int Delete(int ip)
        {
            return restaurantDAO.Delete(ip);
        }

        [WebMethod]
        public int Update(Restaurant restaurant)
        {
            return restaurantDAO.Update(restaurant);
        }

      
        CatogeryDAO catogeryDAO = new CatogeryDAO();
        [WebMethod]
        public DataSet LoadListOfCato()
        {
            DataSet dataSet = new DataSet();
            var tb = catogeryDAO.LoadList();

            dataSet.Tables.Add(tb);
            return dataSet;
        }
    }
}
