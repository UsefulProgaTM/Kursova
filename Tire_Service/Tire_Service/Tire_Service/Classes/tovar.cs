using System;
using System.Collections.Generic;
using System.Text;

namespace Tire_Service.Classes
{
   
    class tovar
    {
        public string nazva{ get; set; }
        public int price { get; set; }
        public int sum { get; set; }
        
        internal static List<tovar> mytovar = new List<tovar>();

        internal int getsum()
        {
            foreach (var a in mytovar)
            {
                sum += a.price;
            }
            return sum;
        }

        public void CastToTovar(Tires tire)
        {
            string name = tire.firm + " " + tire.model;
            this.nazva=name;
            int price = tire.price;     
            this.price = price;
            
            mytovar.Add(this);
            foreach (var a in mytovar)
            {
                sum += a.price;
            }
        }
        public void CastToTovar(Disks disk)
        {
            
            string name = disk.firm + " " + disk.model;
            this.nazva = name;
            int price = disk.price;
            this.price = price;
            
            mytovar.Add(this);
            foreach (var a in mytovar)
            {
                sum += a.price;
            }
        }
        public void CastToTovar(Service serv)
        {
            
            string name = serv.posluga;
            this.nazva = name;
            int price = serv.price;
            this.price = price;
           
            mytovar.Add(this);
            foreach (var a in mytovar)
            {
                sum += a.price;
            }
        }
        internal static List<tovar> GetTovarList()
        {
            return mytovar;
        }
    }
    
}
