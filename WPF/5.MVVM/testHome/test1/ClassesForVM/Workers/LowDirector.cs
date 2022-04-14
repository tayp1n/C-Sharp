﻿using Test.ClassesForVM.Departamens;
using System.Linq;

namespace Test.ClassesForVM.Workers
{
    /// <summary>
    /// Руководители среднего звена (руководят руководителями одиночных отделов), Что то типа Мэра
    /// </summary>
    public class LowDirector : BaseDirector
    {
        public LowDirector()
        {
        }

        public LowDirector(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament)
        {}

        protected override double GetAllDepSalaryes() =>
            Departament.Employees.OfType<DepartmentHead>().Sum(_ => _.SalaryPayment) +
            Departament.SubDepartaments.SelectMany(_ => _.Employees.OfType<DepartmentHead>()).Sum(_ => _.SalaryPayment);
    }
}
