using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Works.Data.Entities
{
    public class Designation : BaseEntity
    {
        [StringLength(250)]
        public string DesignationName { get; set; }
        //one to many


        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual  Department Department { get; set; }
        
        public virtual  ICollection<Employee> Employees { get; set; }
    }
}
