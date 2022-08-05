using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Enum;

namespace Works.Data.Entities
{
    public class Employee : BaseEntity
    {
        [StringLength(200)]
        public string FullName { get; set; }
        public int EmployeeCode { get; set; }
       
        public int PhoneNumber { get; set; }
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

     //   public Gender Gender { get; set; }

        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public virtual  Designation Designation { get; set; }

        public virtual  ICollection<Worklog> Worklogs { get; set; }
        public virtual ICollection<Request> Requests { get; set; }


    }


}
