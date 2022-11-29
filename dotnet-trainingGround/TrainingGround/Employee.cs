namespace TrainingGround
{
    public class Employee : Person
    {

        public Employee()
        {
        }
        public Employee(string Id)
        {
            this.EmployeeId = Id;
        }
        public Employee(string name, string Id) : base(name)
        {
            this.EmployeeId = Id;

        }
        public string EmployeeId { get; set; }

    }
}