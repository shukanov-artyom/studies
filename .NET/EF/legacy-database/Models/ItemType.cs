using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            ItemsItemsConnectedItemType = new HashSet<ItemsItems>();
            ItemsItemsItemType = new HashSet<ItemsItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemsItems> ItemsItemsConnectedItemType { get; set; }
        public ICollection<ItemsItems> ItemsItemsItemType { get; set; }
    }
}
