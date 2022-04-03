//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seller
    {
        public Seller()
        {
            this.ProductBooks = new HashSet<ProductBook>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> Admin_Id { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual ICollection<ProductBook> ProductBooks { get; set; }
    }
}
