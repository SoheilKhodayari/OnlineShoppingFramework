﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    public class Basket
    {
        private string _Id;
        private DateTime _DateTime;
        private List<Item> _Items;

        public Basket(string id)
        {
            this._Id = id;
            this._Items = new List<Item>();
        }
        public Basket(string id, List<Item> items)
        {
            this._Id = id;
            this._Items = items;
        }

        public string getId()
        {
            return this._Id;
        }
        public void setId(string id)
        {
            this._Id = id;
        }
        public List<Item> getItems()
        {
            return this._Items;
        }
        public void addItem(Item item)
        {
            this._Items.Add(item);
        }
        public void addItems(List<Item> items)
        {
            this._Items.AddRange(items);
        }
    }
}
