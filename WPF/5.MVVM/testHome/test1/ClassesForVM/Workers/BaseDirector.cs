using Test.ClassesForVM.Departamens;

namespace Test.ClassesForVM.Workers
{
	public abstract class BaseDirector : BasePerson
	{
		protected double coefSalary;
		private double lowSalary;

		/// <summary>Зарплатный коэфициент</summary>
		public double CoefSalary { get => coefSalary; set => SetProperty(ref coefSalary, value); }
		/// <summary>Минимальная ЗП</summary>
		public double LowSalary { get => lowSalary; set => SetProperty(ref lowSalary, value); }
		/// <summary>Начисленная ЗП</summary>
		public override double SalaryPayment => ((GetAllDepSalaryes() * CoefSalary) > LowSalary) ? (GetAllDepSalaryes() * CoefSalary) : LowSalary;

		/// <summary>Просчитывает ЗП сотрудников в подчиненных департаментах</summary>
		/// <param name="start">Начальная ЗП</param>
		protected abstract double GetAllDepSalaryes();

		public override void CopyTo(BasePerson other)
		{
			base.CopyTo(other);
			if (other is BaseDirector director)
			{
				director.CoefSalary = CoefSalary;
				director.LowSalary = LowSalary;
			}
		}

		public override void CopyFrom(BasePerson other)
		{
			base.CopyFrom(other);
			if (other is BaseDirector director)
			{
				CoefSalary = director.CoefSalary;
				LowSalary = director.LowSalary;
			}
		}

		public BaseDirector() { }
		public BaseDirector(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament)
		{
		}


	}
}
