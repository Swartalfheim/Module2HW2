namespace Module2HW2
{
    internal class Starter
    {
        public void Start()
        {
            ProductList productList = new ProductList();
            productList.PrintInfo();
            ShoppingCart cart = new ShoppingCart();
            cart.Info();
            Order order = new Order();
            order.FinOrder();
        }
    }
}
