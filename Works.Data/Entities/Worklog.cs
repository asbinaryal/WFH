using System.ComponentModel.DataAnnotations.Schema;

namespace Works.Data.Entities
{
    public class Worklog : BaseEntity
    {
        
        public string WorklogTitle { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string Remarks { get; set; }
        public string ApprovedBy { get; set; }
        public string RejectedBy { get; set;}

        [ForeignKey("Employee")]
        public int  EmployeeId { get; set; }
        public virtual  Employee Employee { get; set; }



    }
    
    //public class UserNotification : BaseEntity
    //{

    //}




}
