namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product= new Product();
            product.Attach(new Custom());

            product.ChangeStock();
        }
    }
}