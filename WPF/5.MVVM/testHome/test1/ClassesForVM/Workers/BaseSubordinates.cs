using Test.ClassesForVM.Departamens;

namespace Test.ClassesForVM.Workers
{
	abstract public class BaseSubordinates : BasePerson
	{
		protected double salary;
		public double Salary { get => salary; set => SetProperty(ref salary, value); }

		public BaseSubordinates() { }
		public BaseSubordinates(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament)
		{
		}

		public override void CopyTo(BasePerson other)
		{
			base.CopyTo(other);
			if (other is BaseSubordinates baseSubordinates)
				baseSubordinates.Salary = salary;
		}

		public override void CopyFrom(BasePerson other)
		{
			base.CopyFrom(other);
			if (other is BaseSubordinates baseSubordinates)
				Salary = baseSubordinates.salary;
		}
	}
}
