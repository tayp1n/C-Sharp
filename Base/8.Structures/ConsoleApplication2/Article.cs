namespace ConsoleApplication2
{
    public struct Article
    {
        private int _code;
        private string _productName;
        private int _productPrice;

        public Article(int code, string productName, int productPrice)
        {
            _code = code;
            _productName = productName;
            _productPrice = productPrice;
        }

        public int Code
        {
            get => _code;
            set => _code = value;
        }
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        public int ProductPrice
        {
            get => _productPrice;
            set => _productPrice = value;
        }
        
        public override string ToString()
        {
            return $"Code = {_code}\n Product name = {_productName}\n " +
                   $"Product price = {_productPrice}\n";
        }
    }
}