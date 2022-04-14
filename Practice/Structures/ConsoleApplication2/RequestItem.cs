namespace ConsoleApplication2
{
    public struct RequestItem
    {
        
        public Article _product;
        private int _numberOfProducts; //
        
        public RequestItem(Article product, int numberOfProducts)
        {
            _product = product;
            _numberOfProducts = numberOfProducts;
        }

        public int NumberOfProducts
        {
            get => _numberOfProducts;
            set => _numberOfProducts = value;
        }
        
        public override string ToString()
        {
            return $"Product:\n {_product.ToString()}\n Number of products = {_numberOfProducts}\n";

        }
    }
}