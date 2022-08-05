using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Works.Data.Entities
{
    public class Department : BaseEntity
    {
        [StringLength(250)]
        public string Name { get; set; }

        public virtual  ICollection<Designation> Designations { get; set; }




    }
}
