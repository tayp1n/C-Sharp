namespace ConsoleApplication1
{
    public interface ISimpleNSquare
    {
        
        double Height { get; }
        double Base { get; }
        double BaseAdjacentSide { get;}
        int NumberOfSides { get;}
        
        double this[int index] { get; set; }
    }
}