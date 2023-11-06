namespace InMemoryCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MockEmployeeRepository db= new MockEmployeeRepository();
            Display(db);
           Employee a= db.Add(new Employee { Name = "Kavita", Email = "smvita@gmail.com", Department = Dept.HR });
            Console.WriteLine("Record Added: {0} {1} {2} {3}", a.Id, a.Name, a.Email, a.Department);
            Display(db);
            db.Delete(4);
            Display(db);
            Employee m= new Employee { Id = 3, Name = "Sam", Department = Dept.MKT, Email = "sam@CDACtech.com" };
            UpdateData(m,db);
            

        }
        static void Display(MockEmployeeRepository db)
        { 
            foreach(Employee a in db.GetAllEmployee())
                Console.WriteLine(": {0} {1} {2} {3}", a.Id, a.Name, a.Email, a.Department);
        }
        static void UpdateData(Employee e, MockEmployeeRepository db)
        { 
             db.Update(e);
            Display(db);
        }
    }
}