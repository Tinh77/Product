namespace Products
{
    public abstract class Product
    {
        public abstract double ComputeTax();
        
        public int _productId;
        public string _productName;
        public double _productPrice;

        public Product()
        {
        }

        public Product(int productId, string productName, double productPrice)
        {
            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;
        }

        public int ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public double ProductPrice
        {
            get => _productPrice;
            set => _productPrice = value;
        }

    }
   


}