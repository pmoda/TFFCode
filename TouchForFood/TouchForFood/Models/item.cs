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
    
    public partial class item
    {
        public item()
        {
            this.version = 1;
            this.menu_item = new HashSet<menu_item>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string metadata { get; set; }
        public Nullable<int> category_id { get; set; }
        public string image_url { get; set; }
        public int version { get; set; }
    
        public virtual category category { get; set; }
        public virtual ICollection<menu_item> menu_item { get; set; }
    }
}