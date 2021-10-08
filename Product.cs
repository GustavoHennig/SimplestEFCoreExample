using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [Table("product")]
    public class Product
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("sale_price")]
        public decimal SalePrice { get; set; }

        [Column("status")]
        public ProductStatus Status { get; set; }

        public enum ProductStatus : short
        {
            Inactive = 0,
            Active = 1
        }

    }
}
