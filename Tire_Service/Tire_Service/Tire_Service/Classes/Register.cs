using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using Xamarin.Forms;
using Tire_Service.Classes;
namespace Tire_Service.Classes
{
    class Register
    {
        static string connection = @"Data Source = 26.162.28.29; Initial Catalog = tire_service; User = user; Password = user";
        internal static void RecordUser(string phone, string name, string surname, string auto)
        {
            string sql = String.Format("INSERT INTO ezuser (name,surname,phone_number,sign_number) VALUES ('{0}', '{1}','{2}','{3}')", name, surname,phone,auto);
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();                   
                }
                con.Close();
            }
        }
        internal static void RecordOrder()
        {
            List<tovar> mylist = new List<tovar>();
               mylist = tovar.GetTovarList();
            string nazva="", sum="";
            int id=0;
            DateTime date = DateTime.Now;
            string mydate;
            mydate=date.ToString("f");
            
            foreach (var a in mylist)
            {
                nazva += a.nazva + ", ";
                sum += a.price;
            }
            string sql1 = "SELECT MAX(id_user) FROM ezuser";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(sql1, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {                   
                        while (reader.Read())
                        {
                           id = reader.GetInt32(0);                     
                        }
                    }
                }
                con.Close();
            }
            string sql = String.Format("INSERT INTO mysuperezorder (id_user,nazva,sum,date) VALUES ('{0}', '{1}','{2}','{3}')", id, nazva, sum,mydate);
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }      
}


