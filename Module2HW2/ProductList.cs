namespace Module2HW2
{
    internal class ProductList
    {
        private string[,] _myarray = new string[10, 5]
        {
            { "1  ", "680  ", "Throwing knife  ", "255  ", "48  " },
            { "2  ", "400  ", "MTech karambit stick  ", "300  ", "402  " },
            { "3  ", "300  ", "Throwing knife  ", "212  ", "3507  " },
            { "4  ", "280  ", "Throwing knife  ", "238  ", "52  " },
            { "5  ", "1200  ", "Throwing Knife Set  ", "526  ", "863  " },
            { "6  ", "500  ", "Saken 7 Knife Throw  ", " 230  ", "230  " },
            { "7  ", "300  ", "stick-type special-purpose knife  ", "320  ", "49  " },
            { "8  ", "860  ", "Karambit GW Tiger Claw  ", "280  ", "620  " },
            { "9  ", "720  ", "Miter knife Cold Steel Black Fly  ", "410  ", "360  " },
            { "10  ", "963  ", "Throwing knife  ", "120  ", "350  " },
        };
        public void PrintInfo()
        {
            Console.WriteLine("Welcome to our knife store, here you can choose a knife that you need or like, or several knives.");
            Console.WriteLine("See the list of our products");
            Console.WriteLine("knife number; price in hryvnias; size in millimeters; steel type");
            int height = _myarray.GetLength(0);
            int width = _myarray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_myarray[i, j]);
                }

                Console.WriteLine();
            }
        }

        public string[,] ReturnMass()
        {
            return _myarray;
        }
    }
}
