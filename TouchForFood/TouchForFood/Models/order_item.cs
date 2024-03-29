//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouchForFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_item
    {
        public order_item()
        {
            this.version = 1;
            this.review_order_item = new HashSet<review_order_item>();
        }
    
        public int id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> menu_item_id { get; set; }
        public string note { get; set; }
        public Nullable<int> order_item_status { get; set; }
        public Nullable<System.DateTime> last_changed { get; set; }
        public int version { get; set; }
        public Nullable<int> bill_id { get; set; }
        public Nullable<int> sides_id { get; set; }
    
        public virtual bill bill { get; set; }
        public virtual menu_item menu_item { get; set; }
        public virtual order order { get; set; }
        public virtual side side { get; set; }
        public virtual ICollection<review_order_item> review_order_item { get; set; }
    }
}
