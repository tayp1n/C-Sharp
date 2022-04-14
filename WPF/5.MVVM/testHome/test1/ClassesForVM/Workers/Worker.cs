using Test.ClassesForVM.Departamens;

namespace Test.ClassesForVM.Workers
{
	public class Worker : BaseSubordinates
	{
		/// <summary>
		/// Кол-во отработанных часов при почасовой оплате
		/// </summary>
		double workHours;
		public double WorkHours { get => workHours; set => SetProperty(ref workHours, value); }

		public override double SalaryPayment => WorkHours * Salary;

		public Worker(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament) { }

		public Worker()
		{
		}

		public override void CopyTo(BasePerson other)
		{
			base.CopyTo(other);
			if (other is Worker worker)
				worker.WorkHours = workHours;
		}

		public override void CopyFrom(BasePerson other)
		{
			base.CopyFrom(other);
			if (other is Worker worker)
				worker.WorkHours = worker.workHours;
		}
	}
}
