namespace Works.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public IEnumerable<DepartmentViewModel> Department { get; set; }
    }
}