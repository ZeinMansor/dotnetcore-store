using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicStoreDemo.Models
{
    [Table("product_descreption")]
    public class ProductDescreption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public string? text { get; set; }

        public Product product { get; set; }

    }
}

