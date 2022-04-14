using Test.ClassesForVM.Departamens;

namespace Test.ClassesForVM.Workers
{
    /// <summary>
    /// Почти Царь. Руководит директорами верхних уровней. Советник президента.
    /// </summary>
    public class TopDirector : MidDirector
    {
        public TopDirector()
        {
        }

        public TopDirector(string name, string surname, string position, BaseDepartament departament) : base(name, surname, position, departament)
        {
        }
    }
}
