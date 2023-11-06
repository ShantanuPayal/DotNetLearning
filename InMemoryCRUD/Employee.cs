
namespace InMemoryCRUD
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }

    }

    public enum Dept { MKT, ADV, HR }
}