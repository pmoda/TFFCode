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
    
    public partial class friendship
    {
        public long id { get; set; }
        public Nullable<int> first_user { get; set; }
        public Nullable<int> second_user { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}