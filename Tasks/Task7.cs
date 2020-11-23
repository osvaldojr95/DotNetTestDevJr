using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() 
        {
            Repository repository = new Repository();
            List<string> lista;

            lista = repository.Products.Where(p => p.Stock.Quantity == 0).Select(p => p.Name).ToList();
            return lista;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() 
        {
            Repository repository = new Repository();
            return repository.Products.Select(p => p.Stock.Quantity).Sum();
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) 
        {
            Repository repository = new Repository();
            Product produto = repository.Products.Where(p => p.Id == productId).FirstOrDefault();

            if (produto.Stock.Quantity >= orderQuantity)
                return true;

            return false;
        }
    }
}
