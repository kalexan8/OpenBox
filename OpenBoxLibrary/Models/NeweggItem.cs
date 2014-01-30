using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBoxLibrary.Models
{
    public class NeweggItem
    {
        public string ItemNumber { get; set; }
        public bool IsActivated { get; set; }
        public ItemType ItemType { get; set; }
        public string Description { get; set; }
        public string OriginalPrice { get; set; }
        public string PromotionText { get; set; }
        public string FinalPrice { get; set; }
    }
    public class ItemType
    {
        public bool IsOpenBoxItem { get; set; }
    }
}
