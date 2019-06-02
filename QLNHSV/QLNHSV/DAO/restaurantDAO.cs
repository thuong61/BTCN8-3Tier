using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
   public class restaurantDAO
    {
 
            public DataTable LoadList()
            {
                string sql = "Select * From Restaurant";
                var rs = ProcessData.LoadData(sql);

                return rs;
            }

        public int Insert(Restaurant restaurant)
        {
            string sql = string.Format("Insert Into Restaurant(Name,Address,Describe,CategoryIP) Values('{0}','{1}','{2}',{3})"
                , restaurant.Name, restaurant.Address, restaurant.Describe,restaurant.CategoryIP);

            var rs = ProcessData.Execute(sql);

            return rs;
        }

        public int Delete(int ip)
        {
            string sql = string.Format("Delete From Restaurant Where IP={0}", 
                ip); 

            var rs = ProcessData.Execute(sql);

            return rs;
        }

        public int Update(Restaurant restaurant)
        {
            string sql = string.Format("Update Restaurant Set Name='{0}', Address='{1}', Describe='{2}' Where IP={3}"
                , restaurant.Name, restaurant.Address, restaurant.Describe, restaurant.IP);

            var rs = ProcessData.Execute(sql);

            return rs;
        }

        public int DeleteByStore(int ip)
        {
            string store = "spRes_Delete";
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@IP",ip);
            var rs = ProcessData.ExecuteStore(store, dic);

            return rs;
        }

    }
    }



