//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
        public int Total { get; internal set; }
    }
}
