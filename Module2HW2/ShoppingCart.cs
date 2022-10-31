namespace Module2HW2
{
    internal class ShoppingCart
    {
        private ProductList _productList;
        private string[,] _newarray = new string[10, 5];
        public void Info()
        {
            Console.WriteLine("\nEnter the number or numbers of the goods you plan to purchase by separating the enter " +
                "\nWhen you have completed your selection, press the number zero (0)");
        }

        public void Result()
        {
            int height = _newarray.GetLength(0);
            int width = _newarray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                if (_newarray[i, 0] != null)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(_newarray[i, j]);
                    }
                }
                else
                {
                    continue;
                }

                Console.WriteLine();
            }
        }

        public int Summ()
        {
            int s = 0;
            int height = _newarray.GetLength(0);
            int width = _newarray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                if (_newarray[i, 0] != null)
                {
                    s = s + Convert.ToInt32(_newarray[i, 1]);
                }
                else
                {
                    continue;
                }
            }

            return s;
        }

        public void Choice()
        {
            _productList = new ProductList();
            int height = _productList.ReturnMass().GetLength(0);
            int width = _productList.ReturnMass().GetLength(1);
            int choise;
            while (true)
            {
                choise = int.Parse(Console.ReadLine());
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (int.Parse(_productList.ReturnMass()[i, 0]) == choise)
                        {
                           _newarray[i, j] = _productList.ReturnMass()[i, j];
                        }
                    }
                }

                if (choise == 0)
                {
                    break;
                }
            }
        }
    }
}
