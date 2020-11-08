using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tire_Service.Classes
{
    public class DatabaseDisks
    {
        static string connection = @"Data Source = 26.162.28.29; Initial Catalog = tire_service; User = user; Password = user";
        internal static List<Disks> diskbuylist = new List<Disks>();
        internal static List<Disks> GetDisks()
        {
            List<Disks> listdisks = new List<Disks>();
            string sql = "SELECT * FROM disks";

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
                            Disks disk = new Disks()
                            {
                                id_disks = reader.GetInt32(0),
                                firm = reader.GetString(1),
                                model = reader.GetString(2),
                                width = reader.GetString(3),
                                diameter = reader.GetString(4),
                                colour = reader.GetString(5),
                               photo_disks="disk"+i+".jpg",
                                vylet=reader.GetString(7),
                                bolts=reader.GetString(8),
                                central_hole=reader.GetString(9),
                                price=reader.GetInt32(10)
                            };
                            
                            listdisks.Add(disk);
                            i++;
                        }
                    }
                }

                con.Close();
                
                return listdisks;
            }
        }
        internal static void AddToDisksBuyList(Disks disk)
        {
            diskbuylist.Add(disk);
        }
        internal static List<Disks> GetDiskBuyList()
        {
            return diskbuylist;
        }

    }
}
