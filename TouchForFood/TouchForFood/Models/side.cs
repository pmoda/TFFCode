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
    
    public partial class side
    {
        public side()
        {
            this.version = 1;
            this.order_item = new HashSet<order_item>();
        }
    
        public int id { get; set; }
        public Nullable<int> menu_category_id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> price { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public int version { get; set; }
    
        public virtual menu_category menu_category { get; set; }
        public virtual ICollection<order_item> order_item { get; set; }
    }
}
