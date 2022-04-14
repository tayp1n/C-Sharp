namespace Test.ClassesForVM.Departamens
{
    public class Departament : BaseDepartament
    {
        public Departament() : base() 
        {
        }

        public Departament(string title, int parentId = 0) : base(title, parentId)
        {}
    }
}
