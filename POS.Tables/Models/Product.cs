using POS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Tables.Models
{
    [Table(nameof(Product) + "s", Schema = AppConstant.Schemas.Guide)]

    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }//link
        public long Quantity { get; set; }
        public decimal Price { get; set; }


        // Nav Prop With Category
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }


        // Nav Prop With Units
        public virtual ICollection<ProductUnit> ProductUnits { get; set; }

        // Nav Prop With Store
        public virtual ICollection<ProductStore> StoreProducts { get; set; }


    }
}
