using POS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Tables.Models
{
    [Table("Categories",Schema = AppConstant.Schemas.Guide)]
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //NAv Prop with Products MAny
        public virtual ICollection<Product> Products { get; set; }

    }
}
