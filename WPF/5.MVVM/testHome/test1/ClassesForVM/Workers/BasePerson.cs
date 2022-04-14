using Common;
using Test.ClassesForVM.Departamens;
using System;
using System.Collections.Generic;

namespace Test.ClassesForVM.Workers
{
	public abstract class BasePerson : OnPropertyChangedClass, ICloneable<BasePerson>, ICopy<BasePerson>
	{
		static public Dictionary<string, Type> Classes;
		public static int globalId;
		/// <summary>Класс</summary>
		public string Class => this.GetType().Name;
		/// <summary>Уникальный ID</summary>
		int id;
		public int Id { get => id; set => SetProperty(ref id, value); }
		/// <summary>Имя</summary>
		string firstName;
		public string FirstName { get => firstName; set => SetProperty(ref firstName, value); }
		/// <summary>Фамилия</summary>
		string surname;
		public string Surname { get => surname; set => SetProperty(ref surname, value); }
		/// <summary>День рождения</summary>
		DateTime birthday;
		public DateTime Birthday { get => birthday; set => SetProperty(ref birthday, value); }
		/// <summary>Адрес проживания</summary>
		string address;
		public string Address { get => address; set => SetProperty(ref address, value); }
		/// <summary>Департамент в котором он находится</summary>
		BaseDepartament departament;
		public BaseDepartament Departament { get => departament; set => SetProperty(ref departament, value); }
		/// <summary>Занимаемая должность</summary>
		string position;
		public string Position { get => position; set => SetProperty(ref position, value); }
		/// <summary>Вычисляет возраст на основе даты рождения</summary>
		public int Age
		{
			get
			{
				var age = DateTime.Now.Year - Birthday.Year;
				if (DateTime.Now.DayOfYear < Birthday.DayOfYear) age--; //на случай, если день рождения ещё не наступил
				return age;
			}
		}


		/// <summary>Метод начисления зарплаты</summary>
		/// <returns>Зарплата за период</returns>
		public abstract double SalaryPayment { get; }

		static BasePerson()
		{
			globalId = 1;
			if (Classes == null)
			{
				Classes = new Dictionary<string, Type>();
				Classes.Add("Интерн", typeof(Intern));
				Classes.Add("Работник", typeof(Worker));
				Classes.Add("Руководитель департамента", typeof(DepartmentHead));
				Classes.Add("Руководитель ветки департаментов", typeof(LowDirector));
				Classes.Add("Руководитель сетки департаементов", typeof(MidDirector));
				Classes.Add("Руководитель сектора департаементов", typeof(TopDirector));
				Classes.Add("Директор", typeof(King));
			}
		
		}
		public BasePerson(string name, string surname, string position, BaseDepartament departament, int id = -1)
			:this()
		{
			if (id == -1)
				this.id = NextID();
			else this.Id = id;
			this.FirstName = name;
			this.Surname = surname;
			this.Position = position;
			this.Departament = departament;
		}
		public BasePerson() => Birthday = DateTime.Now.AddYears(-35);

		/// <summary>
		/// Увеличиваем статичный ID
		/// </summary>
		/// <returns></returns>
		static int NextID()
		{
			globalId++;
			return globalId;
		}

		//static public BasePerson CreateDialog(BaseDepartament departament)
		//{

		//}


		#region Методы взаимодействия с департаментами
		/// <summary>
		/// Добавить сотрудника в департамент
		/// </summary>
		public void AddToDepartament(BaseDepartament departament)
		{
			this.departament = departament;
			departament.Employees.Add(this);
		}

		public void Remove(BaseDepartament departament, BaseDepartament archive)
		{
			archive.Employees.Add(this);
			departament.Employees.Remove(this);
		}

		public BasePerson Clone() => (BasePerson)MemberwiseClone();

		object ICloneable.Clone() => MemberwiseClone();

		public virtual void CopyTo(BasePerson other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));
			other.Id = Id;
			other.FirstName = FirstName;
			other.Surname = Surname;
			other.Position = Position;
			other.Departament = Departament;
			other.Birthday = Birthday;
			other.Address = Address;
		}

		public virtual void CopyFrom(BasePerson other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));
			Id = other.Id;
			FirstName = other.FirstName;
			Surname = other.Surname;
			Position = other.Position;
			Departament = other.Departament;
			Birthday = other.Birthday;
			Address = other.Address;
		}

		protected override void PropertyNewValue<T>(ref T fieldProperty, T newValue, string propertyName)
		{
			base.PropertyNewValue(ref fieldProperty, newValue, propertyName);
			if (propertyName == nameof(Birthday))
				OnPropertyChanged(nameof(Age));
		}



		#endregion
	}
}
