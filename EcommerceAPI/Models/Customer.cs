using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }
        
        public int CustomerId { get; set; }
       [EmailAddress]
       [Required]
        public string Email { get; set; }
       [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        public string DefaultAddress { get; set; }
        public string Country { get; set; }
   

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
