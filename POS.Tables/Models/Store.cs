using POS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Tables.Models
{
    [Table(nameof(Store) + "s", Schema = AppConstant.Schemas.Guide)]
    public class Store:BaseEntity
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }

        // Nav Prop With Products
        public virtual ICollection<ProductStore> StoreProducts { get; set; }

    }
}
