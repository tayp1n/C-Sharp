namespace ConsoleApplication1
{
    public class Node: Phonebook
    {
        public Node(Phonebook obj)
        {
            Obj = obj;
        }

        
        //public T Obj { get; set; }

        public Phonebook Obj
        {
            get;
            set;
        }

        public new int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public new string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public new string Surname
        {
            get => Obj.Surname;
            set => Obj.Surname = value;
        }

        public new string Adress
        {
            get => Obj.Adress;
            set => Obj.Adress = value;
        }

        public new int Phone
        {
            get => Obj.Phone;
            set => Obj.Phone = value;
        }
        
        public Node Prev {get; set;}
        public Node Next {get; set;}
    }
}