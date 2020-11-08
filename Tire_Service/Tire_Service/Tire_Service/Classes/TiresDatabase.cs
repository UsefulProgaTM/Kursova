using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tire_Service.Classes
{
    class TiresDatabase
    {
        static string connection = @"Data Source = 26.162.28.29; Initial Catalog = tire_service; User = user; Password = user";
        internal static List<Tires> tirebuylist = new List<Tires>();
        internal static List<Tires> GetTires()
        {
            List<Tires> listtires = new List<Tires>();
            string sql = "SELECT * FROM tires";

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
                            Tires tire = new Tires()
                            {
                                id_tires = reader.GetInt32(0),
                                size = reader.GetString(1),
                                firm = reader.GetString(2),
                                model = reader.GetString(3),
                                season = reader.GetString(4),
                                type = reader.GetString(5),
                                speed_index = reader.GetString(6),
                                loading_index = reader.GetString(7),
                                photo_tires = "tires"+i+".jpg",
                                spiked = reader.GetString(9),
                                price = reader.GetInt32(10)
                            };

                            listtires.Add(tire);
                            i++;
                        }
                    }
                }

                con.Close();

                return listtires;
            }
        }
        internal static void AddToTireBuyList(Tires tire)
        {
            tirebuylist.Add(tire);
        }
        internal static List<Tires> GetTireBuyList()
        {
            return tirebuylist;
        }

    }
}
