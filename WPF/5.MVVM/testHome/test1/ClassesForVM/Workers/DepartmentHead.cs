using Test.ClassesForVM.Departamens;
using System.Linq;

namespace Test.ClassesForVM.Workers
{
    public class DepartmentHead : BaseDirector
    {
        public DepartmentHead()
        {
        }

        public DepartmentHead(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament)
        {
        }

        protected override double GetAllDepSalaryes() => Departament.Employees.Where(_ => _ is BaseSubordinates).Sum(_ => _.SalaryPayment);

    }
}
