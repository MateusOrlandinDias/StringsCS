using System;

namespace StringsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2+19.2;
            // var text = "O preço do produto é "+price+" apenas na promoção";
            // var text = string.Format("O preço do produto é {0} apenas na promoção {1}.", price, true);
            var text = $"O preço do produto é {price} apenas na promoção.";
            // var text = $@"O preço do produto 
            // é {price} apenas 
            // na promoção.";
            // var text = $"O preço do produto \n é {price} apenas na promoção.";

            Console.WriteLine(text);
        }
    }
}
