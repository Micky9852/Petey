//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Petteys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        public Pet()
        {
            this.Popular = new HashSet<Popular>();
            this.Order_details = new HashSet<Order_details>();
            this.Orders = new HashSet<Orders>();
        }
    
        public int Product_Id { get; set; }
        public int Customer_id { get; set; }
        public string name { get; set; }
        public string specices { get; set; }
        public string sex { get; set; }
        public System.DateTime birthdate { get; set; }
        public int age { get; set; }
        public decimal price { get; set; }
        public string history { get; set; }
        public string images { get; set; }
    
        public virtual ICollection<Popular> Popular { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order_details> Order_details { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
