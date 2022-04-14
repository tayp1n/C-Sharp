using Test.ClassesForVM.Departamens;

namespace Test.ClassesForVM.Workers
{
    public class Intern : BaseSubordinates
    {
        public Intern()
        {
        }

        public Intern(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament) {}
            
        public override double SalaryPayment => Salary;
    }
}
