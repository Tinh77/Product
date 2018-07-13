namespace Products
{
    public class Phone : Product
    {
        public override double ComputeTax()
        {
            return _productPrice* 10/100;
        }
    }
}