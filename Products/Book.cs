namespace Products
{
    public class Book : Product
    {
        public override double ComputeTax()
        {
            return _productPrice* 5/100;
        }
    }
}