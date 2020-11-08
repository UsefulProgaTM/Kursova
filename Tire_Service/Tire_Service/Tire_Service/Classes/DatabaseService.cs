using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Tire_Service.Views;
using Tire_Service.Classes;

namespace Tire_Service.Classes
{
    class DatabaseService
    {
        static string connection = @"Data Source = 26.162.28.29; Initial Catalog = tire_service; User = user; Password = user";
        internal static List<Service> servicebuylist = new List<Service>();
        internal static List<Service> GetService()
        {
            List<Service> listservice = new List<Service>();
            string sql = "SELECT * FROM service";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            Service disk = new Service()
                            {
                                id_service = reader.GetInt32(0),
                                posluga = reader.GetString(1),
                                price = reader.GetInt32(2),
                               description=reader.GetString(3)
                            };

                            listservice.Add(disk);
                            i++;
                        }
                    }
                }

                con.Close();

                return listservice;
            }
        }
        internal static void AddToServiceBuyList(Service service)
        {
            servicebuylist.Add(service);
        }
        internal static List<Service> GetServiceBuyList()
        {
            return servicebuylist;
        }

    }
}
