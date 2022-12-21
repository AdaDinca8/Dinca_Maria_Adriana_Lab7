using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace Dinca_Maria_Adriana_Lab7.Models
{
    public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }
        public string ShopDetails { get { return ShopName + ""+Adress;} }
        [OneToMany]
        public List<ShopList> ShopLists { get; set; }

    }

}
