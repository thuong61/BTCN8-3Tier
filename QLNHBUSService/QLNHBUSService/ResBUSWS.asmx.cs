using QLNHBUSService.ResDAOWS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace QLNHBUSService
{
    /// <summary>
    /// Summary description for ResBUSWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ResBUSWS : System.Web.Services.WebService
    {
        ResDAOWS.WebService1SoapClient resDAOWS = new ResDAOWS.WebService1SoapClient();

        [WebMethod]
        public DataSet LoadListOfRes()
        {
        
            return resDAOWS.LoadListOfRes();
        }

        [WebMethod]
        public int Insert(Restaurant restaurant)
        {
            return resDAOWS.Insert(restaurant);
        }

        [WebMethod]
        public int Delete(int ip)
        {
            return resDAOWS.Delete(ip);
        }

        [WebMethod]
        public int Update(Restaurant restaurant)
        {
            return resDAOWS.Update(restaurant);
        }


        [WebMethod]
        public DataSet LoadListOfCato()
        {
          
            return resDAOWS.LoadListOfCato();
        }
    }
}
