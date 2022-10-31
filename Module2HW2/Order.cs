namespace Module2HW2
{
    internal class Order
    {
        private ShoppingCart _shopingCart;
        private string[] _info = new string[4];
        public void FinOrder()
        {
            _shopingCart = new ShoppingCart();
            _shopingCart.Choice();
            Console.Clear();
            FillInData();
            Console.Clear();
            _shopingCart.Result();
            Data();
        }

        private void FillInData()
        {
            Random random = new Random();
            for (int i = 0; i < _info.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter your name");
                    _info[i] = Console.ReadLine();
                }

                if (i == 1)
                {
                    Console.WriteLine("Enter last name");
                    _info[i] = Console.ReadLine();
                }

                if (i == 2)
                {
                    Console.WriteLine("Enter your email");
                    _info[i] = Console.ReadLine();
                }

                if (i == 3)
                {
                    _info[i] = Convert.ToString(random.Next(0, 9999999));
                }
            }
        }

        private void Data()
        {
            Console.WriteLine("\nYour data:");
            for (int i = 0; i < _info.Length; i++)
            {
                if (i != 3)
                {
                    Console.Write(_info[i] + ";     ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\nYour order number:");
                    Console.Write(_info[i] + ";     " + "\n");
                }
            }

            Console.WriteLine($"\nto pay:\n{_shopingCart.Summ()} hryvnia");
        }
    }
}
