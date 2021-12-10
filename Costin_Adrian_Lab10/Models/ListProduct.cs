using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Costin_Adrian_Lab10.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }

        public ListProduct()
        {
        }
    }
}
