using System.ComponentModel.DataAnnotations.Schema;
using Works.Data.Enum;

namespace Works.Data.Entities
{
    public class Request : BaseEntity
    {
        public Status Status { get; set; }
       
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual  Employee Employee { get; set; }
       
        public int ApprovedBy { get; set; }
        
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Type { get; set; }
        public string Remarks { get; set; }

        




    }

}
