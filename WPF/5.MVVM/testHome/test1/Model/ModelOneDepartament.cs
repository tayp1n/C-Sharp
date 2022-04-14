using Test.ClassesForVM.Departamens;
using Test.ClassesForVM.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
	public class ModelMainDepartament
	{
		MainDeportament mainDeportament;
		public void LoadData()
			=> mainDeportament = new GeneratorCommands().MainGeneratorV1();
		public IEnumerable<BasePerson> GetAllWorkers() => mainDeportament.Employees;
	}
}
