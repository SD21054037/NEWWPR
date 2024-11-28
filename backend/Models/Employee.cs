namespace backend.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } // Bijvoorbeeld "johndoe@bedrijf.nl"
        public int BusinessCustomerId { get; set; }
        public BusinessCustomer BusinessCustomer { get; set; }
    }
}
