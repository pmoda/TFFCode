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
    
    public partial class table
    {
        public table()
        {
            this.orders = new HashSet<order>();
            this.service_request = new HashSet<service_request>();
            this.users = new HashSet<user>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> restaurant_id { get; set; }
    
        public virtual ICollection<order> orders { get; set; }
        public virtual restaurant restaurant { get; set; }
        public virtual ICollection<service_request> service_request { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}