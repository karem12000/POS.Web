using POS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Tables.Models
{
    [Table(nameof(Unit) + "s", Schema = AppConstant.Schemas.Guide)]
    public class Unit:BaseEntity
    {
        public string Name { get; set; }


        //Nav Prop with Product

        public virtual ICollection<ProductUnit> ProductUnits { get; set; }

    }
}
