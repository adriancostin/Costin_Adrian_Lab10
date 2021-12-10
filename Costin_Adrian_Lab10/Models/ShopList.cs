﻿using System;
using SQLite;

namespace Costin_Adrian_Lab10.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public ShopList()
        {
           
        }
    }
}
