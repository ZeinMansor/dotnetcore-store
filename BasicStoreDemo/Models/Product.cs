using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicStoreDemo.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public string? name { get; set; }
        public List<ProductDescreption>? description { get; set; }
        public float price { get; set; }
        [Column("discount_price")]
        public float? discountPrice { get; set; }
        public float ratting { get; set; }
        [Column("image_url")]
        public string? imageUrl { get; set; }

    }
}

