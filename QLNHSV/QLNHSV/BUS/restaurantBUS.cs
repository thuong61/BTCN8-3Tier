using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
   public class restaurantBUS
    {
        restaurantDAO restaurantDAO = new restaurantDAO();
            public DataTable LoadList()
            {
                return restaurantDAO.LoadList();
            }

        public int Insert(Restaurant restaurant)
        {
            // check
            if (restaurant.Name.StartsWith("@@@"))
                return -1;
            if (String.IsNullOrEmpty(restaurant.Address))
                return -2;
            return restaurantDAO.Insert(restaurant);
        }

        public int Delete(int ip)
        {
            return restaurantDAO.Delete(ip);
        }

        public int Update(Restaurant restaurant)
        {
            return restaurantDAO.Update(restaurant);
        }

    }
    }



