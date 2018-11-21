using System;

namespace MyShop.Api.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
    }
}