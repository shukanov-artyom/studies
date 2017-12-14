using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ItemsItems
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public int ConnectedItemId { get; set; }
        public int ConnectedItemTypeId { get; set; }
        public string ConnectedItemTypeName { get; set; }
        public DateTime Date { get; set; }

        public ItemType ConnectedItemType { get; set; }
        public ItemType ItemType { get; set; }
    }
}
