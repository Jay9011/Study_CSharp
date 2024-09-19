namespace _20_Pattern_Factory
{
    public interface IProduct
    {
        void DoStuff();
    }
    public class ProductA : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("ProductA");
        }
    }
    public class ProductB : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("ProductB");
        }
    }
    public interface IFactory
    {
        IProduct CreateProduct();
    }
    public class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
    public class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new FactoryA();
            IProduct product = factory.CreateProduct();
            product.DoStuff();
        }
    }
}